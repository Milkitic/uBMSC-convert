using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

public partial class OpPlayer : Form
{
    private MainWindow.PlayerArguments[] pArg;
    private int CurrPlayer;

    private void OK_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
        MyProject.Forms.MainWindow.pArgs = (MainWindow.PlayerArguments[])pArg.Clone();
        MyProject.Forms.MainWindow.CurrentPlayer = CurrPlayer;
        Dispose();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
        Dispose();
    }

    private void OpPlayer_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Text = Strings.fopPlayer.Title;
        Label1.Text = Strings.fopPlayer.Path;
        Label2.Text = Strings.fopPlayer.PlayFromBeginning;
        Label3.Text = Strings.fopPlayer.PlayFromHere;
        Label4.Text = Strings.fopPlayer.StopPlaying;
        BAdd.Text = Strings.fopPlayer.Add;
        BRemove.Text = Strings.fopPlayer.Remove;
        Label6.Text = Strings.fopPlayer.References + "\r\n<apppath> = " + Strings.fopPlayer.DirectoryOfApp +
                      "\r\n<measure> = " + Strings.fopPlayer.CurrMeasure + "\r\n<filename> = " +
                      Strings.fopPlayer.FileName;
        OK_Button.Text = Strings.OK;
        Cancel_Button.Text = Strings.Cancel;
        BDefault.Text = Strings.fopPlayer.RestoreDefault;
    }

    private void LPlayer_Click(object sender, EventArgs e)
    {
        if (pArg != null && pArg.Length != 0)
        {
            CurrPlayer = LPlayer.SelectedIndex;
            ShowInTextbox();
        }
    }

    private void LPlayer_KeyDown(object sender, KeyEventArgs e)
    {
        LPlayer_Click(RuntimeHelpers.GetObjectValue(sender), EventArgs.Empty);
    }

    private void BPrevAdd_Click(object sender, EventArgs e)
    {
        checked
        {
            pArg = (MainWindow.PlayerArguments[])Utils.CopyArray(pArg,
                new MainWindow.PlayerArguments[Information.UBound(pArg) + 1 + 1]);
            CurrPlayer++;
            int num = Information.UBound(pArg);
            int currPlayer = CurrPlayer;
            for (int i = num; i >= currPlayer; i += -1)
            {
                ref MainWindow.PlayerArguments reference = ref pArg[i];
                reference = pArg[i - 1];
            }

            LPlayer.Items.Insert(CurrPlayer, GetFileName(pArg[CurrPlayer - 1].Path));
            LPlayer.SelectedIndex++;
        }
    }

    private void BPrevDelete_Click(object sender, EventArgs e)
    {
        if (LPlayer.Items.Count == 1)
        {
            Interaction.MsgBox(Strings.Messages.PreviewDelError, MsgBoxStyle.Exclamation);
            return;
        }

        int currPlayer = CurrPlayer;
        checked
        {
            int num = Information.UBound(pArg) - 1;
            for (int i = currPlayer; i <= num; i++)
            {
                ref MainWindow.PlayerArguments reference = ref pArg[i];
                reference = pArg[i + 1];
            }

            pArg = (MainWindow.PlayerArguments[])Utils.CopyArray(pArg,
                new MainWindow.PlayerArguments[Information.UBound(pArg) - 1 + 1]);
            LPlayer.Items.RemoveAt(CurrPlayer);
            LPlayer.SelectedIndex =
                Conversions.ToInteger(
                    Interaction.IIf(CurrPlayer > Information.UBound(pArg), CurrPlayer - 1, CurrPlayer));
            CurrPlayer = Math.Min(CurrPlayer, Information.UBound(pArg));
            ShowInTextbox();
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void BPrevBrowse_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Conversions.ToString(Interaction.IIf(
            Operators.CompareString(
                Path.GetDirectoryName(Microsoft.VisualBasic.Strings.Replace(TPath.Text, "<apppath>",
                    MyProject.Application.Info.DirectoryPath)), "", TextCompare: false) == 0,
            MyProject.Application.Info.DirectoryPath,
            Path.GetDirectoryName(Microsoft.VisualBasic.Strings.Replace(TPath.Text, "<apppath>",
                MyProject.Application.Info.DirectoryPath))));
        openFileDialog.Filter = Strings.FileType.EXE + "|*.exe";
        openFileDialog.DefaultExt = "exe";
        if (openFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            TPath.Text = Microsoft.VisualBasic.Strings.Replace(openFileDialog.FileName,
                MyProject.Application.Info.DirectoryPath, "<apppath>");
        }
    }

    private void BPrevDefault_Click(object sender, EventArgs e)
    {
        if (Interaction.MsgBox(Strings.Messages.RestoreDefaultSettings, MsgBoxStyle.YesNo | MsgBoxStyle.Question) !=
            MsgBoxResult.No)
        {
            MainWindow.PlayerArguments[] array = new MainWindow.PlayerArguments[2];
            ref MainWindow.PlayerArguments reference = ref array[0];
            MainWindow.PlayerArguments playerArguments = new MainWindow.PlayerArguments("<apppath>\\uBMplay.exe",
                "-P -N0 \"<filename>\"", "-P -N<measure> \"<filename>\"", "-S");
            reference = playerArguments;
            ref MainWindow.PlayerArguments reference2 = ref array[1];
            MainWindow.PlayerArguments playerArguments2 = new MainWindow.PlayerArguments("<apppath>\\o2play.exe",
                "-P -N0 \"<filename>\"", "-P -N<measure> \"<filename>\"", "-S");
            reference2 = playerArguments2;
            pArg = array;
            CurrPlayer = 0;
            ResetLPlayer_ShowInTextbox();
        }
    }

    private void ResetLPlayer_ShowInTextbox()
    {
        LPlayer.Items.Clear();
        int num = Information.UBound(pArg);
        for (int i = 0; i <= num; i = checked(i + 1))
        {
            LPlayer.Items.Add(GetFileName(pArg[i].Path));
        }

        LPlayer.SelectedIndex = CurrPlayer;
        ShowInTextbox();
    }

    private void LPlayerChangeCurrIndex(string xStr)
    {
        LPlayer.Items[CurrPlayer] = GetFileName(xStr);
    }

    private void SavePArg()
    {
        pArg[CurrPlayer].Path = TPath.Text;
        pArg[CurrPlayer].aBegin = TPlayB.Text;
        pArg[CurrPlayer].aHere = TPlay.Text;
        pArg[CurrPlayer].aStop = TStop.Text;
    }

    private void ShowInTextbox()
    {
        TPath.Text = pArg[CurrPlayer].Path;
        TPlayB.Text = pArg[CurrPlayer].aBegin;
        TPlay.Text = pArg[CurrPlayer].aHere;
        TStop.Text = pArg[CurrPlayer].aStop;
        ValidateTextBox();
    }

    private void ValidateTextBox()
    {
        TextBox[] array = new TextBox[4] { TPath, TPlayB, TPlay, TStop };
        Color backColor = default(Color);
        foreach (TextBox textBox in array)
        {
            string text = textBox.Text.Replace("<apppath>", "").Replace("<measure>", "").Replace("<filename>", "")
                .Replace("\"", "");
            bool flag = false;
            char[] invalidPathChars = Path.GetInvalidPathChars();
            foreach (char value in invalidPathChars)
            {
                if (text.IndexOf(value) != -1)
                {
                    flag = true;
                    break;
                }
            }

            textBox.BackColor = flag ? Color.FromArgb(-16192) : backColor;
        }
    }

    public OpPlayer(int xCurrPlayer)
    {
        Load += OpPlayer_Load;
        CurrPlayer = -1;
        InitializeComponent();
        pArg = (MainWindow.PlayerArguments[])MyProject.Forms.MainWindow.pArgs.Clone();
        CurrPlayer = xCurrPlayer;
        ResetLPlayer_ShowInTextbox();
    }

    private void TPath_KeyDown(object sender, KeyEventArgs e)
    {
        SavePArg();
        if (ReferenceEquals(RuntimeHelpers.GetObjectValue(sender), TPath))
        {
            LPlayerChangeCurrIndex(pArg[CurrPlayer].Path);
        }
    }

    private void TPath_LostFocus(object sender, EventArgs e)
    {
        SavePArg();
        if (ReferenceEquals(RuntimeHelpers.GetObjectValue(sender), TPath))
        {
            LPlayerChangeCurrIndex(pArg[CurrPlayer].Path);
        }

        ValidateTextBox();
    }

    private string GetFileName(string s)
    {
        int num = Microsoft.VisualBasic.Strings.InStrRev(s, "/");
        int num2 = Microsoft.VisualBasic.Strings.InStrRev(s, "\\");
        return Microsoft.VisualBasic.Strings.Mid(s,
            Conversions.ToInteger(Operators.AddObject(Interaction.IIf(num > num2, num, num2), 1)));
    }
}