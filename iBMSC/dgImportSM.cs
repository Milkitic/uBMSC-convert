using System;
using System.Windows.Forms;
using iBMSC.My;

namespace iBMSC;

public partial class dgImportSM : Form
{
    public int iResult;

    public dgImportSM(string[] sDiff)
    {
        Load += dgImportSM_Load;
        iResult = -1;
        InitializeComponent();
        LDiff.Items.AddRange(sDiff);
        LDiff.SelectedIndex = 0;
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        iResult = LDiff.SelectedIndex;
        Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void dgImportSM_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Text = Strings.fImportSM.Title;
        Label7.Text = Strings.fImportSM.Difficulty;
        Label5.Text = Strings.fImportSM.Note;
        OK_Button.Text = Strings.OK;
        Cancel_Button.Text = Strings.Cancel;
    }
}