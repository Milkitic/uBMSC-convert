using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using iBMSC.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class dgStatistics : Form
{
    private IContainer components;

    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;

    [AccessedThroughProperty("lIcon")]
    private Label _lIcon;

    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;

    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    [AccessedThroughProperty("Label15")]
    private Label _Label15;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("Label7")]
    private Label _Label7;

    [AccessedThroughProperty("Label8")]
    private Label _Label8;

    [AccessedThroughProperty("Label9")]
    private Label _Label9;

    [AccessedThroughProperty("Label10")]
    private Label _Label10;

    [AccessedThroughProperty("Label11")]
    private Label _Label11;

    [AccessedThroughProperty("Label12")]
    private Label _Label12;

    [AccessedThroughProperty("Label13")]
    private Label _Label13;

    [AccessedThroughProperty("Label14")]
    private Label _Label14;

    [AccessedThroughProperty("Label2")]
    private Label _Label2;

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

    internal virtual Label lIcon
    {
        get
        {
            return _lIcon;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lIcon = value;
        }
    }

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

    internal virtual Label Label15
    {
        get
        {
            return _Label15;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label15 = value;
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

    internal virtual Label Label8
    {
        get
        {
            return _Label8;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label8 = value;
        }
    }

    internal virtual Label Label9
    {
        get
        {
            return _Label9;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label9 = value;
        }
    }

    internal virtual Label Label10
    {
        get
        {
            return _Label10;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label10 = value;
        }
    }

    internal virtual Label Label11
    {
        get
        {
            return _Label11;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label11 = value;
        }
    }

    internal virtual Label Label12
    {
        get
        {
            return _Label12;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label12 = value;
        }
    }

    internal virtual Label Label13
    {
        get
        {
            return _Label13;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label13 = value;
        }
    }

    internal virtual Label Label14
    {
        get
        {
            return _Label14;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label14 = value;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iBMSC.dgStatistics));
        this.OK_Button = new System.Windows.Forms.Button();
        this.lIcon = new System.Windows.Forms.Label();
        this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.Label2 = new System.Windows.Forms.Label();
        this.Label15 = new System.Windows.Forms.Label();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label6 = new System.Windows.Forms.Label();
        this.Label7 = new System.Windows.Forms.Label();
        this.Label8 = new System.Windows.Forms.Label();
        this.Label9 = new System.Windows.Forms.Label();
        this.Label10 = new System.Windows.Forms.Label();
        this.Label11 = new System.Windows.Forms.Label();
        this.Label12 = new System.Windows.Forms.Label();
        this.Label13 = new System.Windows.Forms.Label();
        this.Label14 = new System.Windows.Forms.Label();
        this.TableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button oK_Button = this.OK_Button;
        System.Drawing.Point location = new System.Drawing.Point(381, 188);
        oK_Button.Location = location;
        this.OK_Button.Name = "OK_Button";
        System.Windows.Forms.Button oK_Button2 = this.OK_Button;
        System.Drawing.Size size = new System.Drawing.Size(78, 27);
        oK_Button2.Size = size;
        this.OK_Button.TabIndex = 0;
        this.OK_Button.Text = "OK";
        this.lIcon.Image = iBMSC.My.Resources.Resources.Statistics3;
        System.Windows.Forms.Label label = this.lIcon;
        location = new System.Drawing.Point(12, 9);
        label.Location = location;
        this.lIcon.Name = "lIcon";
        System.Windows.Forms.Label label2 = this.lIcon;
        size = new System.Drawing.Size(42, 42);
        label2.Size = size;
        this.lIcon.TabIndex = 1;
        this.TableLayoutPanel1.ColumnCount = 7;
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.Controls.Add(this.Label2, 5, 0);
        this.TableLayoutPanel1.Controls.Add(this.Label15, 4, 0);
        this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 6);
        this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 1);
        this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 2);
        this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 3);
        this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 4);
        this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 5);
        this.TableLayoutPanel1.Controls.Add(this.Label11, 1, 0);
        this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 0);
        this.TableLayoutPanel1.Controls.Add(this.Label13, 3, 0);
        this.TableLayoutPanel1.Controls.Add(this.Label14, 4, 0);
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel1;
        location = new System.Drawing.Point(64, 12);
        tableLayoutPanel.Location = location;
        this.TableLayoutPanel1.Name = "TableLayoutPanel1";
        this.TableLayoutPanel1.RowCount = 7;
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25f));
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667f));
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel1;
        size = new System.Drawing.Size(387, 164);
        tableLayoutPanel2.Size = size;
        this.TableLayoutPanel1.TabIndex = 12;
        this.Label2.AutoSize = true;
        this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label3 = this.Label2;
        location = new System.Drawing.Point(330, 0);
        label3.Location = location;
        System.Windows.Forms.Label label4 = this.Label2;
        System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(0);
        label4.Margin = margin;
        this.Label2.Name = "Label2";
        System.Windows.Forms.Label label5 = this.Label2;
        size = new System.Drawing.Size(57, 25);
        label5.Size = size;
        this.Label2.TabIndex = 16;
        this.Label2.Text = "Total";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Label15.AutoSize = true;
        this.Label15.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label6 = this.Label15;
        location = new System.Drawing.Point(274, 0);
        label6.Location = location;
        System.Windows.Forms.Label label7 = this.Label15;
        margin = new System.Windows.Forms.Padding(0);
        label7.Margin = margin;
        this.Label15.Name = "Label15";
        System.Windows.Forms.Label label8 = this.Label15;
        size = new System.Drawing.Size(56, 25);
        label8.Size = size;
        this.Label15.TabIndex = 15;
        this.Label15.Text = "Errors";
        this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Label1.AutoSize = true;
        this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label9 = this.Label1;
        location = new System.Drawing.Point(0, 140);
        label9.Location = location;
        System.Windows.Forms.Label label10 = this.Label1;
        margin = new System.Windows.Forms.Padding(0);
        label10.Margin = margin;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label11 = this.Label1;
        margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label11.Padding = margin;
        System.Windows.Forms.Label label12 = this.Label1;
        size = new System.Drawing.Size(50, 24);
        label12.Size = size;
        this.Label1.TabIndex = 14;
        this.Label1.Text = "Total";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label6.AutoSize = true;
        this.Label6.BackColor = System.Drawing.Color.FromArgb(16, 0, 0, 0);
        this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label13 = this.Label6;
        location = new System.Drawing.Point(0, 25);
        label13.Location = location;
        System.Windows.Forms.Label label14 = this.Label6;
        margin = new System.Windows.Forms.Padding(0);
        label14.Margin = margin;
        this.Label6.Name = "Label6";
        System.Windows.Forms.Label label15 = this.Label6;
        margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label15.Padding = margin;
        System.Windows.Forms.Label label16 = this.Label6;
        size = new System.Drawing.Size(50, 23);
        label16.Size = size;
        this.Label6.TabIndex = 13;
        this.Label6.Text = "BPM";
        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label7.AutoSize = true;
        this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label17 = this.Label7;
        location = new System.Drawing.Point(0, 48);
        label17.Location = location;
        System.Windows.Forms.Label label18 = this.Label7;
        margin = new System.Windows.Forms.Padding(0);
        label18.Margin = margin;
        this.Label7.Name = "Label7";
        System.Windows.Forms.Label label19 = this.Label7;
        margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label19.Padding = margin;
        System.Windows.Forms.Label label20 = this.Label7;
        size = new System.Drawing.Size(50, 23);
        label20.Size = size;
        this.Label7.TabIndex = 13;
        this.Label7.Text = "STOP";
        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label8.AutoSize = true;
        this.Label8.BackColor = System.Drawing.Color.FromArgb(16, 0, 0, 0);
        this.Label8.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label21 = this.Label8;
        location = new System.Drawing.Point(0, 71);
        label21.Location = location;
        System.Windows.Forms.Label label22 = this.Label8;
        margin = new System.Windows.Forms.Padding(0);
        label22.Margin = margin;
        this.Label8.Name = "Label8";
        System.Windows.Forms.Label label23 = this.Label8;
        margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label23.Padding = margin;
        System.Windows.Forms.Label label24 = this.Label8;
        size = new System.Drawing.Size(50, 23);
        label24.Size = size;
        this.Label8.TabIndex = 13;
        this.Label8.Text = "A1-A8";
        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label9.AutoSize = true;
        this.Label9.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label25 = this.Label9;
        location = new System.Drawing.Point(0, 94);
        label25.Location = location;
        System.Windows.Forms.Label label26 = this.Label9;
        margin = new System.Windows.Forms.Padding(0);
        label26.Margin = margin;
        this.Label9.Name = "Label9";
        System.Windows.Forms.Label label27 = this.Label9;
        margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label27.Padding = margin;
        System.Windows.Forms.Label label28 = this.Label9;
        size = new System.Drawing.Size(50, 23);
        label28.Size = size;
        this.Label9.TabIndex = 13;
        this.Label9.Text = "D1-D8";
        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label10.AutoSize = true;
        this.Label10.BackColor = System.Drawing.Color.FromArgb(16, 0, 0, 0);
        this.Label10.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label29 = this.Label10;
        location = new System.Drawing.Point(0, 117);
        label29.Location = location;
        System.Windows.Forms.Label label30 = this.Label10;
        margin = new System.Windows.Forms.Padding(0);
        label30.Margin = margin;
        this.Label10.Name = "Label10";
        System.Windows.Forms.Label label31 = this.Label10;
        margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label31.Padding = margin;
        System.Windows.Forms.Label label32 = this.Label10;
        size = new System.Drawing.Size(50, 23);
        label32.Size = size;
        this.Label10.TabIndex = 13;
        this.Label10.Text = "BGM";
        this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.Label11.AutoSize = true;
        this.Label11.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label33 = this.Label11;
        location = new System.Drawing.Point(50, 0);
        label33.Location = location;
        System.Windows.Forms.Label label34 = this.Label11;
        margin = new System.Windows.Forms.Padding(0);
        label34.Margin = margin;
        this.Label11.Name = "Label11";
        System.Windows.Forms.Label label35 = this.Label11;
        size = new System.Drawing.Size(56, 25);
        label35.Size = size;
        this.Label11.TabIndex = 13;
        this.Label11.Text = "Short";
        this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Label12.AutoSize = true;
        this.Label12.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label36 = this.Label12;
        location = new System.Drawing.Point(106, 0);
        label36.Location = location;
        System.Windows.Forms.Label label37 = this.Label12;
        margin = new System.Windows.Forms.Padding(0);
        label37.Margin = margin;
        this.Label12.Name = "Label12";
        System.Windows.Forms.Label label38 = this.Label12;
        size = new System.Drawing.Size(56, 25);
        label38.Size = size;
        this.Label12.TabIndex = 13;
        this.Label12.Text = "Long";
        this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Label13.AutoSize = true;
        this.Label13.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label39 = this.Label13;
        location = new System.Drawing.Point(162, 0);
        label39.Location = location;
        System.Windows.Forms.Label label40 = this.Label13;
        margin = new System.Windows.Forms.Padding(0);
        label40.Margin = margin;
        this.Label13.Name = "Label13";
        System.Windows.Forms.Label label41 = this.Label13;
        size = new System.Drawing.Size(56, 25);
        label41.Size = size;
        this.Label13.TabIndex = 13;
        this.Label13.Text = "LnObj";
        this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Label14.AutoSize = true;
        this.Label14.Dock = System.Windows.Forms.DockStyle.Fill;
        System.Windows.Forms.Label label42 = this.Label14;
        location = new System.Drawing.Point(218, 0);
        label42.Location = location;
        System.Windows.Forms.Label label43 = this.Label14;
        margin = new System.Windows.Forms.Padding(0);
        label43.Margin = margin;
        this.Label14.Name = "Label14";
        System.Windows.Forms.Label label44 = this.Label14;
        size = new System.Drawing.Size(56, 25);
        label44.Size = size;
        this.Label14.TabIndex = 13;
        this.Label14.Text = "Hidden";
        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.OK_Button;
        size = new System.Drawing.Size(482, 230);
        this.ClientSize = size;
        this.Controls.Add(this.TableLayoutPanel1);
        this.Controls.Add(this.lIcon);
        this.Controls.Add(this.OK_Button);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "dgStatistics";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Statistics";
        this.TableLayoutPanel1.ResumeLayout(false);
        this.TableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void dgStatistics_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Text = Strings.fStatistics.Title;
        Label6.Text = Strings.fStatistics.lBPM;
        Label7.Text = Strings.fStatistics.lSTOP;
        Label8.Text = Strings.fStatistics.lA;
        Label9.Text = Strings.fStatistics.lD;
        Label10.Text = Strings.fStatistics.lBGM;
        Label1.Text = Strings.fStatistics.lTotal;
        Label11.Text = Strings.fStatistics.lShort;
        Label12.Text = Strings.fStatistics.lLong;
        Label13.Text = Strings.fStatistics.lLnObj;
        Label14.Text = Strings.fStatistics.lHidden;
        Label15.Text = Strings.fStatistics.lErrors;
        Label2.Text = Strings.fStatistics.lTotal;
        OK_Button.Text = Strings.OK;
    }

    public dgStatistics(int[,] data)
    {
        base.Load += dgStatistics_Load;
        InitializeComponent();
        int num = 0;
        checked
        {
            do
            {
                int num2 = 0;
                do
                {
                    Label label = new Label
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Padding margin = new Padding(0);
                    label.Margin = margin;
                    label.Font = new Font(Font, FontStyle.Bold);
                    if (data[num, num2] != 0)
                    {
                        label.Text = Conversions.ToString(data[num, num2]);
                    }
                    if (unchecked(num % 2) == 0)
                    {
                        label.BackColor = Color.FromArgb(268435456);
                    }
                    TableLayoutPanel1.Controls.Add(label, num2 + 1, num + 1);
                    num2++;
                }
                while (num2 <= 5);
                num++;
            }
            while (num <= 5);
        }
    }
}
