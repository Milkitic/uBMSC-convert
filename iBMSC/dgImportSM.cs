using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class dgImportSM : Form
{
    private IContainer components;

    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;

    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;

    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;

    [AccessedThroughProperty("Label5")]
    private Label _Label5;

    [AccessedThroughProperty("LDiff")]
    private ListBox _LDiff;

    [AccessedThroughProperty("Label7")]
    private Label _Label7;

    public int iResult;

    internal virtual TableLayoutPanel TableLayoutPanel1
    {
        get
        {
            return _TableLayoutPanel1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel1 = value;
        }
    }

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

    internal virtual ListBox LDiff
    {
        get
        {
            return _LDiff;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _LDiff = value;
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
        this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.OK_Button = new System.Windows.Forms.Button();
        this.Cancel_Button = new System.Windows.Forms.Button();
        this.Label5 = new System.Windows.Forms.Label();
        this.LDiff = new System.Windows.Forms.ListBox();
        this.Label7 = new System.Windows.Forms.Label();
        this.TableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.TableLayoutPanel1.ColumnCount = 2;
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
        this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
        this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel1;
        System.Drawing.Point location = new System.Drawing.Point(52, 162);
        tableLayoutPanel.Location = location;
        this.TableLayoutPanel1.Name = "TableLayoutPanel1";
        this.TableLayoutPanel1.RowCount = 1;
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel1;
        System.Drawing.Size size = new System.Drawing.Size(146, 29);
        tableLayoutPanel2.Size = size;
        this.TableLayoutPanel1.TabIndex = 0;
        this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
        System.Windows.Forms.Button oK_Button = this.OK_Button;
        location = new System.Drawing.Point(3, 3);
        oK_Button.Location = location;
        this.OK_Button.Name = "OK_Button";
        System.Windows.Forms.Button oK_Button2 = this.OK_Button;
        size = new System.Drawing.Size(67, 23);
        oK_Button2.Size = size;
        this.OK_Button.TabIndex = 0;
        this.OK_Button.Text = "OK";
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        System.Windows.Forms.Button cancel_Button = this.Cancel_Button;
        location = new System.Drawing.Point(76, 3);
        cancel_Button.Location = location;
        this.Cancel_Button.Name = "Cancel_Button";
        System.Windows.Forms.Button cancel_Button2 = this.Cancel_Button;
        size = new System.Drawing.Size(67, 23);
        cancel_Button2.Size = size;
        this.Cancel_Button.TabIndex = 1;
        this.Cancel_Button.Text = "Cancel";
        System.Windows.Forms.Label label = this.Label5;
        location = new System.Drawing.Point(12, 96);
        label.Location = location;
        this.Label5.Name = "Label5";
        System.Windows.Forms.Label label2 = this.Label5;
        size = new System.Drawing.Size(186, 64);
        label2.Size = size;
        this.Label5.TabIndex = 26;
        this.Label5.Text = "Please note that bg musics and STOP values will not be imported.";
        this.LDiff.FormattingEnabled = true;
        this.LDiff.ItemHeight = 15;
        System.Windows.Forms.ListBox lDiff = this.LDiff;
        location = new System.Drawing.Point(15, 27);
        lDiff.Location = location;
        this.LDiff.Name = "LDiff";
        System.Windows.Forms.ListBox lDiff2 = this.LDiff;
        size = new System.Drawing.Size(183, 64);
        lDiff2.Size = size;
        this.LDiff.TabIndex = 27;
        this.Label7.AutoSize = true;
        System.Windows.Forms.Label label3 = this.Label7;
        location = new System.Drawing.Point(12, 9);
        label3.Location = location;
        this.Label7.Name = "Label7";
        System.Windows.Forms.Label label4 = this.Label7;
        size = new System.Drawing.Size(58, 15);
        label4.Size = size;
        this.Label7.TabIndex = 28;
        this.Label7.Text = "Difficulty:";
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
        size = new System.Drawing.Size(210, 203);
        this.ClientSize = size;
        this.Controls.Add(this.Label7);
        this.Controls.Add(this.LDiff);
        this.Controls.Add(this.Label5);
        this.Controls.Add(this.TableLayoutPanel1);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "dgImportSM";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Import *.SM file";
        this.TableLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    public dgImportSM(string[] sDiff)
    {
        base.Load += dgImportSM_Load;
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
