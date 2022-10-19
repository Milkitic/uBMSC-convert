using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using iBMSC.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace iBMSC;

[DesignerGenerated]
public class OpGeneral : Form
{
    private IContainer components;

    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;

    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;

    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;

    [AccessedThroughProperty("CWheel")]
    private ComboBox _CWheel;

    [AccessedThroughProperty("CTextEncoding")]
    private ComboBox _CTextEncoding;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [AccessedThroughProperty("Label4")]
    private Label _Label4;

    [AccessedThroughProperty("TBAssociate")]
    private Button _TBAssociate;

    [AccessedThroughProperty("cBeep")]
    private CheckBox _cBeep;

    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [AccessedThroughProperty("cBpm1296")]
    private CheckBox _cBpm1296;

    [AccessedThroughProperty("cStop1296")]
    private CheckBox _cStop1296;

    [AccessedThroughProperty("cMEnterFocus")]
    private CheckBox _cMEnterFocus;

    [AccessedThroughProperty("cMClickFocus")]
    private CheckBox _cMClickFocus;

    [AccessedThroughProperty("TBAssociatePMS")]
    private Button _TBAssociatePMS;

    [AccessedThroughProperty("TBAssociateIBMSC")]
    private Button _TBAssociateIBMSC;

    [AccessedThroughProperty("Label5")]
    private Label _Label5;

    [AccessedThroughProperty("CPgUpDn")]
    private ComboBox _CPgUpDn;

    [AccessedThroughProperty("NAutoSave")]
    private NumericUpDown _NAutoSave;

    [AccessedThroughProperty("Label7")]
    private Label _Label7;

    [AccessedThroughProperty("cAutoSave")]
    private CheckBox _cAutoSave;

    [AccessedThroughProperty("cMStopPreview")]
    private CheckBox _cMStopPreview;

    [AccessedThroughProperty("nGridPartition")]
    private NumericUpDown _nGridPartition;

    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    [AccessedThroughProperty("TBAssociateBME")]
    private Button _TBAssociateBME;

    [AccessedThroughProperty("TBAssociateBML")]
    private Button _TBAssociateBML;

    [AccessedThroughProperty("Label3")]
    private Label _Label3;

    [AccessedThroughProperty("FlowLayoutPanel1")]
    private FlowLayoutPanel _FlowLayoutPanel1;

    [AccessedThroughProperty("rMiddleAuto")]
    private RadioButton _rMiddleAuto;

    [AccessedThroughProperty("rMiddleDrag")]
    private RadioButton _rMiddleDrag;

    public int zWheel;

    public int zPgUpDn;

    public Encoding zEncoding;

    public int zMiddle;

    public int zAutoSave;

    public int zGridPartition;

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

    internal virtual ComboBox CWheel
    {
        get
        {
            return _CWheel;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _CWheel = value;
        }
    }

