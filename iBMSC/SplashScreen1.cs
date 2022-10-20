using System.Drawing;
using System.Windows.Forms;

namespace iBMSC;

public sealed partial class SplashScreen1 : Form
{
    public SplashScreen1()
    {
        Paint += SplashScreen1_Paint;
        InitializeComponent();
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