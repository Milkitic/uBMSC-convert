using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class OpPlayer : Form
{
    private IContainer components;

    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;

    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;

    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [AccessedThroughProperty("Label3")]
    private Label _Label3;

    [AccessedThroughProperty("Label4")]
    private Label _Label4;

    [AccessedThroughProperty("TPlayB")]
    private TextBox _TPlayB;

    [AccessedThroughProperty("TPlay")]
    private TextBox _TPlay;

    [AccessedThroughProperty("TStop")]
    private TextBox _TStop;

    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    [AccessedThroughProperty("TPath")]
    private TextBox _TPath;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("BBrowse")]
    private Button _BBrowse;

    [AccessedThroughProperty("BDefault")]
    private Button _BDefault;

    [AccessedThroughProperty("BRemove")]
    private Button _BRemove;

    [AccessedThroughProperty("BAdd")]
    private Button _BAdd;

    [AccessedThroughProperty("LPlayer")]
    private ListBox _LPlayer;

    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [AccessedThroughProperty("Label5")]
    private Label _Label5;

    [AccessedThroughProperty("Label7")]
    private Label _Label7;

    private MainWindow.PlayerArguments[] pArg;

    private int CurrPlayer;

    internal virtual Button OK_Button
    {
        get
        {
            return _OK_Button;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = OK_Button_Click;
            if (_OK_Button != null)
            {
                _OK_Button.Click -= value2;
            }
            _OK_Button = value;
            if (_OK_Button != null)
            {
                _OK_Button.Click += value2;
            }
        }
    }

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

    internal virtual Label Label2
    {
        get
        {
            return _Label2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label2 = value;
        }
    }

    internal virtual Label Label3
    {
        get
        {
            return _Label3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label3 = value;
        }
    }

    internal virtual Label Label4
    {
        get
        {
            return _Label4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label4 = value;
        }
    }

    internal virtual TextBox TPlayB
    {
        get
        {
            return _TPlayB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            KeyEventHandler value2 = TPath_KeyDown;
            EventHandler value3 = TPath_LostFocus;
            if (_TPlayB != null)
            {
                _TPlayB.KeyUp -= value2;
                _TPlayB.LostFocus -= value3;
            }
            _TPlayB = value;
            if (_TPlayB != null)
            {
                _TPlayB.KeyUp += value2;
                _TPlayB.LostFocus += value3;
            }
        }
    }

    internal virtual TextBox TPlay
    {
        get
        {
            return _TPlay;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            KeyEventHandler value2 = TPath_KeyDown;
            EventHandler value3 = TPath_LostFocus;
            if (_TPlay != null)
            {
                _TPlay.KeyUp -= value2;
                _TPlay.LostFocus -= value3;
            }
            _TPlay = value;
            if (_TPlay != null)
            {
                _TPlay.KeyUp += value2;
                _TPlay.LostFocus += value3;
            }
        }
    }

    internal virtual TextBox TStop
    {
        get
        {
            return _TStop;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            KeyEventHandler value2 = TPath_KeyDown;
            EventHandler value3 = TPath_LostFocus;
            if (_TStop != null)
            {
                _TStop.KeyUp -= value2;
                _TStop.LostFocus -= value3;
            }
            _TStop = value;
            if (_TStop != null)
            {
                _TStop.KeyUp += value2;
                _TStop.LostFocus += value3;
            }
        }
    }

    internal virtual Label Label6
    {
        get
        {
            return _Label6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label6 = value;
        }
    }

    internal virtual TextBox TPath
    {
        get
        {
            return _TPath;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            KeyEventHandler value2 = TPath_KeyDown;
            EventHandler value3 = TPath_LostFocus;
            if (_TPath != null)
            {
                _TPath.KeyUp -= value2;
                _TPath.LostFocus -= value3;
            }
            _TPath = value;
            if (_TPath != null)
            {
                _TPath.KeyUp += value2;
                _TPath.LostFocus += value3;
            }
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

    internal virtual Button BBrowse
    {
        get
        {
            return _BBrowse;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BPrevBrowse_Click;
            if (_BBrowse != null)
            {
                _BBrowse.Click -= value2;
            }
            _BBrowse = value;
            if (_BBrowse != null)
            {
                _BBrowse.Click += value2;
            }
        }
    }

    internal virtual Button BDefault
    {
        get
        {
            return _BDefault;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BPrevDefault_Click;
            if (_BDefault != null)
            {
                _BDefault.Click -= value2;
            }
            _BDefault = value;
            if (_BDefault != null)
            {
                _BDefault.Click += value2;
            }
        }
    }

    internal virtual Button BRemove
    {
        get
        {
            return _BRemove;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BPrevDelete_Click;
            if (_BRemove != null)
            {
                _BRemove.Click -= value2;
            }
            _BRemove = value;
            if (_BRemove != null)
            {
                _BRemove.Click += value2;
            }
        }
    }

    internal virtual Button BAdd
    {
        get
        {
            return _BAdd;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BPrevAdd_Click;
            if (_BAdd != null)
            {
                _BAdd.Click -= value2;
            }
            _BAdd = value;
            if (_BAdd != null)
            {
                _BAdd.Click += value2;
            }
        }
    }

    internal virtual ListBox LPlayer
    {
        get
        {
            return _LPlayer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            KeyEventHandler value2 = LPlayer_KeyDown;
            EventHandler value3 = LPlayer_Click;
            if (_LPlayer != null)
            {
                _LPlayer.KeyDown -= value2;
                _LPlayer.Click -= value3;
            }
            _LPlayer = value;
            if (_LPlayer != null)
            {
                _LPlayer.KeyDown += value2;
                _LPlayer.Click += value3;
            }
        }
    }

    internal virtual PictureBox PictureBox1
    {
        get
        {
            return _PictureBox1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox1 = value;
        }
    }

    internal virtual Label Label5
    {
        get
        {
            return _Label5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label5 = value;
        }
    }

    internal virtual Label Label7
    {
        get
        {
            return _Label7;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label7 = value;
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
        this.OK_Button = new System.Windows.Forms.Button();
        this.Cancel_Button = new System.Windows.Forms.Button();
        this.Label2 = new System.Windows.Forms.Label();
        this.Label3 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.TPlayB = new System.Windows.Forms.TextBox();
        this.TPlay = new System.Windows.Forms.TextBox();
        this.TStop = new System.Windows.Forms.TextBox();
        this.Label6 = new System.Windows.Forms.Label();
        this.TPath = new System.Windows.Forms.TextBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.BBrowse = new System.Windows.Forms.Button();
        this.BDefault = new System.Windows.Forms.Button();
        this.BRemove = new System.Windows.Forms.Button();
        this.BAdd = new System.Windows.Forms.Button();
        this.LPlayer = new System.Windows.Forms.ListBox();
        this.PictureBox1 = new System.Windows.Forms.PictureBox();
        this.Label5 = new System.Windows.Forms.Label();
        this.Label7 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
        this.SuspendLayout();
        this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button oK_Button = this.OK_Button;
        System.Drawing.Point location = new System.Drawing.Point(72, 316);
        oK_Button.Location = location;
        this.OK_Button.Name = "OK_Button";
        System.Windows.Forms.Button oK_Button2 = this.OK_Button;
        System.Drawing.Size size = new System.Drawing.Size(78, 23);
        oK_Button2.Size = size;
        this.OK_Button.TabIndex = 0;
        this.OK_Button.Text = "OK";
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button cancel_Button = this.Cancel_Button;
        location = new System.Drawing.Point(156, 316);
        cancel_Button.Location = location;
        this.Cancel_Button.Name = "Cancel_Button";
        System.Windows.Forms.Button cancel_Button2 = this.Cancel_Button;
        size = new System.Drawing.Size(78, 23);
        cancel_Button2.Size = size;
        this.Cancel_Button.TabIndex = 1;
        this.Cancel_Button.Text = "Cancel";
        System.Windows.Forms.Label label = this.Label2;
        location = new System.Drawing.Point(14, 153);
        label.Location = location;
        this.Label2.Name = "Label2";
        System.Windows.Forms.Label label2 = this.Label2;
        size = new System.Drawing.Size(157, 15);
        label2.Size = size;
        this.Label2.TabIndex = 3;
        this.Label2.Text = "Play from beginning";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label3 = this.Label3;
        location = new System.Drawing.Point(14, 182);
        label3.Location = location;
        this.Label3.Name = "Label3";
        System.Windows.Forms.Label label4 = this.Label3;
        size = new System.Drawing.Size(157, 15);
        label4.Size = size;
        this.Label3.TabIndex = 4;
        this.Label3.Text = "Play from current measure";
        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label5 = this.Label4;
        location = new System.Drawing.Point(14, 211);
        label5.Location = location;
        this.Label4.Name = "Label4";
        System.Windows.Forms.Label label6 = this.Label4;
        size = new System.Drawing.Size(157, 15);
        label6.Size = size;
        this.Label4.TabIndex = 5;
        this.Label4.Text = "Stop";
        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.TextBox tPlayB = this.TPlayB;
        location = new System.Drawing.Point(177, 150);
        tPlayB.Location = location;
        this.TPlayB.Name = "TPlayB";
        System.Windows.Forms.TextBox tPlayB2 = this.TPlayB;
        size = new System.Drawing.Size(192, 23);
        tPlayB2.Size = size;
        this.TPlayB.TabIndex = 4;
        System.Windows.Forms.TextBox tPlay = this.TPlay;
        location = new System.Drawing.Point(177, 179);
        tPlay.Location = location;
        this.TPlay.Name = "TPlay";
        System.Windows.Forms.TextBox tPlay2 = this.TPlay;
        size = new System.Drawing.Size(192, 23);
        tPlay2.Size = size;
        this.TPlay.TabIndex = 5;
        System.Windows.Forms.TextBox tStop = this.TStop;
        location = new System.Drawing.Point(177, 208);
        tStop.Location = location;
        this.TStop.Name = "TStop";
        System.Windows.Forms.TextBox tStop2 = this.TStop;
        size = new System.Drawing.Size(192, 23);
        tStop2.Size = size;
        this.TStop.TabIndex = 6;
        this.Label6.AutoSize = true;
        System.Windows.Forms.Label label7 = this.Label6;
        location = new System.Drawing.Point(14, 244);
        label7.Location = location;
        this.Label6.Name = "Label6";
        System.Windows.Forms.Label label8 = this.Label6;
        size = new System.Drawing.Size(225, 60);
        label8.Size = size;
        this.Label6.TabIndex = 11;
        this.Label6.Text = "References (case-sensitive):\r\n<apppath> = Directory of the application\r\n<measure> = Current measure\r\n<filename> = File Name";
        System.Windows.Forms.TextBox tPath = this.TPath;
        location = new System.Drawing.Point(51, 98);
        tPath.Location = location;
        this.TPath.Name = "TPath";
        System.Windows.Forms.TextBox tPath2 = this.TPath;
        size = new System.Drawing.Size(288, 23);
        tPath2.Size = size;
        this.TPath.TabIndex = 2;
        System.Windows.Forms.Label label9 = this.Label1;
        location = new System.Drawing.Point(0, 101);
        label9.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label10 = this.Label1;
        size = new System.Drawing.Size(45, 15);
        label10.Size = size;
        this.Label1.TabIndex = 12;
        this.Label1.Text = "Path";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.BBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bBrowse = this.BBrowse;
        location = new System.Drawing.Point(345, 98);
        bBrowse.Location = location;
        this.BBrowse.Name = "BBrowse";
        System.Windows.Forms.Button bBrowse2 = this.BBrowse;
        size = new System.Drawing.Size(24, 23);
        bBrowse2.Size = size;
        this.BBrowse.TabIndex = 3;
        this.BBrowse.Text = "...";
        this.BBrowse.UseVisualStyleBackColor = true;
        this.BDefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.BDefault.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bDefault = this.BDefault;
        location = new System.Drawing.Point(240, 316);
        bDefault.Location = location;
        this.BDefault.Name = "BDefault";
        System.Windows.Forms.Button bDefault2 = this.BDefault;
        size = new System.Drawing.Size(130, 23);
        bDefault2.Size = size;
        this.BDefault.TabIndex = 62;
        this.BDefault.Text = "Restore default";
        this.BDefault.UseVisualStyleBackColor = true;
        this.BRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bRemove = this.BRemove;
        location = new System.Drawing.Point(243, 41);
        bRemove.Location = location;
        this.BRemove.Name = "BRemove";
        System.Windows.Forms.Button bRemove2 = this.BRemove;
        size = new System.Drawing.Size(117, 23);
        bRemove2.Size = size;
        this.BRemove.TabIndex = 59;
        this.BRemove.Text = "Remove";
        this.BRemove.UseVisualStyleBackColor = true;
        this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bAdd = this.BAdd;
        location = new System.Drawing.Point(243, 12);
        bAdd.Location = location;
        this.BAdd.Name = "BAdd";
        System.Windows.Forms.Button bAdd2 = this.BAdd;
        size = new System.Drawing.Size(117, 23);
        bAdd2.Size = size;
        this.BAdd.TabIndex = 58;
        this.BAdd.Text = "Add";
        this.BAdd.UseVisualStyleBackColor = true;
        this.LPlayer.FormattingEnabled = true;
        this.LPlayer.IntegralHeight = false;
        this.LPlayer.ItemHeight = 15;
        this.LPlayer.Items.AddRange(new object[2] { "uBMplay.exe", "o2play.exe" });
        System.Windows.Forms.ListBox lPlayer = this.LPlayer;
        location = new System.Drawing.Point(12, 27);
        lPlayer.Location = location;
        this.LPlayer.Name = "LPlayer";
        System.Windows.Forms.ListBox lPlayer2 = this.LPlayer;
        size = new System.Drawing.Size(225, 55);
        lPlayer2.Size = size;
        this.LPlayer.TabIndex = 63;
        this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        System.Windows.Forms.PictureBox pictureBox = this.PictureBox1;
        location = new System.Drawing.Point(12, 134);
        pictureBox.Location = location;
        this.PictureBox1.Name = "PictureBox1";
        System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox1;
        size = new System.Drawing.Size(357, 1);
        pictureBox2.Size = size;
        this.PictureBox1.TabIndex = 64;
        this.PictureBox1.TabStop = false;
        this.Label5.AutoSize = true;
        System.Windows.Forms.Label label11 = this.Label5;
        location = new System.Drawing.Point(12, 9);
        label11.Location = location;
        this.Label5.Name = "Label5";
        System.Windows.Forms.Label label12 = this.Label5;
        size = new System.Drawing.Size(85, 15);
        label12.Size = size;
        this.Label5.TabIndex = 65;
        this.Label5.Text = "Current Player:";
        this.Label7.AutoSize = true;
        System.Windows.Forms.Label label13 = this.Label7;
        location = new System.Drawing.Point(12, 126);
        label13.Location = location;
        this.Label7.Name = "Label7";
        System.Windows.Forms.Label label14 = this.Label7;
        size = new System.Drawing.Size(66, 15);
        label14.Size = size;
        this.Label7.TabIndex = 66;
        this.Label7.Text = "Arguments";
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
        size = new System.Drawing.Size(382, 351);
        this.ClientSize = size;
        this.Controls.Add(this.Label7);
        this.Controls.Add(this.Label5);
        this.Controls.Add(this.PictureBox1);
        this.Controls.Add(this.Cancel_Button);
        this.Controls.Add(this.OK_Button);
        this.Controls.Add(this.LPlayer);
        this.Controls.Add(this.BDefault);
        this.Controls.Add(this.BRemove);
        this.Controls.Add(this.BAdd);
        this.Controls.Add(this.BBrowse);
        this.Controls.Add(this.TPath);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.Label6);
        this.Controls.Add(this.TStop);
        this.Controls.Add(this.TPlay);
        this.Controls.Add(this.TPlayB);
        this.Controls.Add(this.Label4);
        this.Controls.Add(this.Label3);
        this.Controls.Add(this.Label2);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "OpPlayer";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Player Options";
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

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
        Label6.Text = Strings.fopPlayer.References + "\r\n<apppath> = " + Strings.fopPlayer.DirectoryOfApp + "\r\n<measure> = " + Strings.fopPlayer.CurrMeasure + "\r\n<filename> = " + Strings.fopPlayer.FileName;
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
        LPlayer_Click(RuntimeHelpers.GetObjectValue(sender), new EventArgs());
    }

    private void BPrevAdd_Click(object sender, EventArgs e)
    {
        checked
        {
            pArg = (MainWindow.PlayerArguments[])Utils.CopyArray(pArg, new MainWindow.PlayerArguments[Information.UBound(pArg) + 1 + 1]);
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
            pArg = (MainWindow.PlayerArguments[])Utils.CopyArray(pArg, new MainWindow.PlayerArguments[Information.UBound(pArg) - 1 + 1]);
            LPlayer.Items.RemoveAt(CurrPlayer);
            LPlayer.SelectedIndex = Conversions.ToInteger(Interaction.IIf(CurrPlayer > Information.UBound(pArg), CurrPlayer - 1, CurrPlayer));
            CurrPlayer = Math.Min(CurrPlayer, Information.UBound(pArg));
            ShowInTextbox();
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void BPrevBrowse_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Conversions.ToString(Interaction.IIf(Operators.CompareString(Path.GetDirectoryName(Microsoft.VisualBasic.Strings.Replace(TPath.Text, "<apppath>", MyProject.Application.Info.DirectoryPath)), "", TextCompare: false) == 0, MyProject.Application.Info.DirectoryPath, Path.GetDirectoryName(Microsoft.VisualBasic.Strings.Replace(TPath.Text, "<apppath>", MyProject.Application.Info.DirectoryPath))));
        openFileDialog.Filter = Strings.FileType.EXE + "|*.exe";
        openFileDialog.DefaultExt = "exe";
        if (openFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            TPath.Text = Microsoft.VisualBasic.Strings.Replace(openFileDialog.FileName, MyProject.Application.Info.DirectoryPath, "<apppath>");
        }
    }

    private void BPrevDefault_Click(object sender, EventArgs e)
    {
        if (Interaction.MsgBox(Strings.Messages.RestoreDefaultSettings, MsgBoxStyle.YesNo | MsgBoxStyle.Question) != MsgBoxResult.No)
        {
            MainWindow.PlayerArguments[] array = new MainWindow.PlayerArguments[2];
            ref MainWindow.PlayerArguments reference = ref array[0];
            MainWindow.PlayerArguments playerArguments = new MainWindow.PlayerArguments("<apppath>\\uBMplay.exe", "-P -N0 \"<filename>\"", "-P -N<measure> \"<filename>\"", "-S");
            reference = playerArguments;
            ref MainWindow.PlayerArguments reference2 = ref array[1];
            MainWindow.PlayerArguments playerArguments2 = new MainWindow.PlayerArguments("<apppath>\\o2play.exe", "-P -N0 \"<filename>\"", "-P -N<measure> \"<filename>\"", "-S");
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
            if (flag)
            {
                textBox.BackColor = Color.FromArgb(-16192);
            }
            else
            {
                textBox.BackColor = backColor;
            }
        }
    }

    public OpPlayer(int xCurrPlayer)
    {
        base.Load += OpPlayer_Load;
        CurrPlayer = -1;
        InitializeComponent();
        pArg = (MainWindow.PlayerArguments[])MyProject.Forms.MainWindow.pArgs.Clone();
        CurrPlayer = xCurrPlayer;
        ResetLPlayer_ShowInTextbox();
    }

    private void TPath_KeyDown(object sender, KeyEventArgs e)
    {
        SavePArg();
        if (object.ReferenceEquals(RuntimeHelpers.GetObjectValue(sender), TPath))
        {
            LPlayerChangeCurrIndex(pArg[CurrPlayer].Path);
        }
    }

    private void TPath_LostFocus(object sender, EventArgs e)
    {
        SavePArg();
        if (object.ReferenceEquals(RuntimeHelpers.GetObjectValue(sender), TPath))
        {
            LPlayerChangeCurrIndex(pArg[CurrPlayer].Path);
        }
        ValidateTextBox();
    }

    private string GetFileName(string s)
    {
        int num = Microsoft.VisualBasic.Strings.InStrRev(s, "/");
        int num2 = Microsoft.VisualBasic.Strings.InStrRev(s, "\\");
        return Microsoft.VisualBasic.Strings.Mid(s, Conversions.ToInteger(Operators.AddObject(Interaction.IIf(num > num2, num, num2), 1)));
    }
}
