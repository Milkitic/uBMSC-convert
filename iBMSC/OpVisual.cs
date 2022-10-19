using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iBMSC.Editor;
using iBMSC.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC;

[DesignerGenerated]
public class OpVisual : Form
{
    public struct ColumnOptionSet
    {
        public NumericUpDown Width;

        public TextBox Title;

        public Button SNote;

        public Button SText;

        public Button LNote;

        public Button LText;

        public Button BG;
    }

    private IContainer components;

    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;

    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;

    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;

    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;

    [AccessedThroughProperty("Label39")]
    private Label _Label39;

    [AccessedThroughProperty("Label38")]
    private Label _Label38;

    [AccessedThroughProperty("Label37")]
    private Label _Label37;

    [AccessedThroughProperty("Label88")]
    private Label _Label88;

    [AccessedThroughProperty("Label35")]
    private Label _Label35;

    [AccessedThroughProperty("Label34")]
    private Label _Label34;

    [AccessedThroughProperty("Label86")]
    private Label _Label86;

    [AccessedThroughProperty("Label98")]
    private Label _Label98;

    [AccessedThroughProperty("Label31")]
    private Label _Label31;

    [AccessedThroughProperty("Label30")]
    private Label _Label30;

    [AccessedThroughProperty("Label29")]
    private Label _Label29;

    [AccessedThroughProperty("Label28")]
    private Label _Label28;

    [AccessedThroughProperty("Label27")]
    private Label _Label27;

    [AccessedThroughProperty("Label26")]
    private Label _Label26;

    [AccessedThroughProperty("Label25")]
    private Label _Label25;

    [AccessedThroughProperty("Label24")]
    private Label _Label24;

    [AccessedThroughProperty("Label22")]
    private Label _Label22;

    [AccessedThroughProperty("Label21")]
    private Label _Label21;

    [AccessedThroughProperty("Label40")]
    private Label _Label40;

    [AccessedThroughProperty("cColumnTitle")]
    private Button _cColumnTitle;

    [AccessedThroughProperty("fColumnTitle")]
    private Button _fColumnTitle;

    [AccessedThroughProperty("cBG")]
    private Button _cBG;

    [AccessedThroughProperty("fTSBPM")]
    private Button _fTSBPM;

    [AccessedThroughProperty("cTSBPM")]
    private Button _cTSBPM;

    [AccessedThroughProperty("cTSSelectionFill")]
    private Button _cTSSelectionFill;

    [AccessedThroughProperty("cTSCursor")]
    private Button _cTSCursor;

    [AccessedThroughProperty("cSelectionBox")]
    private Button _cSelectionBox;

    [AccessedThroughProperty("cWaveForm")]
    private Button _cWaveForm;

    [AccessedThroughProperty("cMeasureBarLine")]
    private Button _cMeasureBarLine;

    [AccessedThroughProperty("cVerticalLine")]
    private Button _cVerticalLine;

    [AccessedThroughProperty("cSub")]
    private Button _cSub;

    [AccessedThroughProperty("cGrid")]
    private Button _cGrid;

    [AccessedThroughProperty("fNoteLabel")]
    private Button _fNoteLabel;

    [AccessedThroughProperty("iNoteHeight")]
    private NumericUpDown _iNoteHeight;

    [AccessedThroughProperty("fMeasureLabel")]
    private Button _fMeasureLabel;

    [AccessedThroughProperty("iLongLabelHorizShift")]
    private NumericUpDown _iLongLabelHorizShift;

    [AccessedThroughProperty("iLabelHorizShift")]
    private NumericUpDown _iLabelHorizShift;

    [AccessedThroughProperty("iLabelVerticalShift")]
    private NumericUpDown _iLabelVerticalShift;

    [AccessedThroughProperty("cSelectedBorder")]
    private Button _cSelectedBorder;

    [AccessedThroughProperty("cMouseOver")]
    private Button _cMouseOver;

    [AccessedThroughProperty("Label23")]
    private Label _Label23;

