using System.Text;

namespace SourceTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo("D:\\GitHub\\uBMSC\\iBMSC");
            foreach (var enumerateFile in directory.EnumerateFiles("*.cs"))
            {
                var context = new Context { FileName = enumerateFile.FullName };
                bool isValidFile = false;
                //context.Source.Clear();
                //context.Designer.Clear();

                var lines = File.ReadAllLines(enumerateFile.FullName);
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    if (MatchNameSpace(context, lines, ref i)) continue;
                    if (MatchPartial(context, lines, ref i, ref isValidFile)) continue;
                    if (MatchComponents(context, lines, ref i)) continue;
                    if (MatchAccessedThroughProperty(context, lines, ref i)) continue;
                    if (MatchActualProperty(context, lines, ref i)) continue;
                    if (MatchDispose(context, lines, ref i)) continue;
                    if (MatchInitializeComponent(context, lines, ref i)) continue;
                    context.AppendSourceLine(line);
                }

                if (isValidFile)
                {
                    var designerString = DesignerUtil.GetDesignerString(context);

                    var filename = Path.GetFileNameWithoutExtension(enumerateFile.Name);
                    var extension = Path.GetExtension(enumerateFile.Name);
                    var newPath = Path.Combine(directory.FullName, filename + ".Designer" + extension);

                    //File.WriteAllText(enumerateFile.FullName, context.SourceString);
                    //File.WriteAllText(newPath, designerString);
                }
            }

        }

        private static bool MatchNameSpace(Context context, string[] lines, ref int i)
        {
            var line = lines[i];
            var split = line.TrimEnd(';', ' ').Split(' ');
            if (split.Length == 2 && split[0] == "namespace")
            {
                context.Namespace = split[1];
            }
            return false;
        }

        private static bool MatchDispose(Context context, string[] lines, ref int i)
        {
            var line = lines[i];
            if (!line.Contains("[DebuggerNonUserCode]")) return false;
            var nextLine = lines[i + 1];
            if (!nextLine.Contains("protected override void Dispose(bool disposing)")) return false;
            var sb = new StringBuilder();
            sb.AppendLine(line);
            sb.AppendLine(nextLine);
            i += 2;

            var brace = lines[i];
            sb.AppendLine(lines[i]);
            var endBrace = brace.Replace('{', '}').TrimEnd();
            while (!lines[i].StartsWith(endBrace))
            {
                i++;
                sb.AppendLine(lines[i]);
            }

            context.DisposeDefinition = sb.ToString().TrimEnd();
            return true;
        }

        private static bool MatchInitializeComponent(Context context, string[] lines, ref int i)
        {
            var line = lines[i];
            if (!line.Contains("DebuggerStepThrough]")) return false;
            var nextLine = lines[i + 1];
            if (!nextLine.Contains("private void InitializeComponent()")) return false;
            var sb = new StringBuilder();
            sb.AppendLine(line);
            sb.AppendLine(nextLine);
            i += 2;

            var brace = lines[i];
            sb.AppendLine(lines[i]);
            var endBrace = brace.Replace('{', '}').TrimEnd();
            while (!lines[i].StartsWith(endBrace))
            {
                i++;
                sb.AppendLine(lines[i]);
            }

            context.InitializeComponentDefinition = sb.ToString().TrimEnd();
            return true;
        }

        private static bool MatchActualProperty(Context context, string[] lines, ref int i)
        {
            var line = lines[i];
            var split = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (split.Length != 3 && split.Length != 4) return false;
            var haveDef = context.Fields.TryGetValue(split[^1], out var type);
            if (!haveDef || type != split[^2]) return false;

            var sb = new StringBuilder();

            sb.AppendLine(line);
            i++;
            var brace = lines[i];
            sb.AppendLine(lines[i]);
            var endBrace = brace.Replace('{', '}').TrimEnd();
            while (!lines[i].StartsWith(endBrace))
            {
                i++;
                sb.AppendLine(lines[i]);
            }

            context.TargetFields.Add(split[^1], sb.ToString().TrimEnd());
            return true;
        }

        private static bool MatchAccessedThroughProperty(Context context, string[] lines, ref int i)
        {
            var line = lines[i];
            var str1 = "[AccessedThroughProperty(\"";
            var index = line.IndexOf(str1, StringComparison.Ordinal);
            if (index <= 0) return false;

            var index2 = line.IndexOf("\")]", index, StringComparison.Ordinal);
            if (index2 <= 0) return false;

            var prop = line.Substring(index + str1.Length, index2 - index - str1.Length);
            var nextLine = lines[i + 1];
            if (!nextLine.Contains(prop)) return false;

            i++;
            var split = nextLine.TrimEnd(' ', ';')
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var o = split.First(k => k == $"_{prop}");
            var index3 = Array.LastIndexOf(split, o);
            var type = split[index3 - 1];
            context.Fields.Add(prop, type);
            return true;
        }

        private static bool MatchComponents(Context context, string[] lines, ref int i)
        {
            var line = lines[i];
            if (!line.Contains("private IContainer components;")) return false;

            context.TargetComponentDefinition = line;
            return true;
        }

        private static bool MatchPartial(Context context, string[] lines, ref int i, ref bool isValidFile)
        {

            var line = lines[i];
            if (!line.Contains("[DesignerGenerated]")) return false;

            var nextLine = lines[i + 1];
            if (!nextLine.Contains(" : Form")) return false;

            var split = nextLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var o = split.First(k => k == $":");
            var index3 = Array.LastIndexOf(split, o);
            var type = split[index3 - 1];
            context.TargetClass = type;

            i++;
            context.AppendSourceLine(line);
            var index = nextLine.IndexOf(" class ", StringComparison.Ordinal);
            context.AppendSourceLine(nextLine.Substring(0, index) + " partial " + nextLine.Substring(index));
            isValidFile = true;
            return true;
        }
    }
}