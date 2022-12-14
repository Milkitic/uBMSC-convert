using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace iBMSC;

public sealed partial class AboutBox1 : Form
{
    private const int WM_SYSCOMMAND = 274;
    private const int SC_MOVE = 61456;
    private const int WM_NCLBUTTONDOWN = 161;
    private const int HTCAPTION = 2;
    public Bitmap bBitmap;

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams createParams = base.CreateParams;
            createParams.ExStyle |= 524288;
            return createParams;
        }
    }

    [DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true,
        SetLastError = true)]
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
        KeyPress += AboutBox1_KeyPress;
        Load += AboutBox1_Load;
        MouseDown += AboutBox1_MouseDown;
        MouseUp += AboutBox1_MouseUp;
        bBitmap = Resources.SplashScreenx;
        InitializeComponent();
    }
}