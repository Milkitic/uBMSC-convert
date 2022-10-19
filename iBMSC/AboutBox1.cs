using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iBMSC.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public sealed class AboutBox1 : Form
{
    private IContainer components;

    [AccessedThroughProperty("ClickToCopy")]
    private Label _ClickToCopy;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    private const int WM_SYSCOMMAND = 274;

    private const int SC_MOVE = 61456;

    private const int WM_NCLBUTTONDOWN = 161;

    private const int HTCAPTION = 2;

    public Bitmap bBitmap;

    internal  Label ClickToCopy
    {
        get
        {
            return _ClickToCopy;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = ClickToCopy_Click;
            if (_ClickToCopy != null)
            {
                _ClickToCopy.Click -= value2;
            }
            _ClickToCopy = value;
            if (_ClickToCopy != null)
            {
                _ClickToCopy.Click += value2;
            }
        }
    }

    internal  Label Label1
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

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams createParams = base.CreateParams;
            createParams.ExStyle |= 524288;
            return createParams;
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
        this.ClickToCopy = new System.Windows.Forms.Label();
        this.Label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        this.ClickToCopy.Cursor = System.Windows.Forms.Cursors.Hand;
        System.Windows.Forms.Label clickToCopy = this.ClickToCopy;
        System.Drawing.Point location = new System.Drawing.Point(540, 355);
        clickToCopy.Location = location;
        this.ClickToCopy.Name = "ClickToCopy";
        System.Windows.Forms.Label clickToCopy2 = this.ClickToCopy;
        System.Drawing.Size size = new System.Drawing.Size(131, 23);
        clickToCopy2.Size = size;
        this.ClickToCopy.TabIndex = 1;
        this.ClickToCopy.Tag = "620, 288";
        this.ClickToCopy.Text = "Click to copy";
        this.ClickToCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.ClickToCopy.Visible = false;
        this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
        System.Windows.Forms.Label label = this.Label1;
        location = new System.Drawing.Point(620, 288);
        label.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label2 = this.Label1;
        size = new System.Drawing.Size(96, 21);
        label2.Size = size;
        this.Label1.TabIndex = 2;
        this.Label1.Tag = "620, 288";
        this.Label1.Text = "Click to copy";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Label1.Visible = false;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        size = new System.Drawing.Size(1000, 600);
        this.ClientSize = size;
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.ClickToCopy);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "AboutBox1";
        System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(10);
        this.Padding = padding;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "About";
        this.ResumeLayout(false);
    }

    [DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
    public static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    public static extern int ReleaseCapture();

    private void AboutBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        Close();
    }

    private void AboutBox1_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle.ToInt32(), 274, 61458, 0);
    }

    private void AboutBox1_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            Close();
        }
    }

    public void SelectBitmap()
    {
        if (bBitmap.PixelFormat != PixelFormat.Format32bppArgb)
        {
            throw new ApplicationException("The bitmap must be 32bpp with alpha-channel.");
        }
        IntPtr dC = APIHelp.GetDC(IntPtr.Zero);
        IntPtr intPtr = APIHelp.CreateCompatibleDC(dC);
        IntPtr intPtr2 = IntPtr.Zero;
        IntPtr hObject = IntPtr.Zero;
        try
        {
            intPtr2 = bBitmap.GetHbitmap(Color.FromArgb(0));
            hObject = APIHelp.SelectObject(intPtr, intPtr2);
            APIHelp.Size psize = new APIHelp.Size(bBitmap.Width, bBitmap.Height);
            APIHelp.Point pprSrc = new APIHelp.Point(0, 0);
            APIHelp.Point pptDst = new APIHelp.Point(Left, Top);
            APIHelp.BLENDFUNCTION pblend = default(APIHelp.BLENDFUNCTION);
            pblend.BlendOp = 0;
            pblend.BlendFlags = 0;
            pblend.SourceConstantAlpha = byte.MaxValue;
            pblend.AlphaFormat = 1;
            APIHelp.UpdateLayeredWindow(Handle, dC, ref pptDst, ref psize, intPtr, ref pprSrc, 0, ref pblend, 2);
        }
        finally
        {
            APIHelp.ReleaseDC(IntPtr.Zero, dC);
            if (intPtr2 != IntPtr.Zero)
            {
                APIHelp.SelectObject(intPtr, hObject);
                APIHelp.DeleteObject(intPtr2);
            }
            APIHelp.DeleteDC(intPtr);
        }
    }

    private void ClickToCopy_Click(object sender, EventArgs e)
    {
        Clipboard.Clear();
        Clipboard.SetText("higan314doaz9@qq.com");
        Interaction.Beep();
    }

    private void AboutBox1_Load(object sender, EventArgs e)
    {
        SelectBitmap();
    }

    public AboutBox1()
    {
        base.KeyPress += AboutBox1_KeyPress;
        base.Load += AboutBox1_Load;
        base.MouseDown += AboutBox1_MouseDown;
        base.MouseUp += AboutBox1_MouseUp;
        bBitmap = Resources.SplashScreenx;
        InitializeComponent();
    }
}
