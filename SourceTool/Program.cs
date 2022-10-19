using System.Text;

namespace SourceTool
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static StringBuilder sbOut = new StringBuilder();
        private static string SbString => sb.ToString();
        private static string SbOutString => sbOut.ToString();
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo("D:\\GitHub\\uBMSC\\iBMSC");
            foreach (var enumerateFile in directory.EnumerateFiles("*.cs"))
            {
                sb.Clear();
                sbOut.Clear();

                var lines = File.ReadAllLines(enumerateFile.FullName);
                bool isValidFile = false;
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    if (line.Contains("[DesignerGenerated]"))
                    {
                        var nextLine = lines[i + 1];
                        if (nextLine.Contains(" : Form"))
                        {
                            i++;
                            sb.AppendLine(line);
                            sb.Append(nextLine.Substring(0, 14));
                            sb.Append(" partial ");
                            sb.Append(nextLine.Substring(14));
                            isValidFile = true;
                            continue;
                        }
                    }

                    sb.AppendLine(line);
                }
            }
        }
    }
}