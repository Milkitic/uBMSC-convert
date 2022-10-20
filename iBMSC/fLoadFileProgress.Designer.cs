using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace iBMSC
{
    public partial class fLoadFileProgress : Form
    {
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
    private IContainer components;
    [System.Diagnostics.DebuggerStepThrough]
    private void InitializeComponent()
    {
        this.Cancel_Button = new System.Windows.Forms.Button();
this.Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
        this.prog = new System.Windows.Forms.ProgressBar();
        this.Label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
this.Cancel_Button.Location = new System.Drawing.Point(245, 81);
        this.Cancel_Button.Name = "Cancel_Button";
this.Cancel_Button.Size = new System.Drawing.Size(120, 27);
        this.Cancel_Button.TabIndex = 1;
        this.Cancel_Button.Text = "Cancel";
this.prog.Location = new System.Drawing.Point(15, 60);
        this.prog.Name = "prog";
this.prog.Size = new System.Drawing.Size(584, 15);
        this.prog.TabIndex = 2;
this.Label1.Location = new System.Drawing.Point(12, 9);
        this.Label1.Name = "Label1";
this.Label1.Size = new System.Drawing.Size(587, 48);
        this.Label1.TabIndex = 3;
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.AcceptButton = this.Cancel_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
this.ClientSize=new System.Drawing.Size(611, 120);
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

internal Button Cancel_Button;
internal ProgressBar prog;
internal Label Label1;
    }
}
