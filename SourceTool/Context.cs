using System.Text;

namespace SourceTool;

internal class Context
{
    private readonly StringBuilder _source = new();
    private string? _lastLineTrim;

    public string? TargetClass { get; set; }
    public string? TargetComponentDefinition { get; set; }
    public string? DisposeDefinition { get; set; }
    public string? InitializeComponentDefinition { get; set; }
    public string? Namespace { get; set; }

    public Dictionary<string, string> TargetFields { get; } = new();
    public Dictionary<string, string> Fields { get; } = new();

    public Dictionary<string, List<(string Event, string EventHandlerTypeName, string EventHandler)>> EventHandlers { get; } = new();

    public string SourceString => _source.ToString();

    public void AppendSourceLine(string content)
    {
        if (_lastLineTrim == "" && content.Trim() == "")
        {
            return;
        }

        if (_lastLineTrim == "{" && content.Trim() == "")
        {
            return;
        }

        _lastLineTrim = content.Trim();
        _source.AppendLine(content);
    }
}