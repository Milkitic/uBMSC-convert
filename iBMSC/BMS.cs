using System;
using iBMSC.Editor;
using Microsoft.VisualBasic;

namespace iBMSC;

internal static class BMS
{
    public static bool IsChannelLongNote(string I)
    {
        int num = checked((int)Math.Round(Conversion.Val(I)));
        return num is >= 50 and < 90;
    }

    public static bool IsChannelHidden(string I)
    {
        int num = checked((int)Math.Round(Conversion.Val(I)));
        return num is >= 30 and < 50 or >= 70 and < 90;
    }

    public static bool IsChannelLandmine(string I)
    {
        int num = Functions.C36to10("D0");
        int num2 = Functions.C36to10("EZ");
        int num3 = Functions.C36to10(I);
        return num3 > num && num3 < num2;
    }
}