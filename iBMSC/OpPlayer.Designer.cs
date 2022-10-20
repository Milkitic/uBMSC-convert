using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace iBMSC
{
    public partial class OpPlayer : Form
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
        this.OK_Button = new System.Windows.Forms.Button();
this.OK_Button.Click += new EventHandler(OK_Button_Click);
        this.Cancel_Button = new System.Windows.Forms.Button();
this.Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
        this.Label2 = new System.Windows.Forms.Label();
        this.Label3 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.TPlayB = new System.Windows.Forms.TextBox();
this.TPlayB.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TPlayB.LostFocus += new EventHandler(TPath_LostFocus);
        this.TPlay = new System.Windows.Forms.TextBox();
this.TPlay.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TPlay.LostFocus += new EventHandler(TPath_LostFocus);
        this.TStop = new System.Windows.Forms.TextBox();
this.TStop.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TStop.LostFocus += new EventHandler(TPath_LostFocus);
        this.Label6 = new System.Windows.Forms.Label();
        this.TPath = new System.Windows.Forms.TextBox();
this.TPath.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TPath.LostFocus += new EventHandler(TPath_LostFocus);
        this.Label1 = new System.Windows.Forms.Label();
        this.BBrowse = new System.Windows.Forms.Button();
this.BBrowse.Click += new EventHandler(BPrevBrowse_Click);
        this.BDefault = new System.Windows.Forms.Button();
this.BDefault.Click += new EventHandler(BPrevDefault_Click);
        this.BRemove = new System.Windows.Forms.Button();
this.BRemove.Click += new EventHandler(BPrevDelete_Click);
        this.BAdd = new System.Windows.Forms.Button();
this.BAdd.Click += new EventHandler(BPrevAdd_Click);
        this.LPlayer = new System.Windows.Forms.ListBox();
this.LPlayer.KeyDown += new KeyEventHandler(LPlayer_KeyDown);
this.LPlayer.Click += new EventHandler(LPlayer_Click);
        this.PictureBox1 = new System.Windows.Forms.PictureBox();
        this.Label5 = new System.Windows.Forms.Label();
        this.Label7 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
        this.SuspendLayout();
        this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
this.OK_Button.Click += new EventHandler(OK_Button_Click);
        this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
this.OK_Button.Location = new System.Drawing.Point(72, 316);
        this.OK_Button.Name = "OK_Button";
this.OK_Button.Size = new System.Drawing.Size(78, 23);
        this.OK_Button.TabIndex = 0;
        this.OK_Button.Text = "OK";
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
this.Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
this.Cancel_Button.Location = new System.Drawing.Point(156, 316);
        this.Cancel_Button.Name = "Cancel_Button";
this.Cancel_Button.Size = new System.Drawing.Size(78, 23);
        this.Cancel_Button.TabIndex = 1;
        this.Cancel_Button.Text = "Cancel";
this.Label2.Location = new System.Drawing.Point(14, 153);
        this.Label2.Name = "Label2";
this.Label2.Size = new System.Drawing.Size(157, 15);
        this.Label2.TabIndex = 3;
        this.Label2.Text = "Play from beginning";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
this.Label3.Location = new System.Drawing.Point(14, 182);
        this.Label3.Name = "Label3";
this.Label3.Size = new System.Drawing.Size(157, 15);
        this.Label3.TabIndex = 4;
        this.Label3.Text = "Play from current measure";
        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
this.Label4.Location = new System.Drawing.Point(14, 211);
        this.Label4.Name = "Label4";
this.Label4.Size = new System.Drawing.Size(157, 15);
        this.Label4.TabIndex = 5;
        this.Label4.Text = "Stop";
        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
this.TPlayB.Location = new System.Drawing.Point(177, 150);
        this.TPlayB.Name = "TPlayB";
this.TPlayB.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TPlayB.LostFocus += new EventHandler(TPath_LostFocus);
this.TPlayB.Size = new System.Drawing.Size(192, 23);
        this.TPlayB.TabIndex = 4;
this.TPlay.Location = new System.Drawing.Point(177, 179);
        this.TPlay.Name = "TPlay";
this.TPlay.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TPlay.LostFocus += new EventHandler(TPath_LostFocus);
this.TPlay.Size = new System.Drawing.Size(192, 23);
        this.TPlay.TabIndex = 5;
this.TStop.Location = new System.Drawing.Point(177, 208);
        this.TStop.Name = "TStop";
this.TStop.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TStop.LostFocus += new EventHandler(TPath_LostFocus);
this.TStop.Size = new System.Drawing.Size(192, 23);
        this.TStop.TabIndex = 6;
        this.Label6.AutoSize = true;
this.Label6.Location = new System.Drawing.Point(14, 244);
        this.Label6.Name = "Label6";
this.Label6.Size = new System.Drawing.Size(225, 60);
        this.Label6.TabIndex = 11;
        this.Label6.Text = "References (case-sensitive):\r\n<apppath> = Directory of the application\r\n<measure> = Current measure\r\n<filename> = File Name";
this.TPath.Location = new System.Drawing.Point(51, 98);
        this.TPath.Name = "TPath";
this.TPath.KeyUp += new KeyEventHandler(TPath_KeyDown);
this.TPath.LostFocus += new EventHandler(TPath_LostFocus);
this.TPath.Size = new System.Drawing.Size(288, 23);
        this.TPath.TabIndex = 2;
this.Label1.Location = new System.Drawing.Point(0, 101);
        this.Label1.Name = "Label1";
this.Label1.Size = new System.Drawing.Size(45, 15);
        this.Label1.TabIndex = 12;
        this.Label1.Text = "Path";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.BBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
this.BBrowse.Click += new EventHandler(BPrevBrowse_Click);
this.BBrowse.Location = new System.Drawing.Point(345, 98);
        this.BBrowse.Name = "BBrowse";
this.BBrowse.Size = new System.Drawing.Size(24, 23);
        this.BBrowse.TabIndex = 3;
        this.BBrowse.Text = "...";
        this.BBrowse.UseVisualStyleBackColor = true;
        this.BDefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
this.BDefault.Click += new EventHandler(BPrevDefault_Click);
        this.BDefault.FlatStyle = System.Windows.Forms.FlatStyle.System;
this.BDefault.Location = new System.Drawing.Point(240, 316);
        this.BDefault.Name = "BDefault";
this.BDefault.Size = new System.Drawing.Size(130, 23);
        this.BDefault.TabIndex = 62;
        this.BDefault.Text = "Restore default";
        this.BDefault.UseVisualStyleBackColor = true;
        this.BRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
this.BRemove.Click += new EventHandler(BPrevDelete_Click);
this.BRemove.Location = new System.Drawing.Point(243, 41);
        this.BRemove.Name = "BRemove";
this.BRemove.Size = new System.Drawing.Size(117, 23);
        this.BRemove.TabIndex = 59;
        this.BRemove.Text = "Remove";
        this.BRemove.UseVisualStyleBackColor = true;
        this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
this.BAdd.Click += new EventHandler(BPrevAdd_Click);
this.BAdd.Location = new System.Drawing.Point(243, 12);
        this.BAdd.Name = "BAdd";
this.BAdd.Size = new System.Drawing.Size(117, 23);
        this.BAdd.TabIndex = 58;
        this.BAdd.Text = "Add";
        this.BAdd.UseVisualStyleBackColor = true;
        this.LPlayer.FormattingEnabled = true;
this.LPlayer.KeyDown += new KeyEventHandler(LPlayer_KeyDown);
this.LPlayer.Click += new EventHandler(LPlayer_Click);
        this.LPlayer.IntegralHeight = false;
        this.LPlayer.ItemHeight = 15;
        this.LPlayer.Items.AddRange(new object[2] { "uBMplay.exe", "o2play.exe" });
this.LPlayer.Location = new System.Drawing.Point(12, 27);
        this.LPlayer.Name = "LPlayer";
this.LPlayer.Size = new System.Drawing.Size(225, 55);
        this.LPlayer.TabIndex = 63;
        this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
this.PictureBox1.Location = new System.Drawing.Point(12, 134);
        this.PictureBox1.Name = "PictureBox1";
this.PictureBox1.Size = new System.Drawing.Size(357, 1);
        this.PictureBox1.TabIndex = 64;
        this.PictureBox1.TabStop = false;
        this.Label5.AutoSize = true;
this.Label5.Location = new System.Drawing.Point(12, 9);
        this.Label5.Name = "Label5";
this.Label5.Size = new System.Drawing.Size(85, 15);
        this.Label5.TabIndex = 65;
        this.Label5.Text = "Current Player:";
        this.Label7.AutoSize = true;
this.Label7.Location = new System.Drawing.Point(12, 126);
        this.Label7.Name = "Label7";
this.Label7.Size = new System.Drawing.Size(66, 15);
        this.Label7.TabIndex = 66;
        this.Label7.Text = "Arguments";
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
this.ClientSize=new System.Drawing.Size(382, 351);
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

internal Button OK_Button;
internal Button Cancel_Button;
internal Label Label2;
internal Label Label3;
internal Label Label4;
internal TextBox TPlayB;
internal TextBox TPlay;
internal TextBox TStop;
internal Label Label6;
internal TextBox TPath;
internal Label Label1;
internal Button BBrowse;
internal Button BDefault;
internal Button BRemove;
internal Button BAdd;
internal ListBox LPlayer;
internal PictureBox PictureBox1;
internal Label Label5;
internal Label Label7;
    }
}