    internal virtual ComboBox CTextEncoding
    {
        get
        {
            return _CTextEncoding;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _CTextEncoding = value;
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

    internal virtual Button TBAssociate
    {
        get
        {
            return _TBAssociate;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBAssociate_Click;
            if (_TBAssociate != null)
            {
                _TBAssociate.Click -= value2;
            }
            _TBAssociate = value;
            if (_TBAssociate != null)
            {
                _TBAssociate.Click += value2;
            }
        }
    }

    internal virtual CheckBox cBeep
    {
        get
        {
            return _cBeep;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cBeep = value;
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

    internal virtual CheckBox cBpm1296
    {
        get
        {
            return _cBpm1296;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cBpm1296 = value;
        }
    }

    internal virtual CheckBox cStop1296
    {
        get
        {
            return _cStop1296;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cStop1296 = value;
        }
    }

    internal virtual CheckBox cMEnterFocus
    {
        get
        {
            return _cMEnterFocus;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cMEnterFocus = value;
        }
    }

    internal virtual CheckBox cMClickFocus
    {
        get
        {
            return _cMClickFocus;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cMClickFocus = value;
        }
    }

    internal virtual Button TBAssociatePMS
    {
        get
        {
            return _TBAssociatePMS;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBAssociatePMS_Click;
            if (_TBAssociatePMS != null)
            {
                _TBAssociatePMS.Click -= value2;
            }
            _TBAssociatePMS = value;
            if (_TBAssociatePMS != null)
            {
                _TBAssociatePMS.Click += value2;
            }
        }
    }

    internal virtual Button TBAssociateIBMSC
    {
        get
        {
            return _TBAssociateIBMSC;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBAssociateIBMSC_Click;
            if (_TBAssociateIBMSC != null)
            {
                _TBAssociateIBMSC.Click -= value2;
            }
            _TBAssociateIBMSC = value;
            if (_TBAssociateIBMSC != null)
            {
                _TBAssociateIBMSC.Click += value2;
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

    internal virtual ComboBox CPgUpDn
    {
        get
        {
            return _CPgUpDn;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _CPgUpDn = value;
        }
    }

    internal virtual NumericUpDown NAutoSave
    {
        get
        {
            return _NAutoSave;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _NAutoSave = value;
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

    internal virtual CheckBox cAutoSave
    {
        get
        {
            return _cAutoSave;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = cAutoSave_CheckedChanged;
            if (_cAutoSave != null)
            {
                _cAutoSave.CheckedChanged -= value2;
            }
            _cAutoSave = value;
            if (_cAutoSave != null)
            {
                _cAutoSave.CheckedChanged += value2;
            }
        }
    }

    internal virtual CheckBox cMStopPreview
    {
        get
        {
            return _cMStopPreview;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cMStopPreview = value;
        }
    }

    internal virtual NumericUpDown nGridPartition
    {
        get
        {
            return _nGridPartition;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _nGridPartition = value;
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

    internal virtual Button TBAssociateBME
    {
        get
        {
            return _TBAssociateBME;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBAssociateBME_Click;
            if (_TBAssociateBME != null)
            {
                _TBAssociateBME.Click -= value2;
            }
            _TBAssociateBME = value;
            if (_TBAssociateBME != null)
            {
                _TBAssociateBME.Click += value2;
            }
        }
    }

    internal virtual Button TBAssociateBML
    {
        get
        {
            return _TBAssociateBML;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBAssociateBML_Click;
            if (_TBAssociateBML != null)
            {
                _TBAssociateBML.Click -= value2;
            }
            _TBAssociateBML = value;
            if (_TBAssociateBML != null)
            {
                _TBAssociateBML.Click += value2;
            }
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

    internal virtual FlowLayoutPanel FlowLayoutPanel1
    {
        get
        {
            return _FlowLayoutPanel1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FlowLayoutPanel1 = value;
        }
    }

    internal virtual RadioButton rMiddleAuto
    {
        get
        {
            return _rMiddleAuto;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _rMiddleAuto = value;
        }
    }

    internal virtual RadioButton rMiddleDrag
    {
        get
        {
            return _rMiddleDrag;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _rMiddleDrag = value;
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
        this.CWheel = new System.Windows.Forms.ComboBox();
        this.CTextEncoding = new System.Windows.Forms.ComboBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label2 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.TBAssociate = new System.Windows.Forms.Button();
        this.cBeep = new System.Windows.Forms.CheckBox();
        this.PictureBox1 = new System.Windows.Forms.PictureBox();
        this.cBpm1296 = new System.Windows.Forms.CheckBox();
        this.cStop1296 = new System.Windows.Forms.CheckBox();
        this.cMEnterFocus = new System.Windows.Forms.CheckBox();
        this.cMClickFocus = new System.Windows.Forms.CheckBox();
        this.TBAssociatePMS = new System.Windows.Forms.Button();
        this.TBAssociateIBMSC = new System.Windows.Forms.Button();
        this.Label5 = new System.Windows.Forms.Label();
        this.CPgUpDn = new System.Windows.Forms.ComboBox();
        this.NAutoSave = new System.Windows.Forms.NumericUpDown();
        this.Label7 = new System.Windows.Forms.Label();
        this.cAutoSave = new System.Windows.Forms.CheckBox();
        this.cMStopPreview = new System.Windows.Forms.CheckBox();
        this.nGridPartition = new System.Windows.Forms.NumericUpDown();
        this.Label6 = new System.Windows.Forms.Label();
        this.TBAssociateBME = new System.Windows.Forms.Button();
        this.TBAssociateBML = new System.Windows.Forms.Button();
        this.Label3 = new System.Windows.Forms.Label();
        this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        this.rMiddleAuto = new System.Windows.Forms.RadioButton();
        this.rMiddleDrag = new System.Windows.Forms.RadioButton();
        this.TableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.NAutoSave).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.nGridPartition).BeginInit();
        this.FlowLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.TableLayoutPanel1.ColumnCount = 2;
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
        this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
        this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel1;
        System.Drawing.Point location = new System.Drawing.Point(229, 463);
        tableLayoutPanel.Location = location;
        this.TableLayoutPanel1.Name = "TableLayoutPanel1";
        this.TableLayoutPanel1.RowCount = 1;
        this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel1;
        System.Drawing.Size size = new System.Drawing.Size(170, 33);
        tableLayoutPanel2.Size = size;
        this.TableLayoutPanel1.TabIndex = 0;
        this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
        System.Windows.Forms.Button oK_Button = this.OK_Button;
        location = new System.Drawing.Point(3, 3);
        oK_Button.Location = location;
        this.OK_Button.Name = "OK_Button";
        System.Windows.Forms.Button oK_Button2 = this.OK_Button;
        size = new System.Drawing.Size(78, 27);
        oK_Button2.Size = size;
        this.OK_Button.TabIndex = 0;
        this.OK_Button.Text = "OK";
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        System.Windows.Forms.Button cancel_Button = this.Cancel_Button;
        location = new System.Drawing.Point(88, 3);
        cancel_Button.Location = location;
        this.Cancel_Button.Name = "Cancel_Button";
        System.Windows.Forms.Button cancel_Button2 = this.Cancel_Button;
        size = new System.Drawing.Size(78, 27);
        cancel_Button2.Size = size;
        this.Cancel_Button.TabIndex = 1;
        this.Cancel_Button.Text = "Cancel";
        this.CWheel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.CWheel.FormattingEnabled = true;
        this.CWheel.Items.AddRange(new object[4] { "1", "1 / 2", "1 / 3", "1 / 4" });
        System.Windows.Forms.ComboBox cWheel = this.CWheel;
        location = new System.Drawing.Point(154, 269);
        cWheel.Location = location;
        this.CWheel.Name = "CWheel";
        System.Windows.Forms.ComboBox cWheel2 = this.CWheel;
        size = new System.Drawing.Size(237, 23);
        cWheel2.Size = size;
        this.CWheel.TabIndex = 11;
        this.CTextEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.CTextEncoding.FormattingEnabled = true;
        this.CTextEncoding.Items.AddRange(new object[9] { "ANSI (Locale dependant)", "Little Endian UTF16", "ASCII", "Big Endian UTF16", "Little Endian UTF32", "UTF7", "UTF8", "Shift-JIS", "EUC-KR" });
        System.Windows.Forms.ComboBox cTextEncoding = this.CTextEncoding;
        location = new System.Drawing.Point(137, 18);
        cTextEncoding.Location = location;
        this.CTextEncoding.Name = "CTextEncoding";
        System.Windows.Forms.ComboBox cTextEncoding2 = this.CTextEncoding;
        size = new System.Drawing.Size(254, 23);
        cTextEncoding2.Size = size;
        this.CTextEncoding.TabIndex = 2;
        System.Windows.Forms.Label label = this.Label1;
        location = new System.Drawing.Point(12, 271);
        label.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label2 = this.Label1;
        size = new System.Drawing.Size(136, 17);
        label2.Size = size;
        this.Label1.TabIndex = 40;
        this.Label1.Text = "Mouse Wheel";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label3 = this.Label2;
        location = new System.Drawing.Point(-5, 20);
        label3.Location = location;
        this.Label2.Name = "Label2";
        System.Windows.Forms.Label label4 = this.Label2;
        size = new System.Drawing.Size(136, 17);
        label4.Size = size;
        this.Label2.TabIndex = 41;
        this.Label2.Text = "Text Encoding";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label5 = this.Label4;
        location = new System.Drawing.Point(-5, 50);
        label5.Location = location;
        this.Label4.Name = "Label4";
        System.Windows.Forms.Label label6 = this.Label4;
        size = new System.Drawing.Size(136, 17);
        label6.Size = size;
        this.Label4.TabIndex = 43;
        this.Label4.Text = "Associate Filetype";
        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Button tBAssociate = this.TBAssociate;
        location = new System.Drawing.Point(137, 47);
        tBAssociate.Location = location;
        this.TBAssociate.Name = "TBAssociate";
        System.Windows.Forms.Button tBAssociate2 = this.TBAssociate;
        size = new System.Drawing.Size(122, 23);
        tBAssociate2.Size = size;
        this.TBAssociate.TabIndex = 3;
        this.TBAssociate.Text = "*.bms";
        this.TBAssociate.UseVisualStyleBackColor = true;
        this.cBeep.AutoSize = true;
        this.cBeep.Checked = true;
        this.cBeep.CheckState = System.Windows.Forms.CheckState.Checked;
        System.Windows.Forms.CheckBox checkBox = this.cBeep;
        location = new System.Drawing.Point(32, 169);
        checkBox.Location = location;
        this.cBeep.Name = "cBeep";
        System.Windows.Forms.CheckBox checkBox2 = this.cBeep;
        size = new System.Drawing.Size(116, 19);
        checkBox2.Size = size;
        this.cBeep.TabIndex = 8;
        this.cBeep.Text = "Beep while saved";
        this.cBeep.UseVisualStyleBackColor = true;
        this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        System.Windows.Forms.PictureBox pictureBox = this.PictureBox1;
        location = new System.Drawing.Point(20, 253);
        pictureBox.Location = location;
        this.PictureBox1.Name = "PictureBox1";
        System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox1;
        size = new System.Drawing.Size(375, 1);
        pictureBox2.Size = size;
        this.PictureBox1.TabIndex = 47;
        this.PictureBox1.TabStop = false;
        this.cBpm1296.AutoSize = true;
        System.Windows.Forms.CheckBox checkBox3 = this.cBpm1296;
        location = new System.Drawing.Point(32, 194);
        checkBox3.Location = location;
        this.cBpm1296.Name = "cBpm1296";
        System.Windows.Forms.CheckBox checkBox4 = this.cBpm1296;
        size = new System.Drawing.Size(253, 19);
        checkBox4.Size = size;
        this.cBpm1296.TabIndex = 9;
        this.cBpm1296.Text = "Extend number of multi-byte BPMs to 1296";
        this.cBpm1296.UseVisualStyleBackColor = true;
        this.cStop1296.AutoSize = true;
        System.Windows.Forms.CheckBox checkBox5 = this.cStop1296;
        location = new System.Drawing.Point(32, 219);
        checkBox5.Location = location;
        this.cStop1296.Name = "cStop1296";
        System.Windows.Forms.CheckBox checkBox6 = this.cStop1296;
        size = new System.Drawing.Size(198, 19);
        checkBox6.Size = size;
        this.cStop1296.TabIndex = 10;
        this.cStop1296.Text = "Extend number of STOPs to 1296";
        this.cStop1296.UseVisualStyleBackColor = true;
        this.cMEnterFocus.AutoSize = true;
        System.Windows.Forms.CheckBox checkBox7 = this.cMEnterFocus;
        location = new System.Drawing.Point(34, 379);
        checkBox7.Location = location;
        this.cMEnterFocus.Name = "cMEnterFocus";
        System.Windows.Forms.CheckBox checkBox8 = this.cMEnterFocus;
        size = new System.Drawing.Size(322, 19);
        checkBox8.Size = size;
        this.cMEnterFocus.TabIndex = 14;
        this.cMEnterFocus.Text = "Automatically set focus to editing panel on mouse enter";
        this.cMEnterFocus.UseVisualStyleBackColor = true;
        this.cMClickFocus.AutoSize = true;
        System.Windows.Forms.CheckBox checkBox9 = this.cMClickFocus;
        location = new System.Drawing.Point(34, 404);
        checkBox9.Location = location;
        this.cMClickFocus.Name = "cMClickFocus";
        System.Windows.Forms.CheckBox checkBox10 = this.cMClickFocus;
        size = new System.Drawing.Size(293, 19);
        checkBox10.Size = size;
        this.cMClickFocus.TabIndex = 15;
        this.cMClickFocus.Text = "Disable first click if the editing panel is not focused";
        this.cMClickFocus.UseVisualStyleBackColor = true;
        System.Windows.Forms.Button tBAssociatePMS = this.TBAssociatePMS;
        location = new System.Drawing.Point(310, 78);
        tBAssociatePMS.Location = location;
        this.TBAssociatePMS.Name = "TBAssociatePMS";
        System.Windows.Forms.Button tBAssociatePMS2 = this.TBAssociatePMS;
        size = new System.Drawing.Size(81, 23);
        tBAssociatePMS2.Size = size;
        this.TBAssociatePMS.TabIndex = 4;
        this.TBAssociatePMS.Text = "*.pms";
        this.TBAssociatePMS.UseVisualStyleBackColor = true;
        System.Windows.Forms.Button tBAssociateIBMSC = this.TBAssociateIBMSC;
        location = new System.Drawing.Point(265, 47);
        tBAssociateIBMSC.Location = location;
        this.TBAssociateIBMSC.Name = "TBAssociateIBMSC";
        System.Windows.Forms.Button tBAssociateIBMSC2 = this.TBAssociateIBMSC;
        size = new System.Drawing.Size(127, 23);
        tBAssociateIBMSC2.Size = size;
        this.TBAssociateIBMSC.TabIndex = 5;
        this.TBAssociateIBMSC.Text = "*.ibmsc";
        this.TBAssociateIBMSC.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label7 = this.Label5;
        location = new System.Drawing.Point(12, 300);
        label7.Location = location;
        this.Label5.Name = "Label5";
        System.Windows.Forms.Label label8 = this.Label5;
        size = new System.Drawing.Size(136, 17);
        label8.Size = size;
        this.Label5.TabIndex = 56;
        this.Label5.Text = "PageUp / PageDown";
        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.CPgUpDn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.CPgUpDn.FormattingEnabled = true;
        this.CPgUpDn.Items.AddRange(new object[7] { "8", "6", "4", "3", "2", "1", "1 / 2" });
        System.Windows.Forms.ComboBox cPgUpDn = this.CPgUpDn;
        location = new System.Drawing.Point(154, 298);
        cPgUpDn.Location = location;
        this.CPgUpDn.Name = "CPgUpDn";
        System.Windows.Forms.ComboBox cPgUpDn2 = this.CPgUpDn;
        size = new System.Drawing.Size(237, 23);
        cPgUpDn2.Size = size;
        this.CPgUpDn.TabIndex = 12;
        this.NAutoSave.DecimalPlaces = 1;
        System.Windows.Forms.NumericUpDown nAutoSave = this.NAutoSave;
        location = new System.Drawing.Point(171, 142);
        nAutoSave.Location = location;
        System.Windows.Forms.NumericUpDown nAutoSave2 = this.NAutoSave;
        decimal maximum = new decimal(new int[4] { 60, 0, 0, 0 });
        nAutoSave2.Maximum = maximum;
        maximum = (this.NAutoSave.Minimum = new decimal(new int[4] { 1, 0, 0, 0 }));
        this.NAutoSave.Name = "NAutoSave";
        System.Windows.Forms.NumericUpDown nAutoSave3 = this.NAutoSave;
        size = new System.Drawing.Size(62, 23);
        nAutoSave3.Size = size;
        this.NAutoSave.TabIndex = 7;
        maximum = (this.NAutoSave.Value = new decimal(new int[4] { 2, 0, 0, 0 }));
        System.Windows.Forms.Label label9 = this.Label7;
        location = new System.Drawing.Point(239, 144);
        label9.Location = location;
        this.Label7.Name = "Label7";
        System.Windows.Forms.Label label10 = this.Label7;
        size = new System.Drawing.Size(73, 17);
        label10.Size = size;
        this.Label7.TabIndex = 59;
        this.Label7.Text = "minutes";
        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.cAutoSave.AutoSize = true;
        this.cAutoSave.Checked = true;
        this.cAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
        System.Windows.Forms.CheckBox checkBox11 = this.cAutoSave;
        location = new System.Drawing.Point(32, 144);
        checkBox11.Location = location;
        this.cAutoSave.Name = "cAutoSave";
        System.Windows.Forms.CheckBox checkBox12 = this.cAutoSave;
        size = new System.Drawing.Size(76, 19);
        checkBox12.Size = size;
        this.cAutoSave.TabIndex = 6;
        this.cAutoSave.Text = "AutoSave";
        this.cAutoSave.UseVisualStyleBackColor = true;
        this.cMStopPreview.AutoSize = true;
        this.cMStopPreview.Checked = true;
        this.cMStopPreview.CheckState = System.Windows.Forms.CheckState.Checked;
        System.Windows.Forms.CheckBox checkBox13 = this.cMStopPreview;
        location = new System.Drawing.Point(34, 429);
        checkBox13.Location = location;
        this.cMStopPreview.Name = "cMStopPreview";
        System.Windows.Forms.CheckBox checkBox14 = this.cMStopPreview;
        size = new System.Drawing.Size(253, 19);
        checkBox14.Size = size;
        this.cMStopPreview.TabIndex = 60;
        this.cMStopPreview.Text = "Stop preview if clicked on the editing panel";
        this.cMStopPreview.UseVisualStyleBackColor = true;
        System.Windows.Forms.NumericUpDown numericUpDown = this.nGridPartition;
        location = new System.Drawing.Point(219, 107);
        numericUpDown.Location = location;
        maximum = (this.nGridPartition.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 }));
        maximum = (this.nGridPartition.Minimum = new decimal(new int[4] { 8, 0, 0, 0 }));
        this.nGridPartition.Name = "nGridPartition";
        System.Windows.Forms.NumericUpDown numericUpDown2 = this.nGridPartition;
        size = new System.Drawing.Size(79, 23);
        numericUpDown2.Size = size;
        this.nGridPartition.TabIndex = 61;
        maximum = (this.nGridPartition.Value = new decimal(new int[4] { 192, 0, 0, 0 }));
        System.Windows.Forms.Label label11 = this.Label6;
        location = new System.Drawing.Point(44, 108);
        label11.Location = location;
        this.Label6.Name = "Label6";
        System.Windows.Forms.Label label12 = this.Label6;
        size = new System.Drawing.Size(169, 17);
        label12.Size = size;
        this.Label6.TabIndex = 62;
        this.Label6.Text = "Max Grid Partition in BMS";
        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Button tBAssociateBME = this.TBAssociateBME;
        location = new System.Drawing.Point(137, 78);
        tBAssociateBME.Location = location;
        this.TBAssociateBME.Name = "TBAssociateBME";
        System.Windows.Forms.Button tBAssociateBME2 = this.TBAssociateBME;
        size = new System.Drawing.Size(76, 23);
        tBAssociateBME2.Size = size;
        this.TBAssociateBME.TabIndex = 63;
        this.TBAssociateBME.Text = "*.bme";
        this.TBAssociateBME.UseVisualStyleBackColor = true;
        System.Windows.Forms.Button tBAssociateBML = this.TBAssociateBML;
        location = new System.Drawing.Point(219, 78);
        tBAssociateBML.Location = location;
        this.TBAssociateBML.Name = "TBAssociateBML";
        System.Windows.Forms.Button tBAssociateBML2 = this.TBAssociateBML;
        size = new System.Drawing.Size(85, 23);
        tBAssociateBML2.Size = size;
        this.TBAssociateBML.TabIndex = 64;
        this.TBAssociateBML.Text = "*.bml";
        this.TBAssociateBML.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label13 = this.Label3;
        location = new System.Drawing.Point(12, 328);
        label13.Location = location;
        this.Label3.Name = "Label3";
        System.Windows.Forms.Label label14 = this.Label3;
        size = new System.Drawing.Size(136, 17);
        label14.Size = size;
        this.Label3.TabIndex = 65;
        this.Label3.Text = "Mouse Middle Button";
        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.FlowLayoutPanel1.AutoSize = true;
        this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.FlowLayoutPanel1.Controls.Add(this.rMiddleAuto);
        this.FlowLayoutPanel1.Controls.Add(this.rMiddleDrag);
        this.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        System.Windows.Forms.FlowLayoutPanel flowLayoutPanel = this.FlowLayoutPanel1;
        location = new System.Drawing.Point(154, 327);
        flowLayoutPanel.Location = location;
        this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
        System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2 = this.FlowLayoutPanel1;
        size = new System.Drawing.Size(141, 38);
        flowLayoutPanel2.Size = size;
        this.FlowLayoutPanel1.TabIndex = 66;
        this.rMiddleAuto.AutoSize = true;
        this.rMiddleAuto.Checked = true;
        System.Windows.Forms.RadioButton radioButton = this.rMiddleAuto;
        location = new System.Drawing.Point(3, 0);
        radioButton.Location = location;
        System.Windows.Forms.RadioButton radioButton2 = this.rMiddleAuto;
        System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        radioButton2.Margin = margin;
        this.rMiddleAuto.Name = "rMiddleAuto";
        System.Windows.Forms.RadioButton radioButton3 = this.rMiddleAuto;
        size = new System.Drawing.Size(135, 19);
        radioButton3.Size = size;
        this.rMiddleAuto.TabIndex = 0;
        this.rMiddleAuto.TabStop = true;
        this.rMiddleAuto.Text = "Click and Auto Scroll";
        this.rMiddleAuto.UseVisualStyleBackColor = true;
        this.rMiddleDrag.AutoSize = true;
        System.Windows.Forms.RadioButton radioButton4 = this.rMiddleDrag;
        location = new System.Drawing.Point(3, 19);
        radioButton4.Location = location;
        System.Windows.Forms.RadioButton radioButton5 = this.rMiddleDrag;
        margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        radioButton5.Margin = margin;
        this.rMiddleDrag.Name = "rMiddleDrag";
        System.Windows.Forms.RadioButton radioButton6 = this.rMiddleDrag;
        size = new System.Drawing.Size(102, 19);
        radioButton6.Size = size;
        this.rMiddleDrag.TabIndex = 1;
        this.rMiddleDrag.TabStop = true;
        this.rMiddleDrag.Text = "Click and Drag";
        this.rMiddleDrag.UseVisualStyleBackColor = true;
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
        size = new System.Drawing.Size(413, 510);
        this.ClientSize = size;
        this.Controls.Add(this.FlowLayoutPanel1);
        this.Controls.Add(this.Label3);
        this.Controls.Add(this.TBAssociateBML);
        this.Controls.Add(this.TBAssociateBME);
        this.Controls.Add(this.Label6);
        this.Controls.Add(this.nGridPartition);
        this.Controls.Add(this.cMStopPreview);
        this.Controls.Add(this.cAutoSave);
        this.Controls.Add(this.Label7);
        this.Controls.Add(this.NAutoSave);
        this.Controls.Add(this.Label5);
        this.Controls.Add(this.CPgUpDn);
        this.Controls.Add(this.TBAssociateIBMSC);
        this.Controls.Add(this.TBAssociatePMS);
        this.Controls.Add(this.cMClickFocus);
        this.Controls.Add(this.cMEnterFocus);
        this.Controls.Add(this.cStop1296);
        this.Controls.Add(this.cBpm1296);
        this.Controls.Add(this.PictureBox1);
        this.Controls.Add(this.cBeep);
        this.Controls.Add(this.TBAssociate);
        this.Controls.Add(this.Label4);
        this.Controls.Add(this.Label2);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.CTextEncoding);
        this.Controls.Add(this.CWheel);
        this.Controls.Add(this.TableLayoutPanel1);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "OpGeneral";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "General Settings";
        this.TableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.NAutoSave).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.nGridPartition).EndInit();
        this.FlowLayoutPanel1.ResumeLayout(false);
        this.FlowLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    [DllImport("shell32.dll")]
    public static extern void SHChangeNotify(int wEventId, int uFlags, int dwItem1, int dwItem2);

    private void OK_Button_Click(object sender, EventArgs e)
    {
        switch (CWheel.SelectedIndex)
        {
            case 0:
                zWheel = 192;
                break;
            case 1:
                zWheel = 96;
                break;
            case 2:
                zWheel = 64;
                break;
            case 3:
                zWheel = 48;
                break;
        }
        switch (CPgUpDn.SelectedIndex)
        {
            case 0:
                zPgUpDn = 1536;
                break;
            case 1:
                zPgUpDn = 1152;
                break;
            case 2:
                zPgUpDn = 768;
                break;
            case 3:
                zPgUpDn = 576;
                break;
            case 4:
                zPgUpDn = 384;
                break;
            case 5:
                zPgUpDn = 192;
                break;
            case 6:
                zPgUpDn = 96;
                break;
        }
        switch (CTextEncoding.SelectedIndex)
        {
            case 0:
                zEncoding = Encoding.Default;
                break;
            case 1:
                zEncoding = Encoding.Unicode;
                break;
            case 2:
                zEncoding = Encoding.ASCII;
                break;
            case 3:
                zEncoding = Encoding.BigEndianUnicode;
                break;
            case 4:
                zEncoding = Encoding.UTF32;
                break;
            case 5:
                zEncoding = Encoding.UTF7;
                break;
            case 6:
                zEncoding = Encoding.UTF8;
                break;
            case 7:
                zEncoding = Encoding.GetEncoding(932);
                break;
            case 8:
                zEncoding = Encoding.GetEncoding(51949);
                break;
        }
        zMiddle = Conversions.ToInteger(Interaction.IIf(rMiddleDrag.Checked, 1, 0));
        zAutoSave = Conversions.ToInteger(Operators.MultiplyObject(Operators.MultiplyObject(Interaction.IIf(cAutoSave.Checked, 1, 0), NAutoSave.Value), 60000));
        zGridPartition = Convert.ToInt32(nGridPartition.Value);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    public OpGeneral(int xMsWheel, int xPgUpDn, int xMiddleButton, int xTextEncoding, int xGridPartition, int xAutoSave, bool xBeep, bool xBPMx, bool xSTOPx, bool xMFEnter, bool xMFClick, bool xMStopPreview)
    {
        int try0006_dispatch = -1;
        int num2 = default(int);
        int num = default(int);
        int num3 = default(int);
        int num5 = default(int);
        int num6 = default(int);
        while (true)
        {
            try
            {
                /*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/
                ;
                switch (try0006_dispatch)
                {
                    default:
                        base.Load += OpGeneral_Load;
                        goto IL_0019;
                    case 950:
                        {
                            num2 = num;
                            switch (num3)
                            {
                                case 1:
                                    break;
                                default:
                                    goto end_IL_0006;
                            }
                            int num4 = num2 + 1;
                            num2 = 0;
                            switch (num4)
                            {
                                case 1:
                                    break;
                                case 2:
                                    goto IL_0022;
                                case 3:
                                    goto IL_0029;
                                case 5:
                                case 6:
                                    goto IL_002e;
                                case 7:
                                    goto IL_0039;
                                case 9:
                                    goto IL_004a;
                                case 10:
                                    goto IL_0053;
                                case 12:
                                    goto IL_0065;
                                case 13:
                                    goto IL_006e;
                                case 15:
                                    goto IL_0080;
                                case 16:
                                    goto IL_0089;
                                case 4:
                                case 8:
                                case 11:
                                case 14:
                                case 17:
                                case 18:
                                    goto IL_0099;
                                case 20:
                                case 21:
                                    goto IL_009f;
                                case 22:
                                    goto IL_00ab;
                                case 24:
                                    goto IL_00c0;
                                case 25:
                                    goto IL_00cc;
                                case 27:
                                    goto IL_00e1;
                                case 28:
                                    goto IL_00ed;
                                case 30:
                                    goto IL_00ff;
                                case 31:
                                    goto IL_010b;
                                case 33:
                                    goto IL_011d;
                                case 34:
                                    goto IL_0129;
                                case 36:
                                    goto IL_013b;
                                case 37:
                                    goto IL_0147;
                                case 39:
                                    goto IL_0159;
                                case 40:
                                    goto IL_0162;
                                case 19:
                                case 23:
                                case 26:
                                case 29:
                                case 32:
                                case 35:
                                case 38:
                                case 41:
                                case 42:
                                    goto IL_0172;
                                case 43:
                                    goto IL_0183;
                                case 44:
                                    goto IL_0199;
                                case 45:
                                    goto IL_01a1;
                                case 47:
                                    goto IL_01b3;
                                case 48:
                                    goto IL_01b7;
                                case 46:
                                case 49:
                                case 50:
                                    goto IL_01c7;
                                case 51:
                                    goto IL_020c;
                                case 53:
                                    goto IL_021e;
                                case 54:
                                    goto IL_0222;
                                case 52:
                                case 55:
                                case 56:
                                    goto IL_0243;
                                case 57:
                                    goto IL_0254;
                                case 58:
                                    goto IL_0265;
                                case 59:
                                    goto IL_0276;
                                case 60:
                                    goto IL_0287;
                                case 61:
                                    goto end_IL_0006_2;
                                default:
                                    goto end_IL_0006;
                                case 62:
                                    goto end_IL_0006_3;
                            }
                            goto IL_0019;
                        }
IL_0287:
                        num = 60;
                        cMClickFocus.Checked = xMFClick;
                        break;
IL_0019:
                        num = 1;
                        InitializeComponent();
                        goto IL_0022;
IL_0022:
                        ProjectData.ClearProjectError();
                        num3 = 1;
                        goto IL_0029;
IL_0029:
                        num = 3;
                        num5 = xMsWheel;
                        goto IL_002e;
IL_002e:
                        num = 6;
                        if (num5 == 192)
                        {
                            goto IL_0039;
                        }
                        goto IL_004a;
IL_0039:
                        num = 7;
                        CWheel.SelectedIndex = 0;
                        goto IL_0099;
IL_004a:
                        num = 9;
                        if (num5 == 96)
                        {
                            goto IL_0053;
                        }
                        goto IL_0065;
IL_0053:
                        num = 10;
                        CWheel.SelectedIndex = 1;
                        goto IL_0099;
IL_0065:
                        num = 12;
                        if (num5 == 64)
                        {
                            goto IL_006e;
                        }
                        goto IL_0080;
IL_006e:
                        num = 13;
                        CWheel.SelectedIndex = 2;
                        goto IL_0099;
IL_0080:
                        num = 15;
                        if (num5 == 48)
                        {
                            goto IL_0089;
                        }
                        goto IL_0099;
IL_0089:
                        num = 16;
                        CWheel.SelectedIndex = 3;
                        goto IL_0099;
IL_0099:
                        num = 18;
                        num6 = xPgUpDn;
                        goto IL_009f;
IL_009f:
                        num = 21;
                        if (num6 == 1536)
                        {
                            goto IL_00ab;
                        }
                        goto IL_00c0;
IL_00ab:
                        num = 22;
                        CPgUpDn.SelectedIndex = 0;
                        goto IL_0172;
IL_00c0:
                        num = 24;
                        if (num6 == 1152)
                        {
                            goto IL_00cc;
                        }
                        goto IL_00e1;
IL_00cc:
                        num = 25;
                        CPgUpDn.SelectedIndex = 1;
                        goto IL_0172;
IL_00e1:
                        num = 27;
                        if (num6 == 768)
                        {
                            goto IL_00ed;
                        }
                        goto IL_00ff;
IL_00ed:
                        num = 28;
                        CPgUpDn.SelectedIndex = 2;
                        goto IL_0172;
IL_00ff:
                        num = 30;
                        if (num6 == 576)
                        {
                            goto IL_010b;
                        }
                        goto IL_011d;
IL_010b:
                        num = 31;
                        CPgUpDn.SelectedIndex = 3;
                        goto IL_0172;
IL_011d:
                        num = 33;
                        if (num6 == 384)
                        {
                            goto IL_0129;
                        }
                        goto IL_013b;
IL_0129:
                        num = 34;
                        CPgUpDn.SelectedIndex = 4;
                        goto IL_0172;
IL_013b:
                        num = 36;
                        if (num6 == 192)
                        {
                            goto IL_0147;
                        }
                        goto IL_0159;
IL_0147:
                        num = 37;
                        CPgUpDn.SelectedIndex = 5;
                        goto IL_0172;
IL_0159:
                        num = 39;
                        if (num6 == 96)
                        {
                            goto IL_0162;
                        }
                        goto IL_0172;
IL_0162:
                        num = 40;
                        CPgUpDn.SelectedIndex = 6;
                        goto IL_0172;
IL_0172:
                        num = 42;
                        CTextEncoding.SelectedIndex = xTextEncoding;
                        goto IL_0183;
IL_0183:
                        num = 43;
                        nGridPartition.Value = new decimal(xGridPartition);
                        goto IL_0199;
IL_0199:
                        num = 44;
                        if (xMiddleButton == 0)
                        {
                            goto IL_01a1;
                        }
                        goto IL_01b3;
IL_01a1:
                        num = 45;
                        rMiddleAuto.Checked = true;
                        goto IL_01c7;
IL_01b3:
                        num = 47;
                        goto IL_01b7;
IL_01b7:
                        num = 48;
                        rMiddleDrag.Checked = true;
                        goto IL_01c7;
IL_01c7:
                        num = 50;
                        if (((double)xAutoSave / 60000.0 > Convert.ToDouble(NAutoSave.Maximum)) | ((double)xAutoSave / 60000.0 < Convert.ToDouble(NAutoSave.Minimum)))
                        {
                            goto IL_020c;
                        }
                        goto IL_021e;
IL_020c:
                        num = 51;
                        cAutoSave.Checked = false;
                        goto IL_0243;
IL_021e:
                        num = 53;
                        goto IL_0222;
IL_0222:
                        num = 54;
                        NAutoSave.Value = new decimal((double)xAutoSave / 60000.0);
                        goto IL_0243;
IL_0243:
                        num = 56;
                        cBeep.Checked = xBeep;
                        goto IL_0254;
IL_0254:
                        num = 57;
                        cBpm1296.Checked = xBPMx;
                        goto IL_0265;
IL_0265:
                        num = 58;
                        cStop1296.Checked = xSTOPx;
                        goto IL_0276;
IL_0276:
                        num = 59;
                        cMEnterFocus.Checked = xMFEnter;
                        goto IL_0287;
end_IL_0006_2:
                        break;
                }
                num = 61;
                cMStopPreview.Checked = xMStopPreview;
                break;
end_IL_0006:;
            }
            catch (Exception obj) when (num3 != 0 && num2 == 0)
            {
                ProjectData.SetProjectError((Exception)obj);
                try0006_dispatch = 950;
                continue;
            }
            throw ProjectData.CreateProjectError(-2146828237);
            continue;
end_IL_0006_3:
            break;
        }
        if (num2 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void OpGeneral_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Text = Strings.fopGeneral.Title;
        Label1.Text = Strings.fopGeneral.MouseWheel;
        Label2.Text = Strings.fopGeneral.TextEncoding;
        Label5.Text = Strings.fopGeneral.PageUpDown;
        Label3.Text = Strings.fopGeneral.MiddleButton;
        Label4.Text = Strings.fopGeneral.AssociateFileType;
        rMiddleAuto.Text = Strings.fopGeneral.MiddleButtonAuto;
        rMiddleDrag.Text = Strings.fopGeneral.MiddleButtonDrag;
        Label6.Text = Strings.fopGeneral.MaxGridPartition;
        cBeep.Text = Strings.fopGeneral.BeepWhileSaved;
        cBpm1296.Text = Strings.fopGeneral.ExtendBPM;
        cStop1296.Text = Strings.fopGeneral.ExtendSTOP;
        cMEnterFocus.Text = Strings.fopGeneral.AutoFocusOnMouseEnter;
        cMClickFocus.Text = Strings.fopGeneral.DisableFirstClick;
        cAutoSave.Text = Strings.fopGeneral.AutoSave;
        Label7.Text = Strings.fopGeneral.minutes;
        cMStopPreview.Text = Strings.fopGeneral.StopPreviewOnClick;
        Encoding @default = Encoding.Default;
        CTextEncoding.Items[0] = "System ANSI (" + @default.EncodingName + ")";
        OK_Button.Text = Strings.OK;
        Cancel_Button.Text = Strings.Cancel;
    }

    private void TBAssociate_Click(object sender, EventArgs e)
    {
        Associate(".bms", "iBMSC.BMS", Strings.FileAssociation.BMS, isIBMSC: false);
    }

    private void TBAssociateIBMSC_Click(object sender, EventArgs e)
    {
        Associate(".ibmsc", "iBMSC.iBMSC", Strings.FileAssociation.IBMSC, isIBMSC: true);
    }

    private void TBAssociateBME_Click(object sender, EventArgs e)
    {
        Associate(".bme", "iBMSC.BME", Strings.FileAssociation.BME, isIBMSC: false);
    }

    private void TBAssociateBML_Click(object sender, EventArgs e)
    {
        Associate(".bml", "iBMSC.BML", Strings.FileAssociation.BML, isIBMSC: false);
    }

    private void TBAssociatePMS_Click(object sender, EventArgs e)
    {
        Associate(".pms", "iBMSC.PMS", Strings.FileAssociation.PMS, isIBMSC: false);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void Associate(string xExt, string xClass, string xDescription, bool isIBMSC)
    {
        if (Interaction.MsgBox(Microsoft.VisualBasic.Strings.Replace(Strings.Messages.FileAssociationPrompt, "{}", "*" + xExt), MsgBoxStyle.YesNo | MsgBoxStyle.Question) != MsgBoxResult.Yes)
        {
            return;
        }
        try
        {
            RegistryKey classesRoot = Registry.ClassesRoot;
            if (Array.IndexOf(classesRoot.GetSubKeyNames(), xExt) != -1)
            {
                classesRoot.DeleteSubKeyTree(xExt);
            }
            classesRoot.CreateSubKey(xExt);
            RegistryKey registryKey = classesRoot.OpenSubKey(xExt, writable: true);
            registryKey.SetValue("", xClass, RegistryValueKind.String);
            if (Array.IndexOf(classesRoot.GetSubKeyNames(), xClass) != -1)
            {
                classesRoot.DeleteSubKeyTree(xClass);
            }
            classesRoot.CreateSubKey(xClass);
            registryKey = classesRoot.OpenSubKey(xClass, writable: true);
            registryKey.SetValue("", xDescription, RegistryValueKind.String);
            registryKey.CreateSubKey("DefaultIcon");
            registryKey = classesRoot.OpenSubKey(xClass + "\\DefaultIcon", writable: true);
            registryKey.SetValue("", MyProject.Application.Info.DirectoryPath + "\\TypeBMS.ico", RegistryValueKind.String);
            registryKey = classesRoot.OpenSubKey(xClass, writable: true);
            registryKey.CreateSubKey("shell");
            registryKey = classesRoot.OpenSubKey(xClass + "\\shell", writable: true);
            registryKey.SetValue("", "open");
            registryKey = classesRoot.OpenSubKey(xClass + "\\shell", writable: true);
            registryKey.CreateSubKey("open\\command");
            registryKey = classesRoot.OpenSubKey(xClass + "\\shell\\open", writable: true);
            registryKey.SetValue("", Strings.FileAssociation.Open);
            registryKey = classesRoot.OpenSubKey(xClass + "\\shell\\open\\command", writable: true);
            registryKey.SetValue("", "\"" + Application.ExecutablePath + "\" \"%1\"");
            if (!isIBMSC)
            {
                registryKey = classesRoot.OpenSubKey(xClass + "\\shell", writable: true);
                registryKey.CreateSubKey("preview\\command");
                registryKey = classesRoot.OpenSubKey(xClass + "\\shell\\preview", writable: true);
                registryKey.SetValue("", Strings.FileAssociation.Preview);
                registryKey = classesRoot.OpenSubKey(xClass + "\\shell\\preview\\command", writable: true);
                registryKey.SetValue("", "\"" + MyProject.Application.Info.DirectoryPath + "\\uBMplay.exe\" \"%1\"");
                registryKey = classesRoot.OpenSubKey(xClass + "\\shell", writable: true);
                registryKey.CreateSubKey("viewcode\\command");
                registryKey = classesRoot.OpenSubKey(xClass + "\\shell\\viewcode", writable: true);
                registryKey.SetValue("", Strings.FileAssociation.ViewCode);
                registryKey = classesRoot.OpenSubKey(xClass + "\\shell\\viewcode\\command", writable: true);
                registryKey.SetValue("", Environment.SystemDirectory + "\\notepad.exe %1");
            }
            classesRoot = null;
            RegistryKey currentUser = Registry.CurrentUser;
            currentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + xExt);
            registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + xExt, writable: true);
            registryKey.CreateSubKey("UserChoice");
            registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + xExt + "\\UserChoice", writable: true);
            registryKey.SetValue("Progid", xClass);
            currentUser = null;
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Exception ex2 = ex;
            Interaction.MsgBox(Strings.Messages.FileAssociationError + "\r\n\r\n" + ex2.Message, MsgBoxStyle.Exclamation, Strings.Messages.Err);
            ProjectData.ClearProjectError();
        }
        SHChangeNotify(134217728, 0, 0, 0);
        Interaction.Beep();
    }

    private void cAutoSave_CheckedChanged(object sender, EventArgs e)
    {
        NAutoSave.Enabled = cAutoSave.Checked;
    }
}
