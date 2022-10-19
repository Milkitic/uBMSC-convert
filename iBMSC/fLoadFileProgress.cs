using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class fLoadFileProgress : Form
{
    private IContainer components;

    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;

    [AccessedThroughProperty("prog")]
    private ProgressBar _prog;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    private string[] xPath;

    private bool CancelPressed;

    private bool IsSaved;

    internal virtual Button Cancel_Button
    {
        get
        {
            return _Cancel_Button;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Cancel_Button_Click;
            if (_Cancel_Button != null)
            {
                _Cancel_Button.Click -= value2;
            }
            _Cancel_Button = value;
            if (_Cancel_Button != null)
            {
                _Cancel_Button.Click += value2;
            }
        }
    }

    internal virtual ProgressBar prog
    {
        get
        {
            return _prog;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _prog = value;
        }
    }

    internal virtual Label Label1
    {
        get
        {
            return _Label1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label1 = value;
        }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    [System.Diagnostics.DebuggerStepThrough]
    private void InitializeComponent()
    {
        this.Cancel_Button = new System.Windows.Forms.Button();
        this.prog = new System.Windows.Forms.ProgressBar();
        this.Label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        System.Windows.Forms.Button cancel_Button = this.Cancel_Button;
        System.Drawing.Point location = new System.Drawing.Point(245, 81);
        cancel_Button.Location = location;
        this.Cancel_Button.Name = "Cancel_Button";
        System.Windows.Forms.Button cancel_Button2 = this.Cancel_Button;
        System.Drawing.Size size = new System.Drawing.Size(120, 27);
        cancel_Button2.Size = size;
        this.Cancel_Button.TabIndex = 1;
        this.Cancel_Button.Text = "Cancel";
        System.Windows.Forms.ProgressBar progressBar = this.prog;
        location = new System.Drawing.Point(15, 60);
        progressBar.Location = location;
        this.prog.Name = "prog";
        System.Windows.Forms.ProgressBar progressBar2 = this.prog;
        size = new System.Drawing.Size(584, 15);
        progressBar2.Size = size;
        this.prog.TabIndex = 2;
        System.Windows.Forms.Label label = this.Label1;
        location = new System.Drawing.Point(12, 9);
        label.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label2 = this.Label1;
        size = new System.Drawing.Size(587, 48);
        label2.Size = size;
        this.Label1.TabIndex = 3;
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.AcceptButton = this.Cancel_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
        size = new System.Drawing.Size(611, 120);
        this.ClientSize = size;
        this.ControlBox = false;
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.prog);
        this.Controls.Add(this.Cancel_Button);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "fLoadFileProgress";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Loading Files";
        this.TopMost = true;
        this.ResumeLayout(false);
    }

    public fLoadFileProgress(string[] xxPath, bool xIsSaved, bool TopMost = true)
    {
        base.Shown += fLoadFileProgress_Shown;
        base.Load += fLoadFileProgress_Load;
        xPath = new string[0];
        CancelPressed = false;
        IsSaved = false;
        InitializeComponent();
        prog.Maximum = checked(Information.UBound(xxPath) + 1);
        xPath = xxPath;
        IsSaved = xIsSaved;
        this.TopMost = TopMost;
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        CancelPressed = true;
        Close();
    }

    private void fLoadFileProgress_Shown(object sender, EventArgs e)
    {
        int try0000_dispatch = -1;
        int num2 = default(int);
        int num = default(int);
        while (true)
        {
            try
            {
                /*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
                checked
                {
                    switch (try0000_dispatch)
                    {
                    default:
                    {
                        ProjectData.ClearProjectError();
                        num2 = 0;
                        int num3 = Information.UBound(xPath);
                        for (int i = 0; i <= num3; i++)
                        {
                            Label1.Text = "Currently loading ( " + Conversions.ToString(i + 1) + " / " + Conversions.ToString(Information.UBound(xPath) + 1) + " ): " + xPath[i];
                            int maximum = prog.Maximum;
                            int value = prog.Value;
                            prog.Value = i;
                            Application.DoEvents();
                            if (CancelPressed)
                            {
                                break;
                            }
                            if (i == 0 && IsSaved)
                            {
                                MyProject.Forms.MainWindow.ReadFile(xPath[i]);
                            }
                            else
                            {
                                Process.Start(Application.ExecutablePath, "\"" + xPath[i] + "\"");
                            }
                        }
                        Close();
                        goto end_IL_0000;
                    }
                    case 269:
                        num = -1;
                        switch (num2)
                        {
                        }
                        break;
                    }
                    goto IL_0143;
                }
                end_IL_0000:;
            }
            catch (Exception obj) when (num2 != 0 && num == 0)
            {
                ProjectData.SetProjectError((Exception)obj);
                try0000_dispatch = 269;
                continue;
            }
            break;
            IL_0143:
            throw ProjectData.CreateProjectError(-2146828237);
        }
        if (num != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void fLoadFileProgress_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Cancel_Button.Text = Strings.Cancel;
    }
}
