using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public sealed class SplashScreen1 : Form
{
    private IContainer components;

    public SplashScreen1()
    {
        base.Paint += SplashScreen1_Paint;
        InitializeComponent();
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
        this.SuspendLayout();
        System.Drawing.SizeF sizeF = new System.Drawing.SizeF(6f, 13f);
        this.AutoScaleDimensions = sizeF;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        System.Drawing.Size clientSize = new System.Drawing.Size(722, 331);
        this.ClientSize = clientSize;
        this.ControlBox = false;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "SplashScreen1";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.ResumeLayout(false);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        Rectangle rectangle = new Rectangle(0, 0, Width, Height);
    }

    private void SplashScreen1_Paint(object sender, PaintEventArgs e)
    {
    }
}
