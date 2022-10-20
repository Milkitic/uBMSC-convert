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
}