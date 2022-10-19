using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using iBMSC.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class ColorPicker : Form
{
    private IContainer components;

    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;

    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;

    [AccessedThroughProperty("PCMain")]
    private Panel _PCMain;

    [AccessedThroughProperty("tbPrecision")]
    private TrackBar _tbPrecision;

    [AccessedThroughProperty("PCA")]
    private Panel _PCA;

    [AccessedThroughProperty("PC1")]
    private Panel _PC1;

    [AccessedThroughProperty("rbH")]
    private RadioButton _rbH;

    [AccessedThroughProperty("rbS")]
    private RadioButton _rbS;

    [AccessedThroughProperty("rbL")]
    private RadioButton _rbL;

    [AccessedThroughProperty("rbR")]
    private RadioButton _rbR;

    [AccessedThroughProperty("rbG")]
    private RadioButton _rbG;

    [AccessedThroughProperty("rbB")]
    private RadioButton _rbB;

    [AccessedThroughProperty("inH")]
    private NumericUpDown _inH;

    [AccessedThroughProperty("inS")]
    private NumericUpDown _inS;

    [AccessedThroughProperty("inL")]
    private NumericUpDown _inL;

    [AccessedThroughProperty("inR")]
    private NumericUpDown _inR;

    [AccessedThroughProperty("inG")]
    private NumericUpDown _inG;

    [AccessedThroughProperty("inB")]
    private NumericUpDown _inB;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("tStr")]
    private TextBox _tStr;

    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [AccessedThroughProperty("inA")]
    private NumericUpDown _inA;

    [AccessedThroughProperty("rbA")]
    private RadioButton _rbA;

    [AccessedThroughProperty("pPrev")]
    private Panel _pPrev;

    public Color OrigColor;

    public Color NewColor;

    private int DrawingIndex;

    private bool PassiveValueChange;

    private Point mMain;

    private int mAlpha;

    private int m1;

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

    internal virtual Panel PCMain
    {
        get
        {
            return _PCMain;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            PaintEventHandler value2 = PCMain_Paint;
            MouseEventHandler value3 = PCMain_MouseMove;
            MouseEventHandler value4 = PCMain_MouseDown;
            if (_PCMain != null)
            {
                _PCMain.Paint -= value2;
                _PCMain.MouseMove -= value3;
                _PCMain.MouseDown -= value4;
            }
            _PCMain = value;
            if (_PCMain != null)
            {
                _PCMain.Paint += value2;
                _PCMain.MouseMove += value3;
                _PCMain.MouseDown += value4;
            }
        }
    }

    internal virtual TrackBar tbPrecision
    {
        get
        {
            return _tbPrecision;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = tbPrecision_ValueChanged;
            if (_tbPrecision != null)
            {
                _tbPrecision.ValueChanged -= value2;
            }
            _tbPrecision = value;
            if (_tbPrecision != null)
            {
                _tbPrecision.ValueChanged += value2;
            }
        }
    }

    internal virtual Panel PCA
    {
        get
        {
            return _PCA;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            PaintEventHandler value2 = PCA_Paint;
            MouseEventHandler value3 = PCA_MouseMove;
            MouseEventHandler value4 = PCA_MouseDown;
            if (_PCA != null)
            {
                _PCA.Paint -= value2;
                _PCA.MouseMove -= value3;
                _PCA.MouseDown -= value4;
            }
            _PCA = value;
            if (_PCA != null)
            {
                _PCA.Paint += value2;
                _PCA.MouseMove += value3;
                _PCA.MouseDown += value4;
            }
        }
    }

    internal virtual Panel PC1
    {
        get
        {
            return _PC1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            PaintEventHandler value2 = PC1_Paint;
            MouseEventHandler value3 = PC1_MouseMove;
            MouseEventHandler value4 = PC1_MouseDown;
            if (_PC1 != null)
            {
                _PC1.Paint -= value2;
                _PC1.MouseMove -= value3;
                _PC1.MouseDown -= value4;
            }
            _PC1 = value;
            if (_PC1 != null)
            {
                _PC1.Paint += value2;
                _PC1.MouseMove += value3;
                _PC1.MouseDown += value4;
            }
        }
    }

    internal virtual RadioButton rbH
    {
        get
        {
            return _rbH;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = rbH_CheckedChanged;
            if (_rbH != null)
            {
                _rbH.CheckedChanged -= value2;
            }
            _rbH = value;
            if (_rbH != null)
            {
                _rbH.CheckedChanged += value2;
            }
        }
    }

    internal virtual RadioButton rbS
    {
        get
        {
            return _rbS;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = rbS_CheckedChanged;
            if (_rbS != null)
            {
                _rbS.CheckedChanged -= value2;
            }
            _rbS = value;
            if (_rbS != null)
            {
                _rbS.CheckedChanged += value2;
            }
        }
    }

    internal virtual RadioButton rbL
    {
        get
        {
            return _rbL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = rbL_CheckedChanged;
            if (_rbL != null)
            {
                _rbL.CheckedChanged -= value2;
            }
            _rbL = value;
            if (_rbL != null)
            {
                _rbL.CheckedChanged += value2;
            }
        }
    }

    internal virtual RadioButton rbR
    {
        get
        {
            return _rbR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = rbR_CheckedChanged;
            if (_rbR != null)
            {
                _rbR.CheckedChanged -= value2;
            }
            _rbR = value;
            if (_rbR != null)
            {
                _rbR.CheckedChanged += value2;
            }
        }
    }

    internal virtual RadioButton rbG
    {
        get
        {
            return _rbG;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = rbG_CheckedChanged;
            if (_rbG != null)
            {
                _rbG.CheckedChanged -= value2;
            }
            _rbG = value;
            if (_rbG != null)
            {
                _rbG.CheckedChanged += value2;
            }
        }
    }

    internal virtual RadioButton rbB
    {
        get
        {
            return _rbB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = rbB_CheckedChanged;
            if (_rbB != null)
            {
                _rbB.CheckedChanged -= value2;
            }
            _rbB = value;
            if (_rbB != null)
            {
                _rbB.CheckedChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown inH
    {
        get
        {
            return _inH;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inH_ValueChanged;
            if (_inH != null)
            {
                _inH.ValueChanged -= value2;
            }
            _inH = value;
            if (_inH != null)
            {
                _inH.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown inS
    {
        get
        {
            return _inS;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inS_ValueChanged;
            if (_inS != null)
            {
                _inS.ValueChanged -= value2;
            }
            _inS = value;
            if (_inS != null)
            {
                _inS.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown inL
    {
        get
        {
            return _inL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inL_ValueChanged;
            if (_inL != null)
            {
                _inL.ValueChanged -= value2;
            }
            _inL = value;
            if (_inL != null)
            {
                _inL.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown inR
    {
        get
        {
            return _inR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inR_ValueChanged;
            if (_inR != null)
            {
                _inR.ValueChanged -= value2;
            }
            _inR = value;
            if (_inR != null)
            {
                _inR.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown inG
    {
        get
        {
            return _inG;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inG_ValueChanged;
            if (_inG != null)
            {
                _inG.ValueChanged -= value2;
            }
            _inG = value;
            if (_inG != null)
            {
                _inG.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown inB
    {
        get
        {
            return _inB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inB_ValueChanged;
            if (_inB != null)
            {
                _inB.ValueChanged -= value2;
            }
            _inB = value;
            if (_inB != null)
            {
                _inB.ValueChanged += value2;
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

    internal virtual TextBox tStr
    {
        get
        {
            return _tStr;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = tStr_LostFocus;
            EventHandler value3 = tStr_GotFocus;
            EventHandler value4 = tStr_TextChanged;
            if (_tStr != null)
            {
                _tStr.LostFocus -= value2;
                _tStr.GotFocus -= value3;
                _tStr.TextChanged -= value4;
            }
            _tStr = value;
            if (_tStr != null)
            {
                _tStr.LostFocus += value2;
                _tStr.GotFocus += value3;
                _tStr.TextChanged += value4;
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

    internal virtual NumericUpDown inA
    {
        get
        {
            return _inA;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = inA_ValueChanged;
            if (_inA != null)
            {
                _inA.ValueChanged -= value2;
            }
            _inA = value;
            if (_inA != null)
            {
                _inA.ValueChanged += value2;
            }
        }
    }

    internal virtual RadioButton rbA
    {
        get
        {
            return _rbA;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _rbA = value;
        }
    }

    internal virtual Panel pPrev
    {
        get
        {
            return _pPrev;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            PaintEventHandler value2 = pPrev_Paint;
            if (_pPrev != null)
            {
                _pPrev.Paint -= value2;
            }
            _pPrev = value;
            if (_pPrev != null)
            {
                _pPrev.Paint += value2;
            }
        }
    }

    public ColorPicker()
    {
        base.Load += ColorPicker_Load;
        OrigColor = Color.Black;
        NewColor = Color.Black;
        DrawingIndex = 1;
        PassiveValueChange = false;
        ref Point reference = ref mMain;
        reference = new Point(0, 255);
        mAlpha = 255;
        m1 = 255;
        InitializeComponent();
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
        this.PCMain = new System.Windows.Forms.Panel();
        this.tbPrecision = new System.Windows.Forms.TrackBar();
        this.PCA = new System.Windows.Forms.Panel();
        this.PC1 = new System.Windows.Forms.Panel();
        this.rbH = new System.Windows.Forms.RadioButton();
        this.rbS = new System.Windows.Forms.RadioButton();
        this.rbL = new System.Windows.Forms.RadioButton();
        this.rbR = new System.Windows.Forms.RadioButton();
        this.rbG = new System.Windows.Forms.RadioButton();
        this.rbB = new System.Windows.Forms.RadioButton();
        this.inH = new System.Windows.Forms.NumericUpDown();
        this.inS = new System.Windows.Forms.NumericUpDown();
        this.inL = new System.Windows.Forms.NumericUpDown();
        this.inR = new System.Windows.Forms.NumericUpDown();
        this.inG = new System.Windows.Forms.NumericUpDown();
        this.inB = new System.Windows.Forms.NumericUpDown();
        this.Label1 = new System.Windows.Forms.Label();
        this.tStr = new System.Windows.Forms.TextBox();
        this.Label2 = new System.Windows.Forms.Label();
        this.inA = new System.Windows.Forms.NumericUpDown();
        this.rbA = new System.Windows.Forms.RadioButton();
        this.pPrev = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)this.tbPrecision).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inH).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inS).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inL).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inR).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inG).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.inA).BeginInit();
        this.SuspendLayout();
        this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
        System.Windows.Forms.Button oK_Button = this.OK_Button;
        System.Drawing.Point location = new System.Drawing.Point(315, 275);
        oK_Button.Location = location;
        this.OK_Button.Name = "OK_Button";
        System.Windows.Forms.Button oK_Button2 = this.OK_Button;
        System.Drawing.Size size = new System.Drawing.Size(126, 27);
        oK_Button2.Size = size;
        this.OK_Button.TabIndex = 21;
        this.OK_Button.Text = "OK";
        this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        System.Windows.Forms.Button cancel_Button = this.Cancel_Button;
        location = new System.Drawing.Point(315, 306);
        cancel_Button.Location = location;
        this.Cancel_Button.Name = "Cancel_Button";
        System.Windows.Forms.Button cancel_Button2 = this.Cancel_Button;
        size = new System.Drawing.Size(126, 27);
        cancel_Button2.Size = size;
        this.Cancel_Button.TabIndex = 22;
        this.Cancel_Button.Text = "Cancel";
        this.PCMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        System.Windows.Forms.Panel pCMain = this.PCMain;
        location = new System.Drawing.Point(14, 14);
        pCMain.Location = location;
        this.PCMain.Name = "PCMain";
        System.Windows.Forms.Panel pCMain2 = this.PCMain;
        size = new System.Drawing.Size(258, 258);
        pCMain2.Size = size;
        this.PCMain.TabIndex = 1;
        this.tbPrecision.LargeChange = 2;
        System.Windows.Forms.TrackBar trackBar = this.tbPrecision;
        location = new System.Drawing.Point(73, 303);
        trackBar.Location = location;
        this.tbPrecision.Minimum = 1;
        this.tbPrecision.Name = "tbPrecision";
        System.Windows.Forms.TrackBar trackBar2 = this.tbPrecision;
        size = new System.Drawing.Size(199, 45);
        trackBar2.Size = size;
        this.tbPrecision.TabIndex = 2;
        this.tbPrecision.Value = 2;
        this.PCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        System.Windows.Forms.Panel pCA = this.PCA;
        location = new System.Drawing.Point(14, 278);
        pCA.Location = location;
        this.PCA.Name = "PCA";
        System.Windows.Forms.Panel pCA2 = this.PCA;
        size = new System.Drawing.Size(258, 19);
        pCA2.Size = size;
        this.PCA.TabIndex = 3;
        this.PC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        System.Windows.Forms.Panel pC = this.PC1;
        location = new System.Drawing.Point(278, 14);
        pC.Location = location;
        this.PC1.Name = "PC1";
        System.Windows.Forms.Panel pC2 = this.PC1;
        size = new System.Drawing.Size(19, 258);
        pC2.Size = size;
        this.PC1.TabIndex = 4;
        this.rbH.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton = this.rbH;
        location = new System.Drawing.Point(315, 55);
        radioButton.Location = location;
        this.rbH.Name = "rbH";
        System.Windows.Forms.RadioButton radioButton2 = this.rbH;
        size = new System.Drawing.Size(77, 23);
        radioButton2.Size = size;
        this.rbH.TabIndex = 7;
        this.rbH.Text = "H (0-359)";
        this.rbH.UseVisualStyleBackColor = true;
        this.rbS.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbS.Checked = true;
        this.rbS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton3 = this.rbS;
        location = new System.Drawing.Point(315, 80);
        radioButton3.Location = location;
        this.rbS.Name = "rbS";
        System.Windows.Forms.RadioButton radioButton4 = this.rbS;
        size = new System.Drawing.Size(77, 23);
        radioButton4.Size = size;
        this.rbS.TabIndex = 8;
        this.rbS.TabStop = true;
        this.rbS.Text = "S (0-1000)";
        this.rbS.UseVisualStyleBackColor = true;
        this.rbL.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton5 = this.rbL;
        location = new System.Drawing.Point(315, 105);
        radioButton5.Location = location;
        this.rbL.Name = "rbL";
        System.Windows.Forms.RadioButton radioButton6 = this.rbL;
        size = new System.Drawing.Size(77, 23);
        radioButton6.Size = size;
        this.rbL.TabIndex = 9;
        this.rbL.Text = "L (0-1000)";
        this.rbL.UseVisualStyleBackColor = true;
        this.rbR.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton7 = this.rbR;
        location = new System.Drawing.Point(315, 134);
        radioButton7.Location = location;
        this.rbR.Name = "rbR";
        System.Windows.Forms.RadioButton radioButton8 = this.rbR;
        size = new System.Drawing.Size(77, 23);
        radioButton8.Size = size;
        this.rbR.TabIndex = 10;
        this.rbR.Text = "R (0-255)";
        this.rbR.UseVisualStyleBackColor = true;
        this.rbG.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton9 = this.rbG;
        location = new System.Drawing.Point(315, 159);
        radioButton9.Location = location;
        this.rbG.Name = "rbG";
        System.Windows.Forms.RadioButton radioButton10 = this.rbG;
        size = new System.Drawing.Size(77, 23);
        radioButton10.Size = size;
        this.rbG.TabIndex = 11;
        this.rbG.Text = "G (0-255)";
        this.rbG.UseVisualStyleBackColor = true;
        this.rbB.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton11 = this.rbB;
        location = new System.Drawing.Point(315, 184);
        radioButton11.Location = location;
        this.rbB.Name = "rbB";
        System.Windows.Forms.RadioButton radioButton12 = this.rbB;
        size = new System.Drawing.Size(77, 23);
        radioButton12.Size = size;
        this.rbB.TabIndex = 12;
        this.rbB.Text = "B (0-255)";
        this.rbB.UseVisualStyleBackColor = true;
        System.Windows.Forms.NumericUpDown numericUpDown = this.inH;
        location = new System.Drawing.Point(396, 55);
        numericUpDown.Location = location;
        System.Windows.Forms.NumericUpDown numericUpDown2 = this.inH;
        decimal maximum = new decimal(new int[4] { 360, 0, 0, 0 });
        numericUpDown2.Maximum = maximum;
        this.inH.Name = "inH";
        System.Windows.Forms.NumericUpDown numericUpDown3 = this.inH;
        size = new System.Drawing.Size(45, 23);
        numericUpDown3.Size = size;
        this.inH.TabIndex = 14;
        System.Windows.Forms.NumericUpDown numericUpDown4 = this.inS;
        location = new System.Drawing.Point(396, 80);
        numericUpDown4.Location = location;
        maximum = (this.inS.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
        this.inS.Name = "inS";
        System.Windows.Forms.NumericUpDown numericUpDown5 = this.inS;
        size = new System.Drawing.Size(45, 23);
        numericUpDown5.Size = size;
        this.inS.TabIndex = 15;
        System.Windows.Forms.NumericUpDown numericUpDown6 = this.inL;
        location = new System.Drawing.Point(396, 105);
        numericUpDown6.Location = location;
        maximum = (this.inL.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 }));
        this.inL.Name = "inL";
        System.Windows.Forms.NumericUpDown numericUpDown7 = this.inL;
        size = new System.Drawing.Size(45, 23);
        numericUpDown7.Size = size;
        this.inL.TabIndex = 16;
        System.Windows.Forms.NumericUpDown numericUpDown8 = this.inR;
        location = new System.Drawing.Point(396, 134);
        numericUpDown8.Location = location;
        maximum = (this.inR.Maximum = new decimal(new int[4] { 255, 0, 0, 0 }));
        this.inR.Name = "inR";
        System.Windows.Forms.NumericUpDown numericUpDown9 = this.inR;
        size = new System.Drawing.Size(45, 23);
        numericUpDown9.Size = size;
        this.inR.TabIndex = 17;
        System.Windows.Forms.NumericUpDown numericUpDown10 = this.inG;
        location = new System.Drawing.Point(396, 159);
        numericUpDown10.Location = location;
        maximum = (this.inG.Maximum = new decimal(new int[4] { 255, 0, 0, 0 }));
        this.inG.Name = "inG";
        System.Windows.Forms.NumericUpDown numericUpDown11 = this.inG;
        size = new System.Drawing.Size(45, 23);
        numericUpDown11.Size = size;
        this.inG.TabIndex = 18;
        System.Windows.Forms.NumericUpDown numericUpDown12 = this.inB;
        location = new System.Drawing.Point(396, 184);
        numericUpDown12.Location = location;
        maximum = (this.inB.Maximum = new decimal(new int[4] { 255, 0, 0, 0 }));
        this.inB.Name = "inB";
        System.Windows.Forms.NumericUpDown numericUpDown13 = this.inB;
        size = new System.Drawing.Size(45, 23);
        numericUpDown13.Size = size;
        this.inB.TabIndex = 19;
        this.Label1.AutoSize = true;
        System.Windows.Forms.Label label = this.Label1;
        location = new System.Drawing.Point(16, 305);
        label.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label2 = this.Label1;
        size = new System.Drawing.Size(58, 15);
        label2.Size = size;
        this.Label1.TabIndex = 99;
        this.Label1.Text = "Precision:";
        System.Windows.Forms.TextBox textBox = this.tStr;
        location = new System.Drawing.Point(340, 245);
        textBox.Location = location;
        this.tStr.Name = "tStr";
        System.Windows.Forms.TextBox textBox2 = this.tStr;
        size = new System.Drawing.Size(89, 23);
        textBox2.Size = size;
        this.tStr.TabIndex = 0;
        this.tStr.Text = "FF000000";
        this.Label2.AutoSize = true;
        System.Windows.Forms.Label label3 = this.Label2;
        location = new System.Drawing.Point(320, 248);
        label3.Location = location;
        this.Label2.Name = "Label2";
        System.Windows.Forms.Label label4 = this.Label2;
        size = new System.Drawing.Size(14, 15);
        label4.Size = size;
        this.Label2.TabIndex = 21;
        this.Label2.Text = "#";
        System.Windows.Forms.NumericUpDown numericUpDown14 = this.inA;
        location = new System.Drawing.Point(396, 213);
        numericUpDown14.Location = location;
        maximum = (this.inA.Maximum = new decimal(new int[4] { 255, 0, 0, 0 }));
        this.inA.Name = "inA";
        System.Windows.Forms.NumericUpDown numericUpDown15 = this.inA;
        size = new System.Drawing.Size(45, 23);
        numericUpDown15.Size = size;
        this.inA.TabIndex = 20;
        maximum = (this.inA.Value = new decimal(new int[4] { 255, 0, 0, 0 }));
        this.rbA.Appearance = System.Windows.Forms.Appearance.Button;
        this.rbA.Enabled = false;
        this.rbA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.RadioButton radioButton13 = this.rbA;
        location = new System.Drawing.Point(315, 213);
        radioButton13.Location = location;
        this.rbA.Name = "rbA";
        System.Windows.Forms.RadioButton radioButton14 = this.rbA;
        size = new System.Drawing.Size(77, 23);
        radioButton14.Size = size;
        this.rbA.TabIndex = 13;
        this.rbA.Text = "A (0-255)";
        this.rbA.UseVisualStyleBackColor = true;
        this.pPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        System.Windows.Forms.Panel panel = this.pPrev;
        location = new System.Drawing.Point(315, 14);
        panel.Location = location;
        this.pPrev.Name = "pPrev";
        System.Windows.Forms.Panel panel2 = this.pPrev;
        size = new System.Drawing.Size(125, 30);
        panel2.Size = size;
        this.pPrev.TabIndex = 25;
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
        size = new System.Drawing.Size(453, 345);
        this.ClientSize = size;
        this.Controls.Add(this.inA);
        this.Controls.Add(this.rbA);
        this.Controls.Add(this.Label2);
        this.Controls.Add(this.tStr);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.Cancel_Button);
        this.Controls.Add(this.OK_Button);
        this.Controls.Add(this.inB);
        this.Controls.Add(this.inG);
        this.Controls.Add(this.inR);
        this.Controls.Add(this.inL);
        this.Controls.Add(this.inS);
        this.Controls.Add(this.inH);
        this.Controls.Add(this.rbB);
        this.Controls.Add(this.rbG);
        this.Controls.Add(this.rbR);
        this.Controls.Add(this.rbL);
        this.Controls.Add(this.rbS);
        this.Controls.Add(this.rbH);
        this.Controls.Add(this.PC1);
        this.Controls.Add(this.PCA);
        this.Controls.Add(this.tbPrecision);
        this.Controls.Add(this.PCMain);
        this.Controls.Add(this.pPrev);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "ColorPicker";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "ColorPicker";
        ((System.ComponentModel.ISupportInitialize)this.tbPrecision).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inH).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inS).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inL).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inR).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inG).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inB).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.inA).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    public void SetOrigColor(Color xColor)
    {
        OrigColor = xColor;
        SetNewColor(xColor);
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

    private void SetNewColor(Color xColor, bool xSetText = true)
    {
        NewColor = xColor;
        RefreshPrev(pPrev.DisplayRectangle);
        if (xSetText)
        {
            tStr.Text = Microsoft.VisualBasic.Strings.Mid("0000000" + Conversion.Hex(xColor.ToArgb()), Microsoft.VisualBasic.Strings.Len(Conversion.Hex(xColor.ToArgb())));
        }
    }

    private void SetCursor()
    {
        switch (DrawingIndex)
        {
        case 0:
        {
            ref Point reference6 = ref mMain;
            reference6 = new Point(Convert.ToInt32(decimal.Multiply(decimal.Divide(inS.Value, new decimal(1000L)), new decimal(255L))), Convert.ToInt32(decimal.Multiply(decimal.Divide(decimal.Subtract(new decimal(1000L), inL.Value), new decimal(1000L)), new decimal(255L))));
            m1 = Convert.ToInt32(decimal.Divide(decimal.Multiply(decimal.Subtract(new decimal(360L), inH.Value), new decimal(255L)), new decimal(360L)));
            break;
        }
        case 1:
        {
            ref Point reference5 = ref mMain;
            reference5 = new Point(Convert.ToInt32(decimal.Divide(decimal.Multiply(inH.Value, new decimal(255L)), new decimal(360L))), Convert.ToInt32(decimal.Multiply(decimal.Divide(decimal.Subtract(new decimal(1000L), inL.Value), new decimal(1000L)), new decimal(255L))));
            m1 = Convert.ToInt32(decimal.Divide(decimal.Multiply(decimal.Subtract(new decimal(1000L), inS.Value), new decimal(255L)), new decimal(1000L)));
            break;
        }
        case 2:
        {
            ref Point reference4 = ref mMain;
            reference4 = new Point(Convert.ToInt32(decimal.Divide(decimal.Multiply(inH.Value, new decimal(255L)), new decimal(360L))), Convert.ToInt32(decimal.Divide(decimal.Multiply(decimal.Subtract(new decimal(1000L), inS.Value), new decimal(255L)), new decimal(1000L))));
            m1 = Convert.ToInt32(decimal.Divide(decimal.Multiply(decimal.Subtract(new decimal(1000L), inL.Value), new decimal(255L)), new decimal(1000L)));
            break;
        }
        case 3:
        {
            ref Point reference3 = ref mMain;
            reference3 = new Point(Convert.ToInt32(inB.Value), Convert.ToInt32(decimal.Subtract(new decimal(255L), inG.Value)));
            m1 = Convert.ToInt32(decimal.Subtract(new decimal(255L), inR.Value));
            break;
        }
        case 4:
        {
            ref Point reference2 = ref mMain;
            reference2 = new Point(Convert.ToInt32(inB.Value), Convert.ToInt32(decimal.Subtract(new decimal(255L), inR.Value)));
            m1 = Convert.ToInt32(decimal.Subtract(new decimal(255L), inG.Value));
            break;
        }
        case 5:
        {
            ref Point reference = ref mMain;
            reference = new Point(Convert.ToInt32(inG.Value), Convert.ToInt32(decimal.Subtract(new decimal(255L), inR.Value)));
            m1 = Convert.ToInt32(decimal.Subtract(new decimal(255L), inB.Value));
            break;
        }
        }
        mAlpha = Convert.ToInt32(inA.Value);
    }

    private Color HSL2RGB(int xH, int xS, int xL, int xA = 255)
    {
        if (xH > 360 || xS > 1000 || xL > 1000 || xA > 255)
        {
            return Color.Black;
        }
        double num = (double)xS / 1000.0;
        checked
        {
            double num2 = (double)(xL - 500) / 500.0;
            double num4;
            double num5;
            double num3;
            if (xH < 60)
            {
                num3 = -1.0;
                num4 = 1.0;
                num5 = (double)(xH - 30) / 30.0;
            }
            else if (xH < 120)
            {
                num3 = -1.0;
                num5 = 1.0;
                num4 = (double)(90 - xH) / 30.0;
            }
            else if (xH < 180)
            {
                num4 = -1.0;
                num5 = 1.0;
                num3 = (double)(xH - 150) / 30.0;
            }
            else if (xH < 240)
            {
                num4 = -1.0;
                num3 = 1.0;
                num5 = (double)(210 - xH) / 30.0;
            }
            else if (xH < 300)
            {
                num5 = -1.0;
                num3 = 1.0;
                num4 = (double)(xH - 270) / 30.0;
            }
            else
            {
                num5 = -1.0;
                num4 = 1.0;
                num3 = (double)(330 - xH) / 30.0;
            }
            num4 = (num4 * num * (1.0 - Math.Abs(num2)) + num2 + 1.0) * 255.0 / 2.0;
            num5 = (num5 * num * (1.0 - Math.Abs(num2)) + num2 + 1.0) * 255.0 / 2.0;
            num3 = (num3 * num * (1.0 - Math.Abs(num2)) + num2 + 1.0) * 255.0 / 2.0;
            return Color.FromArgb(xA, (int)Math.Round(num4), (int)Math.Round(num5), (int)Math.Round(num3));
        }
    }

    private void PCMain_MouseDown(object sender, MouseEventArgs e)
    {
        PCMain_MouseMove(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void PCMain_MouseMove(object sender, MouseEventArgs e)
    {
        checked
        {
            if (e.Button == MouseButtons.Left)
            {
                mMain = e.Location;
                if (mMain.X < 0)
                {
                    mMain.X = 0;
                }
                if (mMain.X > 255)
                {
                    mMain.X = 255;
                }
                if (mMain.Y < 0)
                {
                    mMain.Y = 0;
                }
                if (mMain.Y > 255)
                {
                    mMain.Y = 255;
                }
                switch (DrawingIndex)
                {
                case 0:
                    inL.Value = new decimal(1000.0 - (double)mMain.Y / 255.0 * 1000.0);
                    inS.Value = new decimal((double)mMain.X / 255.0 * 1000.0);
                    break;
                case 1:
                    inL.Value = new decimal(1000.0 - (double)mMain.Y / 255.0 * 1000.0);
                    inH.Value = new decimal((double)mMain.X / 255.0 * 360.0);
                    break;
                case 2:
                    inS.Value = new decimal(1000.0 - (double)mMain.Y / 255.0 * 1000.0);
                    inH.Value = new decimal((double)mMain.X / 255.0 * 360.0);
                    break;
                case 3:
                    inG.Value = new decimal(255 - mMain.Y);
                    inB.Value = new decimal(mMain.X);
                    break;
                case 4:
                    inR.Value = new decimal(255 - mMain.Y);
                    inB.Value = new decimal(mMain.X);
                    break;
                case 5:
                    inR.Value = new decimal(255 - mMain.Y);
                    inG.Value = new decimal(mMain.X);
                    break;
                }
            }
        }
    }

    private void PCMain_Paint(object sender, PaintEventArgs e)
    {
        RefreshMain(e.ClipRectangle);
    }

    private void RefreshMain(Rectangle xRegion)
    {
        BufferedGraphics bufferedGraphics = BufferedGraphicsManager.Current.Allocate(PCMain.CreateGraphics(), xRegion);
        int value = tbPrecision.Value;
        checked
        {
            switch (DrawingIndex)
            {
            case 0:
            {
                int xH = Convert.ToInt32(inH.Value);
                int num4 = value;
                for (int i = 0; ((num4 >> 31) ^ i) <= ((num4 >> 31) ^ 0xFF); i += num4)
                {
                    Graphics graphics4 = bufferedGraphics.Graphics;
                    Point point3 = new Point(0, 0);
                    Point point6 = point3;
                    Point point = new Point(0, 128);
                    graphics4.FillRectangle(new LinearGradientBrush(point6, point, Color.White, HSL2RGB(xH, (int)Math.Round((double)i / 255.0 * 1000.0), 500)), i, 0, value, 128);
                    Graphics graphics5 = bufferedGraphics.Graphics;
                    point = new Point(0, 128);
                    Point point7 = point;
                    point3 = new Point(0, 256);
                    graphics5.FillRectangle(new LinearGradientBrush(point7, point3, HSL2RGB(xH, (int)Math.Round((double)i / 255.0 * 1000.0), 500), Color.Black), i, 128, value, 128);
                }
                break;
            }
            case 1:
            {
                int xS = Convert.ToInt32(inS.Value);
                int num6 = value;
                for (int i = 0; ((num6 >> 31) ^ i) <= ((num6 >> 31) ^ 0xFF); i += num6)
                {
                    Graphics graphics7 = bufferedGraphics.Graphics;
                    Point point = new Point(0, 0);
                    Point point9 = point;
                    Point point3 = new Point(0, 128);
                    graphics7.FillRectangle(new LinearGradientBrush(point9, point3, Color.White, HSL2RGB((int)Math.Round((double)i / 255.0 * 360.0), xS, 500)), i, 0, value, 128);
                    Graphics graphics8 = bufferedGraphics.Graphics;
                    point = new Point(0, 128);
                    Point point10 = point;
                    point3 = new Point(0, 256);
                    graphics8.FillRectangle(new LinearGradientBrush(point10, point3, HSL2RGB((int)Math.Round((double)i / 255.0 * 360.0), xS, 500), Color.Black), i, 128, value, 128);
                }
                break;
            }
            case 2:
            {
                int xL = Convert.ToInt32(inL.Value);
                int num2 = value;
                for (int i = 0; ((num2 >> 31) ^ i) <= ((num2 >> 31) ^ 0xFF); i += num2)
                {
                    Graphics graphics2 = bufferedGraphics.Graphics;
                    Point point = new Point(0, 0);
                    Point point4 = point;
                    Point point3 = new Point(0, 256);
                    graphics2.FillRectangle(new LinearGradientBrush(point4, point3, HSL2RGB((int)Math.Round((double)i / 255.0 * 360.0), 1000, xL), HSL2RGB((int)Math.Round((double)i / 255.0 * 360.0), 0, xL)), i, 0, value, 256);
                }
                break;
            }
            case 3:
            {
                int red = Convert.ToInt32(inR.Value);
                int num5 = value;
                for (int i = 0; ((num5 >> 31) ^ i) <= ((num5 >> 31) ^ 0xFF); i += num5)
                {
                    Graphics graphics6 = bufferedGraphics.Graphics;
                    Point point = new Point(0, 0);
                    Point point8 = point;
                    Point point3 = new Point(0, 256);
                    graphics6.FillRectangle(new LinearGradientBrush(point8, point3, Color.FromArgb(red, 255, i), Color.FromArgb(red, 0, i)), i, 0, value, 256);
                }
                break;
            }
            case 4:
            {
                int green = Convert.ToInt32(inG.Value);
                int num3 = value;
                for (int i = 0; ((num3 >> 31) ^ i) <= ((num3 >> 31) ^ 0xFF); i += num3)
                {
                    Graphics graphics3 = bufferedGraphics.Graphics;
                    Point point = new Point(0, 0);
                    Point point5 = point;
                    Point point3 = new Point(0, 256);
                    graphics3.FillRectangle(new LinearGradientBrush(point5, point3, Color.FromArgb(255, green, i), Color.FromArgb(0, green, i)), i, 0, value, 256);
                }
                break;
            }
            case 5:
            {
                int blue = Convert.ToInt32(inB.Value);
                int num = value;
                for (int i = 0; ((num >> 31) ^ i) <= ((num >> 31) ^ 0xFF); i += num)
                {
                    Graphics graphics = bufferedGraphics.Graphics;
                    Point point = new Point(0, 0);
                    Point point2 = point;
                    Point point3 = new Point(0, 256);
                    graphics.FillRectangle(new LinearGradientBrush(point2, point3, Color.FromArgb(255, i, blue), Color.FromArgb(0, i, blue)), i, 0, value, 256);
                }
                break;
            }
            }
            bufferedGraphics.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            NewLateBinding.LateCall(bufferedGraphics.Graphics, null, "DrawEllipse", new object[5]
            {
                RuntimeHelpers.GetObjectValue(Interaction.IIf(decimal.Compare(inL.Value, new decimal(500L)) > 0, Pens.Black, Pens.White)),
                mMain.X - 4,
                mMain.Y - 4,
                8,
                8
            }, null, null, null, IgnoreReturn: true);
            bufferedGraphics.Render(PCMain.CreateGraphics());
            bufferedGraphics.Dispose();
        }
    }

    private void rbH_CheckedChanged(object sender, EventArgs e)
    {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
        {
            DrawingIndex = 0;
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
        }
    }

    private void rbS_CheckedChanged(object sender, EventArgs e)
    {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
        {
            DrawingIndex = 1;
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
        }
    }

    private void rbL_CheckedChanged(object sender, EventArgs e)
    {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
        {
            DrawingIndex = 2;
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
        }
    }

    private void rbR_CheckedChanged(object sender, EventArgs e)
    {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
        {
            DrawingIndex = 3;
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
        }
    }

    private void rbG_CheckedChanged(object sender, EventArgs e)
    {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
        {
            DrawingIndex = 4;
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
        }
    }

    private void rbB_CheckedChanged(object sender, EventArgs e)
    {
        if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
        {
            DrawingIndex = 5;
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
        }
    }

    private void inH_ValueChanged(object sender, EventArgs e)
    {
        if (decimal.Compare(inH.Value, new decimal(360L)) == 0)
        {
            inH.Value = 0m;
        }
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(HSL2RGB(Convert.ToInt32(inH.Value), Convert.ToInt32(inS.Value), Convert.ToInt32(inL.Value), Convert.ToInt32(inA.Value)));
            inR.Value = new decimal(NewColor.R);
            inG.Value = new decimal(NewColor.G);
            inB.Value = new decimal(NewColor.B);
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void inS_ValueChanged(object sender, EventArgs e)
    {
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(HSL2RGB(Convert.ToInt32(inH.Value), Convert.ToInt32(inS.Value), Convert.ToInt32(inL.Value), Convert.ToInt32(inA.Value)));
            inR.Value = new decimal(NewColor.R);
            inG.Value = new decimal(NewColor.G);
            inB.Value = new decimal(NewColor.B);
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void inL_ValueChanged(object sender, EventArgs e)
    {
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(HSL2RGB(Convert.ToInt32(inH.Value), Convert.ToInt32(inS.Value), Convert.ToInt32(inL.Value), Convert.ToInt32(inA.Value)));
            inR.Value = new decimal(NewColor.R);
            inG.Value = new decimal(NewColor.G);
            inB.Value = new decimal(NewColor.B);
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void inR_ValueChanged(object sender, EventArgs e)
    {
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(Color.FromArgb(Convert.ToInt32(inA.Value), Convert.ToInt32(inR.Value), Convert.ToInt32(inG.Value), Convert.ToInt32(inB.Value)));
            inH.Value = new decimal(NewColor.GetHue());
            inS.Value = new decimal(NewColor.GetSaturation() * 1000f);
            inL.Value = new decimal(NewColor.GetBrightness() * 1000f);
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void inG_ValueChanged(object sender, EventArgs e)
    {
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(Color.FromArgb(Convert.ToInt32(inA.Value), Convert.ToInt32(inR.Value), Convert.ToInt32(inG.Value), Convert.ToInt32(inB.Value)));
            inH.Value = new decimal(NewColor.GetHue());
            inS.Value = new decimal(NewColor.GetSaturation() * 1000f);
            inL.Value = new decimal(NewColor.GetBrightness() * 1000f);
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void inB_ValueChanged(object sender, EventArgs e)
    {
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(Color.FromArgb(Convert.ToInt32(inA.Value), Convert.ToInt32(inR.Value), Convert.ToInt32(inG.Value), Convert.ToInt32(inB.Value)));
            inH.Value = new decimal(NewColor.GetHue());
            inS.Value = new decimal(NewColor.GetSaturation() * 1000f);
            inL.Value = new decimal(NewColor.GetBrightness() * 1000f);
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void inA_ValueChanged(object sender, EventArgs e)
    {
        if (!PassiveValueChange)
        {
            PassiveValueChange = true;
            SetNewColor(Color.FromArgb(Convert.ToInt32(inA.Value), Convert.ToInt32(inR.Value), Convert.ToInt32(inG.Value), Convert.ToInt32(inB.Value)));
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
    }

    private void PC1_MouseDown(object sender, MouseEventArgs e)
    {
        PC1_MouseMove(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void PC1_MouseMove(object sender, MouseEventArgs e)
    {
        checked
        {
            if (e.Button == MouseButtons.Left)
            {
                m1 = e.Y;
                if (m1 < 0)
                {
                    m1 = 0;
                }
                if (m1 > 255)
                {
                    m1 = 255;
                }
                switch (DrawingIndex)
                {
                case 0:
                    inH.Value = new decimal(360.0 - (double)m1 / 255.0 * 360.0);
                    break;
                case 1:
                    inS.Value = new decimal(1000.0 - (double)m1 / 255.0 * 1000.0);
                    break;
                case 2:
                    inL.Value = new decimal(1000.0 - (double)m1 / 255.0 * 1000.0);
                    break;
                case 3:
                    inR.Value = new decimal(255 - m1);
                    break;
                case 4:
                    inG.Value = new decimal(255 - m1);
                    break;
                case 5:
                    inB.Value = new decimal(255 - m1);
                    break;
                }
            }
        }
    }

    private void PC1_Paint(object sender, PaintEventArgs e)
    {
        Refresh1(e.ClipRectangle);
    }

    private void Refresh1(Rectangle xRegion)
    {
        BufferedGraphics bufferedGraphics = BufferedGraphicsManager.Current.Allocate(PC1.CreateGraphics(), xRegion);
        int num = PC1.DisplayRectangle.Width;
        int value = tbPrecision.Value;
        checked
        {
            Point point;
            Point point3;
            switch (DrawingIndex)
            {
            case 0:
            {
                int xS2 = Convert.ToInt32(inS.Value);
                int xL2 = Convert.ToInt32(inL.Value);
                int num2 = value;
                for (int i = 0; ((num2 >> 31) ^ i) <= ((num2 >> 31) ^ 0xFF); i += num2)
                {
                    bufferedGraphics.Graphics.FillRectangle(new SolidBrush(HSL2RGB((int)Math.Round((double)(255 - i) / 255.0 * 360.0), xS2, xL2)), 0, i, num, value);
                }
                break;
            }
            case 1:
            {
                int xH2 = Convert.ToInt32(inH.Value);
                int xL = Convert.ToInt32(inL.Value);
                Graphics graphics6 = bufferedGraphics.Graphics;
                point3 = new Point(0, 0);
                Point point8 = point3;
                point = new Point(0, 256);
                graphics6.FillRectangle(new LinearGradientBrush(point8, point, HSL2RGB(xH2, 1000, xL), HSL2RGB(xH2, 0, xL)), 0, 0, num, 256);
                break;
            }
            case 2:
            {
                int xH = Convert.ToInt32(inH.Value);
                int xS = Convert.ToInt32(inS.Value);
                Graphics graphics4 = bufferedGraphics.Graphics;
                point = new Point(0, 0);
                Point point6 = point;
                point3 = new Point(0, 128);
                graphics4.FillRectangle(new LinearGradientBrush(point6, point3, HSL2RGB(xH, xS, 1000), HSL2RGB(xH, xS, 500)), 0, 0, num, 128);
                Graphics graphics5 = bufferedGraphics.Graphics;
                point = new Point(0, 128);
                Point point7 = point;
                point3 = new Point(0, 256);
                graphics5.FillRectangle(new LinearGradientBrush(point7, point3, HSL2RGB(xH, xS, 500), HSL2RGB(xH, xS, 0)), 0, 128, num, 128);
                break;
            }
            case 3:
            {
                int green2 = Convert.ToInt32(inG.Value);
                int blue2 = Convert.ToInt32(inB.Value);
                Graphics graphics3 = bufferedGraphics.Graphics;
                point = new Point(0, 0);
                Point point5 = point;
                point3 = new Point(0, 256);
                graphics3.FillRectangle(new LinearGradientBrush(point5, point3, Color.FromArgb(255, green2, blue2), Color.FromArgb(0, green2, blue2)), 0, 0, num, 256);
                break;
            }
            case 4:
            {
                int red2 = Convert.ToInt32(inR.Value);
                int blue = Convert.ToInt32(inB.Value);
                Graphics graphics2 = bufferedGraphics.Graphics;
                point = new Point(0, 0);
                Point point4 = point;
                point3 = new Point(0, 256);
                graphics2.FillRectangle(new LinearGradientBrush(point4, point3, Color.FromArgb(red2, 255, blue), Color.FromArgb(red2, 0, blue)), 0, 0, num, 256);
                break;
            }
            case 5:
            {
                int red = Convert.ToInt32(inR.Value);
                int green = Convert.ToInt32(inG.Value);
                Graphics graphics = bufferedGraphics.Graphics;
                point = new Point(0, 0);
                Point point2 = point;
                point3 = new Point(0, 256);
                graphics.FillRectangle(new LinearGradientBrush(point2, point3, Color.FromArgb(red, green, 255), Color.FromArgb(red, green, 0)), 0, 0, num, 256);
                break;
            }
            }
            Point[] array = new Point[3];
            ref Point reference = ref array[0];
            point = new Point(4, m1);
            reference = point;
            ref Point reference2 = ref array[1];
            point3 = new Point(-1, m1 - 2);
            reference2 = point3;
            ref Point reference3 = ref array[2];
            Point point9 = new Point(-1, m1 + 2);
            reference3 = point9;
            Point[] points = array;
            array = new Point[3];
            ref Point reference4 = ref array[0];
            point9 = new Point(num - 5, m1);
            reference4 = point9;
            ref Point reference5 = ref array[1];
            point = new Point(num, m1 - 2);
            reference5 = point;
            ref Point reference6 = ref array[2];
            point3 = new Point(num, m1 + 2);
            reference6 = point3;
            Point[] points2 = array;
            bufferedGraphics.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            bufferedGraphics.Graphics.FillPolygon((Brush)Interaction.IIf(decimal.Compare(inL.Value, new decimal(500L)) > 0, Brushes.Black, Brushes.White), points);
            bufferedGraphics.Graphics.FillPolygon((Brush)Interaction.IIf(decimal.Compare(inL.Value, new decimal(500L)) > 0, Brushes.Black, Brushes.White), points2);
            bufferedGraphics.Render(PC1.CreateGraphics());
            bufferedGraphics.Dispose();
        }
    }

    private void PCA_MouseDown(object sender, MouseEventArgs e)
    {
        PCA_MouseMove(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void PCA_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            mAlpha = e.X;
            if (mAlpha < 0)
            {
                mAlpha = 0;
            }
            if (mAlpha > 255)
            {
                mAlpha = 255;
            }
            inA.Value = new decimal(mAlpha);
        }
    }

    private void PCA_Paint(object sender, PaintEventArgs e)
    {
        RefreshA(e.ClipRectangle);
    }

    private void RefreshA(Rectangle xRegion)
    {
        BufferedGraphics bufferedGraphics = BufferedGraphicsManager.Current.Allocate(PCA.CreateGraphics(), xRegion);
        int num = PCA.DisplayRectangle.Height;
        int value = tbPrecision.Value;
        Color baseColor = Color.FromArgb(Convert.ToInt32(inR.Value), Convert.ToInt32(inG.Value), Convert.ToInt32(inB.Value));
        bufferedGraphics.Graphics.DrawImageUnscaledAndClipped(Resources.TransparentBG, xRegion);
        int num2 = value;
        checked
        {
            int i;
            for (i = 0; ((num2 >> 31) ^ i) <= ((num2 >> 31) ^ 0xFF); i += num2)
            {
                bufferedGraphics.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(i, baseColor)), i, 0, value, num);
            }
            Point[] array = new Point[3];
            ref Point reference = ref array[0];
            Point point = new Point(mAlpha, 4);
            reference = point;
            ref Point reference2 = ref array[1];
            Point point2 = new Point(mAlpha - 2, -1);
            reference2 = point2;
            ref Point reference3 = ref array[2];
            Point point3 = new Point(mAlpha + 2, -1);
            reference3 = point3;
            Point[] points = array;
            array = new Point[3];
            ref Point reference4 = ref array[0];
            point3 = new Point(mAlpha, num - 5);
            reference4 = point3;
            ref Point reference5 = ref array[1];
            point2 = new Point(mAlpha - 2, num);
            reference5 = point2;
            ref Point reference6 = ref array[2];
            point = new Point(mAlpha + 2, num);
            reference6 = point;
            Point[] points2 = array;
            i = Convert.ToInt32(decimal.Add(inL.Value, decimal.Divide(decimal.Multiply(decimal.Subtract(new decimal(255L), inA.Value), new decimal(1000L)), new decimal(255L))));
            bufferedGraphics.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            bufferedGraphics.Graphics.FillPolygon((Brush)Interaction.IIf(i > 500, Brushes.Black, Brushes.White), points);
            bufferedGraphics.Graphics.FillPolygon((Brush)Interaction.IIf(i > 500, Brushes.Black, Brushes.White), points2);
            bufferedGraphics.Render(PCA.CreateGraphics());
            bufferedGraphics.Dispose();
        }
    }

    private void tbPrecision_ValueChanged(object sender, EventArgs e)
    {
        RefreshMain(PCMain.DisplayRectangle);
        Refresh1(PC1.DisplayRectangle);
        RefreshA(PCA.DisplayRectangle);
    }

    private void pPrev_Paint(object sender, PaintEventArgs e)
    {
        RefreshPrev(e.ClipRectangle);
    }

    private void RefreshPrev(Rectangle xRegion)
    {
        BufferedGraphics bufferedGraphics = BufferedGraphicsManager.Current.Allocate(pPrev.CreateGraphics(), xRegion);
        Font font = pPrev.Font;
        bufferedGraphics.Graphics.DrawImageUnscaledAndClipped(Resources.TransparentBG, xRegion);
        checked
        {
            if (xRegion.X < 62)
            {
                bufferedGraphics.Graphics.FillRectangle(new SolidBrush(OrigColor), 0, 0, 61, 28);
                bufferedGraphics.Graphics.DrawLine(new Pen(Color.FromKnownColor(KnownColor.WindowFrame)), 61, 0, 61, 28);
                bufferedGraphics.Graphics.DrawString("Orig", font, (Brush)Interaction.IIf((double)OrigColor.GetBrightness() + (double)(255 - unchecked((int)OrigColor.A)) / 255.0 > 0.5, Brushes.Black, Brushes.White), 31f - bufferedGraphics.Graphics.MeasureString("Orig", font).Width / 2f, 14f - bufferedGraphics.Graphics.MeasureString("Orig", font).Height / 2f);
            }
            bufferedGraphics.Graphics.FillRectangle(new SolidBrush(NewColor), 62, 0, 61, 28);
            bufferedGraphics.Graphics.DrawString("New", font, (Brush)Interaction.IIf((double)NewColor.GetBrightness() + (double)(255 - unchecked((int)NewColor.A)) / 255.0 > 0.5, Brushes.Black, Brushes.White), 93f - bufferedGraphics.Graphics.MeasureString("New", font).Width / 2f, 14f - bufferedGraphics.Graphics.MeasureString("New", font).Height / 2f);
            bufferedGraphics.Render(pPrev.CreateGraphics());
            bufferedGraphics.Dispose();
        }
    }

    private void tStr_GotFocus(object sender, EventArgs e)
    {
        tStr.SelectAll();
    }

    private void tStr_LostFocus(object sender, EventArgs e)
    {
        try
        {
            int argb = Convert.ToInt32(tStr.Text, 16);
            SetNewColor(Color.FromArgb(argb));
            PassiveValueChange = true;
            inR.Value = new decimal(NewColor.R);
            inG.Value = new decimal(NewColor.G);
            inB.Value = new decimal(NewColor.B);
            inH.Value = new decimal(NewColor.GetHue());
            inS.Value = new decimal(NewColor.GetSaturation() * 1000f);
            inL.Value = new decimal(NewColor.GetBrightness() * 1000f);
            inA.Value = new decimal(NewColor.A);
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Exception ex2 = ex;
            Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error");
            ProjectData.ClearProjectError();
        }
        finally
        {
            tStr.Text = Microsoft.VisualBasic.Strings.Mid("0000000" + Conversion.Hex(NewColor.ToArgb()), Microsoft.VisualBasic.Strings.Len(Conversion.Hex(NewColor.ToArgb())));
        }
    }

    private void tStr_TextChanged(object sender, EventArgs e)
    {
        if (PassiveValueChange)
        {
            return;
        }
        try
        {
            int argb = Convert.ToInt32(tStr.Text, 16);
            SetNewColor(Color.FromArgb(argb), xSetText: false);
            PassiveValueChange = true;
            inR.Value = new decimal(NewColor.R);
            inG.Value = new decimal(NewColor.G);
            inB.Value = new decimal(NewColor.B);
            inH.Value = new decimal(NewColor.GetHue());
            inS.Value = new decimal(NewColor.GetSaturation() * 1000f);
            inL.Value = new decimal(NewColor.GetBrightness() * 1000f);
            inA.Value = new decimal(NewColor.A);
            SetCursor();
            RefreshMain(PCMain.DisplayRectangle);
            Refresh1(PC1.DisplayRectangle);
            RefreshA(PCA.DisplayRectangle);
            PassiveValueChange = false;
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Exception ex2 = ex;
            ProjectData.ClearProjectError();
        }
    }

    private void ColorPicker_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
    }
}
