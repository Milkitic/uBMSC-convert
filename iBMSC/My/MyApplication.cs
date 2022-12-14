using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
    [STAThread]
    internal static void Main(string[] Args)
    {
        try
        {
            Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
        }
        finally
        {
        }
        MyProject.Application.Run(Args);
    }

    private void MyApplication_Shutdown(object sender, EventArgs e)
    {
    }

    private void MyApplication_Startup(object sender, StartupEventArgs e)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
    {
        MsgBoxResult msgBoxResult = Interaction.MsgBox("An unhandled exception has occurred in the application: \r\n" + e.Exception.Message + "\r\n\r\nClick Yes to save a back-up, click No otherwise, or click Cancel to ignore this exception and continue.", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Critical, "Unhandled Exception");
        if (msgBoxResult == MsgBoxResult.Cancel)
        {
            e.ExitApplication = false;
        }
        if (msgBoxResult == MsgBoxResult.Yes)
        {
            DateTime now = DateTime.Now;
            string text = "\\AutoSave_" + Conversions.ToString(now.Year) + "_" + Conversions.ToString(now.Month) + "_" + Conversions.ToString(now.Day) + "_" + Conversions.ToString(now.Hour) + "_" + Conversions.ToString(now.Minute) + "_" + Conversions.ToString(now.Second) + "_" + Conversions.ToString(now.Millisecond) + ".IBMSC";
            MyProject.Forms.MainWindow.ExceptionSave(MyProject.Application.Info.DirectoryPath + text);
            Interaction.MsgBox("A back-up has been saved to " + MyProject.Application.Info.DirectoryPath + text, MsgBoxStyle.Information);
        }
    }

    [DebuggerStepThrough]
    public MyApplication()
        : base(AuthenticationMode.Windows)
    {
        UnhandledException += MyApplication_UnhandledException;
        Shutdown += MyApplication_Shutdown;
        Startup += MyApplication_Startup;
        IsSingleInstance = false;
        EnableVisualStyles = true;
        SaveMySettingsOnExit = true;
        ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm()
    {
        MainForm = MyProject.Forms.MainWindow;
    }

    [DebuggerStepThrough]
    protected override void OnCreateSplashScreen()
    {
        SplashScreen = MyProject.Forms.SplashScreen1;
    }
}