    [AccessedThroughProperty("cAdjustLengthBorder")]
    private Button _cAdjustLengthBorder;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("Label8")]
    private Label _Label8;

    [AccessedThroughProperty("Label7")]
    private Label _Label7;

    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    [AccessedThroughProperty("Label4")]
    private Label _Label4;

    [AccessedThroughProperty("Label5")]
    private Label _Label5;

    [AccessedThroughProperty("Label33")]
    private Label _Label33;

    [AccessedThroughProperty("iHiddenNoteOpacity")]
    private NumericUpDown _iHiddenNoteOpacity;

    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    [AccessedThroughProperty("Label9")]
    private Label _Label9;

    [AccessedThroughProperty("cTSSplitter")]
    private Button _cTSSplitter;

    [AccessedThroughProperty("Label97")]
    private Label _Label97;

    [AccessedThroughProperty("Label96")]
    private Label _Label96;

    [AccessedThroughProperty("iTSSensitivity")]
    private NumericUpDown _iTSSensitivity;

    [AccessedThroughProperty("cTSMouseOver")]
    private Button _cTSMouseOver;

    [AccessedThroughProperty("Label91")]
    private Label _Label91;

    [AccessedThroughProperty("Label82")]
    private Label _Label82;

    [AccessedThroughProperty("Label14")]
    private Label _Label14;

    [AccessedThroughProperty("iMiddleSensitivity")]
    private NumericUpDown _iMiddleSensitivity;

    private int niB;

    private int[] lLeft;

    private visualSettings vo;

    private Column[] col;

    private ColumnOptionSet[] co;

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

    internal virtual Label Label39
    {
        get
        {
            return _Label39;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label39 = value;
        }
    }

    internal virtual Label Label38
    {
        get
        {
            return _Label38;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label38 = value;
        }
    }

    internal virtual Label Label37
    {
        get
        {
            return _Label37;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label37 = value;
        }
    }

    internal virtual Label Label88
    {
        get
        {
            return _Label88;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label88 = value;
        }
    }

    internal virtual Label Label35
    {
        get
        {
            return _Label35;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label35 = value;
        }
    }

    internal virtual Label Label34
    {
        get
        {
            return _Label34;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label34 = value;
        }
    }

    internal virtual Label Label86
    {
        get
        {
            return _Label86;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label86 = value;
        }
    }

    internal virtual Label Label98
    {
        get
        {
            return _Label98;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label98 = value;
        }
    }

    internal virtual Label Label31
    {
        get
        {
            return _Label31;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label31 = value;
        }
    }

    internal virtual Label Label30
    {
        get
        {
            return _Label30;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label30 = value;
        }
    }

    internal virtual Label Label29
    {
        get
        {
            return _Label29;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label29 = value;
        }
    }

    internal virtual Label Label28
    {
        get
        {
            return _Label28;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label28 = value;
        }
    }

    internal virtual Label Label27
    {
        get
        {
            return _Label27;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label27 = value;
        }
    }

    internal virtual Label Label26
    {
        get
        {
            return _Label26;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label26 = value;
        }
    }

    internal virtual Label Label25
    {
        get
        {
            return _Label25;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label25 = value;
        }
    }

    internal virtual Label Label24
    {
        get
        {
            return _Label24;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label24 = value;
        }
    }

    internal virtual Label Label22
    {
        get
        {
            return _Label22;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label22 = value;
        }
    }

    internal virtual Label Label21
    {
        get
        {
            return _Label21;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label21 = value;
        }
    }

    internal virtual Label Label40
    {
        get
        {
            return _Label40;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label40 = value;
        }
    }

    internal virtual Button cColumnTitle
    {
        get
        {
            return _cColumnTitle;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cColumnTitle != null)
            {
                _cColumnTitle.Click -= value2;
            }
            _cColumnTitle = value;
            if (_cColumnTitle != null)
            {
                _cColumnTitle.Click += value2;
            }
        }
    }

    internal virtual Button fColumnTitle
    {
        get
        {
            return _fColumnTitle;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BFClick;
            if (_fColumnTitle != null)
            {
                _fColumnTitle.Click -= value2;
            }
            _fColumnTitle = value;
            if (_fColumnTitle != null)
            {
                _fColumnTitle.Click += value2;
            }
        }
    }

    internal virtual Button cBG
    {
        get
        {
            return _cBG;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cBG != null)
            {
                _cBG.Click -= value2;
            }
            _cBG = value;
            if (_cBG != null)
            {
                _cBG.Click += value2;
            }
        }
    }

    internal virtual Button fTSBPM
    {
        get
        {
            return _fTSBPM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BFClick;
            if (_fTSBPM != null)
            {
                _fTSBPM.Click -= value2;
            }
            _fTSBPM = value;
            if (_fTSBPM != null)
            {
                _fTSBPM.Click += value2;
            }
        }
    }

    internal virtual Button cTSBPM
    {
        get
        {
            return _cTSBPM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cTSBPM != null)
            {
                _cTSBPM.Click -= value2;
            }
            _cTSBPM = value;
            if (_cTSBPM != null)
            {
                _cTSBPM.Click += value2;
            }
        }
    }

    internal virtual Button cTSSelectionFill
    {
        get
        {
            return _cTSSelectionFill;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cTSSelectionFill != null)
            {
                _cTSSelectionFill.Click -= value2;
            }
            _cTSSelectionFill = value;
            if (_cTSSelectionFill != null)
            {
                _cTSSelectionFill.Click += value2;
            }
        }
    }

    internal virtual Button cTSCursor
    {
        get
        {
            return _cTSCursor;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cTSCursor != null)
            {
                _cTSCursor.Click -= value2;
            }
            _cTSCursor = value;
            if (_cTSCursor != null)
            {
                _cTSCursor.Click += value2;
            }
        }
    }

    internal virtual Button cSelectionBox
    {
        get
        {
            return _cSelectionBox;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cSelectionBox != null)
            {
                _cSelectionBox.Click -= value2;
            }
            _cSelectionBox = value;
            if (_cSelectionBox != null)
            {
                _cSelectionBox.Click += value2;
            }
        }
    }

    internal virtual Button cWaveForm
    {
        get
        {
            return _cWaveForm;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cWaveForm != null)
            {
                _cWaveForm.Click -= value2;
            }
            _cWaveForm = value;
            if (_cWaveForm != null)
            {
                _cWaveForm.Click += value2;
            }
        }
    }

    internal virtual Button cMeasureBarLine
    {
        get
        {
            return _cMeasureBarLine;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cMeasureBarLine != null)
            {
                _cMeasureBarLine.Click -= value2;
            }
            _cMeasureBarLine = value;
            if (_cMeasureBarLine != null)
            {
                _cMeasureBarLine.Click += value2;
            }
        }
    }

    internal virtual Button cVerticalLine
    {
        get
        {
            return _cVerticalLine;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cVerticalLine != null)
            {
                _cVerticalLine.Click -= value2;
            }
            _cVerticalLine = value;
            if (_cVerticalLine != null)
            {
                _cVerticalLine.Click += value2;
            }
        }
    }

    internal virtual Button cSub
    {
        get
        {
            return _cSub;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cSub != null)
            {
                _cSub.Click -= value2;
            }
            _cSub = value;
            if (_cSub != null)
            {
                _cSub.Click += value2;
            }
        }
    }

    internal virtual Button cGrid
    {
        get
        {
            return _cGrid;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cGrid != null)
            {
                _cGrid.Click -= value2;
            }
            _cGrid = value;
            if (_cGrid != null)
            {
                _cGrid.Click += value2;
            }
        }
    }

    internal virtual Button fNoteLabel
    {
        get
        {
            return _fNoteLabel;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BFClick;
            if (_fNoteLabel != null)
            {
                _fNoteLabel.Click -= value2;
            }
            _fNoteLabel = value;
            if (_fNoteLabel != null)
            {
                _fNoteLabel.Click += value2;
            }
        }
    }

    internal virtual NumericUpDown iNoteHeight
    {
        get
        {
            return _iNoteHeight;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iNoteHeight = value;
        }
    }

    internal virtual Button fMeasureLabel
    {
        get
        {
            return _fMeasureLabel;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BFClick;
            if (_fMeasureLabel != null)
            {
                _fMeasureLabel.Click -= value2;
            }
            _fMeasureLabel = value;
            if (_fMeasureLabel != null)
            {
                _fMeasureLabel.Click += value2;
            }
        }
    }

    internal virtual NumericUpDown iLongLabelHorizShift
    {
        get
        {
            return _iLongLabelHorizShift;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iLongLabelHorizShift = value;
        }
    }

    internal virtual NumericUpDown iLabelHorizShift
    {
        get
        {
            return _iLabelHorizShift;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iLabelHorizShift = value;
        }
    }

    internal virtual NumericUpDown iLabelVerticalShift
    {
        get
        {
            return _iLabelVerticalShift;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iLabelVerticalShift = value;
        }
    }

    internal virtual Button cSelectedBorder
    {
        get
        {
            return _cSelectedBorder;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cSelectedBorder != null)
            {
                _cSelectedBorder.Click -= value2;
            }
            _cSelectedBorder = value;
            if (_cSelectedBorder != null)
            {
                _cSelectedBorder.Click += value2;
            }
        }
    }

    internal virtual Button cMouseOver
    {
        get
        {
            return _cMouseOver;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cMouseOver != null)
            {
                _cMouseOver.Click -= value2;
            }
            _cMouseOver = value;
            if (_cMouseOver != null)
            {
                _cMouseOver.Click += value2;
            }
        }
    }

    internal virtual Label Label23
    {
        get
        {
            return _Label23;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label23 = value;
        }
    }

    internal virtual Button cAdjustLengthBorder
    {
        get
        {
            return _cAdjustLengthBorder;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cAdjustLengthBorder != null)
            {
                _cAdjustLengthBorder.Click -= value2;
            }
            _cAdjustLengthBorder = value;
            if (_cAdjustLengthBorder != null)
            {
                _cAdjustLengthBorder.Click += value2;
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

    internal virtual Label Label33
    {
        get
        {
            return _Label33;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label33 = value;
        }
    }

    internal virtual NumericUpDown iHiddenNoteOpacity
    {
        get
        {
            return _iHiddenNoteOpacity;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iHiddenNoteOpacity = value;
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

    internal virtual Button cTSSplitter
    {
        get
        {
            return _cTSSplitter;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cTSSplitter != null)
            {
                _cTSSplitter.Click -= value2;
            }
            _cTSSplitter = value;
            if (_cTSSplitter != null)
            {
                _cTSSplitter.Click += value2;
            }
        }
    }

    internal virtual Label Label97
    {
        get
        {
            return _Label97;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label97 = value;
        }
    }

    internal virtual Label Label96
    {
        get
        {
            return _Label96;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label96 = value;
        }
    }

    internal virtual NumericUpDown iTSSensitivity
    {
        get
        {
            return _iTSSensitivity;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iTSSensitivity = value;
        }
    }

    internal virtual Button cTSMouseOver
    {
        get
        {
            return _cTSMouseOver;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BCClick;
            if (_cTSMouseOver != null)
            {
                _cTSMouseOver.Click -= value2;
            }
            _cTSMouseOver = value;
            if (_cTSMouseOver != null)
            {
                _cTSMouseOver.Click += value2;
            }
        }
    }

    internal virtual Label Label91
    {
        get
        {
            return _Label91;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label91 = value;
        }
    }

    internal virtual Label Label82
    {
        get
        {
            return _Label82;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label82 = value;
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

    internal virtual NumericUpDown iMiddleSensitivity
    {
        get
        {
            return _iMiddleSensitivity;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _iMiddleSensitivity = value;
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
        this.Panel1 = new System.Windows.Forms.Panel();
        this.Label8 = new System.Windows.Forms.Label();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label7 = new System.Windows.Forms.Label();
        this.Label5 = new System.Windows.Forms.Label();
        this.Label6 = new System.Windows.Forms.Label();
        this.Label2 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.Label33 = new System.Windows.Forms.Label();
        this.iHiddenNoteOpacity = new System.Windows.Forms.NumericUpDown();
        this.Label23 = new System.Windows.Forms.Label();
        this.cAdjustLengthBorder = new System.Windows.Forms.Button();
        this.cSelectedBorder = new System.Windows.Forms.Button();
        this.cMouseOver = new System.Windows.Forms.Button();
        this.iLongLabelHorizShift = new System.Windows.Forms.NumericUpDown();
        this.iLabelHorizShift = new System.Windows.Forms.NumericUpDown();
        this.iLabelVerticalShift = new System.Windows.Forms.NumericUpDown();
        this.fMeasureLabel = new System.Windows.Forms.Button();
        this.fNoteLabel = new System.Windows.Forms.Button();
        this.iNoteHeight = new System.Windows.Forms.NumericUpDown();
        this.fTSBPM = new System.Windows.Forms.Button();
        this.cTSBPM = new System.Windows.Forms.Button();
        this.cTSSelectionFill = new System.Windows.Forms.Button();
        this.cTSCursor = new System.Windows.Forms.Button();
        this.cSelectionBox = new System.Windows.Forms.Button();
        this.cWaveForm = new System.Windows.Forms.Button();
        this.cMeasureBarLine = new System.Windows.Forms.Button();
        this.cVerticalLine = new System.Windows.Forms.Button();
        this.cSub = new System.Windows.Forms.Button();
        this.cGrid = new System.Windows.Forms.Button();
        this.cBG = new System.Windows.Forms.Button();
        this.fColumnTitle = new System.Windows.Forms.Button();
        this.cColumnTitle = new System.Windows.Forms.Button();
        this.Label40 = new System.Windows.Forms.Label();
        this.Label39 = new System.Windows.Forms.Label();
        this.Label38 = new System.Windows.Forms.Label();
        this.Label37 = new System.Windows.Forms.Label();
        this.Label88 = new System.Windows.Forms.Label();
        this.Label35 = new System.Windows.Forms.Label();
        this.Label34 = new System.Windows.Forms.Label();
        this.Label86 = new System.Windows.Forms.Label();
        this.Label98 = new System.Windows.Forms.Label();
        this.Label31 = new System.Windows.Forms.Label();
        this.Label30 = new System.Windows.Forms.Label();
        this.Label29 = new System.Windows.Forms.Label();
        this.Label28 = new System.Windows.Forms.Label();
        this.Label27 = new System.Windows.Forms.Label();
        this.Label26 = new System.Windows.Forms.Label();
        this.Label25 = new System.Windows.Forms.Label();
        this.Label24 = new System.Windows.Forms.Label();
        this.Label22 = new System.Windows.Forms.Label();
        this.Label21 = new System.Windows.Forms.Label();
        this.Label9 = new System.Windows.Forms.Label();
        this.cTSSplitter = new System.Windows.Forms.Button();
        this.Label97 = new System.Windows.Forms.Label();
        this.Label96 = new System.Windows.Forms.Label();
        this.iTSSensitivity = new System.Windows.Forms.NumericUpDown();
        this.cTSMouseOver = new System.Windows.Forms.Button();
        this.Label91 = new System.Windows.Forms.Label();
        this.Label82 = new System.Windows.Forms.Label();
        this.Label14 = new System.Windows.Forms.Label();
        this.iMiddleSensitivity = new System.Windows.Forms.NumericUpDown();
        this.PictureBox1 = new System.Windows.Forms.PictureBox();
        this.TableLayoutPanel1.SuspendLayout();
        this.Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.iHiddenNoteOpacity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.iLongLabelHorizShift).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.iLabelHorizShift).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.iLabelVerticalShift).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.iNoteHeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.iTSSensitivity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.iMiddleSensitivity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
        this.SuspendLayout();
        this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.TableLayoutPanel1.ColumnCount = 2;
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
        this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
        this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
        this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
        System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel1;
        System.Drawing.Point location = new System.Drawing.Point(868, 672);
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
        this.Panel1.Controls.Add(this.Label8);
        this.Panel1.Controls.Add(this.Label1);
        this.Panel1.Controls.Add(this.Label7);
        this.Panel1.Controls.Add(this.Label5);
        this.Panel1.Controls.Add(this.Label6);
        this.Panel1.Controls.Add(this.Label2);
        this.Panel1.Controls.Add(this.Label4);
        System.Windows.Forms.Panel panel = this.Panel1;
        location = new System.Drawing.Point(10, 263);
        panel.Location = location;
        this.Panel1.Name = "Panel1";
        System.Windows.Forms.Panel panel2 = this.Panel1;
        size = new System.Drawing.Size(1004, 402);
        panel2.Size = size;
        this.Panel1.TabIndex = 87;
        System.Windows.Forms.Label label = this.Label8;
        location = new System.Drawing.Point(12, 324);
        label.Location = location;
        this.Label8.Name = "Label8";
        System.Windows.Forms.Label label2 = this.Label8;
        size = new System.Drawing.Size(60, 65);
        label2.Size = size;
        this.Label8.TabIndex = 39;
        this.Label8.Text = "Bg";
        this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label3 = this.Label1;
        location = new System.Drawing.Point(12, 15);
        label3.Location = location;
        this.Label1.Name = "Label1";
        System.Windows.Forms.Label label4 = this.Label1;
        size = new System.Drawing.Size(60, 15);
        label4.Size = size;
        this.Label1.TabIndex = 33;
        this.Label1.Text = "Width";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label5 = this.Label7;
        location = new System.Drawing.Point(12, 258);
        label5.Location = location;
        this.Label7.Name = "Label7";
        System.Windows.Forms.Label label6 = this.Label7;
        size = new System.Drawing.Size(60, 66);
        label6.Size = size;
        this.Label7.TabIndex = 38;
        this.Label7.Text = "Long\r\nNote\r\nLabel";
        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label7 = this.Label5;
        location = new System.Drawing.Point(12, 193);
        label7.Location = location;
        this.Label5.Name = "Label5";
        System.Windows.Forms.Label label8 = this.Label5;
        size = new System.Drawing.Size(60, 66);
        label8.Size = size;
        this.Label5.TabIndex = 36;
        this.Label5.Text = "Long\r\nNote";
        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label9 = this.Label6;
        location = new System.Drawing.Point(12, 128);
        label9.Location = location;
        this.Label6.Name = "Label6";
        System.Windows.Forms.Label label10 = this.Label6;
        size = new System.Drawing.Size(60, 66);
        label10.Size = size;
        this.Label6.TabIndex = 37;
        this.Label6.Text = "Label";
        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label11 = this.Label2;
        location = new System.Drawing.Point(12, 37);
        label11.Location = location;
        this.Label2.Name = "Label2";
        System.Windows.Forms.Label label12 = this.Label2;
        size = new System.Drawing.Size(60, 15);
        label12.Size = size;
        this.Label2.TabIndex = 34;
        this.Label2.Text = "Caption";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label13 = this.Label4;
        location = new System.Drawing.Point(12, 63);
        label13.Location = location;
        this.Label4.Name = "Label4";
        System.Windows.Forms.Label label14 = this.Label4;
        size = new System.Drawing.Size(60, 66);
        label14.Size = size;
        this.Label4.TabIndex = 35;
        this.Label4.Text = "Note";
        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label15 = this.Label33;
        location = new System.Drawing.Point(315, 152);
        label15.Location = location;
        this.Label33.Name = "Label33";
        System.Windows.Forms.Label label16 = this.Label33;
        size = new System.Drawing.Size(220, 15);
        label16.Size = size;
        this.Label33.TabIndex = 137;
        this.Label33.Text = "Hidden Note Opacity";
        this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.iHiddenNoteOpacity.DecimalPlaces = 2;
        System.Windows.Forms.NumericUpDown numericUpDown = this.iHiddenNoteOpacity;
        decimal increment = new decimal(new int[4] { 1, 0, 0, 65536 });
        numericUpDown.Increment = increment;
        System.Windows.Forms.NumericUpDown numericUpDown2 = this.iHiddenNoteOpacity;
        location = new System.Drawing.Point(537, 148);
        numericUpDown2.Location = location;
        increment = (this.iHiddenNoteOpacity.Maximum = new decimal(new int[4] { 1, 0, 0, 0 }));
        this.iHiddenNoteOpacity.Name = "iHiddenNoteOpacity";
        System.Windows.Forms.NumericUpDown numericUpDown3 = this.iHiddenNoteOpacity;
        size = new System.Drawing.Size(80, 23);
        numericUpDown3.Size = size;
        this.iHiddenNoteOpacity.TabIndex = 136;
        this.iHiddenNoteOpacity.Tag = "4";
        System.Windows.Forms.Label label17 = this.Label23;
        location = new System.Drawing.Point(315, 225);
        label17.Location = location;
        this.Label23.Name = "Label23";
        System.Windows.Forms.Label label18 = this.Label23;
        size = new System.Drawing.Size(220, 15);
        label18.Size = size;
        this.Label23.TabIndex = 135;
        this.Label23.Text = "Note Border on Adjusting Length";
        this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.cAdjustLengthBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button = this.cAdjustLengthBorder;
        location = new System.Drawing.Point(537, 221);
        button.Location = location;
        this.cAdjustLengthBorder.Name = "cAdjustLengthBorder";
        System.Windows.Forms.Button button2 = this.cAdjustLengthBorder;
        size = new System.Drawing.Size(80, 23);
        button2.Size = size;
        this.cAdjustLengthBorder.TabIndex = 134;
        this.cAdjustLengthBorder.Tag = "13";
        this.cAdjustLengthBorder.Text = "FF000000";
        this.cAdjustLengthBorder.UseVisualStyleBackColor = true;
        this.cSelectedBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button3 = this.cSelectedBorder;
        location = new System.Drawing.Point(537, 199);
        button3.Location = location;
        this.cSelectedBorder.Name = "cSelectedBorder";
        System.Windows.Forms.Button button4 = this.cSelectedBorder;
        size = new System.Drawing.Size(80, 23);
        button4.Size = size;
        this.cSelectedBorder.TabIndex = 133;
        this.cSelectedBorder.Tag = "12";
        this.cSelectedBorder.Text = "FF000000";
        this.cSelectedBorder.UseVisualStyleBackColor = true;
        this.cMouseOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button5 = this.cMouseOver;
        location = new System.Drawing.Point(537, 177);
        button5.Location = location;
        this.cMouseOver.Name = "cMouseOver";
        System.Windows.Forms.Button button6 = this.cMouseOver;
        size = new System.Drawing.Size(80, 23);
        button6.Size = size;
        this.cMouseOver.TabIndex = 132;
        this.cMouseOver.Tag = "11";
        this.cMouseOver.Text = "FF000000";
        this.cMouseOver.UseVisualStyleBackColor = true;
        System.Windows.Forms.NumericUpDown numericUpDown4 = this.iLongLabelHorizShift;
        location = new System.Drawing.Point(537, 126);
        numericUpDown4.Location = location;
        increment = (this.iLongLabelHorizShift.Minimum = new decimal(new int[4] { 100, 0, 0, -2147483648 }));
        this.iLongLabelHorizShift.Name = "iLongLabelHorizShift";
        System.Windows.Forms.NumericUpDown numericUpDown5 = this.iLongLabelHorizShift;
        size = new System.Drawing.Size(80, 23);
        numericUpDown5.Size = size;
        this.iLongLabelHorizShift.TabIndex = 131;
        this.iLongLabelHorizShift.Tag = "3";
        System.Windows.Forms.NumericUpDown numericUpDown6 = this.iLabelHorizShift;
        location = new System.Drawing.Point(537, 104);
        numericUpDown6.Location = location;
        increment = (this.iLabelHorizShift.Minimum = new decimal(new int[4] { 100, 0, 0, -2147483648 }));
        this.iLabelHorizShift.Name = "iLabelHorizShift";
        System.Windows.Forms.NumericUpDown numericUpDown7 = this.iLabelHorizShift;
        size = new System.Drawing.Size(80, 23);
        numericUpDown7.Size = size;
        this.iLabelHorizShift.TabIndex = 130;
        this.iLabelHorizShift.Tag = "2";
        System.Windows.Forms.NumericUpDown numericUpDown8 = this.iLabelVerticalShift;
        location = new System.Drawing.Point(537, 82);
        numericUpDown8.Location = location;
        increment = (this.iLabelVerticalShift.Minimum = new decimal(new int[4] { 100, 0, 0, -2147483648 }));
        this.iLabelVerticalShift.Name = "iLabelVerticalShift";
        System.Windows.Forms.NumericUpDown numericUpDown9 = this.iLabelVerticalShift;
        size = new System.Drawing.Size(80, 23);
        numericUpDown9.Size = size;
        this.iLabelVerticalShift.TabIndex = 129;
        this.iLabelVerticalShift.Tag = "1";
        this.fMeasureLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button7 = this.fMeasureLabel;
        location = new System.Drawing.Point(537, 60);
        button7.Location = location;
        this.fMeasureLabel.Name = "fMeasureLabel";
        System.Windows.Forms.Button button8 = this.fMeasureLabel;
        size = new System.Drawing.Size(80, 23);
        button8.Size = size;
        this.fMeasureLabel.TabIndex = 128;
        this.fMeasureLabel.Tag = "3";
        this.fMeasureLabel.Text = "Verdana";
        this.fMeasureLabel.UseVisualStyleBackColor = true;
        this.fNoteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button9 = this.fNoteLabel;
        location = new System.Drawing.Point(537, 38);
        button9.Location = location;
        this.fNoteLabel.Name = "fNoteLabel";
        System.Windows.Forms.Button button10 = this.fNoteLabel;
        size = new System.Drawing.Size(80, 23);
        button10.Size = size;
        this.fNoteLabel.TabIndex = 127;
        this.fNoteLabel.Tag = "2";
        this.fNoteLabel.Text = "Verdana";
        this.fNoteLabel.UseVisualStyleBackColor = true;
        System.Windows.Forms.NumericUpDown numericUpDown10 = this.iNoteHeight;
        location = new System.Drawing.Point(537, 16);
        numericUpDown10.Location = location;
        this.iNoteHeight.Name = "iNoteHeight";
        System.Windows.Forms.NumericUpDown numericUpDown11 = this.iNoteHeight;
        size = new System.Drawing.Size(80, 23);
        numericUpDown11.Size = size;
        this.iNoteHeight.TabIndex = 126;
        this.iNoteHeight.Tag = "0";
        this.fTSBPM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button11 = this.fTSBPM;
        location = new System.Drawing.Point(870, 170);
        button11.Location = location;
        this.fTSBPM.Name = "fTSBPM";
        System.Windows.Forms.Button button12 = this.fTSBPM;
        size = new System.Drawing.Size(80, 23);
        button12.Size = size;
        this.fTSBPM.TabIndex = 125;
        this.fTSBPM.Tag = "1";
        this.fTSBPM.Text = "Verdana";
        this.fTSBPM.UseVisualStyleBackColor = true;
        this.cTSBPM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button13 = this.cTSBPM;
        location = new System.Drawing.Point(870, 148);
        button13.Location = location;
        this.cTSBPM.Name = "cTSBPM";
        System.Windows.Forms.Button button14 = this.cTSBPM;
        size = new System.Drawing.Size(80, 23);
        button14.Size = size;
        this.cTSBPM.TabIndex = 124;
        this.cTSBPM.Tag = "10";
        this.cTSBPM.Text = "FF000000";
        this.cTSBPM.UseVisualStyleBackColor = true;
        this.cTSSelectionFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button15 = this.cTSSelectionFill;
        location = new System.Drawing.Point(870, 126);
        button15.Location = location;
        this.cTSSelectionFill.Name = "cTSSelectionFill";
        System.Windows.Forms.Button button16 = this.cTSSelectionFill;
        size = new System.Drawing.Size(80, 23);
        button16.Size = size;
        this.cTSSelectionFill.TabIndex = 123;
        this.cTSSelectionFill.Tag = "9";
        this.cTSSelectionFill.Text = "FF000000";
        this.cTSSelectionFill.UseVisualStyleBackColor = true;
        this.cTSCursor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button17 = this.cTSCursor;
        location = new System.Drawing.Point(870, 38);
        button17.Location = location;
        this.cTSCursor.Name = "cTSCursor";
        System.Windows.Forms.Button button18 = this.cTSCursor;
        size = new System.Drawing.Size(80, 23);
        button18.Size = size;
        this.cTSCursor.TabIndex = 122;
        this.cTSCursor.Tag = "8";
        this.cTSCursor.Text = "FF000000";
        this.cTSCursor.UseVisualStyleBackColor = true;
        this.cSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button19 = this.cSelectionBox;
        location = new System.Drawing.Point(870, 16);
        button19.Location = location;
        this.cSelectionBox.Name = "cSelectionBox";
        System.Windows.Forms.Button button20 = this.cSelectionBox;
        size = new System.Drawing.Size(80, 23);
        button20.Size = size;
        this.cSelectionBox.TabIndex = 121;
        this.cSelectionBox.Tag = "7";
        this.cSelectionBox.Text = "FF000000";
        this.cSelectionBox.UseVisualStyleBackColor = true;
        this.cWaveForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button21 = this.cWaveForm;
        location = new System.Drawing.Point(204, 177);
        button21.Location = location;
        this.cWaveForm.Name = "cWaveForm";
        System.Windows.Forms.Button button22 = this.cWaveForm;
        size = new System.Drawing.Size(80, 23);
        button22.Size = size;
        this.cWaveForm.TabIndex = 120;
        this.cWaveForm.Tag = "6";
        this.cWaveForm.Text = "FF000000";
        this.cWaveForm.UseVisualStyleBackColor = true;
        this.cMeasureBarLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button23 = this.cMeasureBarLine;
        location = new System.Drawing.Point(204, 155);
        button23.Location = location;
        this.cMeasureBarLine.Name = "cMeasureBarLine";
        System.Windows.Forms.Button button24 = this.cMeasureBarLine;
        size = new System.Drawing.Size(80, 23);
        button24.Size = size;
        this.cMeasureBarLine.TabIndex = 119;
        this.cMeasureBarLine.Tag = "5";
        this.cMeasureBarLine.Text = "FF000000";
        this.cMeasureBarLine.UseVisualStyleBackColor = true;
        this.cVerticalLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button25 = this.cVerticalLine;
        location = new System.Drawing.Point(204, 133);
        button25.Location = location;
        this.cVerticalLine.Name = "cVerticalLine";
        System.Windows.Forms.Button button26 = this.cVerticalLine;
        size = new System.Drawing.Size(80, 23);
        button26.Size = size;
        this.cVerticalLine.TabIndex = 118;
        this.cVerticalLine.Tag = "4";
        this.cVerticalLine.Text = "FF000000";
        this.cVerticalLine.UseVisualStyleBackColor = true;
        this.cSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button27 = this.cSub;
        location = new System.Drawing.Point(204, 111);
        button27.Location = location;
        this.cSub.Name = "cSub";
        System.Windows.Forms.Button button28 = this.cSub;
        size = new System.Drawing.Size(80, 23);
        button28.Size = size;
        this.cSub.TabIndex = 117;
        this.cSub.Tag = "3";
        this.cSub.Text = "FF000000";
        this.cSub.UseVisualStyleBackColor = true;
        this.cGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button29 = this.cGrid;
        location = new System.Drawing.Point(204, 89);
        button29.Location = location;
        this.cGrid.Name = "cGrid";
        System.Windows.Forms.Button button30 = this.cGrid;
        size = new System.Drawing.Size(80, 23);
        button30.Size = size;
        this.cGrid.TabIndex = 116;
        this.cGrid.Tag = "2";
        this.cGrid.Text = "FF000000";
        this.cGrid.UseVisualStyleBackColor = true;
        this.cBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button31 = this.cBG;
        location = new System.Drawing.Point(204, 60);
        button31.Location = location;
        this.cBG.Name = "cBG";
        System.Windows.Forms.Button button32 = this.cBG;
        size = new System.Drawing.Size(80, 23);
        button32.Size = size;
        this.cBG.TabIndex = 115;
        this.cBG.Tag = "1";
        this.cBG.Text = "FF000000";
        this.cBG.UseVisualStyleBackColor = true;
        this.fColumnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button33 = this.fColumnTitle;
        location = new System.Drawing.Point(204, 38);
        button33.Location = location;
        this.fColumnTitle.Name = "fColumnTitle";
        System.Windows.Forms.Button button34 = this.fColumnTitle;
        size = new System.Drawing.Size(80, 23);
        button34.Size = size;
        this.fColumnTitle.TabIndex = 114;
        this.fColumnTitle.Tag = "0";
        this.fColumnTitle.Text = "Tahoma";
        this.fColumnTitle.UseVisualStyleBackColor = true;
        this.cColumnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button35 = this.cColumnTitle;
        location = new System.Drawing.Point(204, 16);
        button35.Location = location;
        this.cColumnTitle.Name = "cColumnTitle";
        System.Windows.Forms.Button button36 = this.cColumnTitle;
        size = new System.Drawing.Size(80, 23);
        button36.Size = size;
        this.cColumnTitle.TabIndex = 113;
        this.cColumnTitle.Tag = "0";
        this.cColumnTitle.Text = "FF000000";
        this.cColumnTitle.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label19 = this.Label40;
        location = new System.Drawing.Point(42, 159);
        label19.Location = location;
        this.Label40.Name = "Label40";
        System.Windows.Forms.Label label20 = this.Label40;
        size = new System.Drawing.Size(160, 15);
        label20.Size = size;
        this.Label40.TabIndex = 111;
        this.Label40.Text = "Measure BarLine";
        this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label21 = this.Label39;
        location = new System.Drawing.Point(315, 130);
        label21.Location = location;
        this.Label39.Name = "Label39";
        System.Windows.Forms.Label label22 = this.Label39;
        size = new System.Drawing.Size(220, 15);
        label22.Size = size;
        this.Label39.TabIndex = 110;
        this.Label39.Text = "LongNote Label Horizontal Shift";
        this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label23 = this.Label38;
        location = new System.Drawing.Point(315, 108);
        label23.Location = location;
        this.Label38.Name = "Label38";
        System.Windows.Forms.Label label24 = this.Label38;
        size = new System.Drawing.Size(220, 15);
        label24.Size = size;
        this.Label38.TabIndex = 109;
        this.Label38.Text = "Note Label Horizontal Shift";
        this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label25 = this.Label37;
        location = new System.Drawing.Point(42, 20);
        label25.Location = location;
        this.Label37.Name = "Label37";
        System.Windows.Forms.Label label26 = this.Label37;
        size = new System.Drawing.Size(160, 15);
        label26.Size = size;
        this.Label37.TabIndex = 103;
        this.Label37.Text = "Column Caption";
        this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label27 = this.Label88;
        location = new System.Drawing.Point(648, 152);
        label27.Location = location;
        this.Label88.Name = "Label88";
        System.Windows.Forms.Label label28 = this.Label88;
        size = new System.Drawing.Size(220, 15);
        label28.Size = size;
        this.Label88.TabIndex = 102;
        this.Label88.Text = "Time Selection BPM";
        this.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label29 = this.Label35;
        location = new System.Drawing.Point(315, 203);
        label29.Location = location;
        this.Label35.Name = "Label35";
        System.Windows.Forms.Label label30 = this.Label35;
        size = new System.Drawing.Size(220, 15);
        label30.Size = size;
        this.Label35.TabIndex = 101;
        this.Label35.Text = "Note Border on Selection";
        this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label31 = this.Label34;
        location = new System.Drawing.Point(315, 181);
        label31.Location = location;
        this.Label34.Name = "Label34";
        System.Windows.Forms.Label label32 = this.Label34;
        size = new System.Drawing.Size(220, 15);
        label32.Size = size;
        this.Label34.TabIndex = 100;
        this.Label34.Text = "Note Border on MouseOver";
        this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label33 = this.Label86;
        location = new System.Drawing.Point(648, 130);
        label33.Location = location;
        this.Label86.Name = "Label86";
        System.Windows.Forms.Label label34 = this.Label86;
        size = new System.Drawing.Size(220, 15);
        label34.Size = size;
        this.Label86.TabIndex = 99;
        this.Label86.Text = "Time Selection Fill";
        this.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label35 = this.Label98;
        location = new System.Drawing.Point(648, 42);
        label35.Location = location;
        this.Label98.Name = "Label98";
        System.Windows.Forms.Label label36 = this.Label98;
        size = new System.Drawing.Size(220, 15);
        label36.Size = size;
        this.Label98.TabIndex = 98;
        this.Label98.Text = "Time Selection Cursor";
        this.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label37 = this.Label31;
        location = new System.Drawing.Point(648, 20);
        label37.Location = location;
        this.Label31.Name = "Label31";
        System.Windows.Forms.Label label38 = this.Label31;
        size = new System.Drawing.Size(220, 15);
        label38.Size = size;
        this.Label31.TabIndex = 97;
        this.Label31.Text = "Selection Box Border";
        this.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label39 = this.Label30;
        location = new System.Drawing.Point(42, 64);
        label39.Location = location;
        this.Label30.Name = "Label30";
        System.Windows.Forms.Label label40 = this.Label30;
        size = new System.Drawing.Size(160, 15);
        label40.Size = size;
        this.Label30.TabIndex = 96;
        this.Label30.Text = "Background";
        this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label41 = this.Label29;
        location = new System.Drawing.Point(42, 137);
        label41.Location = location;
        this.Label29.Name = "Label29";
        System.Windows.Forms.Label label42 = this.Label29;
        size = new System.Drawing.Size(160, 15);
        label42.Size = size;
        this.Label29.TabIndex = 95;
        this.Label29.Text = "Vertical Line";
        this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label43 = this.Label28;
        location = new System.Drawing.Point(315, 64);
        label43.Location = location;
        this.Label28.Name = "Label28";
        System.Windows.Forms.Label label44 = this.Label28;
        size = new System.Drawing.Size(220, 15);
        label44.Size = size;
        this.Label28.TabIndex = 94;
        this.Label28.Text = "Measure Label";
        this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label45 = this.Label27;
        location = new System.Drawing.Point(42, 115);
        label45.Location = location;
        this.Label27.Name = "Label27";
        System.Windows.Forms.Label label46 = this.Label27;
        size = new System.Drawing.Size(160, 15);
        label46.Size = size;
        this.Label27.TabIndex = 93;
        this.Label27.Text = "Sub";
        this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label47 = this.Label26;
        location = new System.Drawing.Point(42, 93);
        label47.Location = location;
        this.Label26.Name = "Label26";
        System.Windows.Forms.Label label48 = this.Label26;
        size = new System.Drawing.Size(160, 15);
        label48.Size = size;
        this.Label26.TabIndex = 92;
        this.Label26.Text = "Grid";
        this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label49 = this.Label25;
        location = new System.Drawing.Point(315, 86);
        label49.Location = location;
        this.Label25.Name = "Label25";
        System.Windows.Forms.Label label50 = this.Label25;
        size = new System.Drawing.Size(220, 15);
        label50.Size = size;
        this.Label25.TabIndex = 91;
        this.Label25.Text = "Note Label Vertical Shift";
        this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label51 = this.Label24;
        location = new System.Drawing.Point(315, 42);
        label51.Location = location;
        this.Label24.Name = "Label24";
        System.Windows.Forms.Label label52 = this.Label24;
        size = new System.Drawing.Size(220, 15);
        label52.Size = size;
        this.Label24.TabIndex = 90;
        this.Label24.Text = "Note Label";
        this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label53 = this.Label22;
        location = new System.Drawing.Point(42, 181);
        label53.Location = location;
        this.Label22.Name = "Label22";
        System.Windows.Forms.Label label54 = this.Label22;
        size = new System.Drawing.Size(160, 15);
        label54.Size = size;
        this.Label22.TabIndex = 88;
        this.Label22.Text = "BGM Waveform";
        this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label55 = this.Label21;
        location = new System.Drawing.Point(315, 20);
        label55.Location = location;
        this.Label21.Name = "Label21";
        System.Windows.Forms.Label label56 = this.Label21;
        size = new System.Drawing.Size(220, 15);
        label56.Size = size;
        this.Label21.TabIndex = 87;
        this.Label21.Text = "Note Height";
        this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label57 = this.Label9;
        location = new System.Drawing.Point(42, 42);
        label57.Location = location;
        this.Label9.Name = "Label9";
        System.Windows.Forms.Label label58 = this.Label9;
        size = new System.Drawing.Size(160, 15);
        label58.Size = size;
        this.Label9.TabIndex = 139;
        this.Label9.Text = "Column Caption Font";
        this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.cTSSplitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button37 = this.cTSSplitter;
        location = new System.Drawing.Point(870, 60);
        button37.Location = location;
        this.cTSSplitter.Name = "cTSSplitter";
        System.Windows.Forms.Button button38 = this.cTSSplitter;
        size = new System.Drawing.Size(80, 23);
        button38.Size = size;
        this.cTSSplitter.TabIndex = 141;
        this.cTSSplitter.Tag = "9";
        this.cTSSplitter.Text = "FF000000";
        this.cTSSplitter.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label59 = this.Label97;
        location = new System.Drawing.Point(648, 64);
        label59.Location = location;
        this.Label97.Name = "Label97";
        System.Windows.Forms.Label label60 = this.Label97;
        size = new System.Drawing.Size(220, 15);
        label60.Size = size;
        this.Label97.TabIndex = 140;
        this.Label97.Text = "Time Selection Splitter";
        this.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label61 = this.Label96;
        location = new System.Drawing.Point(648, 86);
        label61.Location = location;
        this.Label96.Name = "Label96";
        System.Windows.Forms.Label label62 = this.Label96;
        size = new System.Drawing.Size(220, 15);
        label62.Size = size;
        this.Label96.TabIndex = 142;
        this.Label96.Text = "Time Selection Cursor Sensitivity";
        this.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.NumericUpDown numericUpDown12 = this.iTSSensitivity;
        location = new System.Drawing.Point(870, 82);
        numericUpDown12.Location = location;
        increment = (this.iTSSensitivity.Maximum = new decimal(new int[4] { 20, 0, 0, 0 }));
        this.iTSSensitivity.Name = "iTSSensitivity";
        System.Windows.Forms.NumericUpDown numericUpDown13 = this.iTSSensitivity;
        size = new System.Drawing.Size(80, 23);
        numericUpDown13.Size = size;
        this.iTSSensitivity.TabIndex = 143;
        this.iTSSensitivity.Tag = "0";
        increment = (this.iTSSensitivity.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
        this.cTSMouseOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        System.Windows.Forms.Button button39 = this.cTSMouseOver;
        location = new System.Drawing.Point(870, 104);
        button39.Location = location;
        this.cTSMouseOver.Name = "cTSMouseOver";
        System.Windows.Forms.Button button40 = this.cTSMouseOver;
        size = new System.Drawing.Size(80, 23);
        button40.Size = size;
        this.cTSMouseOver.TabIndex = 145;
        this.cTSMouseOver.Tag = "9";
        this.cTSMouseOver.Text = "FF000000";
        this.cTSMouseOver.UseVisualStyleBackColor = true;
        System.Windows.Forms.Label label63 = this.Label91;
        location = new System.Drawing.Point(648, 108);
        label63.Location = location;
        this.Label91.Name = "Label91";
        System.Windows.Forms.Label label64 = this.Label91;
        size = new System.Drawing.Size(220, 15);
        label64.Size = size;
        this.Label91.TabIndex = 144;
        this.Label91.Text = "Time Selection MouseOver Border";
        this.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label65 = this.Label82;
        location = new System.Drawing.Point(648, 174);
        label65.Location = location;
        this.Label82.Name = "Label82";
        System.Windows.Forms.Label label66 = this.Label82;
        size = new System.Drawing.Size(220, 15);
        label66.Size = size;
        this.Label82.TabIndex = 146;
        this.Label82.Text = "Time Selection BPM Font";
        this.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.Label label67 = this.Label14;
        location = new System.Drawing.Point(648, 203);
        label67.Location = location;
        this.Label14.Name = "Label14";
        System.Windows.Forms.Label label68 = this.Label14;
        size = new System.Drawing.Size(220, 15);
        label68.Size = size;
        this.Label14.TabIndex = 147;
        this.Label14.Text = "Middle Button Release Sensitivity";
        this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        System.Windows.Forms.NumericUpDown numericUpDown14 = this.iMiddleSensitivity;
        location = new System.Drawing.Point(870, 199);
        numericUpDown14.Location = location;
        increment = (this.iMiddleSensitivity.Maximum = new decimal(new int[4] { 1000000, 0, 0, 0 }));
        this.iMiddleSensitivity.Name = "iMiddleSensitivity";
        System.Windows.Forms.NumericUpDown numericUpDown15 = this.iMiddleSensitivity;
        size = new System.Drawing.Size(80, 23);
        numericUpDown15.Size = size;
        this.iMiddleSensitivity.TabIndex = 148;
        this.iMiddleSensitivity.Tag = "0";
        increment = (this.iMiddleSensitivity.Value = new decimal(new int[4] { 1, 0, 0, 0 }));
        this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        System.Windows.Forms.PictureBox pictureBox = this.PictureBox1;
        location = new System.Drawing.Point(10, 259);
        pictureBox.Location = location;
        this.PictureBox1.Name = "PictureBox1";
        System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox1;
        size = new System.Drawing.Size(1000, 1);
        pictureBox2.Size = size;
        this.PictureBox1.TabIndex = 138;
        this.PictureBox1.TabStop = false;
        this.AcceptButton = this.OK_Button;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.CancelButton = this.Cancel_Button;
        size = new System.Drawing.Size(1026, 713);
        this.ClientSize = size;
        this.Controls.Add(this.Label14);
        this.Controls.Add(this.iMiddleSensitivity);
        this.Controls.Add(this.Label82);
        this.Controls.Add(this.cTSMouseOver);
        this.Controls.Add(this.Label91);
        this.Controls.Add(this.Label96);
        this.Controls.Add(this.iTSSensitivity);
        this.Controls.Add(this.cTSSplitter);
        this.Controls.Add(this.Label97);
        this.Controls.Add(this.Label9);
        this.Controls.Add(this.PictureBox1);
        this.Controls.Add(this.Label33);
        this.Controls.Add(this.iHiddenNoteOpacity);
        this.Controls.Add(this.TableLayoutPanel1);
        this.Controls.Add(this.Label23);
        this.Controls.Add(this.Panel1);
        this.Controls.Add(this.cAdjustLengthBorder);
        this.Controls.Add(this.Label37);
        this.Controls.Add(this.cSelectedBorder);
        this.Controls.Add(this.Label21);
        this.Controls.Add(this.cMouseOver);
        this.Controls.Add(this.Label22);
        this.Controls.Add(this.iLongLabelHorizShift);
        this.Controls.Add(this.Label24);
        this.Controls.Add(this.iLabelHorizShift);
        this.Controls.Add(this.Label25);
        this.Controls.Add(this.iLabelVerticalShift);
        this.Controls.Add(this.Label26);
        this.Controls.Add(this.fMeasureLabel);
        this.Controls.Add(this.Label27);
        this.Controls.Add(this.fNoteLabel);
        this.Controls.Add(this.Label28);
        this.Controls.Add(this.iNoteHeight);
        this.Controls.Add(this.Label29);
        this.Controls.Add(this.fTSBPM);
        this.Controls.Add(this.Label30);
        this.Controls.Add(this.cTSBPM);
        this.Controls.Add(this.Label31);
        this.Controls.Add(this.cTSSelectionFill);
        this.Controls.Add(this.Label98);
        this.Controls.Add(this.cTSCursor);
        this.Controls.Add(this.Label86);
        this.Controls.Add(this.cSelectionBox);
        this.Controls.Add(this.Label34);
        this.Controls.Add(this.cWaveForm);
        this.Controls.Add(this.Label35);
        this.Controls.Add(this.cMeasureBarLine);
        this.Controls.Add(this.Label88);
        this.Controls.Add(this.cVerticalLine);
        this.Controls.Add(this.Label38);
        this.Controls.Add(this.cSub);
        this.Controls.Add(this.Label39);
        this.Controls.Add(this.cGrid);
        this.Controls.Add(this.Label40);
        this.Controls.Add(this.cBG);
        this.Controls.Add(this.cColumnTitle);
        this.Controls.Add(this.fColumnTitle);
        this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "OpVisual";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Visual Options";
        this.TableLayoutPanel1.ResumeLayout(false);
        this.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.iHiddenNoteOpacity).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.iLongLabelHorizShift).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.iLabelHorizShift).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.iLabelVerticalShift).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.iNoteHeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.iTSSensitivity).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.iMiddleSensitivity).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
        this.ResumeLayout(false);
    }

    public OpVisual(visualSettings xvo, Column[] xcol, Font monoFont)
    {
        base.Load += OpVisual_Load;
        niB = 27;
        lLeft = new int[28]
        {
            78, 110, 142, 174, 208, 240, 272, 304, 336, 368,
            400, 432, 464, 498, 530, 562, 594, 626, 658, 690,
            722, 754, 788, 820, 852, 884, 918, 950
        };
        InitializeComponent();
        vo = xvo;
        cButtonChange(cColumnTitle, vo.ColumnTitle.Color);
        cButtonChange(cBG, vo.Bg.Color);
        cButtonChange(cGrid, vo.pGrid.Color);
        cButtonChange(cSub, vo.pSub.Color);
        cButtonChange(cVerticalLine, vo.pVLine.Color);
        cButtonChange(cMeasureBarLine, vo.pMLine.Color);
        cButtonChange(cWaveForm, vo.pBGMWav.Color);
        cButtonChange(cMouseOver, vo.kMouseOver.Color);
        cButtonChange(cSelectedBorder, vo.kSelected.Color);
        cButtonChange(cAdjustLengthBorder, vo.kMouseOverE.Color);
        cButtonChange(cSelectionBox, vo.SelBox.Color);
        cButtonChange(cTSCursor, vo.PECursor.Color);
        cButtonChange(cTSSplitter, vo.PEHalf.Color);
        cButtonChange(cTSMouseOver, vo.PEMouseOver.Color);
        cButtonChange(cTSSelectionFill, vo.PESel.Color);
        cButtonChange(cTSBPM, vo.PEBPM.Color);
        fButtonChange(fColumnTitle, vo.ColumnTitleFont);
        fButtonChange(fNoteLabel, vo.kFont);
        fButtonChange(fMeasureLabel, vo.kMFont);
        fButtonChange(fTSBPM, vo.PEBPMFont);
        NumericUpDown self = iNoteHeight;
        Extensions.SetValClamped(self, new decimal(vo.kHeight));
        iNoteHeight = self;
        self = iLabelVerticalShift;
        Extensions.SetValClamped(self, new decimal(vo.kLabelVShift));
        iLabelVerticalShift = self;
        self = iLabelHorizShift;
        Extensions.SetValClamped(self, new decimal(vo.kLabelHShift));
        iLabelHorizShift = self;
        self = iLongLabelHorizShift;
        Extensions.SetValClamped(self, new decimal(vo.kLabelHShiftL));
        iLongLabelHorizShift = self;
        self = iHiddenNoteOpacity;
        Extensions.SetValClamped(self, new decimal(vo.kOpacity));
        iHiddenNoteOpacity = self;
        self = iTSSensitivity;
        Extensions.SetValClamped(self, new decimal(vo.PEDeltaMouseOver));
        iTSSensitivity = self;
        self = iMiddleSensitivity;
        Extensions.SetValClamped(self, new decimal(vo.MiddleDeltaRelease));
        iMiddleSensitivity = self;
        col = (Column[])xcol.Clone();
        checked
        {
            co = new ColumnOptionSet[Information.UBound(col) + 1];
            int num = Information.UBound(col);
            Color color = default(Color);
            for (int i = 0; i <= num; i++)
            {
                NumericUpDown numericUpDown = new NumericUpDown();
                NumericUpDown numericUpDown2 = numericUpDown;
                numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
                NumericUpDown numericUpDown3 = numericUpDown2;
                Point location = new Point(lLeft[i], 12);
                numericUpDown3.Location = location;
                numericUpDown2.Maximum = new decimal(999L);
                NumericUpDown numericUpDown4 = numericUpDown2;
                Size size = new Size(33, 23);
                numericUpDown4.Size = size;
                numericUpDown2.Value = new decimal(col[i].Width);
                numericUpDown2 = null;
                TextBox textBox = new TextBox();
                TextBox textBox2 = textBox;
                textBox2.BorderStyle = BorderStyle.FixedSingle;
                TextBox textBox3 = textBox2;
                location = new Point(lLeft[i], 34);
                textBox3.Location = location;
                TextBox textBox4 = textBox2;
                size = new Size(33, 23);
                textBox4.Size = size;
                textBox2.Text = col[i].Title;
                textBox2 = null;
                Button button = new Button();
                Button button2 = button;
                button2.FlatStyle = FlatStyle.Popup;
                button2.Font = monoFont;
                Button button3 = button2;
                location = new Point(lLeft[i], 63);
                button3.Location = location;
                Button button4 = button2;
                size = new Size(33, 66);
                button4.Size = size;
                button2.BackColor = Color.FromArgb(col[i].cNote);
                button2.ForeColor = col[i].cText;
                button2.Text = To4Hex(col[i].cNote);
                button2.Name = "cNote";
                button2 = null;
                Button button5 = new Button();
                Button button6 = button5;
                button6.FlatStyle = FlatStyle.Popup;
                button6.Font = monoFont;
                Button button7 = button6;
                location = new Point(lLeft[i], 128);
                button7.Location = location;
                Button button8 = button6;
                size = new Size(33, 66);
                button8.Size = size;
                button6.BackColor = Color.FromArgb(col[i].cNote);
                button6.ForeColor = col[i].cText;
                button6.Text = To4Hex(col[i].cText.ToArgb());
                button6.Name = "cText";
                button6 = null;
                button.Tag = button5;
                button5.Tag = button;
                Button button9 = new Button();
                Button button10 = button9;
                button10.FlatStyle = FlatStyle.Popup;
                button10.Font = monoFont;
                Button button11 = button10;
                location = new Point(lLeft[i], 193);
                button11.Location = location;
                Button button12 = button10;
                size = new Size(33, 66);
                button12.Size = size;
                button10.BackColor = Color.FromArgb(col[i].cLNote);
                button10.ForeColor = col[i].cLText;
                button10.Text = To4Hex(col[i].cLNote);
                button10.Name = "cNote";
                button10 = null;
                Button button13 = new Button();
                Button button14 = button13;
                button14.FlatStyle = FlatStyle.Popup;
                button14.Font = monoFont;
                Button button15 = button14;
                location = new Point(lLeft[i], 258);
                button15.Location = location;
                Button button16 = button14;
                size = new Size(33, 66);
                button16.Size = size;
                button14.BackColor = Color.FromArgb(col[i].cLNote);
                button14.ForeColor = col[i].cLText;
                button14.Text = To4Hex(col[i].cLText.ToArgb());
                button14.Name = "cText";
                button14 = null;
                button9.Tag = button13;
                button13.Tag = button9;
                Button button17 = new Button();
                Button button18 = button17;
                button18.FlatStyle = FlatStyle.Popup;
                button18.Font = monoFont;
                Button button19 = button18;
                location = new Point(lLeft[i], 323);
                button19.Location = location;
                Button button20 = button18;
                size = new Size(33, 66);
                button20.Size = size;
                button18.BackColor = col[i].cBG;
                Button button21 = button18;
                object obj = Interaction.IIf((int)Math.Round(col[i].cBG.GetBrightness() * 255f) + 255 - unchecked((int)col[i].cBG.A) >= 128, Color.Black, Color.White);
                button21.ForeColor = ((obj != null) ? ((Color)obj) : color);
                button18.Text = To4Hex(col[i].cBG.ToArgb());
                button18.Name = "cBG";
                button18.Tag = null;
                button18 = null;
                Panel1.Controls.Add(numericUpDown);
                Panel1.Controls.Add(textBox);
                Panel1.Controls.Add(button);
                Panel1.Controls.Add(button5);
                Panel1.Controls.Add(button9);
                Panel1.Controls.Add(button13);
                Panel1.Controls.Add(button17);
                co[i].Width = numericUpDown;
                co[i].Title = textBox;
                co[i].SNote = button;
                co[i].SText = button5;
                co[i].LNote = button9;
                co[i].LText = button13;
                co[i].BG = button17;
                button.Click += ButtonClick;
                button5.Click += ButtonClick;
                button9.Click += ButtonClick;
                button13.Click += ButtonClick;
                button17.Click += ButtonClick;
            }
        }
    }

    private void cButtonChange(Button xbutton, Color c)
    {
        xbutton.Text = Conversion.Hex(c.ToArgb());
        xbutton.BackColor = c;
        checked
        {
            object obj = Interaction.IIf((int)Math.Round(c.GetBrightness() * 255f) + 255 - unchecked((int)c.A) >= 128, Color.Black, Color.White);
            Color color = default(Color);
            xbutton.ForeColor = ((obj != null) ? ((Color)obj) : color);
        }
    }

    private void fButtonChange(Button xbutton, Font f)
    {
        xbutton.Text = f.FontFamily.Name;
        xbutton.Font = f;
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
        vo.ColumnTitle.Color = cColumnTitle.BackColor;
        vo.Bg.Color = cBG.BackColor;
        vo.pGrid.Color = cGrid.BackColor;
        vo.pSub.Color = cSub.BackColor;
        vo.pVLine.Color = cVerticalLine.BackColor;
        vo.pMLine.Color = cMeasureBarLine.BackColor;
        vo.pBGMWav.Color = cWaveForm.BackColor;
        vo.kMouseOver.Color = cMouseOver.BackColor;
        vo.kSelected.Color = cSelectedBorder.BackColor;
        vo.kMouseOverE.Color = cAdjustLengthBorder.BackColor;
        vo.SelBox.Color = cSelectionBox.BackColor;
        vo.PECursor.Color = cTSCursor.BackColor;
        vo.PEHalf.Color = cTSSplitter.BackColor;
        vo.PEMouseOver.Color = cTSMouseOver.BackColor;
        vo.PESel.Color = cTSSelectionFill.BackColor;
        vo.PEBPM.Color = cTSBPM.BackColor;
        vo.ColumnTitleFont = fColumnTitle.Font;
        vo.kFont = fNoteLabel.Font;
        vo.kMFont = fMeasureLabel.Font;
        vo.PEBPMFont = fTSBPM.Font;
        vo.kHeight = Convert.ToInt32(iNoteHeight.Value);
        vo.kLabelVShift = Convert.ToInt32(iLabelVerticalShift.Value);
        vo.kLabelHShift = Convert.ToInt32(iLabelHorizShift.Value);
        vo.kLabelHShiftL = Convert.ToInt32(iLongLabelHorizShift.Value);
        vo.kOpacity = Convert.ToSingle(iHiddenNoteOpacity.Value);
        vo.PEDeltaMouseOver = Convert.ToInt32(iTSSensitivity.Value);
        vo.MiddleDeltaRelease = Convert.ToInt32(iMiddleSensitivity.Value);
        MyProject.Forms.MainWindow.setVO(vo);
        int num = Information.UBound(co);
        for (int i = 0; i <= num; i = checked(i + 1))
        {
            col[i].Title = co[i].Title.Text;
            col[i].Width = Convert.ToInt32(co[i].Width.Value);
            col[i].setNoteColor(co[i].SNote.BackColor.ToArgb());
            col[i].cText = co[i].SText.ForeColor;
            col[i].setLNoteColor(co[i].LNote.BackColor.ToArgb());
            col[i].cLText = co[i].LText.ForeColor;
            col[i].cBG = co[i].BG.BackColor;
        }
        MyProject.Forms.MainWindow.column = col;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void OpVisual_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        Text = Strings.fopVisual.Title;
        Label37.Text = Strings.fopVisual.ColumnCaption;
        Label9.Text = Strings.fopVisual.ColumnCaptionFont;
        Label30.Text = Strings.fopVisual.Background;
        Label26.Text = Strings.fopVisual.Grid;
        Label27.Text = Strings.fopVisual.SubGrid;
        Label29.Text = Strings.fopVisual.VerticalLine;
        Label40.Text = Strings.fopVisual.MeasureBarLine;
        Label22.Text = Strings.fopVisual.BGMWaveform;
        Label21.Text = Strings.fopVisual.NoteHeight;
        Label24.Text = Strings.fopVisual.NoteLabel;
        Label28.Text = Strings.fopVisual.MeasureLabel;
        Label25.Text = Strings.fopVisual.LabelVerticalShift;
        Label38.Text = Strings.fopVisual.LabelHorizontalShift;
        Label39.Text = Strings.fopVisual.LongNoteLabelHorizontalShift;
        Label33.Text = Strings.fopVisual.HiddenNoteOpacity;
        Label34.Text = Strings.fopVisual.NoteBorderOnMouseOver;
        Label35.Text = Strings.fopVisual.NoteBorderOnSelection;
        Label23.Text = Strings.fopVisual.NoteBorderOnAdjustingLength;
        Label31.Text = Strings.fopVisual.SelectionBoxBorder;
        Label98.Text = Strings.fopVisual.TSCursor;
        Label97.Text = Strings.fopVisual.TSSplitter;
        Label96.Text = Strings.fopVisual.TSCursorSensitivity;
        Label91.Text = Strings.fopVisual.TSMouseOverBorder;
        Label86.Text = Strings.fopVisual.TSFill;
        Label88.Text = Strings.fopVisual.TSBPM;
        Label82.Text = Strings.fopVisual.TSBPMFont;
        Label14.Text = Strings.fopVisual.MiddleSensitivity;
        Label1.Text = Strings.fopVisual.Width;
        Label2.Text = Strings.fopVisual.Caption;
        Label4.Text = Strings.fopVisual.Note;
        Label6.Text = Strings.fopVisual.Label;
        Label5.Text = Strings.fopVisual.LongNote;
        Label7.Text = Strings.fopVisual.LongNoteLabel;
        Label8.Text = Strings.fopVisual.Bg;
    }

    private void BCClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        ColorPicker colorPicker = new ColorPicker();
        colorPicker.SetOrigColor(button.BackColor);
        if (colorPicker.ShowDialog(this) != DialogResult.Cancel)
        {
            cButtonChange(button, colorPicker.NewColor);
        }
    }

    private void BFClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        FontDialog fontDialog = new FontDialog();
        fontDialog.Font = button.Font;
        if (fontDialog.ShowDialog(this) != DialogResult.Cancel)
        {
            fButtonChange(button, fontDialog.Font);
        }
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        ColorPicker colorPicker = new ColorPicker();
        if (Operators.CompareString(button.Name, "cText", TextCompare: false) == 0)
        {
            colorPicker.SetOrigColor(button.ForeColor);
        }
        else
        {
            colorPicker.SetOrigColor(button.BackColor);
        }
        checked
        {
            if (colorPicker.ShowDialog(this) != DialogResult.Cancel)
            {
                button.Text = To4Hex(colorPicker.NewColor.ToArgb());
                switch (button.Name)
                {
                    case "cNote":
                        button.BackColor = colorPicker.NewColor;
                        ((Button)button.Tag).BackColor = colorPicker.NewColor;
                        break;
                    case "cText":
                        button.ForeColor = colorPicker.NewColor;
                        ((Button)button.Tag).ForeColor = colorPicker.NewColor;
                        break;
                    case "cBG":
                        {
                            button.BackColor = colorPicker.NewColor;
                            object obj = Interaction.IIf((int)Math.Round(colorPicker.NewColor.GetBrightness() * 255f) + 255 - unchecked((int)colorPicker.NewColor.A) >= 128, Color.Black, Color.White);
                            Color color = default(Color);
                            button.ForeColor = ((obj != null) ? ((Color)obj) : color);
                            break;
                        }
                }
            }
        }
    }

    private int[] ColorArrayToIntArray(Color[] xC)
    {
        checked
        {
            int[] array = new int[Information.UBound(xC) + 1];
            int num = Information.UBound(array);
            for (int i = 0; i <= num; i++)
            {
                array[i] = xC[i].ToArgb();
            }
            return array;
        }
    }

    private string To4Hex(int xInt)
    {
        Color color = Color.FromArgb(xInt);
        return Conversion.Hex(color.A) + "\r\n" + Conversion.Hex(color.R) + "\r\n" + Conversion.Hex(color.G) + "\r\n" + Conversion.Hex(color.B);
    }
}
