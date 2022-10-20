using System.Text;

namespace SourceTool;

internal static class DesignerUtil
{
    public static string GetDesignerString(Context context)
    {
        var stringBuilder = new StringBuilder();
        if (context.TargetClass == "MainWindow")
        {
        }

        stringBuilder.AppendLine($@"using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace {context.Namespace}
{{
    public partial class {context.TargetClass} : Form
    {{");
        stringBuilder.AppendLine(context.DisposeDefinition);
        stringBuilder.AppendLine(context.TargetComponentDefinition);

        AnalyzeEvents(context, stringBuilder);
        WriteInitializeComponents(context, stringBuilder);

        foreach (var contextField in context.Fields)
        {
            stringBuilder.AppendLine($"internal {contextField.Value} {contextField.Key};");
        }

        stringBuilder.AppendLine(@"    }
}");

        var str = stringBuilder.ToString();
        if (context.TargetClass == "MainWindow")
        {
        }
        return null;
    }

    private static void WriteInitializeComponents(Context context, StringBuilder stringBuilder)
    {
        if (context.TargetClass == "MainWindow")
        {
        }

        var sb = new StringBuilder();

        bool isIn = false;
        var lines = GetAllLines(context.InitializeComponentDefinition!);

        var varMapping = new Dictionary<string, string>();
        string? lastObject = null;
        string? thisObject = null;

        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];

            if (!isIn && line.Trim() == "{")
            {
                isIn = true;
            }
            else if (isIn)
            {
                var split = line.Trim(';', ' ').Split('=').Select(k => k.Trim()).ToArray();

                if (split.Length == 3)
                {
                    if (split[1].StartsWith('(') && split[2].EndsWith(')'))
                    {
                        split[1] = split[1].Substring(1);
                        split[2] = split[2].Substring(0, split[2].Length - 1);
                    }

                    if (varMapping.ContainsKey(split[0]))
                    {
                        varMapping[split[0]] = split[2];
                        split = split.Skip(1).ToArray();
                        line = string.Join('=', split) + ";";
                    }
                }

                if (split.Length == 2)
                {
                    if (varMapping.ContainsKey(split[0]))
                    {
                        varMapping[split[0]] = split[1];
                        continue;
                    }

                    if (varMapping.TryGetValue(split[1], out var val))
                    {
                        split[1] = val;
                    }

                    var def = split[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (def.Length == 2)// var declaration
                    {
                        varMapping.Add(def[1], split[1]);
                        continue;
                    }
                    else
                    {
                        var def2 = split[0].Split('.', StringSplitOptions.RemoveEmptyEntries);
                        thisObject = def2[0] == "this" ? def2[1] : def2[0];


                        if (def2[0] != "this")// var declaration
                        {
                            if (varMapping.TryGetValue(def2[0], out var value))
                            {
                                def2[0] = value;
                                var full = string.Join('.', def2) + " = " + split[1] + ";";
                                sb.AppendLine(full);
                                continue;
                            }
                        }
                    }
                }
            }
            
            sb.AppendLine(line);
            if (thisObject != null && thisObject != lastObject &&
                context.EventHandlers.TryGetValue(thisObject, out var list))
            {
                lastObject = thisObject;
                foreach (var (@event, eventHandlerTypeName, eventHandler) in list)
                {
                    sb.AppendLine($"this.{thisObject}.{@event} += new {eventHandlerTypeName}({eventHandler});");
                }
            }
        }

        var str = sb.ToString();
        if (context.TargetClass == "MainWindow")
        {
        }

        stringBuilder.AppendLine(str);
    }

    private static void AnalyzeEvents(Context context, StringBuilder stringBuilder)
    {
        foreach (var kvp in context.TargetFields)
        {
            var name = kvp.Key;
            var code = kvp.Value;
            var lines = GetAllLines(code);
            bool isInSet = false;
            string? outBrace = null;

            var tempMap = new Dictionary<string, (string Type, string Handler)>();

            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (isInSet)
                {
                    if (line.TrimEnd() == outBrace)
                    {
                        break;
                    }

                    var split = line.TrimEnd(' ', ';').Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (split.Length == 4 && split[2] == "=")
                    {
                        tempMap.Add(split[1], (split[0], split[3]));
                    }
                    else if (split.Length == 3 && split[1] == "-=")
                    {
                        var tempName = split[2];
                        var split2 = split[0].Split('.');
                        if (split2.Length == 2 && split2[0] == $"_{name}")
                        {
                            var (type, handler) = tempMap[tempName];

                            if (!context.EventHandlers.ContainsKey(name))
                            {
                                context.EventHandlers.Add(name,
                                    new List<(string Event, string EventHandlerTypeName, string EventHNandler)>());
                            }

                            var list = context.EventHandlers[name];
                            list.Add((split2[1], type, handler));
                        }
                    }
                }
                else if (!isInSet && lines[i].Trim() == "set" && lines[i + 1].Trim() == "{")
                {
                    outBrace = lines[i + 1].Replace('{', '}').TrimEnd();
                    i++;
                    isInSet = true;
                }
            }
        }
    }

    private static string[] GetAllLines(string contextTargetField)
    {
        var lines = new List<string>();

        using (var sr = new StringReader(contextTargetField))
        {
            while (sr.ReadLine() is { } line)
            {
                lines.Add(line);
            }
        }

        return lines.ToArray();
    }
}