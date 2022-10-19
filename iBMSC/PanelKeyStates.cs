using iBMSC.My;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[StandardModule]
internal sealed class PanelKeyStates
{
    public static bool ModifierLongNoteActive()
    {
        return MyProject.Computer.Keyboard.ShiftKeyDown & !MyProject.Computer.Keyboard.CtrlKeyDown;
    }

    public static bool ModifierHiddenActive()
    {
        return MyProject.Computer.Keyboard.CtrlKeyDown & !MyProject.Computer.Keyboard.ShiftKeyDown;
    }

    public static bool ModifierLandmineActive()
    {
        return MyProject.Computer.Keyboard.CtrlKeyDown & MyProject.Computer.Keyboard.ShiftKeyDown;
    }

    public static bool ModifierMultiselectActive()
    {
        return MyProject.Computer.Keyboard.ShiftKeyDown & MyProject.Computer.Keyboard.CtrlKeyDown;
    }
}
