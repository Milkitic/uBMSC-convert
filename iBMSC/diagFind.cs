using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class diagFind : Form
{
    private IContainer components;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [AccessedThroughProperty("mr1")]
    private NumericUpDown _mr1;

    [AccessedThroughProperty("mr2")]
    private NumericUpDown _mr2;

    [AccessedThroughProperty("lr1")]
    private TextBox _lr1;

    [AccessedThroughProperty("lr2")]
    private TextBox _lr2;

    [AccessedThroughProperty("vr2")]
    private NumericUpDown _vr2;

    [AccessedThroughProperty("vr1")]
    private NumericUpDown _vr1;

    [AccessedThroughProperty("cb1")]
    private CheckBox _cb1;

    [AccessedThroughProperty("cb2")]
    private CheckBox _cb2;

    [AccessedThroughProperty("cba1")]
    private CheckBox _cba1;

    [AccessedThroughProperty("cba2")]
    private CheckBox _cba2;

    [AccessedThroughProperty("cba3")]
    private CheckBox _cba3;

    [AccessedThroughProperty("cba4")]
    private CheckBox _cba4;

    [AccessedThroughProperty("cba5")]
    private CheckBox _cba5;

    [AccessedThroughProperty("cba6")]
    private CheckBox _cba6;

    [AccessedThroughProperty("cba7")]
    private CheckBox _cba7;

    [AccessedThroughProperty("cba8")]
    private CheckBox _cba8;

    [AccessedThroughProperty("cbd1")]
    private CheckBox _cbd1;

    [AccessedThroughProperty("cbd2")]
    private CheckBox _cbd2;

    [AccessedThroughProperty("cbd3")]
    private CheckBox _cbd3;

    [AccessedThroughProperty("cbd4")]
    private CheckBox _cbd4;

    [AccessedThroughProperty("cbd5")]
    private CheckBox _cbd5;

    [AccessedThroughProperty("cbd6")]
    private CheckBox _cbd6;

    [AccessedThroughProperty("cbd7")]
    private CheckBox _cbd7;

    [AccessedThroughProperty("cbd8")]
    private CheckBox _cbd8;

    [AccessedThroughProperty("cb3")]
    private CheckBox _cb3;

    [AccessedThroughProperty("cb4")]
    private CheckBox _cb4;

    [AccessedThroughProperty("cb5")]
    private CheckBox _cb5;

    [AccessedThroughProperty("cbb1")]
    private CheckBox _cbb1;

    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;

    [AccessedThroughProperty("BSAll")]
    private Button _BSAll;

    [AccessedThroughProperty("BSInv")]
    private Button _BSInv;

    [AccessedThroughProperty("BSNone")]
    private Button _BSNone;

    [AccessedThroughProperty("Label3")]
    private Label _Label3;

    [AccessedThroughProperty("Label4")]
    private Label _Label4;

    [AccessedThroughProperty("TBSelect")]
    private Button _TBSelect;

    [AccessedThroughProperty("TBClose")]
    private Button _TBClose;

    [AccessedThroughProperty("TBDelete")]
    private Button _TBDelete;

    [AccessedThroughProperty("TBrl")]
    private Button _TBrl;

    [AccessedThroughProperty("TBrv")]
    private Button _TBrv;

    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;

    [AccessedThroughProperty("Label5")]
    private Label _Label5;

    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    [AccessedThroughProperty("Label7")]
    private Label _Label7;

    [AccessedThroughProperty("Ttv")]
    private NumericUpDown _Ttv;

    [AccessedThroughProperty("Ttl")]
    private TextBox _Ttl;

    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;

    [AccessedThroughProperty("Label8")]
    private Label _Label8;

    [AccessedThroughProperty("Label9")]
    private Label _Label9;

    [AccessedThroughProperty("cbx1")]
    private CheckBox _cbx1;

    [AccessedThroughProperty("cbx2")]
    private CheckBox _cbx2;

    [AccessedThroughProperty("cbx3")]
    private CheckBox _cbx3;

    [AccessedThroughProperty("TBUnselect")]
    private Button _TBUnselect;

    [AccessedThroughProperty("cbx4")]
    private CheckBox _cbx4;

    [AccessedThroughProperty("cbx5")]
    private CheckBox _cbx5;

    [AccessedThroughProperty("cbx6")]
    private CheckBox _cbx6;

    private int bCol;

    private string msg1;

    private string msg2;

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

    internal virtual NumericUpDown mr1
    {
        get
        {
            return _mr1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mr1 = value;
        }
    }

    internal virtual NumericUpDown mr2
    {
        get
        {
            return _mr2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mr2 = value;
        }
    }

    internal virtual TextBox lr1
    {
        get
        {
            return _lr1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lr1 = value;
        }
    }

    internal virtual TextBox lr2
    {
        get
        {
            return _lr2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _lr2 = value;
        }
    }

    internal virtual NumericUpDown vr2
    {
        get
        {
            return _vr2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _vr2 = value;
        }
    }

    internal virtual NumericUpDown vr1
    {
        get
        {
            return _vr1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _vr1 = value;
        }
    }

    internal virtual CheckBox cb1
    {
        get
        {
            return _cb1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cb1 = value;
        }
    }

    internal virtual CheckBox cb2
    {
        get
        {
            return _cb2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cb2 = value;
        }
    }

    internal virtual CheckBox cba1
    {
        get
        {
            return _cba1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba1 = value;
        }
    }

    internal virtual CheckBox cba2
    {
        get
        {
            return _cba2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba2 = value;
        }
    }

    internal virtual CheckBox cba3
    {
        get
        {
            return _cba3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba3 = value;
        }
    }

    internal virtual CheckBox cba4
    {
        get
        {
            return _cba4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba4 = value;
        }
    }

    internal virtual CheckBox cba5
    {
        get
        {
            return _cba5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba5 = value;
        }
    }

    internal virtual CheckBox cba6
    {
        get
        {
            return _cba6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba6 = value;
        }
    }

    internal virtual CheckBox cba7
    {
        get
        {
            return _cba7;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba7 = value;
        }
    }

    internal virtual CheckBox cba8
    {
        get
        {
            return _cba8;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cba8 = value;
        }
    }

    internal virtual CheckBox cbd1
    {
        get
        {
            return _cbd1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd1 = value;
        }
    }

    internal virtual CheckBox cbd2
    {
        get
        {
            return _cbd2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd2 = value;
        }
    }

    internal virtual CheckBox cbd3
    {
        get
        {
            return _cbd3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd3 = value;
        }
    }

    internal virtual CheckBox cbd4
    {
        get
        {
            return _cbd4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd4 = value;
        }
    }

    internal virtual CheckBox cbd5
    {
        get
        {
            return _cbd5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd5 = value;
        }
    }

    internal virtual CheckBox cbd6
    {
        get
        {
            return _cbd6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd6 = value;
        }
    }

    internal virtual CheckBox cbd7
    {
        get
        {
            return _cbd7;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd7 = value;
        }
    }

    internal virtual CheckBox cbd8
    {
        get
        {
            return _cbd8;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbd8 = value;
        }
    }

    internal virtual CheckBox cb3
    {
        get
        {
            return _cb3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cb3 = value;
        }
    }

    internal virtual CheckBox cb4
    {
        get
        {
            return _cb4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cb4 = value;
        }
    }

    internal virtual CheckBox cb5
    {
        get
        {
            return _cb5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cb5 = value;
        }
    }

    internal virtual CheckBox cbb1
    {
        get
        {
            return _cbb1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbb1 = value;
        }
    }

    internal virtual Panel Panel1
    {
        get
        {
            return _Panel1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Panel1 = value;
        }
    }

    internal virtual Button BSAll
    {
        get
        {
            return _BSAll;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BSAll_Click;
            if (_BSAll != null)
            {
                _BSAll.Click -= value2;
            }
            _BSAll = value;
            if (_BSAll != null)
            {
                _BSAll.Click += value2;
            }
        }
    }

    internal virtual Button BSInv
    {
        get
        {
            return _BSInv;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BSInv_Click;
            if (_BSInv != null)
            {
                _BSInv.Click -= value2;
            }
            _BSInv = value;
            if (_BSInv != null)
            {
                _BSInv.Click += value2;
            }
        }
    }

    internal virtual Button BSNone
    {
        get
        {
            return _BSNone;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BSNone_Click;
            if (_BSNone != null)
            {
                _BSNone.Click -= value2;
            }
            _BSNone = value;
            if (_BSNone != null)
            {
                _BSNone.Click += value2;
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

    internal virtual Button TBSelect
    {
        get
        {
            return _TBSelect;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBSelect_Click;
            if (_TBSelect != null)
            {
                _TBSelect.Click -= value2;
            }
            _TBSelect = value;
            if (_TBSelect != null)
            {
                _TBSelect.Click += value2;
            }
        }
    }

    internal virtual Button TBClose
    {
        get
        {
            return _TBClose;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CloseDialog;
            if (_TBClose != null)
            {
                _TBClose.Click -= value2;
            }
            _TBClose = value;
            if (_TBClose != null)
            {
                _TBClose.Click += value2;
            }
        }
    }

    internal virtual Button TBDelete
    {
        get
        {
            return _TBDelete;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBDelete_Click;
            if (_TBDelete != null)
            {
                _TBDelete.Click -= value2;
            }
            _TBDelete = value;
            if (_TBDelete != null)
            {
                _TBDelete.Click += value2;
            }
        }
    }

    internal virtual Button TBrl
    {
        get
        {
            return _TBrl;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBrl_Click;
            if (_TBrl != null)
            {
                _TBrl.Click -= value2;
            }
            _TBrl = value;
            if (_TBrl != null)
            {
                _TBrl.Click += value2;
            }
        }
    }

    internal virtual Button TBrv
    {
        get
        {
            return _TBrv;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBrv_Click;
            if (_TBrv != null)
            {
                _TBrv.Click -= value2;
            }
            _TBrv = value;
            if (_TBrv != null)
            {
                _TBrv.Click += value2;
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

    internal virtual PictureBox PictureBox2
    {
        get
        {
            return _PictureBox2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox2 = value;
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

    internal virtual NumericUpDown Ttv
    {
        get
        {
            return _Ttv;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Ttv = value;
        }
    }

    internal virtual TextBox Ttl
    {
        get
        {
            return _Ttl;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Ttl = value;
        }
    }

    internal virtual PictureBox PictureBox3
    {
        get
        {
            return _PictureBox3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox3 = value;
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

    internal virtual CheckBox cbx1
    {
        get
        {
            return _cbx1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbx1 = value;
        }
    }

    internal virtual CheckBox cbx2
    {
        get
        {
            return _cbx2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbx2 = value;
        }
    }

    internal virtual CheckBox cbx3
    {
        get
        {
            return _cbx3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbx3 = value;
        }
    }

    internal virtual Button TBUnselect
    {
        get
        {
            return _TBUnselect;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBUnselect_Click;
            if (_TBUnselect != null)
            {
                _TBUnselect.Click -= value2;
            }
            _TBUnselect = value;
            if (_TBUnselect != null)
            {
                _TBUnselect.Click += value2;
            }
        }
    }

    internal virtual CheckBox cbx4
    {
        get
        {
            return _cbx4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbx4 = value;
        }
    }

    internal virtual CheckBox cbx5
    {
        get
        {
            return _cbx5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbx5 = value;
        }
    }

    internal virtual CheckBox cbx6
    {
        get
        {
            return _cbx6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cbx6 = value;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iBMSC.diagFind));
        this.Label1 = new System.Windows.Forms.Label();
        this.Label2 = new System.Windows.Forms.Label();
        this.mr1 = new System.Windows.Forms.NumericUpDown();
        this.mr2 = new System.Windows.Forms.NumericUpDown();
        this.lr1 = new System.Windows.Forms.TextBox();
        this.lr2 = new System.Windows.Forms.TextBox();
        this.vr2 = new System.Windows.Forms.NumericUpDown();
        this.vr1 = new System.Windows.Forms.NumericUpDown();
        this.cb1 = new System.Windows.Forms.CheckBox();
        this.cb2 = new System.Windows.Forms.CheckBox();
        this.cba1 = new System.Windows.Forms.CheckBox();
        this.cba2 = new System.Windows.Forms.CheckBox();
        this.cba3 = new System.Windows.Forms.CheckBox();
        this.cba4 = new System.Windows.Forms.CheckBox();
        this.cba5 = new System.Windows.Forms.CheckBox();
        this.cba6 = new System.Windows.Forms.CheckBox();
        this.cba7 = new System.Windows.Forms.CheckBox();
        this.cba8 = new System.Windows.Forms.CheckBox();
        this.cbd1 = new System.Windows.Forms.CheckBox();
        this.cbd2 = new System.Windows.Forms.CheckBox();
        this.cbd3 = new System.Windows.Forms.CheckBox();
        this.cbd4 = new System.Windows.Forms.CheckBox();
        this.cbd5 = new System.Windows.Forms.CheckBox();
        this.cbd6 = new System.Windows.Forms.CheckBox();
        this.cbd7 = new System.Windows.Forms.CheckBox();
        this.cbd8 = new System.Windows.Forms.CheckBox();
        this.cb3 = new System.Windows.Forms.CheckBox();
        this.cb4 = new System.Windows.Forms.CheckBox();
        this.cb5 = new System.Windows.Forms.CheckBox();
        this.cbb1 = new System.Windows.Forms.CheckBox();
        this.Panel1 = new System.Windows.Forms.Panel();
        this.BSAll = new System.Windows.Forms.Button();
        this.BSInv = new System.Windows.Forms.Button();
        this.BSNone = new System.Windows.Forms.Button();
        this.Label3 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.TBSelect = new System.Windows.Forms.Button();
        this.TBClose = new System.Windows.Forms.Button();
        this.TBDelete = new System.Windows.Forms.Button();
        this.TBrl = new System.Windows.Forms.Button();
        this.TBrv = new System.Windows.Forms.Button();
        this.Label5 = new System.Windows.Forms.Label();
        this.Label6 = new System.Windows.Forms.Label();
        this.Label7 = new System.Windows.Forms.Label();
        this.Ttv = new System.Windows.Forms.NumericUpDown();
        this.Ttl = new System.Windows.Forms.TextBox();
        this.Label8 = new System.Windows.Forms.Label();
        this.Label9 = new System.Windows.Forms.Label();
        this.PictureBox3 = new System.Windows.Forms.PictureBox();
        this.PictureBox2 = new System.Windows.Forms.PictureBox();
        this.PictureBox1 = new System.Windows.Forms.PictureBox();
        this.cbx1 = new System.Windows.Forms.CheckBox();
        this.cbx2 = new System.Windows.Forms.CheckBox();
        this.cbx3 = new System.Windows.Forms.CheckBox();
        this.TBUnselect = new System.Windows.Forms.Button();
        this.cbx4 = new System.Windows.Forms.CheckBox();
        this.cbx5 = new System.Windows.Forms.CheckBox();
        this.cbx6 = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)this.mr1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.mr2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.vr2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.vr1).BeginInit();
        this.Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.Ttv).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
        this.SuspendLayout();
        System.Windows.Forms.Label label = this.Label1;
        System.Drawing.Point location = new System.Drawing.Point(26, 20);
        label.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label2 = this.Label1;
        System.Drawing.Size size = new System.Drawing.Size(120, 17);
        label2.Size = size;
        this.Label1.TabIndex = 2;
        this.Label1.Text = "Note Range";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label3 = this.Label2;
        location = new System.Drawing.Point(26, 73);
        label3.Location = location;
        this.Label2.Name = "Label2";
        System.Windows.Forms.Label label4 = this.Label2;
        size = new System.Drawing.Size(120, 17);
        label4.Size = size;
        this.Label2.TabIndex = 4;
        this.Label2.Text = "Measure Range";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.NumericUpDown numericUpDown = this.mr1;
        location = new System.Drawing.Point(152, 72);
        numericUpDown.Location = location;
        System.Windows.Forms.NumericUpDown numericUpDown2 = this.mr1;
        decimal maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        numericUpDown2.Maximum = maximum;
        this.mr1.Name = "mr1";
        System.Windows.Forms.NumericUpDown numericUpDown3 = this.mr1;
        size = new System.Drawing.Size(70, 23);
        numericUpDown3.Size = size;
        this.mr1.TabIndex = 5;
        System.Windows.Forms.NumericUpDown numericUpDown4 = this.mr2;
        location = new System.Drawing.Point(258, 72);
        numericUpDown4.Location = location;
        maximum = (this.mr2.Maximum = new decimal(new int[4] { 999, 0, 0, 0 }));
        this.mr2.Name = "mr2";
        System.Windows.Forms.NumericUpDown numericUpDown5 = this.mr2;
        size = new System.Drawing.Size(70, 23);
        numericUpDown5.Size = size;
        this.mr2.TabIndex = 6;
        maximum = (this.mr2.Value = new decimal(new int[4] { 999, 0, 0, 0 }));
        System.Windows.Forms.TextBox textBox = this.lr1;
        location = new System.Drawing.Point(152, 101);
        textBox.Location = location;
        this.lr1.MaxLength = 2;
        this.lr1.Name = "lr1";
        System.Windows.Forms.TextBox textBox2 = this.lr1;
        size = new System.Drawing.Size(70, 23);
        textBox2.Size = size;
        this.lr1.TabIndex = 7;
        this.lr1.Text = "01";
        System.Windows.Forms.TextBox textBox3 = this.lr2;
        location = new System.Drawing.Point(258, 101);
        textBox3.Location = location;
        this.lr2.MaxLength = 2;
        this.lr2.Name = "lr2";
        System.Windows.Forms.TextBox textBox4 = this.lr2;
        size = new System.Drawing.Size(70, 23);
        textBox4.Size = size;
        this.lr2.TabIndex = 8;
        this.lr2.Text = "ZZ";
        this.vr2.DecimalPlaces = 4;
        System.Windows.Forms.NumericUpDown numericUpDown6 = this.vr2;
        location = new System.Drawing.Point(258, 130);
        numericUpDown6.Location = location;
        maximum = (this.vr2.Maximum = new decimal(new int[4] { 655359999, 0, 0, 262144 }));
        maximum = (this.vr2.Minimum = new decimal(new int[4] { 1, 0, 0, 262144 }));
        this.vr2.Name = "vr2";
        System.Windows.Forms.NumericUpDown numericUpDown7 = this.vr2;
        size = new System.Drawing.Size(100, 23);
        numericUpDown7.Size = size;
        this.vr2.TabIndex = 10;
        maximum = (this.vr2.Value = new decimal(new int[4] { 655359999, 0, 0, 262144 }));
        this.vr1.DecimalPlaces = 4;
        System.Windows.Forms.NumericUpDown numericUpDown8 = this.vr1;
        location = new System.Drawing.Point(152, 130);
        numericUpDown8.Location = location;
        maximum = (this.vr1.Maximum = new decimal(new int[4] { 655359999, 0, 0, 262144 }));
        maximum = (this.vr1.Minimum = new decimal(new int[4] { 1, 0, 0, 262144 }));
        this.vr1.Name = "vr1";
        System.Windows.Forms.NumericUpDown numericUpDown9 = this.vr1;
        size = new System.Drawing.Size(70, 23);
        numericUpDown9.Size = size;
        this.vr1.TabIndex = 9;
        maximum = (this.vr1.Value = new decimal(new int[4] { 1, 0, 0, 262144 }));
        this.cb1.Appearance = System.Windows.Forms.Appearance.Button;
        this.cb1.Checked = true;
        this.cb1.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb1.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox = this.cb1;
        location = new System.Drawing.Point(3, 2);
        checkBox.Location = location;
        this.cb1.Name = "cb1";
        System.Windows.Forms.CheckBox checkBox2 = this.cb1;
        size = new System.Drawing.Size(50, 25);
        checkBox2.Size = size;
        this.cb1.TabIndex = 0;
        this.cb1.Tag = "1";
        this.cb1.Text = "BPM";
        this.cb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cb1.UseVisualStyleBackColor = false;
        this.cb2.Appearance = System.Windows.Forms.Appearance.Button;
        this.cb2.Checked = true;
        this.cb2.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb2.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox3 = this.cb2;
        location = new System.Drawing.Point(53, 2);
        checkBox3.Location = location;
        this.cb2.Name = "cb2";
        System.Windows.Forms.CheckBox checkBox4 = this.cb2;
        size = new System.Drawing.Size(50, 25);
        checkBox4.Size = size;
        this.cb2.TabIndex = 1;
        this.cb2.Tag = "2";
        this.cb2.Text = "STOP";
        this.cb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cb2.UseVisualStyleBackColor = true;
        this.cba1.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba1.Checked = true;
        this.cba1.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba1.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox5 = this.cba1;
        location = new System.Drawing.Point(3, 27);
        checkBox5.Location = location;
        this.cba1.Name = "cba1";
        System.Windows.Forms.CheckBox checkBox6 = this.cba1;
        size = new System.Drawing.Size(35, 25);
        checkBox6.Size = size;
        this.cba1.TabIndex = 2;
        this.cba1.Tag = "4";
        this.cba1.Text = "A1";
        this.cba1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba1.UseVisualStyleBackColor = true;
        this.cba2.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba2.Checked = true;
        this.cba2.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba2.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox7 = this.cba2;
        location = new System.Drawing.Point(38, 27);
        checkBox7.Location = location;
        this.cba2.Name = "cba2";
        System.Windows.Forms.CheckBox checkBox8 = this.cba2;
        size = new System.Drawing.Size(35, 25);
        checkBox8.Size = size;
        this.cba2.TabIndex = 3;
        this.cba2.Tag = "5";
        this.cba2.Text = "A2";
        this.cba2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba2.UseVisualStyleBackColor = true;
        this.cba3.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba3.Checked = true;
        this.cba3.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba3.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox9 = this.cba3;
        location = new System.Drawing.Point(73, 27);
        checkBox9.Location = location;
        this.cba3.Name = "cba3";
        System.Windows.Forms.CheckBox checkBox10 = this.cba3;
        size = new System.Drawing.Size(35, 25);
        checkBox10.Size = size;
        this.cba3.TabIndex = 4;
        this.cba3.Tag = "6";
        this.cba3.Text = "A3";
        this.cba3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba3.UseVisualStyleBackColor = true;
        this.cba4.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba4.Checked = true;
        this.cba4.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba4.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox11 = this.cba4;
        location = new System.Drawing.Point(108, 27);
        checkBox11.Location = location;
        this.cba4.Name = "cba4";
        System.Windows.Forms.CheckBox checkBox12 = this.cba4;
        size = new System.Drawing.Size(35, 25);
        checkBox12.Size = size;
        this.cba4.TabIndex = 5;
        this.cba4.Tag = "7";
        this.cba4.Text = "A4";
        this.cba4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba4.UseVisualStyleBackColor = true;
        this.cba5.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba5.Checked = true;
        this.cba5.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba5.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox13 = this.cba5;
        location = new System.Drawing.Point(143, 27);
        checkBox13.Location = location;
        this.cba5.Name = "cba5";
        System.Windows.Forms.CheckBox checkBox14 = this.cba5;
        size = new System.Drawing.Size(35, 25);
        checkBox14.Size = size;
        this.cba5.TabIndex = 6;
        this.cba5.Tag = "8";
        this.cba5.Text = "A5";
        this.cba5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba5.UseVisualStyleBackColor = true;
        this.cba6.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba6.Checked = true;
        this.cba6.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba6.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox15 = this.cba6;
        location = new System.Drawing.Point(178, 27);
        checkBox15.Location = location;
        this.cba6.Name = "cba6";
        System.Windows.Forms.CheckBox checkBox16 = this.cba6;
        size = new System.Drawing.Size(35, 25);
        checkBox16.Size = size;
        this.cba6.TabIndex = 7;
        this.cba6.Tag = "9";
        this.cba6.Text = "A6";
        this.cba6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba6.UseVisualStyleBackColor = true;
        this.cba7.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba7.Checked = true;
        this.cba7.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba7.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox17 = this.cba7;
        location = new System.Drawing.Point(213, 27);
        checkBox17.Location = location;
        this.cba7.Name = "cba7";
        System.Windows.Forms.CheckBox checkBox18 = this.cba7;
        size = new System.Drawing.Size(35, 25);
        checkBox18.Size = size;
        this.cba7.TabIndex = 8;
        this.cba7.Tag = "10";
        this.cba7.Text = "A7";
        this.cba7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba7.UseVisualStyleBackColor = true;
        this.cba8.Appearance = System.Windows.Forms.Appearance.Button;
        this.cba8.Checked = true;
        this.cba8.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cba8.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox19 = this.cba8;
        location = new System.Drawing.Point(248, 27);
        checkBox19.Location = location;
        this.cba8.Name = "cba8";
        System.Windows.Forms.CheckBox checkBox20 = this.cba8;
        size = new System.Drawing.Size(35, 25);
        checkBox20.Size = size;
        this.cba8.TabIndex = 9;
        this.cba8.Tag = "11";
        this.cba8.Text = "A8";
        this.cba8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cba8.UseVisualStyleBackColor = true;
        this.cbd1.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd1.Checked = true;
        this.cbd1.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd1.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox21 = this.cbd1;
        location = new System.Drawing.Point(3, 52);
        checkBox21.Location = location;
        this.cbd1.Name = "cbd1";
        System.Windows.Forms.CheckBox checkBox22 = this.cbd1;
        size = new System.Drawing.Size(35, 25);
        checkBox22.Size = size;
        this.cbd1.TabIndex = 10;
        this.cbd1.Tag = "13";
        this.cbd1.Text = "D1";
        this.cbd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd1.UseVisualStyleBackColor = true;
        this.cbd2.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd2.Checked = true;
        this.cbd2.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd2.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox23 = this.cbd2;
        location = new System.Drawing.Point(38, 52);
        checkBox23.Location = location;
        this.cbd2.Name = "cbd2";
        System.Windows.Forms.CheckBox checkBox24 = this.cbd2;
        size = new System.Drawing.Size(35, 25);
        checkBox24.Size = size;
        this.cbd2.TabIndex = 11;
        this.cbd2.Tag = "14";
        this.cbd2.Text = "D2";
        this.cbd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd2.UseVisualStyleBackColor = true;
        this.cbd3.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd3.Checked = true;
        this.cbd3.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd3.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox25 = this.cbd3;
        location = new System.Drawing.Point(73, 52);
        checkBox25.Location = location;
        this.cbd3.Name = "cbd3";
        System.Windows.Forms.CheckBox checkBox26 = this.cbd3;
        size = new System.Drawing.Size(35, 25);
        checkBox26.Size = size;
        this.cbd3.TabIndex = 12;
        this.cbd3.Tag = "15";
        this.cbd3.Text = "D3";
        this.cbd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd3.UseVisualStyleBackColor = true;
        this.cbd4.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd4.Checked = true;
        this.cbd4.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd4.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox27 = this.cbd4;
        location = new System.Drawing.Point(108, 52);
        checkBox27.Location = location;
        this.cbd4.Name = "cbd4";
        System.Windows.Forms.CheckBox checkBox28 = this.cbd4;
        size = new System.Drawing.Size(35, 25);
        checkBox28.Size = size;
        this.cbd4.TabIndex = 13;
        this.cbd4.Tag = "16";
        this.cbd4.Text = "D4";
        this.cbd4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd4.UseVisualStyleBackColor = true;
        this.cbd5.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd5.Checked = true;
        this.cbd5.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd5.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox29 = this.cbd5;
        location = new System.Drawing.Point(143, 52);
        checkBox29.Location = location;
        this.cbd5.Name = "cbd5";
        System.Windows.Forms.CheckBox checkBox30 = this.cbd5;
        size = new System.Drawing.Size(35, 25);
        checkBox30.Size = size;
        this.cbd5.TabIndex = 14;
        this.cbd5.Tag = "17";
        this.cbd5.Text = "D5";
        this.cbd5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd5.UseVisualStyleBackColor = true;
        this.cbd6.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd6.Checked = true;
        this.cbd6.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd6.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox31 = this.cbd6;
        location = new System.Drawing.Point(178, 52);
        checkBox31.Location = location;
        this.cbd6.Name = "cbd6";
        System.Windows.Forms.CheckBox checkBox32 = this.cbd6;
        size = new System.Drawing.Size(35, 25);
        checkBox32.Size = size;
        this.cbd6.TabIndex = 15;
        this.cbd6.Tag = "18";
        this.cbd6.Text = "D6";
        this.cbd6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd6.UseVisualStyleBackColor = true;
        this.cbd7.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd7.Checked = true;
        this.cbd7.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd7.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox33 = this.cbd7;
        location = new System.Drawing.Point(213, 52);
        checkBox33.Location = location;
        this.cbd7.Name = "cbd7";
        System.Windows.Forms.CheckBox checkBox34 = this.cbd7;
        size = new System.Drawing.Size(35, 25);
        checkBox34.Size = size;
        this.cbd7.TabIndex = 16;
        this.cbd7.Tag = "19";
        this.cbd7.Text = "D7";
        this.cbd7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd7.UseVisualStyleBackColor = true;
        this.cbd8.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbd8.Checked = true;
        this.cbd8.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbd8.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox35 = this.cbd8;
        location = new System.Drawing.Point(248, 52);
        checkBox35.Location = location;
        this.cbd8.Name = "cbd8";
        System.Windows.Forms.CheckBox checkBox36 = this.cbd8;
        size = new System.Drawing.Size(35, 25);
        checkBox36.Size = size;
        this.cbd8.TabIndex = 17;
        this.cbd8.Tag = "20";
        this.cbd8.Text = "D8";
        this.cbd8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbd8.UseVisualStyleBackColor = true;
        this.cb3.Appearance = System.Windows.Forms.Appearance.Button;
        this.cb3.Checked = true;
        this.cb3.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb3.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox37 = this.cb3;
        location = new System.Drawing.Point(3, 77);
        checkBox37.Location = location;
        this.cb3.Name = "cb3";
        System.Windows.Forms.CheckBox checkBox38 = this.cb3;
        size = new System.Drawing.Size(55, 25);
        checkBox38.Size = size;
        this.cb3.TabIndex = 18;
        this.cb3.Tag = "22";
        this.cb3.Text = "BGA";
        this.cb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cb3.UseVisualStyleBackColor = true;
        this.cb4.Appearance = System.Windows.Forms.Appearance.Button;
        this.cb4.Checked = true;
        this.cb4.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb4.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox39 = this.cb4;
        location = new System.Drawing.Point(58, 77);
        checkBox39.Location = location;
        this.cb4.Name = "cb4";
        System.Windows.Forms.CheckBox checkBox40 = this.cb4;
        size = new System.Drawing.Size(55, 25);
        checkBox40.Size = size;
        this.cb4.TabIndex = 19;
        this.cb4.Tag = "23";
        this.cb4.Text = "LAYER";
        this.cb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cb4.UseVisualStyleBackColor = true;
        this.cb5.Appearance = System.Windows.Forms.Appearance.Button;
        this.cb5.Checked = true;
        this.cb5.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cb5.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox41 = this.cb5;
        location = new System.Drawing.Point(113, 77);
        checkBox41.Location = location;
        this.cb5.Name = "cb5";
        System.Windows.Forms.CheckBox checkBox42 = this.cb5;
        size = new System.Drawing.Size(55, 25);
        checkBox42.Size = size;
        this.cb5.TabIndex = 20;
        this.cb5.Tag = "24";
        this.cb5.Text = "POOR";
        this.cb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cb5.UseVisualStyleBackColor = true;
        this.cbb1.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbb1.Checked = true;
        this.cbb1.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbb1.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox43 = this.cbb1;
        location = new System.Drawing.Point(3, 102);
        checkBox43.Location = location;
        this.cbb1.Name = "cbb1";
        System.Windows.Forms.CheckBox checkBox44 = this.cbb1;
        size = new System.Drawing.Size(35, 25);
        checkBox44.Size = size;
        this.cbb1.TabIndex = 21;
        this.cbb1.Tag = "26";
        this.cbb1.Text = "B1";
        this.cbb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbb1.UseVisualStyleBackColor = true;
        this.Panel1.AutoScroll = true;
        this.Panel1.Controls.Add(this.cb1);
        this.Panel1.Controls.Add(this.cbd8);
        this.Panel1.Controls.Add(this.cb2);
        this.Panel1.Controls.Add(this.cb3);
        this.Panel1.Controls.Add(this.cba1);
        this.Panel1.Controls.Add(this.cbd7);
        this.Panel1.Controls.Add(this.cb4);
        this.Panel1.Controls.Add(this.cba2);
        this.Panel1.Controls.Add(this.cbd6);
        this.Panel1.Controls.Add(this.cb5);
        this.Panel1.Controls.Add(this.cba3);
        this.Panel1.Controls.Add(this.cbd5);
        this.Panel1.Controls.Add(this.cbb1);
        this.Panel1.Controls.Add(this.cba4);
        this.Panel1.Controls.Add(this.cbd4);
        this.Panel1.Controls.Add(this.cbd3);
        this.Panel1.Controls.Add(this.cba5);
        this.Panel1.Controls.Add(this.cbd2);
        this.Panel1.Controls.Add(this.cbd1);
        this.Panel1.Controls.Add(this.cba6);
        this.Panel1.Controls.Add(this.cba8);
        this.Panel1.Controls.Add(this.cba7);
        System.Windows.Forms.Panel panel = this.Panel1;
        location = new System.Drawing.Point(26, 186);
        panel.Location = location;
        this.Panel1.Name = "Panel1";
        System.Windows.Forms.Panel panel2 = this.Panel1;
        size = new System.Drawing.Size(302, 131);
        panel2.Size = size;
        this.Panel1.TabIndex = 22;
        this.BSAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bSAll = this.BSAll;
        location = new System.Drawing.Point(334, 189);
        bSAll.Location = location;
        this.BSAll.Name = "BSAll";
        System.Windows.Forms.Button bSAll2 = this.BSAll;
        size = new System.Drawing.Size(120, 23);
        bSAll2.Size = size;
        this.BSAll.TabIndex = 23;
        this.BSAll.Text = "Select All";
        this.BSAll.UseVisualStyleBackColor = true;
        this.BSInv.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bSInv = this.BSInv;
        location = new System.Drawing.Point(334, 218);
        bSInv.Location = location;
        this.BSInv.Name = "BSInv";
        System.Windows.Forms.Button bSInv2 = this.BSInv;
        size = new System.Drawing.Size(120, 23);
        bSInv2.Size = size;
        this.BSInv.TabIndex = 24;
        this.BSInv.Text = "Select Inverse";
        this.BSInv.UseVisualStyleBackColor = true;
        this.BSNone.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.Button bSNone = this.BSNone;
        location = new System.Drawing.Point(334, 247);
        bSNone.Location = location;
        this.BSNone.Name = "BSNone";
        System.Windows.Forms.Button bSNone2 = this.BSNone;
        size = new System.Drawing.Size(120, 23);
        bSNone2.Size = size;
        this.BSNone.TabIndex = 25;
        this.BSNone.Text = "Unselect All";
        this.BSNone.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label5 = this.Label3;
        location = new System.Drawing.Point(26, 103);
        label5.Location = location;
        this.Label3.Name = "Label3";
        System.Windows.Forms.Label label6 = this.Label3;
        size = new System.Drawing.Size(120, 17);
        label6.Size = size;
        this.Label3.TabIndex = 26;
        this.Label3.Text = "Label Range";
        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label7 = this.Label4;
        location = new System.Drawing.Point(26, 131);
        label7.Location = location;
        this.Label4.Name = "Label4";
        System.Windows.Forms.Label label8 = this.Label4;
        size = new System.Drawing.Size(120, 17);
        label8.Size = size;
        this.Label4.TabIndex = 27;
        this.Label4.Text = "Value Range";
        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Button tBSelect = this.TBSelect;
        location = new System.Drawing.Point(298, 354);
        tBSelect.Location = location;
        this.TBSelect.Name = "TBSelect";
        System.Windows.Forms.Button tBSelect2 = this.TBSelect;
        size = new System.Drawing.Size(85, 23);
        tBSelect2.Size = size;
        this.TBSelect.TabIndex = 28;
        this.TBSelect.Text = "Select";
        this.TBSelect.UseVisualStyleBackColor = true;
        this.TBClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        System.Windows.Forms.Button tBClose = this.TBClose;
        location = new System.Drawing.Point(389, 383);
        tBClose.Location = location;
        this.TBClose.Name = "TBClose";
        System.Windows.Forms.Button tBClose2 = this.TBClose;
        size = new System.Drawing.Size(65, 23);
        tBClose2.Size = size;
        this.TBClose.TabIndex = 29;
        this.TBClose.Text = "Close";
        this.TBClose.UseVisualStyleBackColor = true;
        System.Windows.Forms.Button tBDelete = this.TBDelete;
        location = new System.Drawing.Point(389, 354);
        tBDelete.Location = location;
        this.TBDelete.Name = "TBDelete";
        System.Windows.Forms.Button tBDelete2 = this.TBDelete;
        size = new System.Drawing.Size(65, 23);
        tBDelete2.Size = size;
        this.TBDelete.TabIndex = 30;
        this.TBDelete.Text = "Delete";
        this.TBDelete.UseVisualStyleBackColor = true;
        System.Windows.Forms.Button tBrl = this.TBrl;
        location = new System.Drawing.Point(26, 354);
        tBrl.Location = location;
        this.TBrl.Name = "TBrl";
        System.Windows.Forms.Button tBrl2 = this.TBrl;
        size = new System.Drawing.Size(178, 23);
        tBrl2.Size = size;
        this.TBrl.TabIndex = 33;
        this.TBrl.Text = "Replace with Label:";
        this.TBrl.UseVisualStyleBackColor = true;
        System.Windows.Forms.Button tBrv = this.TBrv;
        location = new System.Drawing.Point(26, 383);
        tBrv.Location = location;
        this.TBrv.Name = "TBrv";
        System.Windows.Forms.Button tBrv2 = this.TBrv;
        size = new System.Drawing.Size(178, 23);
        tBrv2.Size = size;
        this.TBrv.TabIndex = 35;
        this.TBrv.Text = "Replace with Value:";
        this.TBrv.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label9 = this.Label5;
        location = new System.Drawing.Point(221, 103);
        label9.Location = location;
        this.Label5.Name = "Label5";
        System.Windows.Forms.Label label10 = this.Label5;
        size = new System.Drawing.Size(39, 16);
        label10.Size = size;
        this.Label5.TabIndex = 50;
        this.Label5.Text = "to";
        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        System.Windows.Forms.Label label11 = this.Label6;
        location = new System.Drawing.Point(221, 74);
        label11.Location = location;
        this.Label6.Name = "Label6";
        System.Windows.Forms.Label label12 = this.Label6;
        size = new System.Drawing.Size(39, 16);
        label12.Size = size;
        this.Label6.TabIndex = 51;
        this.Label6.Text = "to";
        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        System.Windows.Forms.Label label13 = this.Label7;
        location = new System.Drawing.Point(221, 132);
        label13.Location = location;
        this.Label7.Name = "Label7";
        System.Windows.Forms.Label label14 = this.Label7;
        size = new System.Drawing.Size(39, 16);
        label14.Size = size;
        this.Label7.TabIndex = 52;
        this.Label7.Text = "to";
        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Ttv.DecimalPlaces = 4;
        System.Windows.Forms.NumericUpDown ttv = this.Ttv;
        location = new System.Drawing.Point(210, 383);
        ttv.Location = location;
        maximum = (this.Ttv.Maximum = new decimal(new int[4] { 655359999, 0, 0, 262144 }));
        maximum = (this.Ttv.Minimum = new decimal(new int[4] { 1, 0, 0, 262144 }));
        this.Ttv.Name = "Ttv";
        System.Windows.Forms.NumericUpDown ttv2 = this.Ttv;
        size = new System.Drawing.Size(70, 23);
        ttv2.Size = size;
        this.Ttv.TabIndex = 34;
        maximum = (this.Ttv.Value = new decimal(new int[4] { 120, 0, 0, 0 }));
        System.Windows.Forms.TextBox ttl = this.Ttl;
        location = new System.Drawing.Point(210, 354);
        ttl.Location = location;
        this.Ttl.MaxLength = 2;
        this.Ttl.Name = "Ttl";
        System.Windows.Forms.TextBox ttl2 = this.Ttl;
        size = new System.Drawing.Size(70, 23);
        ttl2.Size = size;
        this.Ttl.TabIndex = 32;
        this.Ttl.Text = "01";
        this.Label8.AutoSize = true;
        System.Windows.Forms.Label label15 = this.Label8;
        location = new System.Drawing.Point(12, 165);
        label15.Location = location;
        this.Label8.Name = "Label8";
        System.Windows.Forms.Label label16 = this.Label8;
        size = new System.Drawing.Size(50, 15);
        label16.Size = size;
        this.Label8.TabIndex = 56;
        this.Label8.Text = "Column";
        this.Label9.AutoSize = true;
        System.Windows.Forms.Label label17 = this.Label9;
        location = new System.Drawing.Point(12, 327);
        label17.Location = location;
        this.Label9.Name = "Label9";
        System.Windows.Forms.Label label18 = this.Label9;
        size = new System.Drawing.Size(60, 15);
        label18.Size = size;
        this.Label9.TabIndex = 57;
        this.Label9.Text = "Operation";
        this.PictureBox3.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        System.Windows.Forms.PictureBox pictureBox = this.PictureBox3;
        location = new System.Drawing.Point(289, 354);
        pictureBox.Location = location;
        this.PictureBox3.Name = "PictureBox3";
        System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox3;
        size = new System.Drawing.Size(1, 52);
        pictureBox2.Size = size;
        this.PictureBox3.TabIndex = 55;
        this.PictureBox3.TabStop = false;
        this.PictureBox2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        System.Windows.Forms.PictureBox pictureBox3 = this.PictureBox2;
        location = new System.Drawing.Point(12, 335);
        pictureBox3.Location = location;
        this.PictureBox2.Name = "PictureBox2";
        System.Windows.Forms.PictureBox pictureBox4 = this.PictureBox2;
        size = new System.Drawing.Size(450, 1);
        pictureBox4.Size = size;
        this.PictureBox2.TabIndex = 49;
        this.PictureBox2.TabStop = false;
        this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        System.Windows.Forms.PictureBox pictureBox5 = this.PictureBox1;
        location = new System.Drawing.Point(12, 173);
        pictureBox5.Location = location;
        this.PictureBox1.Name = "PictureBox1";
        System.Windows.Forms.PictureBox pictureBox6 = this.PictureBox1;
        size = new System.Drawing.Size(450, 1);
        pictureBox6.Size = size;
        this.PictureBox1.TabIndex = 48;
        this.PictureBox1.TabStop = false;
        this.cbx1.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbx1.Checked = true;
        this.cbx1.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbx1.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox45 = this.cbx1;
        location = new System.Drawing.Point(152, 16);
        checkBox45.Location = location;
        this.cbx1.Name = "cbx1";
        System.Windows.Forms.CheckBox checkBox46 = this.cbx1;
        size = new System.Drawing.Size(100, 25);
        checkBox46.Size = size;
        this.cbx1.TabIndex = 58;
        this.cbx1.Tag = "1";
        this.cbx1.Text = "Selected";
        this.cbx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbx1.UseVisualStyleBackColor = false;
        this.cbx2.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbx2.Checked = true;
        this.cbx2.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbx2.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox47 = this.cbx2;
        location = new System.Drawing.Point(152, 41);
        checkBox47.Location = location;
        this.cbx2.Name = "cbx2";
        System.Windows.Forms.CheckBox checkBox48 = this.cbx2;
        size = new System.Drawing.Size(100, 25);
        checkBox48.Size = size;
        this.cbx2.TabIndex = 59;
        this.cbx2.Tag = "1";
        this.cbx2.Text = "Unselected";
        this.cbx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbx2.UseVisualStyleBackColor = false;
        this.cbx3.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbx3.Checked = true;
        this.cbx3.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbx3.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox49 = this.cbx3;
        location = new System.Drawing.Point(258, 16);
        checkBox49.Location = location;
        this.cbx3.Name = "cbx3";
        System.Windows.Forms.CheckBox checkBox50 = this.cbx3;
        size = new System.Drawing.Size(70, 25);
        checkBox50.Size = size;
        this.cbx3.TabIndex = 60;
        this.cbx3.Tag = "1";
        this.cbx3.Text = "Short";
        this.cbx3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbx3.UseVisualStyleBackColor = false;
        System.Windows.Forms.Button tBUnselect = this.TBUnselect;
        location = new System.Drawing.Point(298, 383);
        tBUnselect.Location = location;
        this.TBUnselect.Name = "TBUnselect";
        System.Windows.Forms.Button tBUnselect2 = this.TBUnselect;
        size = new System.Drawing.Size(85, 23);
        tBUnselect2.Size = size;
        this.TBUnselect.TabIndex = 31;
        this.TBUnselect.Text = "Unselect";
        this.TBUnselect.UseVisualStyleBackColor = true;
        this.cbx4.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbx4.Checked = true;
        this.cbx4.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbx4.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox51 = this.cbx4;
        location = new System.Drawing.Point(258, 41);
        checkBox51.Location = location;
        this.cbx4.Name = "cbx4";
        System.Windows.Forms.CheckBox checkBox52 = this.cbx4;
        size = new System.Drawing.Size(70, 25);
        checkBox52.Size = size;
        this.cbx4.TabIndex = 61;
        this.cbx4.Tag = "1";
        this.cbx4.Text = "Long";
        this.cbx4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbx4.UseVisualStyleBackColor = false;
        this.cbx5.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbx5.Checked = true;
        this.cbx5.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbx5.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox53 = this.cbx5;
        location = new System.Drawing.Point(334, 16);
        checkBox53.Location = location;
        this.cbx5.Name = "cbx5";
        System.Windows.Forms.CheckBox checkBox54 = this.cbx5;
        size = new System.Drawing.Size(80, 25);
        checkBox54.Size = size;
        this.cbx5.TabIndex = 62;
        this.cbx5.Tag = "1";
        this.cbx5.Text = "Hidden";
        this.cbx5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbx5.UseVisualStyleBackColor = false;
        this.cbx6.Appearance = System.Windows.Forms.Appearance.Button;
        this.cbx6.Checked = true;
        this.cbx6.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbx6.FlatStyle = System.Windows.Forms.FlatStyle.System;
        System.Windows.Forms.CheckBox checkBox55 = this.cbx6;
        location = new System.Drawing.Point(334, 41);
        checkBox55.Location = location;
        this.cbx6.Name = "cbx6";
        System.Windows.Forms.CheckBox checkBox56 = this.cbx6;
        size = new System.Drawing.Size(80, 25);
        checkBox56.Size = size;
        this.cbx6.TabIndex = 63;
        this.cbx6.Tag = "1";
        this.cbx6.Text = "Visible";
        this.cbx6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.cbx6.UseVisualStyleBackColor = false;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.TBClose;
        size = new System.Drawing.Size(474, 422);
        this.ClientSize = size;
        this.Controls.Add(this.cbx6);
        this.Controls.Add(this.cbx5);
        this.Controls.Add(this.cbx4);
        this.Controls.Add(this.TBUnselect);
        this.Controls.Add(this.cbx3);
        this.Controls.Add(this.cbx2);
        this.Controls.Add(this.cbx1);
        this.Controls.Add(this.Label9);
        this.Controls.Add(this.Label8);
        this.Controls.Add(this.PictureBox3);
        this.Controls.Add(this.Ttv);
        this.Controls.Add(this.Ttl);
        this.Controls.Add(this.PictureBox2);
        this.Controls.Add(this.PictureBox1);
        this.Controls.Add(this.TBrv);
        this.Controls.Add(this.TBrl);
        this.Controls.Add(this.TBDelete);
        this.Controls.Add(this.TBClose);
        this.Controls.Add(this.TBSelect);
        this.Controls.Add(this.Label4);
        this.Controls.Add(this.Label3);
        this.Controls.Add(this.BSNone);
        this.Controls.Add(this.BSInv);
        this.Controls.Add(this.BSAll);
        this.Controls.Add(this.Panel1);
        this.Controls.Add(this.vr2);
        this.Controls.Add(this.vr1);
        this.Controls.Add(this.lr2);
        this.Controls.Add(this.lr1);
        this.Controls.Add(this.mr2);
        this.Controls.Add(this.mr1);
        this.Controls.Add(this.Label2);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.Label7);
        this.Controls.Add(this.Label6);
        this.Controls.Add(this.Label5);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "diagFind";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Find / Delete / Replace";
        this.TopMost = true;
        ((System.ComponentModel.ISupportInitialize)this.mr1).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.mr2).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.vr2).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.vr1).EndInit();
        this.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.Ttv).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    public diagFind(int xbCol, string xmsg1, string xmsg2)
    {
        base.Load += diagFind_Load;
        bCol = 46;
        msg1 = "Error";
        msg2 = "Invalid label.";
        InitializeComponent();
        bCol = xbCol;
        msg1 = xmsg1;
        msg2 = xmsg2;
    }

    private void CloseDialog(object sender, EventArgs e)
    {
        Close();
    }

    private void BSAll_Click(object sender, EventArgs e)
    {
        IEnumerator enumerator = default(IEnumerator);
        try
        {
            enumerator = Panel1.Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
                CheckBox checkBox = (CheckBox)enumerator.Current;
                checkBox.Checked = true;
            }
        }
        finally
        {
            if (enumerator is IDisposable)
            {
                (enumerator as IDisposable).Dispose();
            }
        }
    }

    private void BSInv_Click(object sender, EventArgs e)
    {
        IEnumerator enumerator = default(IEnumerator);
        try
        {
            enumerator = Panel1.Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
                CheckBox checkBox = (CheckBox)enumerator.Current;
                checkBox.Checked = !checkBox.Checked;
            }
        }
        finally
        {
            if (enumerator is IDisposable)
            {
                (enumerator as IDisposable).Dispose();
            }
        }
    }

    private void BSNone_Click(object sender, EventArgs e)
    {
        IEnumerator enumerator = default(IEnumerator);
        try
        {
            enumerator = Panel1.Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
                CheckBox checkBox = (CheckBox)enumerator.Current;
                checkBox.Checked = false;
            }
        }
        finally
        {
            if (enumerator is IDisposable)
            {
                (enumerator as IDisposable).Dispose();
            }
        }
    }

    private void diagFind_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Font font = new Font(Font, FontStyle.Bold);
        TBSelect.Font = font;
        Label8.Font = font;
        Label9.Font = font;
        Text = MyProject.Forms.MainWindow.TBFind.Text;
        Label1.Text = Strings.fFind.NoteRange;
        Label2.Text = Strings.fFind.MeasureRange;
        Label3.Text = Strings.fFind.LabelRange;
        Label4.Text = Strings.fFind.ValueRange;
        Label5.Text = Strings.fFind.to_;
        Label6.Text = Strings.fFind.to_;
        Label7.Text = Strings.fFind.to_;
        cbx1.Text = Strings.fFind.Selected;
        cbx2.Text = Strings.fFind.UnSelected;
        cbx3.Text = Strings.fFind.ShortNote;
        cbx4.Text = Strings.fFind.LongNote;
        cbx5.Text = Strings.fFind.Hidden;
        cbx6.Text = Strings.fFind.Visible;
        Label8.Text = Strings.fFind.Column;
        BSAll.Text = Strings.fFind.SelectAll;
        BSInv.Text = Strings.fFind.SelectInverse;
        BSNone.Text = Strings.fFind.UnselectAll;
        Label9.Text = Strings.fFind.Operation;
        TBrl.Text = Strings.fFind.ReplaceWithLabel;
        TBrv.Text = Strings.fFind.ReplaceWithValue;
        TBSelect.Text = Strings.fFind.Select_;
        TBUnselect.Text = Strings.fFind.Unselect_;
        TBDelete.Text = Strings.fFind.Delete_;
        TBClose.Text = Strings.fFind.Close_;
        int num = bCol;
        checked
        {
            for (int i = 27; i <= num; i++)
            {
                CheckBox checkBox = new CheckBox();
                CheckBox checkBox2 = checkBox;
                checkBox2.Appearance = Appearance.Button;
                checkBox2.Checked = true;
                checkBox2.FlatStyle = FlatStyle.System;
                CheckBox checkBox3 = checkBox2;
                Point location = new Point(unchecked(checked(i - 26) % 8) * 35 + 3, unchecked(checked(i - 26) / 8) * 25 + 103);
                checkBox3.Location = location;
                CheckBox checkBox4 = checkBox2;
                Size size = new Size(35, 25);
                checkBox4.Size = size;
                checkBox2.Tag = i;
                checkBox2.Text = "B" + (i - 25);
                checkBox2.TextAlign = ContentAlignment.MiddleCenter;
                checkBox2.UseVisualStyleBackColor = true;
                checkBox2 = null;
                Panel1.Controls.Add(checkBox);
            }
            lr1.KeyDown += lblKeyDown;
            lr2.KeyDown += lblKeyDown;
            Ttl.KeyDown += lblKeyDown;
        }
    }

    private bool ValidLabel(string xStr)
    {
        xStr = Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Trim(xStr));
        if (Microsoft.VisualBasic.Strings.Len(xStr) == 0)
        {
            return false;
        }
        if ((Operators.CompareString(xStr, "00", TextCompare: false) == 0) | (Operators.CompareString(xStr, "0", TextCompare: false) == 0))
        {
            return false;
        }
        if ((Microsoft.VisualBasic.Strings.Len(xStr) != 1) & (Microsoft.VisualBasic.Strings.Len(xStr) != 2))
        {
            return false;
        }
        int num = Microsoft.VisualBasic.Strings.Asc(Microsoft.VisualBasic.Strings.Mid(xStr, 1, 1));
        if (!((num >= 48 && num <= 57) || (num >= 65 && num <= 90)))
        {
            return false;
        }
        if (Microsoft.VisualBasic.Strings.Len(xStr) == 2)
        {
            int num2 = Microsoft.VisualBasic.Strings.Asc(Microsoft.VisualBasic.Strings.Mid(xStr, 2, 1));
            if (!((num2 >= 48 && num2 <= 57) || (num2 >= 65 && num2 <= 90)))
            {
                return false;
            }
        }
        return true;
    }

    private void lblKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Return)
        {
            ValidateLabel(RuntimeHelpers.GetObjectValue(sender));
        }
    }

    private bool ValidateLabel(object sender)
    {
        bool flag = ValidLabel(Conversions.ToString(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)));
        if (!flag)
        {
            Interaction.MsgBox(msg2, MsgBoxStyle.Critical, msg1);
            NewLateBinding.LateCall(sender, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
            NewLateBinding.LateCall(sender, null, "SelectAll", new object[0], null, null, null, IgnoreReturn: true);
        }
        return flag;
    }

    private void TBSelect_Click(object sender, EventArgs e)
    {
        if (!ValidateLabel(lr1) || !ValidateLabel(lr2))
        {
            return;
        }
        int[] array = new int[0];
        checked
        {
            IEnumerator enumerator = default(IEnumerator);
            try
            {
                enumerator = Panel1.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CheckBox checkBox = (CheckBox)enumerator.Current;
                    if (checkBox.Checked)
                    {
                        array = (int[])Utils.CopyArray(array, new int[Information.UBound(array) + 1 + 1]);
                        array[Information.UBound(array)] = Conversions.ToInteger(checkBox.Tag);
                    }
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            int num = 1;
            if (cbx1.Checked)
            {
                num *= 2;
            }
            if (cbx2.Checked)
            {
                num *= 3;
            }
            if (cbx3.Checked)
            {
                num *= 5;
            }
            if (cbx4.Checked)
            {
                num *= 7;
            }
            if (cbx5.Checked)
            {
                num *= 11;
            }
            if (cbx6.Checked)
            {
                num *= 13;
            }
            MyProject.Forms.MainWindow.fdrSelect(num, Convert.ToInt32(mr1.Value), Convert.ToInt32(mr2.Value), lr1.Text, lr2.Text, Convert.ToInt32(decimal.Multiply(vr1.Value, new decimal(10000L))), Convert.ToInt32(decimal.Multiply(vr2.Value, new decimal(10000L))), array);
        }
    }

    private void TBUnselect_Click(object sender, EventArgs e)
    {
        if (!ValidateLabel(lr1) || !ValidateLabel(lr2))
        {
            return;
        }
        int[] array = new int[0];
        checked
        {
            IEnumerator enumerator = default(IEnumerator);
            try
            {
                enumerator = Panel1.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CheckBox checkBox = (CheckBox)enumerator.Current;
                    if (checkBox.Checked)
                    {
                        array = (int[])Utils.CopyArray(array, new int[Information.UBound(array) + 1 + 1]);
                        array[Information.UBound(array)] = Conversions.ToInteger(checkBox.Tag);
                    }
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            int num = 1;
            if (cbx1.Checked)
            {
                num *= 2;
            }
            if (cbx2.Checked)
            {
                num *= 3;
            }
            if (cbx3.Checked)
            {
                num *= 5;
            }
            if (cbx4.Checked)
            {
                num *= 7;
            }
            if (cbx5.Checked)
            {
                num *= 11;
            }
            if (cbx6.Checked)
            {
                num *= 13;
            }
            MyProject.Forms.MainWindow.fdrUnselect(num, Convert.ToInt32(mr1.Value), Convert.ToInt32(mr2.Value), lr1.Text, lr2.Text, Convert.ToInt32(decimal.Multiply(vr1.Value, new decimal(10000L))), Convert.ToInt32(decimal.Multiply(vr2.Value, new decimal(10000L))), array);
        }
    }

    private void TBDelete_Click(object sender, EventArgs e)
    {
        if (!ValidateLabel(lr1) || !ValidateLabel(lr2))
        {
            return;
        }
        int[] array = new int[0];
        checked
        {
            IEnumerator enumerator = default(IEnumerator);
            try
            {
                enumerator = Panel1.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CheckBox checkBox = (CheckBox)enumerator.Current;
                    if (checkBox.Checked)
                    {
                        array = (int[])Utils.CopyArray(array, new int[Information.UBound(array) + 1 + 1]);
                        array[Information.UBound(array)] = Conversions.ToInteger(checkBox.Tag);
                    }
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            int num = 1;
            if (cbx1.Checked)
            {
                num *= 2;
            }
            if (cbx2.Checked)
            {
                num *= 3;
            }
            if (cbx3.Checked)
            {
                num *= 5;
            }
            if (cbx4.Checked)
            {
                num *= 7;
            }
            if (cbx5.Checked)
            {
                num *= 11;
            }
            if (cbx6.Checked)
            {
                num *= 13;
            }
            MyProject.Forms.MainWindow.fdrDelete(num, Convert.ToInt32(mr1.Value), Convert.ToInt32(mr2.Value), lr1.Text, lr2.Text, Convert.ToInt32(decimal.Multiply(vr1.Value, new decimal(10000L))), Convert.ToInt32(decimal.Multiply(vr2.Value, new decimal(10000L))), array);
        }
    }

    private void TBrl_Click(object sender, EventArgs e)
    {
        if (!ValidateLabel(lr1) || !ValidateLabel(lr2) || !ValidateLabel(Ttl))
        {
            return;
        }
        int[] array = new int[0];
        checked
        {
            IEnumerator enumerator = default(IEnumerator);
            try
            {
                enumerator = Panel1.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CheckBox checkBox = (CheckBox)enumerator.Current;
                    if (checkBox.Checked)
                    {
                        array = (int[])Utils.CopyArray(array, new int[Information.UBound(array) + 1 + 1]);
                        array[Information.UBound(array)] = Conversions.ToInteger(checkBox.Tag);
                    }
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            int num = 1;
            if (cbx1.Checked)
            {
                num *= 2;
            }
            if (cbx2.Checked)
            {
                num *= 3;
            }
            if (cbx3.Checked)
            {
                num *= 5;
            }
            if (cbx4.Checked)
            {
                num *= 7;
            }
            if (cbx5.Checked)
            {
                num *= 11;
            }
            if (cbx6.Checked)
            {
                num *= 13;
            }
            MyProject.Forms.MainWindow.fdrReplaceL(num, Convert.ToInt32(mr1.Value), Convert.ToInt32(mr2.Value), lr1.Text, lr2.Text, Convert.ToInt32(decimal.Multiply(vr1.Value, new decimal(10000L))), Convert.ToInt32(decimal.Multiply(vr2.Value, new decimal(10000L))), array, Ttl.Text);
        }
    }

    private void TBrv_Click(object sender, EventArgs e)
    {
        if (!ValidateLabel(lr1) || !ValidateLabel(lr2))
        {
            return;
        }
        int[] array = new int[0];
        checked
        {
            IEnumerator enumerator = default(IEnumerator);
            try
            {
                enumerator = Panel1.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    CheckBox checkBox = (CheckBox)enumerator.Current;
                    if (checkBox.Checked)
                    {
                        array = (int[])Utils.CopyArray(array, new int[Information.UBound(array) + 1 + 1]);
                        array[Information.UBound(array)] = Conversions.ToInteger(checkBox.Tag);
                    }
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            int num = 1;
            if (cbx1.Checked)
            {
                num *= 2;
            }
            if (cbx2.Checked)
            {
                num *= 3;
            }
            if (cbx3.Checked)
            {
                num *= 5;
            }
            if (cbx4.Checked)
            {
                num *= 7;
            }
            if (cbx5.Checked)
            {
                num *= 11;
            }
            if (cbx6.Checked)
            {
                num *= 13;
            }
            MyProject.Forms.MainWindow.fdrReplaceV(num, Convert.ToInt32(mr1.Value), Convert.ToInt32(mr2.Value), lr1.Text, lr2.Text, Convert.ToInt32(decimal.Multiply(vr1.Value, new decimal(10000L))), Convert.ToInt32(decimal.Multiply(vr2.Value, new decimal(10000L))), array, Convert.ToInt32(decimal.Multiply(Ttv.Value, new decimal(10000L))));
        }
    }
}
