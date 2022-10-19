using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace iBMSC
{
    public partial class MainWindow
    {
        private IContainer components;
           internal virtual Panel POptionsScroll
    {
        get
        {
            return _POptionsScroll;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POptionsScroll = value;
        }
    }

    internal virtual ListBox LWAV
    {
        get
        {
            return _LWAV;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            KeyEventHandler value2 = LWAV_KeyDown;
            EventHandler value3 = LWAV_DoubleClick;
            EventHandler value4 = LWAV_Click;
            if (_LWAV != null)
            {
                _LWAV.KeyDown -= value2;
                _LWAV.DoubleClick -= value3;
                _LWAV.Click -= value4;
            }
            _LWAV = value;
            if (_LWAV != null)
            {
                _LWAV.KeyDown += value2;
                _LWAV.DoubleClick += value3;
                _LWAV.Click += value4;
            }
        }
    }

    internal virtual Timer Timer1
    {
        get
        {
            return _Timer1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Timer1_Tick;
            if (_Timer1 != null)
            {
                _Timer1.Tick -= value2;
            }
            _Timer1 = value;
            if (_Timer1 != null)
            {
                _Timer1.Tick += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem MInsert
    {
        get
        {
            return _MInsert;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = MInsert_Click;
            if (_MInsert != null)
            {
                _MInsert.Click -= value2;
            }
            _MInsert = value;
            if (_MInsert != null)
            {
                _MInsert.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem MRemove
    {
        get
        {
            return _MRemove;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = MRemove_Click;
            if (_MRemove != null)
            {
                _MRemove.Click -= value2;
            }
            _MRemove = value;
            if (_MRemove != null)
            {
                _MRemove.Click += value2;
            }
        }
    }

    internal virtual ContextMenuStrip Menu1
    {
        get
        {
            return _Menu1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Menu1 = value;
        }
    }

    internal virtual Timer AutoSaveTimer
    {
        get
        {
            return _AutoSaveTimer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = AutoSaveTimer_Tick;
            if (_AutoSaveTimer != null)
            {
                _AutoSaveTimer.Tick -= value2;
            }
            _AutoSaveTimer = value;
            if (_AutoSaveTimer != null)
            {
                _AutoSaveTimer.Tick += value2;
            }
        }
    }

    internal virtual MenuStrip mnMain
    {
        get
        {
            return _mnMain;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = mnMain_MouseDown;
            if (_mnMain != null)
            {
                _mnMain.MouseDown -= value2;
            }
            _mnMain = value;
            if (_mnMain != null)
            {
                _mnMain.MouseDown += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnFile
    {
        get
        {
            return _mnFile;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnFile = value;
        }
    }

    internal virtual ToolStripMenuItem mnNew
    {
        get
        {
            return _mnNew;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBNew_Click;
            if (_mnNew != null)
            {
                _mnNew.Click -= value2;
            }
            _mnNew = value;
            if (_mnNew != null)
            {
                _mnNew.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnOpen
    {
        get
        {
            return _mnOpen;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpen_ButtonClick;
            if (_mnOpen != null)
            {
                _mnOpen.Click -= value2;
            }
            _mnOpen = value;
            if (_mnOpen != null)
            {
                _mnOpen.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnImportSM
    {
        get
        {
            return _mnImportSM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBImportSM_Click;
            if (_mnImportSM != null)
            {
                _mnImportSM.Click -= value2;
            }
            _mnImportSM = value;
            if (_mnImportSM != null)
            {
                _mnImportSM.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnImportIBMSC
    {
        get
        {
            return _mnImportIBMSC;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBImportIBMSC_Click;
            if (_mnImportIBMSC != null)
            {
                _mnImportIBMSC.Click -= value2;
            }
            _mnImportIBMSC = value;
            if (_mnImportIBMSC != null)
            {
                _mnImportIBMSC.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator14
    {
        get
        {
            return _ToolStripSeparator14;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator14 = value;
        }
    }

    internal virtual ToolStripMenuItem mnSave
    {
        get
        {
            return _mnSave;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBSave_ButtonClick;
            if (_mnSave != null)
            {
                _mnSave.Click -= value2;
            }
            _mnSave = value;
            if (_mnSave != null)
            {
                _mnSave.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSaveAs
    {
        get
        {
            return _mnSaveAs;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBSaveAs_Click;
            if (_mnSaveAs != null)
            {
                _mnSaveAs.Click -= value2;
            }
            _mnSaveAs = value;
            if (_mnSaveAs != null)
            {
                _mnSaveAs.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnExport
    {
        get
        {
            return _mnExport;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBExport_Click;
            if (_mnExport != null)
            {
                _mnExport.Click -= value2;
            }
            _mnExport = value;
            if (_mnExport != null)
            {
                _mnExport.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator15
    {
        get
        {
            return _ToolStripSeparator15;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator15 = value;
        }
    }

    internal virtual ToolStripMenuItem mnOpenR0
    {
        get
        {
            return _mnOpenR0;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR0_Click;
            if (_mnOpenR0 != null)
            {
                _mnOpenR0.Click -= value2;
            }
            _mnOpenR0 = value;
            if (_mnOpenR0 != null)
            {
                _mnOpenR0.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnOpenR1
    {
        get
        {
            return _mnOpenR1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR1_Click;
            if (_mnOpenR1 != null)
            {
                _mnOpenR1.Click -= value2;
            }
            _mnOpenR1 = value;
            if (_mnOpenR1 != null)
            {
                _mnOpenR1.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnOpenR2
    {
        get
        {
            return _mnOpenR2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR2_Click;
            if (_mnOpenR2 != null)
            {
                _mnOpenR2.Click -= value2;
            }
            _mnOpenR2 = value;
            if (_mnOpenR2 != null)
            {
                _mnOpenR2.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnOpenR3
    {
        get
        {
            return _mnOpenR3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR3_Click;
            if (_mnOpenR3 != null)
            {
                _mnOpenR3.Click -= value2;
            }
            _mnOpenR3 = value;
            if (_mnOpenR3 != null)
            {
                _mnOpenR3.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnOpenR4
    {
        get
        {
            return _mnOpenR4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR4_Click;
            if (_mnOpenR4 != null)
            {
                _mnOpenR4.Click -= value2;
            }
            _mnOpenR4 = value;
            if (_mnOpenR4 != null)
            {
                _mnOpenR4.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator16
    {
        get
        {
            return _ToolStripSeparator16;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator16 = value;
        }
    }

    internal virtual ToolStripMenuItem mnQuit
    {
        get
        {
            return _mnQuit;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnQuit_Click;
            if (_mnQuit != null)
            {
                _mnQuit.Click -= value2;
            }
            _mnQuit = value;
            if (_mnQuit != null)
            {
                _mnQuit.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnEdit
    {
        get
        {
            return _mnEdit;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnEdit = value;
        }
    }

    internal virtual ToolStripMenuItem mnUndo
    {
        get
        {
            return _mnUndo;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBUndo_Click;
            if (_mnUndo != null)
            {
                _mnUndo.Click -= value2;
            }
            _mnUndo = value;
            if (_mnUndo != null)
            {
                _mnUndo.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnRedo
    {
        get
        {
            return _mnRedo;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBRedo_Click;
            if (_mnRedo != null)
            {
                _mnRedo.Click -= value2;
            }
            _mnRedo = value;
            if (_mnRedo != null)
            {
                _mnRedo.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator17
    {
        get
        {
            return _ToolStripSeparator17;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator17 = value;
        }
    }

    internal virtual ToolStripMenuItem mnCut
    {
        get
        {
            return _mnCut;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBCut_Click;
            if (_mnCut != null)
            {
                _mnCut.Click -= value2;
            }
            _mnCut = value;
            if (_mnCut != null)
            {
                _mnCut.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnCopy
    {
        get
        {
            return _mnCopy;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBCopy_Click;
            if (_mnCopy != null)
            {
                _mnCopy.Click -= value2;
            }
            _mnCopy = value;
            if (_mnCopy != null)
            {
                _mnCopy.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnPaste
    {
        get
        {
            return _mnPaste;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPaste_Click;
            if (_mnPaste != null)
            {
                _mnPaste.Click -= value2;
            }
            _mnPaste = value;
            if (_mnPaste != null)
            {
                _mnPaste.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator18
    {
        get
        {
            return _ToolStripSeparator18;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator18 = value;
        }
    }

    internal virtual ToolStripMenuItem mnFind
    {
        get
        {
            return _mnFind;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBFind_Click;
            if (_mnFind != null)
            {
                _mnFind.Click -= value2;
            }
            _mnFind = value;
            if (_mnFind != null)
            {
                _mnFind.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnStatistics
    {
        get
        {
            return _mnStatistics;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBStatistics_Click;
            if (_mnStatistics != null)
            {
                _mnStatistics.Click -= value2;
            }
            _mnStatistics = value;
            if (_mnStatistics != null)
            {
                _mnStatistics.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnDelete
    {
        get
        {
            return _mnDelete;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnDelete_Click;
            if (_mnDelete != null)
            {
                _mnDelete.Click -= value2;
            }
            _mnDelete = value;
            if (_mnDelete != null)
            {
                _mnDelete.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSelectAll
    {
        get
        {
            return _mnSelectAll;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSelectAll_Click;
            if (_mnSelectAll != null)
            {
                _mnSelectAll.Click -= value2;
            }
            _mnSelectAll = value;
            if (_mnSelectAll != null)
            {
                _mnSelectAll.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnMyO2
    {
        get
        {
            return _mnMyO2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBMyO2_Click;
            if (_mnMyO2 != null)
            {
                _mnMyO2.Click -= value2;
            }
            _mnMyO2 = value;
            if (_mnMyO2 != null)
            {
                _mnMyO2.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator19
    {
        get
        {
            return _ToolStripSeparator19;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator19 = value;
        }
    }

    internal virtual ToolStripMenuItem mnOptions
    {
        get
        {
            return _mnOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnOptions = value;
        }
    }

    internal virtual ToolStripMenuItem mnPreview
    {
        get
        {
            return _mnPreview;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnPreview = value;
        }
    }

    internal virtual ToolStripMenuItem mnPlayB
    {
        get
        {
            return _mnPlayB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPlayB_Click;
            if (_mnPlayB != null)
            {
                _mnPlayB.Click -= value2;
            }
            _mnPlayB = value;
            if (_mnPlayB != null)
            {
                _mnPlayB.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnPlay
    {
        get
        {
            return _mnPlay;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPlay_Click;
            if (_mnPlay != null)
            {
                _mnPlay.Click -= value2;
            }
            _mnPlay = value;
            if (_mnPlay != null)
            {
                _mnPlay.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnStop
    {
        get
        {
            return _mnStop;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBStop_Click;
            if (_mnStop != null)
            {
                _mnStop.Click -= value2;
            }
            _mnStop = value;
            if (_mnStop != null)
            {
                _mnStop.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnTimeSelect
    {
        get
        {
            return _mnTimeSelect;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPostEffects_Click;
            if (_mnTimeSelect != null)
            {
                _mnTimeSelect.Click -= value2;
            }
            _mnTimeSelect = value;
            if (_mnTimeSelect != null)
            {
                _mnTimeSelect.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSelect
    {
        get
        {
            return _mnSelect;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBSelect_Click;
            if (_mnSelect != null)
            {
                _mnSelect.Click -= value2;
            }
            _mnSelect = value;
            if (_mnSelect != null)
            {
                _mnSelect.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnWrite
    {
        get
        {
            return _mnWrite;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBWrite_Click;
            if (_mnWrite != null)
            {
                _mnWrite.Click -= value2;
            }
            _mnWrite = value;
            if (_mnWrite != null)
            {
                _mnWrite.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator23
    {
        get
        {
            return _ToolStripSeparator23;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator23 = value;
        }
    }

    internal virtual ToolStripMenuItem mnConversion
    {
        get
        {
            return _mnConversion;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnConversion = value;
        }
    }

    internal virtual ToolStripMenuItem mnErrorCheck
    {
        get
        {
            return _mnErrorCheck;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBErrorCheck_Click;
            if (_mnErrorCheck != null)
            {
                _mnErrorCheck.Click -= value2;
            }
            _mnErrorCheck = value;
            if (_mnErrorCheck != null)
            {
                _mnErrorCheck.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnPreviewOnClick
    {
        get
        {
            return _mnPreviewOnClick;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPreviewOnClick_Click;
            if (_mnPreviewOnClick != null)
            {
                _mnPreviewOnClick.Click -= value2;
            }
            _mnPreviewOnClick = value;
            if (_mnPreviewOnClick != null)
            {
                _mnPreviewOnClick.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnShowFileName
    {
        get
        {
            return _mnShowFileName;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBShowFileName_Click;
            if (_mnShowFileName != null)
            {
                _mnShowFileName.Click -= value2;
            }
            _mnShowFileName = value;
            if (_mnShowFileName != null)
            {
                _mnShowFileName.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator20
    {
        get
        {
            return _ToolStripSeparator20;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator20 = value;
        }
    }

    internal virtual ToolStripMenuItem mnGOptions
    {
        get
        {
            return _mnGOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBGOptions_Click;
            if (_mnGOptions != null)
            {
                _mnGOptions.Click -= value2;
            }
            _mnGOptions = value;
            if (_mnGOptions != null)
            {
                _mnGOptions.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnVOptions
    {
        get
        {
            return _mnVOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOptions_Click;
            if (_mnVOptions != null)
            {
                _mnVOptions.Click -= value2;
            }
            _mnVOptions = value;
            if (_mnVOptions != null)
            {
                _mnVOptions.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnLanguage
    {
        get
        {
            return _mnLanguage;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnLanguage = value;
        }
    }

    internal virtual ToolStripMenuItem mnTheme
    {
        get
        {
            return _mnTheme;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnTheme = value;
        }
    }

    internal virtual ContextMenuStrip cmnLanguage
    {
        get
        {
            return _cmnLanguage;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cmnLanguage = value;
        }
    }

    internal virtual ToolStripMenuItem TBLangDef
    {
        get
        {
            return _TBLangDef;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBLangDef_Click;
            if (_TBLangDef != null)
            {
                _TBLangDef.Click -= value2;
            }
            _TBLangDef = value;
            if (_TBLangDef != null)
            {
                _TBLangDef.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator9
    {
        get
        {
            return _ToolStripSeparator9;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator9 = value;
        }
    }

    internal virtual ContextMenuStrip cmnTheme
    {
        get
        {
            return _cmnTheme;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cmnTheme = value;
        }
    }

    internal virtual ToolStripMenuItem TBThemeDef
    {
        get
        {
            return _TBThemeDef;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBThemeDef_Click;
            if (_TBThemeDef != null)
            {
                _TBThemeDef.Click -= value2;
            }
            _TBThemeDef = value;
            if (_TBThemeDef != null)
            {
                _TBThemeDef.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBThemeSave
    {
        get
        {
            return _TBThemeSave;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBThemeSave_Click;
            if (_TBThemeSave != null)
            {
                _TBThemeSave.Click -= value2;
            }
            _TBThemeSave = value;
            if (_TBThemeSave != null)
            {
                _TBThemeSave.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBThemeRefresh
    {
        get
        {
            return _TBThemeRefresh;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBThemeRefresh_Click;
            if (_TBThemeRefresh != null)
            {
                _TBThemeRefresh.Click -= value2;
            }
            _TBThemeRefresh = value;
            if (_TBThemeRefresh != null)
            {
                _TBThemeRefresh.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator6
    {
        get
        {
            return _ToolStripSeparator6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator6 = value;
        }
    }

    internal virtual ContextMenuStrip cmnConversion
    {
        get
        {
            return _cmnConversion;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _cmnConversion = value;
        }
    }

    internal virtual ToolStripMenuItem POBLong
    {
        get
        {
            return _POBLong;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBLong_Click;
            if (_POBLong != null)
            {
                _POBLong.Click -= value2;
            }
            _POBLong = value;
            if (_POBLong != null)
            {
                _POBLong.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem POBShort
    {
        get
        {
            return _POBShort;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBNormal_Click;
            if (_POBShort != null)
            {
                _POBShort.Click -= value2;
            }
            _POBShort = value;
            if (_POBShort != null)
            {
                _POBShort.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem POBLongShort
    {
        get
        {
            return _POBLongShort;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBNormalLong_Click;
            if (_POBLongShort != null)
            {
                _POBLongShort.Click -= value2;
            }
            _POBLongShort = value;
            if (_POBLongShort != null)
            {
                _POBLongShort.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator10
    {
        get
        {
            return _ToolStripSeparator10;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator10 = value;
        }
    }

    internal virtual ToolStripMenuItem POBHidden
    {
        get
        {
            return _POBHidden;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBHidden_Click;
            if (_POBHidden != null)
            {
                _POBHidden.Click -= value2;
            }
            _POBHidden = value;
            if (_POBHidden != null)
            {
                _POBHidden.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem POBVisible
    {
        get
        {
            return _POBVisible;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBVisible_Click;
            if (_POBVisible != null)
            {
                _POBVisible.Click -= value2;
            }
            _POBVisible = value;
            if (_POBVisible != null)
            {
                _POBVisible.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem POBHiddenVisible
    {
        get
        {
            return _POBHiddenVisible;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBHiddenVisible_Click;
            if (_POBHiddenVisible != null)
            {
                _POBHiddenVisible.Click -= value2;
            }
            _POBHiddenVisible = value;
            if (_POBHiddenVisible != null)
            {
                _POBHiddenVisible.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator11
    {
        get
        {
            return _ToolStripSeparator11;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator11 = value;
        }
    }

    internal virtual ToolStripMenuItem POBMirror
    {
        get
        {
            return _POBMirror;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBMirror_Click;
            if (_POBMirror != null)
            {
                _POBMirror.Click -= value2;
            }
            _POBMirror = value;
            if (_POBMirror != null)
            {
                _POBMirror.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem POBModify
    {
        get
        {
            return _POBModify;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBModify_Click;
            if (_POBModify != null)
            {
                _POBModify.Click -= value2;
            }
            _POBModify = value;
            if (_POBModify != null)
            {
                _POBModify.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSys
    {
        get
        {
            return _mnSys;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _mnSys = value;
        }
    }

    internal virtual ToolStripMenuItem mnSMenu
    {
        get
        {
            return _mnSMenu;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSMenu_Click;
            if (_mnSMenu != null)
            {
                _mnSMenu.CheckedChanged -= value2;
            }
            _mnSMenu = value;
            if (_mnSMenu != null)
            {
                _mnSMenu.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSTB
    {
        get
        {
            return _mnSTB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSTB_Click;
            if (_mnSTB != null)
            {
                _mnSTB.CheckedChanged -= value2;
            }
            _mnSTB = value;
            if (_mnSTB != null)
            {
                _mnSTB.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSOP
    {
        get
        {
            return _mnSOP;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSOP_Click;
            if (_mnSOP != null)
            {
                _mnSOP.CheckedChanged -= value2;
            }
            _mnSOP = value;
            if (_mnSOP != null)
            {
                _mnSOP.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSStatus
    {
        get
        {
            return _mnSStatus;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSStatus_Click;
            if (_mnSStatus != null)
            {
                _mnSStatus.CheckedChanged -= value2;
            }
            _mnSStatus = value;
            if (_mnSStatus != null)
            {
                _mnSStatus.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSLSplitter
    {
        get
        {
            return _mnSLSplitter;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSLSplitter_Click;
            if (_mnSLSplitter != null)
            {
                _mnSLSplitter.CheckedChanged -= value2;
            }
            _mnSLSplitter = value;
            if (_mnSLSplitter != null)
            {
                _mnSLSplitter.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnSRSplitter
    {
        get
        {
            return _mnSRSplitter;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnSRSplitter_Click;
            if (_mnSRSplitter != null)
            {
                _mnSRSplitter.CheckedChanged -= value2;
            }
            _mnSRSplitter = value;
            if (_mnSRSplitter != null)
            {
                _mnSRSplitter.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnNTInput
    {
        get
        {
            return _mnNTInput;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBNTInput_Click;
            if (_mnNTInput != null)
            {
                _mnNTInput.Click -= value2;
            }
            _mnNTInput = value;
            if (_mnNTInput != null)
            {
                _mnNTInput.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBLangRefresh
    {
        get
        {
            return _TBLangRefresh;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBLangRefresh_Click;
            if (_TBLangRefresh != null)
            {
                _TBLangRefresh.Click -= value2;
            }
            _TBLangRefresh = value;
            if (_TBLangRefresh != null)
            {
                _TBLangRefresh.Click += value2;
            }
        }
    }

    internal virtual NumericUpDown CGSub
    {
        get
        {
            return _CGSub;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGSub_ValueChanged;
            if (_CGSub != null)
            {
                _CGSub.ValueChanged -= value2;
            }
            _CGSub = value;
            if (_CGSub != null)
            {
                _CGSub.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown CGDivide
    {
        get
        {
            return _CGDivide;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGDivide_ValueChanged;
            if (_CGDivide != null)
            {
                _CGDivide.ValueChanged -= value2;
            }
            _CGDivide = value;
            if (_CGDivide != null)
            {
                _CGDivide.ValueChanged += value2;
            }
        }
    }

    internal virtual PictureBox PictureBox7
    {
        get
        {
            return _PictureBox7;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox7 = value;
        }
    }

    internal virtual CheckBox CGSnap
    {
        get
        {
            return _CGSnap;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGSnap_CheckedChanged;
            if (_CGSnap != null)
            {
                _CGSnap.CheckedChanged -= value2;
            }
            _CGSnap = value;
            if (_CGSnap != null)
            {
                _CGSnap.CheckedChanged += value2;
            }
        }
    }

    internal virtual CheckBox BWLock
    {
        get
        {
            return _BWLock;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWLock_CheckedChanged;
            if (_BWLock != null)
            {
                _BWLock.CheckedChanged -= value2;
            }
            _BWLock = value;
            if (_BWLock != null)
            {
                _BWLock.CheckedChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown TWSaturation
    {
        get
        {
            return _TWSaturation;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWSaturation_ValueChanged;
            if (_TWSaturation != null)
            {
                _TWSaturation.ValueChanged -= value2;
            }
            _TWSaturation = value;
            if (_TWSaturation != null)
            {
                _TWSaturation.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown TWTransparency
    {
        get
        {
            return _TWTransparency;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWTransparency_ValueChanged;
            if (_TWTransparency != null)
            {
                _TWTransparency.ValueChanged -= value2;
            }
            _TWTransparency = value;
            if (_TWTransparency != null)
            {
                _TWTransparency.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown TWPrecision
    {
        get
        {
            return _TWPrecision;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWPrecision_ValueChanged;
            if (_TWPrecision != null)
            {
                _TWPrecision.ValueChanged -= value2;
            }
            _TWPrecision = value;
            if (_TWPrecision != null)
            {
                _TWPrecision.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown TWWidth
    {
        get
        {
            return _TWWidth;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWWidth_ValueChanged;
            if (_TWWidth != null)
            {
                _TWWidth.ValueChanged -= value2;
            }
            _TWWidth = value;
            if (_TWWidth != null)
            {
                _TWWidth.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown TWLeft
    {
        get
        {
            return _TWLeft;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWLeft_ValueChanged;
            if (_TWLeft != null)
            {
                _TWLeft.ValueChanged -= value2;
            }
            _TWLeft = value;
            if (_TWLeft != null)
            {
                _TWLeft.ValueChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown TWPosition
    {
        get
        {
            return _TWPosition;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWPosition_ValueChanged;
            if (_TWPosition != null)
            {
                _TWPosition.ValueChanged -= value2;
            }
            _TWPosition = value;
            if (_TWPosition != null)
            {
                _TWPosition.ValueChanged += value2;
            }
        }
    }

    internal virtual PictureBox PictureBox5
    {
        get
        {
            return _PictureBox5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox5 = value;
        }
    }

    internal virtual PictureBox PictureBox6
    {
        get
        {
            return _PictureBox6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox6 = value;
        }
    }

    internal virtual PictureBox PictureBox4
    {
        get
        {
            return _PictureBox4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox4 = value;
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

    internal virtual TrackBar TWSaturation2
    {
        get
        {
            return _TWSaturation2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWSaturation2_Scroll;
            if (_TWSaturation2 != null)
            {
                _TWSaturation2.Scroll -= value2;
            }
            _TWSaturation2 = value;
            if (_TWSaturation2 != null)
            {
                _TWSaturation2.Scroll += value2;
            }
        }
    }

    internal virtual TrackBar TWTransparency2
    {
        get
        {
            return _TWTransparency2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWTransparency2_Scroll;
            if (_TWTransparency2 != null)
            {
                _TWTransparency2.Scroll -= value2;
            }
            _TWTransparency2 = value;
            if (_TWTransparency2 != null)
            {
                _TWTransparency2.Scroll += value2;
            }
        }
    }

    internal virtual TrackBar TWPrecision2
    {
        get
        {
            return _TWPrecision2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWPrecision2_Scroll;
            if (_TWPrecision2 != null)
            {
                _TWPrecision2.Scroll -= value2;
            }
            _TWPrecision2 = value;
            if (_TWPrecision2 != null)
            {
                _TWPrecision2.Scroll += value2;
            }
        }
    }

    internal virtual TrackBar TWWidth2
    {
        get
        {
            return _TWWidth2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWWidth2_Scroll;
            if (_TWWidth2 != null)
            {
                _TWWidth2.Scroll -= value2;
            }
            _TWWidth2 = value;
            if (_TWWidth2 != null)
            {
                _TWWidth2.Scroll += value2;
            }
        }
    }

    internal virtual TrackBar TWLeft2
    {
        get
        {
            return _TWLeft2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWLeft2_Scroll;
            if (_TWLeft2 != null)
            {
                _TWLeft2.Scroll -= value2;
            }
            _TWLeft2 = value;
            if (_TWLeft2 != null)
            {
                _TWLeft2.Scroll += value2;
            }
        }
    }

    internal virtual TrackBar TWPosition2
    {
        get
        {
            return _TWPosition2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TWPosition2_Scroll;
            if (_TWPosition2 != null)
            {
                _TWPosition2.Scroll -= value2;
            }
            _TWPosition2 = value;
            if (_TWPosition2 != null)
            {
                _TWPosition2.Scroll += value2;
            }
        }
    }

    internal virtual TextBox TWFileName
    {
        get
        {
            return _TWFileName;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TWFileName = value;
        }
    }

    internal virtual Button BWClear
    {
        get
        {
            return _BWClear;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWClear_Click;
            if (_BWClear != null)
            {
                _BWClear.Click -= value2;
            }
            _BWClear = value;
            if (_BWClear != null)
            {
                _BWClear.Click += value2;
            }
        }
    }

    internal virtual Button BWLoad
    {
        get
        {
            return _BWLoad;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWLoad_Click;
            if (_BWLoad != null)
            {
                _BWLoad.Click -= value2;
            }
            _BWLoad = value;
            if (_BWLoad != null)
            {
                _BWLoad.Click += value2;
            }
        }
    }

    internal virtual ToolStrip TBMain
    {
        get
        {
            return _TBMain;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TBMain = value;
        }
    }

    internal virtual ToolStripButton TBNew
    {
        get
        {
            return _TBNew;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBNew_Click;
            if (_TBNew != null)
            {
                _TBNew.Click -= value2;
            }
            _TBNew = value;
            if (_TBNew != null)
            {
                _TBNew.Click += value2;
            }
        }
    }

    internal virtual ToolStripSplitButton TBOpen
    {
        get
        {
            return _TBOpen;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpen_ButtonClick;
            if (_TBOpen != null)
            {
                _TBOpen.ButtonClick -= value2;
            }
            _TBOpen = value;
            if (_TBOpen != null)
            {
                _TBOpen.ButtonClick += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBOpenR0
    {
        get
        {
            return _TBOpenR0;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR0_Click;
            if (_TBOpenR0 != null)
            {
                _TBOpenR0.Click -= value2;
            }
            _TBOpenR0 = value;
            if (_TBOpenR0 != null)
            {
                _TBOpenR0.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBOpenR1
    {
        get
        {
            return _TBOpenR1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR1_Click;
            if (_TBOpenR1 != null)
            {
                _TBOpenR1.Click -= value2;
            }
            _TBOpenR1 = value;
            if (_TBOpenR1 != null)
            {
                _TBOpenR1.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBOpenR2
    {
        get
        {
            return _TBOpenR2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR2_Click;
            if (_TBOpenR2 != null)
            {
                _TBOpenR2.Click -= value2;
            }
            _TBOpenR2 = value;
            if (_TBOpenR2 != null)
            {
                _TBOpenR2.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBOpenR3
    {
        get
        {
            return _TBOpenR3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR3_Click;
            if (_TBOpenR3 != null)
            {
                _TBOpenR3.Click -= value2;
            }
            _TBOpenR3 = value;
            if (_TBOpenR3 != null)
            {
                _TBOpenR3.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBOpenR4
    {
        get
        {
            return _TBOpenR4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOpenR4_Click;
            if (_TBOpenR4 != null)
            {
                _TBOpenR4.Click -= value2;
            }
            _TBOpenR4 = value;
            if (_TBOpenR4 != null)
            {
                _TBOpenR4.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator12
    {
        get
        {
            return _ToolStripSeparator12;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator12 = value;
        }
    }

    internal virtual ToolStripMenuItem TBImportSM
    {
        get
        {
            return _TBImportSM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBImportSM_Click;
            if (_TBImportSM != null)
            {
                _TBImportSM.Click -= value2;
            }
            _TBImportSM = value;
            if (_TBImportSM != null)
            {
                _TBImportSM.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBImportIBMSC
    {
        get
        {
            return _TBImportIBMSC;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBImportIBMSC_Click;
            if (_TBImportIBMSC != null)
            {
                _TBImportIBMSC.Click -= value2;
            }
            _TBImportIBMSC = value;
            if (_TBImportIBMSC != null)
            {
                _TBImportIBMSC.Click += value2;
            }
        }
    }

    internal virtual ToolStripSplitButton TBSave
    {
        get
        {
            return _TBSave;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBSave_ButtonClick;
            if (_TBSave != null)
            {
                _TBSave.ButtonClick -= value2;
            }
            _TBSave = value;
            if (_TBSave != null)
            {
                _TBSave.ButtonClick += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBSaveAs
    {
        get
        {
            return _TBSaveAs;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBSaveAs_Click;
            if (_TBSaveAs != null)
            {
                _TBSaveAs.Click -= value2;
            }
            _TBSaveAs = value;
            if (_TBSaveAs != null)
            {
                _TBSaveAs.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem TBExport
    {
        get
        {
            return _TBExport;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBExport_Click;
            if (_TBExport != null)
            {
                _TBExport.Click -= value2;
            }
            _TBExport = value;
            if (_TBExport != null)
            {
                _TBExport.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator1
    {
        get
        {
            return _ToolStripSeparator1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator1 = value;
        }
    }

    internal virtual ToolStripButton TBCut
    {
        get
        {
            return _TBCut;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBCut_Click;
            if (_TBCut != null)
            {
                _TBCut.Click -= value2;
            }
            _TBCut = value;
            if (_TBCut != null)
            {
                _TBCut.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBCopy
    {
        get
        {
            return _TBCopy;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBCopy_Click;
            if (_TBCopy != null)
            {
                _TBCopy.Click -= value2;
            }
            _TBCopy = value;
            if (_TBCopy != null)
            {
                _TBCopy.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBPaste
    {
        get
        {
            return _TBPaste;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPaste_Click;
            if (_TBPaste != null)
            {
                _TBPaste.Click -= value2;
            }
            _TBPaste = value;
            if (_TBPaste != null)
            {
                _TBPaste.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBFind
    {
        get
        {
            return _TBFind;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBFind_Click;
            if (_TBFind != null)
            {
                _TBFind.Click -= value2;
            }
            _TBFind = value;
            if (_TBFind != null)
            {
                _TBFind.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBStatistics
    {
        get
        {
            return _TBStatistics;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBStatistics_Click;
            if (_TBStatistics != null)
            {
                _TBStatistics.Click -= value2;
            }
            _TBStatistics = value;
            if (_TBStatistics != null)
            {
                _TBStatistics.Click += value2;
            }
        }
    }

    internal virtual Panel pStatus
    {
        get
        {
            return _pStatus;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _pStatus = value;
        }
    }

    internal virtual StatusStrip FStatus
    {
        get
        {
            return _FStatus;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FStatus = value;
        }
    }

    internal virtual ToolStripStatusLabel FSC
    {
        get
        {
            return _FSC;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSC = value;
        }
    }

    internal virtual ToolStripStatusLabel FSP1
    {
        get
        {
            return _FSP1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSP1 = value;
        }
    }

    internal virtual ToolStripStatusLabel FSP2
    {
        get
        {
            return _FSP2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSP2 = value;
        }
    }

    internal virtual ToolStripStatusLabel FSP3
    {
        get
        {
            return _FSP3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSP3 = value;
        }
    }

    internal virtual ToolStripStatusLabel FSP4
    {
        get
        {
            return _FSP4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSP4 = value;
        }
    }

    internal virtual ToolStripStatusLabel FST
    {
        get
        {
            return _FST;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FST = value;
        }
    }

    internal virtual ToolStripStatusLabel FSH
    {
        get
        {
            return _FSH;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSH = value;
        }
    }

    internal virtual ToolStripStatusLabel FSE
    {
        get
        {
            return _FSE;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSE = value;
        }
    }

    internal virtual StatusStrip FStatus2
    {
        get
        {
            return _FStatus2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FStatus2 = value;
        }
    }

    internal virtual ToolStripButton BVCReverse
    {
        get
        {
            return _BVCReverse;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BVCReverse_Click;
            if (_BVCReverse != null)
            {
                _BVCReverse.Click -= value2;
            }
            _BVCReverse = value;
            if (_BVCReverse != null)
            {
                _BVCReverse.Click += value2;
            }
        }
    }

    internal virtual ToolStripStatusLabel LblMultiply
    {
        get
        {
            return _LblMultiply;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _LblMultiply = value;
        }
    }

    internal virtual ToolStripTextBox TVCBPM
    {
        get
        {
            return _TVCBPM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TVCBPM_LostFocus;
            KeyEventHandler value3 = TVCBPM_KeyDown;
            if (_TVCBPM != null)
            {
                _TVCBPM.LostFocus -= value2;
                _TVCBPM.KeyDown -= value3;
            }
            _TVCBPM = value;
            if (_TVCBPM != null)
            {
                _TVCBPM.LostFocus += value2;
                _TVCBPM.KeyDown += value3;
            }
        }
    }

    internal virtual ToolStripTextBox TVCM
    {
        get
        {
            return _TVCM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TVCM_LostFocus;
            KeyEventHandler value3 = TVCM_KeyDown;
            if (_TVCM != null)
            {
                _TVCM.LostFocus -= value2;
                _TVCM.KeyDown -= value3;
            }
            _TVCM = value;
            if (_TVCM != null)
            {
                _TVCM.LostFocus += value2;
                _TVCM.KeyDown += value3;
            }
        }
    }

    internal virtual ToolStripStatusLabel LblDivide
    {
        get
        {
            return _LblDivide;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _LblDivide = value;
        }
    }

    internal virtual ToolStripTextBox TVCD
    {
        get
        {
            return _TVCD;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TVCD_LostFocus;
            KeyEventHandler value3 = TVCD_KeyDown;
            if (_TVCD != null)
            {
                _TVCD.LostFocus -= value2;
                _TVCD.KeyDown -= value3;
            }
            _TVCD = value;
            if (_TVCD != null)
            {
                _TVCD.LostFocus += value2;
                _TVCD.KeyDown += value3;
            }
        }
    }

    internal virtual ToolStripButton BVCApply
    {
        get
        {
            return _BVCApply;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BVCApply_Click;
            if (_BVCApply != null)
            {
                _BVCApply.Click -= value2;
            }
            _BVCApply = value;
            if (_BVCApply != null)
            {
                _BVCApply.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton BVCCalculate
    {
        get
        {
            return _BVCCalculate;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BVCCalculate_Click;
            if (_BVCCalculate != null)
            {
                _BVCCalculate.Click -= value2;
            }
            _BVCCalculate = value;
            if (_BVCCalculate != null)
            {
                _BVCCalculate.Click += value2;
            }
        }
    }

    internal virtual ToolStripStatusLabel FSW
    {
        get
        {
            return _FSW;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSW = value;
        }
    }

    internal virtual ToolStripButton FSSS
    {
        get
        {
            return _FSSS;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = FSSS_Click;
            if (_FSSS != null)
            {
                _FSSS.Click -= value2;
            }
            _FSSS = value;
            if (_FSSS != null)
            {
                _FSSS.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton FSSL
    {
        get
        {
            return _FSSL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = FSSL_Click;
            if (_FSSL != null)
            {
                _FSSL.Click -= value2;
            }
            _FSSL = value;
            if (_FSSL != null)
            {
                _FSSL.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton FSSH
    {
        get
        {
            return _FSSH;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = FSSH_Click;
            if (_FSSH != null)
            {
                _FSSH.Click -= value2;
            }
            _FSSH = value;
            if (_FSSH != null)
            {
                _FSSH.Click += value2;
            }
        }
    }

    internal virtual TextBox TExpansion
    {
        get
        {
            return _TExpansion;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_TExpansion != null)
            {
                _TExpansion.TextChanged -= value2;
            }
            _TExpansion = value;
            if (_TExpansion != null)
            {
                _TExpansion.TextChanged += value2;
            }
        }
    }

    internal virtual Timer TimerMiddle
    {
        get
        {
            return _TimerMiddle;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TimerMiddle_Tick;
            if (_TimerMiddle != null)
            {
                _TimerMiddle.Tick -= value2;
            }
            _TimerMiddle = value;
            if (_TimerMiddle != null)
            {
                _TimerMiddle.Tick += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator21
    {
        get
        {
            return _ToolStripSeparator21;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator21 = value;
        }
    }

    internal virtual ToolStripMenuItem CGShow
    {
        get
        {
            return _CGShow;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShow_CheckedChanged;
            if (_CGShow != null)
            {
                _CGShow.CheckedChanged -= value2;
            }
            _CGShow = value;
            if (_CGShow != null)
            {
                _CGShow.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGShowS
    {
        get
        {
            return _CGShowS;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShowS_CheckedChanged;
            if (_CGShowS != null)
            {
                _CGShowS.CheckedChanged -= value2;
            }
            _CGShowS = value;
            if (_CGShowS != null)
            {
                _CGShowS.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGShowBG
    {
        get
        {
            return _CGShowBG;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShowBG_CheckedChanged;
            if (_CGShowBG != null)
            {
                _CGShowBG.CheckedChanged -= value2;
            }
            _CGShowBG = value;
            if (_CGShowBG != null)
            {
                _CGShowBG.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGShowM
    {
        get
        {
            return _CGShowM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShowM_CheckedChanged;
            if (_CGShowM != null)
            {
                _CGShowM.CheckedChanged -= value2;
            }
            _CGShowM = value;
            if (_CGShowM != null)
            {
                _CGShowM.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGShowMB
    {
        get
        {
            return _CGShowMB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShowMB_CheckedChanged;
            if (_CGShowMB != null)
            {
                _CGShowMB.CheckedChanged -= value2;
            }
            _CGShowMB = value;
            if (_CGShowMB != null)
            {
                _CGShowMB.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGShowV
    {
        get
        {
            return _CGShowV;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShowV_CheckedChanged;
            if (_CGShowV != null)
            {
                _CGShowV.CheckedChanged -= value2;
            }
            _CGShowV = value;
            if (_CGShowV != null)
            {
                _CGShowV.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGShowC
    {
        get
        {
            return _CGShowC;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGShowC_CheckedChanged;
            if (_CGShowC != null)
            {
                _CGShowC.CheckedChanged -= value2;
            }
            _CGShowC = value;
            if (_CGShowC != null)
            {
                _CGShowC.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator22
    {
        get
        {
            return _ToolStripSeparator22;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator22 = value;
        }
    }

    internal virtual ToolStripMenuItem CGBLP
    {
        get
        {
            return _CGBLP;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGBLP_CheckedChanged;
            if (_CGBLP != null)
            {
                _CGBLP.CheckedChanged -= value2;
            }
            _CGBLP = value;
            if (_CGBLP != null)
            {
                _CGBLP.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGSTOP
    {
        get
        {
            return _CGSTOP;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGSTOP_CheckedChanged;
            if (_CGSTOP != null)
            {
                _CGSTOP.CheckedChanged -= value2;
            }
            _CGSTOP = value;
            if (_CGSTOP != null)
            {
                _CGSTOP.CheckedChanged += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem CGSCROLL
    {
        get
        {
            return _CGSCROLL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGSCROLL_CheckedChanged;
            if (_CGSCROLL != null)
            {
                _CGSCROLL.CheckedChanged -= value2;
            }
            _CGSCROLL = value;
            if (_CGSCROLL != null)
            {
                _CGSCROLL.CheckedChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown nBeatN
    {
        get
        {
            return _nBeatN;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _nBeatN = value;
        }
    }

    internal virtual ListBox LBeat
    {
        get
        {
            return _LBeat;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _LBeat = value;
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

    internal virtual Button BBeatApply
    {
        get
        {
            return _BBeatApply;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BBeatApply_Click;
            if (_BBeatApply != null)
            {
                _BBeatApply.Click -= value2;
            }
            _BBeatApply = value;
            if (_BBeatApply != null)
            {
                _BBeatApply.Click += value2;
            }
        }
    }

    internal virtual ToolStripMenuItem mnPOptions
    {
        get
        {
            return _mnPOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPOptions_Click;
            if (_mnPOptions != null)
            {
                _mnPOptions.Click -= value2;
            }
            _mnPOptions = value;
            if (_mnPOptions != null)
            {
                _mnPOptions.Click += value2;
            }
        }
    }

    internal virtual ToolStripContainer ToolStripContainer1
    {
        get
        {
            return _ToolStripContainer1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripContainer1 = value;
        }
    }

    internal virtual Panel PMain
    {
        get
        {
            return _PMain;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PMain = value;
        }
    }

    internal virtual Panel PMainIn
    {
        get
        {
            return _PMainIn;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = PMain_Scroll;
            EventHandler value3 = PMainInMouseLeave;
            PreviewKeyDownEventHandler value4 = PMainInPreviewKeyDown;
            EventHandler value5 = PMainInMouseEnter;
            MouseEventHandler value6 = PMainInMouseMove;
            MouseEventHandler value7 = PMainInMouseDown;
            EventHandler value8 = PMainInLostFocus;
            EventHandler value9 = PMainInResize;
            PaintEventHandler value10 = PMainInPaint;
            MouseEventHandler value11 = PMainInMouseWheel;
            MouseEventHandler value12 = PMainInMouseUp;
            if (_PMainIn != null)
            {
                _PMainIn.MouseWheel -= value2;
                _PMainIn.MouseLeave -= value3;
                _PMainIn.PreviewKeyDown -= value4;
                _PMainIn.MouseEnter -= value5;
                _PMainIn.MouseMove -= value6;
                _PMainIn.MouseDown -= value7;
                _PMainIn.LostFocus -= value8;
                _PMainIn.Resize -= value9;
                _PMainIn.Paint -= value10;
                _PMainIn.MouseWheel -= value11;
                _PMainIn.MouseUp -= value12;
            }
            _PMainIn = value;
            if (_PMainIn != null)
            {
                _PMainIn.MouseWheel += value2;
                _PMainIn.MouseLeave += value3;
                _PMainIn.PreviewKeyDown += value4;
                _PMainIn.MouseEnter += value5;
                _PMainIn.MouseMove += value6;
                _PMainIn.MouseDown += value7;
                _PMainIn.LostFocus += value8;
                _PMainIn.Resize += value9;
                _PMainIn.Paint += value10;
                _PMainIn.MouseWheel += value11;
                _PMainIn.MouseUp += value12;
            }
        }
    }

    internal virtual VScrollBar MainPanelScroll
    {
        get
        {
            return _MainPanelScroll;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = VSValueChanged;
            EventHandler value3 = VSGotFocus;
            if (_MainPanelScroll != null)
            {
                _MainPanelScroll.ValueChanged -= value2;
                _MainPanelScroll.GotFocus -= value3;
            }
            _MainPanelScroll = value;
            if (_MainPanelScroll != null)
            {
                _MainPanelScroll.ValueChanged += value2;
                _MainPanelScroll.GotFocus += value3;
            }
        }
    }

    internal virtual HScrollBar HS
    {
        get
        {
            return _HS;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = HSValueChanged;
            EventHandler value3 = HSGotFocus;
            if (_HS != null)
            {
                _HS.ValueChanged -= value2;
                _HS.GotFocus -= value3;
            }
            _HS = value;
            if (_HS != null)
            {
                _HS.ValueChanged += value2;
                _HS.GotFocus += value3;
            }
        }
    }

    internal virtual Panel PMainR
    {
        get
        {
            return _PMainR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PMainR = value;
        }
    }

    internal virtual Panel PMainInR
    {
        get
        {
            return _PMainInR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = PMain_Scroll;
            EventHandler value3 = PMainInMouseLeave;
            PreviewKeyDownEventHandler value4 = PMainInPreviewKeyDown;
            EventHandler value5 = PMainInMouseEnter;
            MouseEventHandler value6 = PMainInMouseMove;
            MouseEventHandler value7 = PMainInMouseDown;
            EventHandler value8 = PMainInLostFocus;
            EventHandler value9 = PMainInResize;
            PaintEventHandler value10 = PMainInPaint;
            MouseEventHandler value11 = PMainInMouseWheel;
            MouseEventHandler value12 = PMainInMouseUp;
            if (_PMainInR != null)
            {
                _PMainInR.MouseWheel -= value2;
                _PMainInR.MouseLeave -= value3;
                _PMainInR.PreviewKeyDown -= value4;
                _PMainInR.MouseEnter -= value5;
                _PMainInR.MouseMove -= value6;
                _PMainInR.MouseDown -= value7;
                _PMainInR.LostFocus -= value8;
                _PMainInR.Resize -= value9;
                _PMainInR.Paint -= value10;
                _PMainInR.MouseWheel -= value11;
                _PMainInR.MouseUp -= value12;
            }
            _PMainInR = value;
            if (_PMainInR != null)
            {
                _PMainInR.MouseWheel += value2;
                _PMainInR.MouseLeave += value3;
                _PMainInR.PreviewKeyDown += value4;
                _PMainInR.MouseEnter += value5;
                _PMainInR.MouseMove += value6;
                _PMainInR.MouseDown += value7;
                _PMainInR.LostFocus += value8;
                _PMainInR.Resize += value9;
                _PMainInR.Paint += value10;
                _PMainInR.MouseWheel += value11;
                _PMainInR.MouseUp += value12;
            }
        }
    }

    internal virtual VScrollBar RightPanelScroll
    {
        get
        {
            return _RightPanelScroll;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = VSValueChanged;
            EventHandler value3 = VSGotFocus;
            if (_RightPanelScroll != null)
            {
                _RightPanelScroll.ValueChanged -= value2;
                _RightPanelScroll.GotFocus -= value3;
            }
            _RightPanelScroll = value;
            if (_RightPanelScroll != null)
            {
                _RightPanelScroll.ValueChanged += value2;
                _RightPanelScroll.GotFocus += value3;
            }
        }
    }

    internal virtual HScrollBar HSR
    {
        get
        {
            return _HSR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = HSValueChanged;
            EventHandler value3 = HSGotFocus;
            if (_HSR != null)
            {
                _HSR.ValueChanged -= value2;
                _HSR.GotFocus -= value3;
            }
            _HSR = value;
            if (_HSR != null)
            {
                _HSR.ValueChanged += value2;
                _HSR.GotFocus += value3;
            }
        }
    }

    internal virtual Panel PMainL
    {
        get
        {
            return _PMainL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PMainL = value;
        }
    }

    internal virtual Panel PMainInL
    {
        get
        {
            return _PMainInL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = PMain_Scroll;
            EventHandler value3 = PMainInMouseLeave;
            PreviewKeyDownEventHandler value4 = PMainInPreviewKeyDown;
            EventHandler value5 = PMainInMouseEnter;
            MouseEventHandler value6 = PMainInMouseMove;
            MouseEventHandler value7 = PMainInMouseDown;
            EventHandler value8 = PMainInLostFocus;
            EventHandler value9 = PMainInResize;
            PaintEventHandler value10 = PMainInPaint;
            MouseEventHandler value11 = PMainInMouseWheel;
            MouseEventHandler value12 = PMainInMouseUp;
            if (_PMainInL != null)
            {
                _PMainInL.MouseWheel -= value2;
                _PMainInL.MouseLeave -= value3;
                _PMainInL.PreviewKeyDown -= value4;
                _PMainInL.MouseEnter -= value5;
                _PMainInL.MouseMove -= value6;
                _PMainInL.MouseDown -= value7;
                _PMainInL.LostFocus -= value8;
                _PMainInL.Resize -= value9;
                _PMainInL.Paint -= value10;
                _PMainInL.MouseWheel -= value11;
                _PMainInL.MouseUp -= value12;
            }
            _PMainInL = value;
            if (_PMainInL != null)
            {
                _PMainInL.MouseWheel += value2;
                _PMainInL.MouseLeave += value3;
                _PMainInL.PreviewKeyDown += value4;
                _PMainInL.MouseEnter += value5;
                _PMainInL.MouseMove += value6;
                _PMainInL.MouseDown += value7;
                _PMainInL.LostFocus += value8;
                _PMainInL.Resize += value9;
                _PMainInL.Paint += value10;
                _PMainInL.MouseWheel += value11;
                _PMainInL.MouseUp += value12;
            }
        }
    }

    internal virtual VScrollBar LeftPanelScroll
    {
        get
        {
            return _LeftPanelScroll;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = VSValueChanged;
            EventHandler value3 = VSGotFocus;
            if (_LeftPanelScroll != null)
            {
                _LeftPanelScroll.ValueChanged -= value2;
                _LeftPanelScroll.GotFocus -= value3;
            }
            _LeftPanelScroll = value;
            if (_LeftPanelScroll != null)
            {
                _LeftPanelScroll.ValueChanged += value2;
                _LeftPanelScroll.GotFocus += value3;
            }
        }
    }

    internal virtual HScrollBar HSL
    {
        get
        {
            return _HSL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = HSValueChanged;
            EventHandler value3 = HSGotFocus;
            if (_HSL != null)
            {
                _HSL.ValueChanged -= value2;
                _HSL.GotFocus -= value3;
            }
            _HSL = value;
            if (_HSL != null)
            {
                _HSL.ValueChanged += value2;
                _HSL.GotFocus += value3;
            }
        }
    }

    internal virtual ToolStripDropDownButton POConvert
    {
        get
        {
            return _POConvert;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POConvert = value;
        }
    }

    internal virtual ToolStripDropDownButton TBLanguage
    {
        get
        {
            return _TBLanguage;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TBLanguage = value;
        }
    }

    internal virtual ToolStripDropDownButton TBTheme
    {
        get
        {
            return _TBTheme;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TBTheme = value;
        }
    }

    internal virtual ToolStripButton TBMyO2
    {
        get
        {
            return _TBMyO2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBMyO2_Click;
            if (_TBMyO2 != null)
            {
                _TBMyO2.Click -= value2;
            }
            _TBMyO2 = value;
            if (_TBMyO2 != null)
            {
                _TBMyO2.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator4
    {
        get
        {
            return _ToolStripSeparator4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator4 = value;
        }
    }

    internal virtual ToolStripButton TBErrorCheck
    {
        get
        {
            return _TBErrorCheck;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBErrorCheck_Click;
            if (_TBErrorCheck != null)
            {
                _TBErrorCheck.Click -= value2;
            }
            _TBErrorCheck = value;
            if (_TBErrorCheck != null)
            {
                _TBErrorCheck.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBPreviewOnClick
    {
        get
        {
            return _TBPreviewOnClick;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPreviewOnClick_Click;
            if (_TBPreviewOnClick != null)
            {
                _TBPreviewOnClick.Click -= value2;
            }
            _TBPreviewOnClick = value;
            if (_TBPreviewOnClick != null)
            {
                _TBPreviewOnClick.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBShowFileName
    {
        get
        {
            return _TBShowFileName;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBShowFileName_Click;
            if (_TBShowFileName != null)
            {
                _TBShowFileName.Click -= value2;
            }
            _TBShowFileName = value;
            if (_TBShowFileName != null)
            {
                _TBShowFileName.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator2
    {
        get
        {
            return _ToolStripSeparator2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator2 = value;
        }
    }

    internal virtual ToolStripButton TBUndo
    {
        get
        {
            return _TBUndo;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBUndo_Click;
            if (_TBUndo != null)
            {
                _TBUndo.Click -= value2;
            }
            _TBUndo = value;
            if (_TBUndo != null)
            {
                _TBUndo.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBRedo
    {
        get
        {
            return _TBRedo;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBRedo_Click;
            if (_TBRedo != null)
            {
                _TBRedo.Click -= value2;
            }
            _TBRedo = value;
            if (_TBRedo != null)
            {
                _TBRedo.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator5
    {
        get
        {
            return _ToolStripSeparator5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator5 = value;
        }
    }

    internal virtual ToolStripButton TBNTInput
    {
        get
        {
            return _TBNTInput;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBNTInput_Click;
            if (_TBNTInput != null)
            {
                _TBNTInput.Click -= value2;
            }
            _TBNTInput = value;
            if (_TBNTInput != null)
            {
                _TBNTInput.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBTimeSelect
    {
        get
        {
            return _TBTimeSelect;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPostEffects_Click;
            if (_TBTimeSelect != null)
            {
                _TBTimeSelect.Click -= value2;
            }
            _TBTimeSelect = value;
            if (_TBTimeSelect != null)
            {
                _TBTimeSelect.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBSelect
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

    internal virtual ToolStripButton TBWrite
    {
        get
        {
            return _TBWrite;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBWrite_Click;
            if (_TBWrite != null)
            {
                _TBWrite.Click -= value2;
            }
            _TBWrite = value;
            if (_TBWrite != null)
            {
                _TBWrite.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator3
    {
        get
        {
            return _ToolStripSeparator3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator3 = value;
        }
    }

    internal virtual ToolStripButton TBPlayB
    {
        get
        {
            return _TBPlayB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPlayB_Click;
            if (_TBPlayB != null)
            {
                _TBPlayB.Click -= value2;
            }
            _TBPlayB = value;
            if (_TBPlayB != null)
            {
                _TBPlayB.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBPlay
    {
        get
        {
            return _TBPlay;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPlay_Click;
            if (_TBPlay != null)
            {
                _TBPlay.Click -= value2;
            }
            _TBPlay = value;
            if (_TBPlay != null)
            {
                _TBPlay.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBStop
    {
        get
        {
            return _TBStop;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBStop_Click;
            if (_TBStop != null)
            {
                _TBStop.Click -= value2;
            }
            _TBStop = value;
            if (_TBStop != null)
            {
                _TBStop.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBPOptions
    {
        get
        {
            return _TBPOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBPOptions_Click;
            if (_TBPOptions != null)
            {
                _TBPOptions.Click -= value2;
            }
            _TBPOptions = value;
            if (_TBPOptions != null)
            {
                _TBPOptions.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator7
    {
        get
        {
            return _ToolStripSeparator7;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator7 = value;
        }
    }

    internal virtual ToolStripButton TBVOptions
    {
        get
        {
            return _TBVOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBOptions_Click;
            if (_TBVOptions != null)
            {
                _TBVOptions.Click -= value2;
            }
            _TBVOptions = value;
            if (_TBVOptions != null)
            {
                _TBVOptions.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton TBGOptions
    {
        get
        {
            return _TBGOptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBGOptions_Click;
            if (_TBGOptions != null)
            {
                _TBGOptions.Click -= value2;
            }
            _TBGOptions = value;
            if (_TBGOptions != null)
            {
                _TBGOptions.Click += value2;
            }
        }
    }

    internal virtual ToolStripButton POBStorm
    {
        get
        {
            return _POBStorm;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBStorm_Click;
            if (_POBStorm != null)
            {
                _POBStorm.Click -= value2;
            }
            _POBStorm = value;
            if (_POBStorm != null)
            {
                _POBStorm.Click += value2;
            }
        }
    }

    internal virtual Panel POptions
    {
        get
        {
            return _POptions;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POptions = value;
        }
    }

    internal virtual Panel POHeader
    {
        get
        {
            return _POHeader;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POHeader = value;
        }
    }

    internal virtual CheckBox POHeaderSwitch
    {
        get
        {
            return _POHeaderSwitch;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Switches_CheckedChanged;
            if (_POHeaderSwitch != null)
            {
                _POHeaderSwitch.CheckedChanged -= value2;
            }
            _POHeaderSwitch = value;
            if (_POHeaderSwitch != null)
            {
                _POHeaderSwitch.CheckedChanged += value2;
            }
        }
    }

    internal virtual Panel POGrid
    {
        get
        {
            return _POGrid;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POGrid = value;
        }
    }

    internal virtual CheckBox POGridSwitch
    {
        get
        {
            return _POGridSwitch;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Switches_CheckedChanged;
            if (_POGridSwitch != null)
            {
                _POGridSwitch.CheckedChanged -= value2;
            }
            _POGridSwitch = value;
            if (_POGridSwitch != null)
            {
                _POGridSwitch.CheckedChanged += value2;
            }
        }
    }

    internal virtual Panel POHeaderInner
    {
        get
        {
            return _POHeaderInner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POHeaderInner = value;
        }
    }

    internal virtual TableLayoutPanel POHeaderPart2
    {
        get
        {
            return _POHeaderPart2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POHeaderPart2 = value;
        }
    }

    internal virtual TextBox THExRank
    {
        get
        {
            return _THExRank;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THExRank != null)
            {
                _THExRank.TextChanged -= value2;
            }
            _THExRank = value;
            if (_THExRank != null)
            {
                _THExRank.TextChanged += value2;
            }
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

    internal virtual ComboBox CHLnObj
    {
        get
        {
            return _CHLnObj;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CHLnObj_SelectedIndexChanged;
            if (_CHLnObj != null)
            {
                _CHLnObj.SelectedIndexChanged -= value2;
            }
            _CHLnObj = value;
            if (_CHLnObj != null)
            {
                _CHLnObj.SelectedIndexChanged += value2;
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

    internal virtual TextBox THComment
    {
        get
        {
            return _THComment;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THComment != null)
            {
                _THComment.TextChanged -= value2;
            }
            _THComment = value;
            if (_THComment != null)
            {
                _THComment.TextChanged += value2;
            }
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

    internal virtual TextBox THTotal
    {
        get
        {
            return _THTotal;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THTotal != null)
            {
                _THTotal.TextChanged -= value2;
            }
            _THTotal = value;
            if (_THTotal != null)
            {
                _THTotal.TextChanged += value2;
            }
        }
    }

    internal virtual Label Label20
    {
        get
        {
            return _Label20;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label20 = value;
        }
    }

    internal virtual Button BHStageFile
    {
        get
        {
            return _BHStageFile;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BHStageFile_Click;
            if (_BHStageFile != null)
            {
                _BHStageFile.Click -= value2;
            }
            _BHStageFile = value;
            if (_BHStageFile != null)
            {
                _BHStageFile.Click += value2;
            }
        }
    }

    internal virtual Button BHBanner
    {
        get
        {
            return _BHBanner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BHStageFile_Click;
            if (_BHBanner != null)
            {
                _BHBanner.Click -= value2;
            }
            _BHBanner = value;
            if (_BHBanner != null)
            {
                _BHBanner.Click += value2;
            }
        }
    }

    internal virtual Label Label19
    {
        get
        {
            return _Label19;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label19 = value;
        }
    }

    internal virtual Button BHBackBMP
    {
        get
        {
            return _BHBackBMP;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BHStageFile_Click;
            if (_BHBackBMP != null)
            {
                _BHBackBMP.Click -= value2;
            }
            _BHBackBMP = value;
            if (_BHBackBMP != null)
            {
                _BHBackBMP.Click += value2;
            }
        }
    }

    internal virtual Label Label17
    {
        get
        {
            return _Label17;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label17 = value;
        }
    }

    internal virtual Label Label16
    {
        get
        {
            return _Label16;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Label16 = value;
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

    internal virtual TextBox THBackBMP
    {
        get
        {
            return _THBackBMP;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THBackBMP != null)
            {
                _THBackBMP.TextChanged -= value2;
            }
            _THBackBMP = value;
            if (_THBackBMP != null)
            {
                _THBackBMP.TextChanged += value2;
            }
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

    internal virtual TextBox THBanner
    {
        get
        {
            return _THBanner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THBanner != null)
            {
                _THBanner.TextChanged -= value2;
            }
            _THBanner = value;
            if (_THBanner != null)
            {
                _THBanner.TextChanged += value2;
            }
        }
    }

    internal virtual TextBox THStageFile
    {
        get
        {
            return _THStageFile;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THStageFile != null)
            {
                _THStageFile.TextChanged -= value2;
            }
            _THStageFile = value;
            if (_THStageFile != null)
            {
                _THStageFile.TextChanged += value2;
            }
        }
    }

    internal virtual TextBox THSubTitle
    {
        get
        {
            return _THSubTitle;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THSubTitle != null)
            {
                _THSubTitle.TextChanged -= value2;
            }
            _THSubTitle = value;
            if (_THSubTitle != null)
            {
                _THSubTitle.TextChanged += value2;
            }
        }
    }

    internal virtual TextBox THSubArtist
    {
        get
        {
            return _THSubArtist;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THSubArtist != null)
            {
                _THSubArtist.TextChanged -= value2;
            }
            _THSubArtist = value;
            if (_THSubArtist != null)
            {
                _THSubArtist.TextChanged += value2;
            }
        }
    }

    internal virtual CheckBox POHeaderExpander
    {
        get
        {
            return _POHeaderExpander;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Expanders_CheckChanged;
            if (_POHeaderExpander != null)
            {
                _POHeaderExpander.CheckedChanged -= value2;
            }
            _POHeaderExpander = value;
            if (_POHeaderExpander != null)
            {
                _POHeaderExpander.CheckedChanged += value2;
            }
        }
    }

    internal virtual TableLayoutPanel POHeaderPart1
    {
        get
        {
            return _POHeaderPart1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POHeaderPart1 = value;
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

    internal virtual TextBox THPlayLevel
    {
        get
        {
            return _THPlayLevel;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THPlayLevel != null)
            {
                _THPlayLevel.TextChanged -= value2;
            }
            _THPlayLevel = value;
            if (_THPlayLevel != null)
            {
                _THPlayLevel.TextChanged += value2;
            }
        }
    }

    internal virtual ComboBox CHRank
    {
        get
        {
            return _CHRank;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_CHRank != null)
            {
                _CHRank.SelectedIndexChanged -= value2;
            }
            _CHRank = value;
            if (_CHRank != null)
            {
                _CHRank.SelectedIndexChanged += value2;
            }
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

    internal virtual ComboBox CHPlayer
    {
        get
        {
            return _CHPlayer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CHPlayer_SelectedIndexChanged;
            if (_CHPlayer != null)
            {
                _CHPlayer.SelectedIndexChanged -= value2;
            }
            _CHPlayer = value;
            if (_CHPlayer != null)
            {
                _CHPlayer.SelectedIndexChanged += value2;
            }
        }
    }

    internal virtual ComboBox CHDifficulty
    {
        get
        {
            return _CHDifficulty;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_CHDifficulty != null)
            {
                _CHDifficulty.SelectedIndexChanged -= value2;
            }
            _CHDifficulty = value;
            if (_CHDifficulty != null)
            {
                _CHDifficulty.SelectedIndexChanged += value2;
            }
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

    internal virtual TextBox THGenre
    {
        get
        {
            return _THGenre;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THGenre != null)
            {
                _THGenre.TextChanged -= value2;
            }
            _THGenre = value;
            if (_THGenre != null)
            {
                _THGenre.TextChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown THBPM
    {
        get
        {
            return _THBPM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THBPM_ValueChanged;
            if (_THBPM != null)
            {
                _THBPM.ValueChanged -= value2;
            }
            _THBPM = value;
            if (_THBPM != null)
            {
                _THBPM.ValueChanged += value2;
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

    internal virtual TextBox THArtist
    {
        get
        {
            return _THArtist;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THArtist != null)
            {
                _THArtist.TextChanged -= value2;
            }
            _THArtist = value;
            if (_THArtist != null)
            {
                _THArtist.TextChanged += value2;
            }
        }
    }

    internal virtual TextBox THTitle
    {
        get
        {
            return _THTitle;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = THGenre_TextChanged;
            if (_THTitle != null)
            {
                _THTitle.TextChanged -= value2;
            }
            _THTitle = value;
            if (_THTitle != null)
            {
                _THTitle.TextChanged += value2;
            }
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

    internal virtual TableLayoutPanel POGridPart1
    {
        get
        {
            return _POGridPart1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POGridPart1 = value;
        }
    }

    internal virtual TableLayoutPanel TableLayoutPanel2
    {
        get
        {
            return _TableLayoutPanel2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel2 = value;
        }
    }

    internal virtual Panel POGridInner
    {
        get
        {
            return _POGridInner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POGridInner = value;
        }
    }

    internal virtual TableLayoutPanel POGridPart2
    {
        get
        {
            return _POGridPart2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POGridPart2 = value;
        }
    }

    internal virtual TableLayoutPanel TableLayoutPanel5
    {
        get
        {
            return _TableLayoutPanel5;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel5 = value;
        }
    }

    internal virtual CheckBox cVSLockR
    {
        get
        {
            return _cVSLockR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = cVSLock_CheckedChanged;
            if (_cVSLockR != null)
            {
                _cVSLockR.CheckedChanged -= value2;
            }
            _cVSLockR = value;
            if (_cVSLockR != null)
            {
                _cVSLockR.CheckedChanged += value2;
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

    internal virtual CheckBox cVSLock
    {
        get
        {
            return _cVSLock;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = cVSLock_CheckedChanged;
            if (_cVSLock != null)
            {
                _cVSLock.CheckedChanged -= value2;
            }
            _cVSLock = value;
            if (_cVSLock != null)
            {
                _cVSLock.CheckedChanged += value2;
            }
        }
    }

    internal virtual CheckBox cVSLockL
    {
        get
        {
            return _cVSLockL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = cVSLock_CheckedChanged;
            if (_cVSLockL != null)
            {
                _cVSLockL.CheckedChanged -= value2;
            }
            _cVSLockL = value;
            if (_cVSLockL != null)
            {
                _cVSLockL.CheckedChanged += value2;
            }
        }
    }

    internal virtual CheckBox CGDisableVertical
    {
        get
        {
            return _CGDisableVertical;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGDisableVertical_CheckedChanged;
            if (_CGDisableVertical != null)
            {
                _CGDisableVertical.CheckedChanged -= value2;
            }
            _CGDisableVertical = value;
            if (_CGDisableVertical != null)
            {
                _CGDisableVertical.CheckedChanged += value2;
            }
        }
    }

    internal virtual TableLayoutPanel TableLayoutPanel4
    {
        get
        {
            return _TableLayoutPanel4;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel4 = value;
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

    internal virtual NumericUpDown CGB
    {
        get
        {
            return _CGB;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGB_ValueChanged;
            if (_CGB != null)
            {
                _CGB.ValueChanged -= value2;
            }
            _CGB = value;
            if (_CGB != null)
            {
                _CGB.ValueChanged += value2;
            }
        }
    }

    internal virtual CheckBox POGridExpander
    {
        get
        {
            return _POGridExpander;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Expanders_CheckChanged;
            if (_POGridExpander != null)
            {
                _POGridExpander.CheckedChanged -= value2;
            }
            _POGridExpander = value;
            if (_POGridExpander != null)
            {
                _POGridExpander.CheckedChanged += value2;
            }
        }
    }

    internal virtual TableLayoutPanel TableLayoutPanel3
    {
        get
        {
            return _TableLayoutPanel3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel3 = value;
        }
    }

    internal virtual PictureBox PictureBox9
    {
        get
        {
            return _PictureBox9;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox9 = value;
        }
    }

    internal virtual TrackBar CGHeight2
    {
        get
        {
            return _CGHeight2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGHeight2_Scroll;
            if (_CGHeight2 != null)
            {
                _CGHeight2.Scroll -= value2;
            }
            _CGHeight2 = value;
            if (_CGHeight2 != null)
            {
                _CGHeight2.Scroll += value2;
            }
        }
    }

    internal virtual NumericUpDown CGHeight
    {
        get
        {
            return _CGHeight;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGHeight_ValueChanged;
            if (_CGHeight != null)
            {
                _CGHeight.ValueChanged -= value2;
            }
            _CGHeight = value;
            if (_CGHeight != null)
            {
                _CGHeight.ValueChanged += value2;
            }
        }
    }

    internal virtual PictureBox PictureBox10
    {
        get
        {
            return _PictureBox10;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _PictureBox10 = value;
        }
    }

    internal virtual TrackBar CGWidth2
    {
        get
        {
            return _CGWidth2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGWidth2_Scroll;
            if (_CGWidth2 != null)
            {
                _CGWidth2.Scroll -= value2;
            }
            _CGWidth2 = value;
            if (_CGWidth2 != null)
            {
                _CGWidth2.Scroll += value2;
            }
        }
    }

    internal virtual NumericUpDown CGWidth
    {
        get
        {
            return _CGWidth;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGWidth_ValueChanged;
            if (_CGWidth != null)
            {
                _CGWidth.ValueChanged -= value2;
            }
            _CGWidth = value;
            if (_CGWidth != null)
            {
                _CGWidth.ValueChanged += value2;
            }
        }
    }

    internal virtual Panel POWaveForm
    {
        get
        {
            return _POWaveForm;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POWaveForm = value;
        }
    }

    internal virtual CheckBox POWaveFormSwitch
    {
        get
        {
            return _POWaveFormSwitch;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Switches_CheckedChanged;
            if (_POWaveFormSwitch != null)
            {
                _POWaveFormSwitch.CheckedChanged -= value2;
            }
            _POWaveFormSwitch = value;
            if (_POWaveFormSwitch != null)
            {
                _POWaveFormSwitch.CheckedChanged += value2;
            }
        }
    }

    internal virtual Panel POWaveFormInner
    {
        get
        {
            return _POWaveFormInner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POWaveFormInner = value;
        }
    }

    internal virtual TableLayoutPanel POWaveFormPart2
    {
        get
        {
            return _POWaveFormPart2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POWaveFormPart2 = value;
        }
    }

    internal virtual CheckBox POWaveFormExpander
    {
        get
        {
            return _POWaveFormExpander;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Expanders_CheckChanged;
            if (_POWaveFormExpander != null)
            {
                _POWaveFormExpander.CheckedChanged -= value2;
            }
            _POWaveFormExpander = value;
            if (_POWaveFormExpander != null)
            {
                _POWaveFormExpander.CheckedChanged += value2;
            }
        }
    }

    internal virtual TableLayoutPanel POWaveFormPart1
    {
        get
        {
            return _POWaveFormPart1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POWaveFormPart1 = value;
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

    internal virtual TableLayoutPanel TableLayoutPanel6
    {
        get
        {
            return _TableLayoutPanel6;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel6 = value;
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

    internal virtual FlowLayoutPanel FlowLayoutPanel2
    {
        get
        {
            return _FlowLayoutPanel2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FlowLayoutPanel2 = value;
        }
    }

    internal virtual Panel POWAV
    {
        get
        {
            return _POWAV;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POWAV_Resize;
            EventHandler value3 = POWAV_DragLeave;
            DragEventHandler value4 = POWAV_DragEnter;
            DragEventHandler value5 = POWAV_DragDrop;
            if (_POWAV != null)
            {
                _POWAV.Resize -= value2;
                _POWAV.DragLeave -= value3;
                _POWAV.DragEnter -= value4;
                _POWAV.DragDrop -= value5;
            }
            _POWAV = value;
            if (_POWAV != null)
            {
                _POWAV.Resize += value2;
                _POWAV.DragLeave += value3;
                _POWAV.DragEnter += value4;
                _POWAV.DragDrop += value5;
            }
        }
    }

    internal virtual TableLayoutPanel POWAVInner
    {
        get
        {
            return _POWAVInner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POWAVInner = value;
        }
    }

    internal virtual CheckBox POWAVSwitch
    {
        get
        {
            return _POWAVSwitch;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Switches_CheckedChanged;
            if (_POWAVSwitch != null)
            {
                _POWAVSwitch.CheckedChanged -= value2;
            }
            _POWAVSwitch = value;
            if (_POWAVSwitch != null)
            {
                _POWAVSwitch.CheckedChanged += value2;
            }
        }
    }

    internal virtual Panel POBeat
    {
        get
        {
            return _POBeat;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POBeat_Resize;
            if (_POBeat != null)
            {
                _POBeat.Resize -= value2;
            }
            _POBeat = value;
            if (_POBeat != null)
            {
                _POBeat.Resize += value2;
            }
        }
    }

    internal virtual TableLayoutPanel POBeatInner
    {
        get
        {
            return _POBeatInner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POBeatInner = value;
        }
    }

    internal virtual CheckBox POBeatSwitch
    {
        get
        {
            return _POBeatSwitch;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Switches_CheckedChanged;
            if (_POBeatSwitch != null)
            {
                _POBeatSwitch.CheckedChanged -= value2;
            }
            _POBeatSwitch = value;
            if (_POBeatSwitch != null)
            {
                _POBeatSwitch.CheckedChanged += value2;
            }
        }
    }

    internal virtual FlowLayoutPanel FlowLayoutPanel3
    {
        get
        {
            return _FlowLayoutPanel3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FlowLayoutPanel3 = value;
        }
    }

    internal virtual Button BWAVUp
    {
        get
        {
            return _BWAVUp;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWAVUp_Click;
            if (_BWAVUp != null)
            {
                _BWAVUp.Click -= value2;
            }
            _BWAVUp = value;
            if (_BWAVUp != null)
            {
                _BWAVUp.Click += value2;
            }
        }
    }

    internal virtual Button BWAVDown
    {
        get
        {
            return _BWAVDown;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWAVDown_Click;
            if (_BWAVDown != null)
            {
                _BWAVDown.Click -= value2;
            }
            _BWAVDown = value;
            if (_BWAVDown != null)
            {
                _BWAVDown.Click += value2;
            }
        }
    }

    internal virtual Button BWAVBrowse
    {
        get
        {
            return _BWAVBrowse;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWAVBrowse_Click;
            if (_BWAVBrowse != null)
            {
                _BWAVBrowse.Click -= value2;
            }
            _BWAVBrowse = value;
            if (_BWAVBrowse != null)
            {
                _BWAVBrowse.Click += value2;
            }
        }
    }

    internal virtual Button BWAVRemove
    {
        get
        {
            return _BWAVRemove;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BWAVRemove_Click;
            if (_BWAVRemove != null)
            {
                _BWAVRemove.Click -= value2;
            }
            _BWAVRemove = value;
            if (_BWAVRemove != null)
            {
                _BWAVRemove.Click += value2;
            }
        }
    }

    internal virtual Panel POExpansion
    {
        get
        {
            return _POExpansion;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = POExpansion_Resize;
            if (_POExpansion != null)
            {
                _POExpansion.Resize -= value2;
            }
            _POExpansion = value;
            if (_POExpansion != null)
            {
                _POExpansion.Resize += value2;
            }
        }
    }

    internal virtual Panel POExpansionInner
    {
        get
        {
            return _POExpansionInner;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POExpansionInner = value;
        }
    }

    internal virtual CheckBox POExpansionSwitch
    {
        get
        {
            return _POExpansionSwitch;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Switches_CheckedChanged;
            if (_POExpansionSwitch != null)
            {
                _POExpansionSwitch.CheckedChanged -= value2;
            }
            _POExpansionSwitch = value;
            if (_POExpansionSwitch != null)
            {
                _POExpansionSwitch.CheckedChanged += value2;
            }
        }
    }

    internal virtual Button POWAVResizer
    {
        get
        {
            return _POWAVResizer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = POResizer_MouseMove;
            MouseEventHandler value3 = VerticalResizer_MouseDown;
            if (_POWAVResizer != null)
            {
                _POWAVResizer.MouseMove -= value2;
                _POWAVResizer.MouseDown -= value3;
            }
            _POWAVResizer = value;
            if (_POWAVResizer != null)
            {
                _POWAVResizer.MouseMove += value2;
                _POWAVResizer.MouseDown += value3;
            }
        }
    }

    internal virtual TableLayoutPanel TableLayoutPanel7
    {
        get
        {
            return _TableLayoutPanel7;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TableLayoutPanel7 = value;
        }
    }

    internal virtual Button POExpansionResizer
    {
        get
        {
            return _POExpansionResizer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = POResizer_MouseMove;
            MouseEventHandler value3 = VerticalResizer_MouseDown;
            if (_POExpansionResizer != null)
            {
                _POExpansionResizer.MouseMove -= value2;
                _POExpansionResizer.MouseDown -= value3;
            }
            _POExpansionResizer = value;
            if (_POExpansionResizer != null)
            {
                _POExpansionResizer.MouseMove += value2;
                _POExpansionResizer.MouseDown += value3;
            }
        }
    }

    internal virtual Button POBeatResizer
    {
        get
        {
            return _POBeatResizer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = POResizer_MouseMove;
            MouseEventHandler value3 = VerticalResizer_MouseDown;
            if (_POBeatResizer != null)
            {
                _POBeatResizer.MouseMove -= value2;
                _POBeatResizer.MouseDown -= value3;
            }
            _POBeatResizer = value;
            if (_POBeatResizer != null)
            {
                _POBeatResizer.MouseMove += value2;
                _POBeatResizer.MouseDown += value3;
            }
        }
    }

    internal virtual Button POptionsResizer
    {
        get
        {
            return _POptionsResizer;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = POptionsResizer_MouseMove;
            MouseEventHandler value3 = HorizontalResizer_MouseDown;
            if (_POptionsResizer != null)
            {
                _POptionsResizer.MouseMove -= value2;
                _POptionsResizer.MouseDown -= value3;
            }
            _POptionsResizer = value;
            if (_POptionsResizer != null)
            {
                _POptionsResizer.MouseMove += value2;
                _POptionsResizer.MouseDown += value3;
            }
        }
    }

    internal virtual Button SpR
    {
        get
        {
            return _SpR;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = SpR_MouseMove;
            MouseEventHandler value3 = HorizontalResizer_MouseDown;
            if (_SpR != null)
            {
                _SpR.MouseMove -= value2;
                _SpR.MouseDown -= value3;
            }
            _SpR = value;
            if (_SpR != null)
            {
                _SpR.MouseMove += value2;
                _SpR.MouseDown += value3;
            }
        }
    }

    internal virtual Button SpL
    {
        get
        {
            return _SpL;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            MouseEventHandler value2 = SpL_MouseMove;
            MouseEventHandler value3 = HorizontalResizer_MouseDown;
            if (_SpL != null)
            {
                _SpL.MouseMove -= value2;
                _SpL.MouseDown -= value3;
            }
            _SpL = value;
            if (_SpL != null)
            {
                _SpL.MouseMove += value2;
                _SpL.MouseDown += value3;
            }
        }
    }

    internal virtual ToolStripMenuItem TBThemeLoadComptability
    {
        get
        {
            return _TBThemeLoadComptability;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBThemeLoadComptability_Click;
            if (_TBThemeLoadComptability != null)
            {
                _TBThemeLoadComptability.Click -= value2;
            }
            _TBThemeLoadComptability = value;
            if (_TBThemeLoadComptability != null)
            {
                _TBThemeLoadComptability.Click += value2;
            }
        }
    }

    internal virtual CheckBox POWAVExpander
    {
        get
        {
            return _POWAVExpander;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Expanders_CheckChanged;
            if (_POWAVExpander != null)
            {
                _POWAVExpander.CheckedChanged -= value2;
            }
            _POWAVExpander = value;
            if (_POWAVExpander != null)
            {
                _POWAVExpander.CheckedChanged += value2;
            }
        }
    }

    internal virtual TableLayoutPanel POWAVPart2
    {
        get
        {
            return _POWAVPart2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POWAVPart2 = value;
        }
    }

    internal virtual CheckBox CWAVMultiSelect
    {
        get
        {
            return _CWAVMultiSelect;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CWAVMultiSelect_CheckedChanged;
            if (_CWAVMultiSelect != null)
            {
                _CWAVMultiSelect.CheckedChanged -= value2;
            }
            _CWAVMultiSelect = value;
            if (_CWAVMultiSelect != null)
            {
                _CWAVMultiSelect.CheckedChanged += value2;
            }
        }
    }

    internal virtual CheckBox CWAVChangeLabel
    {
        get
        {
            return _CWAVChangeLabel;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CWAVChangeLabel_CheckedChanged;
            if (_CWAVChangeLabel != null)
            {
                _CWAVChangeLabel.CheckedChanged -= value2;
            }
            _CWAVChangeLabel = value;
            if (_CWAVChangeLabel != null)
            {
                _CWAVChangeLabel.CheckedChanged += value2;
            }
        }
    }

    internal virtual NumericUpDown nBeatD
    {
        get
        {
            return _nBeatD;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _nBeatD = value;
        }
    }

    internal virtual Button BBeatApplyV
    {
        get
        {
            return _BBeatApplyV;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BBeatApplyV_Click;
            if (_BBeatApplyV != null)
            {
                _BBeatApplyV.Click -= value2;
            }
            _BBeatApplyV = value;
            if (_BBeatApplyV != null)
            {
                _BBeatApplyV.Click += value2;
            }
        }
    }

    internal virtual TextBox tBeatValue
    {
        get
        {
            return _tBeatValue;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = tBeatValue_LostFocus;
            if (_tBeatValue != null)
            {
                _tBeatValue.LostFocus -= value2;
            }
            _tBeatValue = value;
            if (_tBeatValue != null)
            {
                _tBeatValue.LostFocus += value2;
            }
        }
    }

    internal virtual CheckBox POBeatExpander
    {
        get
        {
            return _POBeatExpander;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = Expanders_CheckChanged;
            if (_POBeatExpander != null)
            {
                _POBeatExpander.CheckedChanged -= value2;
            }
            _POBeatExpander = value;
            if (_POBeatExpander != null)
            {
                _POBeatExpander.CheckedChanged += value2;
            }
        }
    }

    internal virtual TableLayoutPanel POBeatPart2
    {
        get
        {
            return _POBeatPart2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _POBeatPart2 = value;
        }
    }

    internal virtual RadioButton CBeatScale
    {
        get
        {
            return _CBeatScale;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CBeatPreserve_Click;
            if (_CBeatScale != null)
            {
                _CBeatScale.Click -= value2;
            }
            _CBeatScale = value;
            if (_CBeatScale != null)
            {
                _CBeatScale.Click += value2;
            }
        }
    }

    internal virtual RadioButton CBeatCut
    {
        get
        {
            return _CBeatCut;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CBeatPreserve_Click;
            if (_CBeatCut != null)
            {
                _CBeatCut.Click -= value2;
            }
            _CBeatCut = value;
            if (_CBeatCut != null)
            {
                _CBeatCut.Click += value2;
            }
        }
    }

    internal virtual RadioButton CBeatMeasure
    {
        get
        {
            return _CBeatMeasure;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CBeatPreserve_Click;
            if (_CBeatMeasure != null)
            {
                _CBeatMeasure.Click -= value2;
            }
            _CBeatMeasure = value;
            if (_CBeatMeasure != null)
            {
                _CBeatMeasure.Click += value2;
            }
        }
    }

    internal virtual RadioButton CBeatPreserve
    {
        get
        {
            return _CBeatPreserve;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CBeatPreserve_Click;
            if (_CBeatPreserve != null)
            {
                _CBeatPreserve.Click -= value2;
            }
            _CBeatPreserve = value;
            if (_CBeatPreserve != null)
            {
                _CBeatPreserve.Click += value2;
            }
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

    internal virtual ToolTip ToolTipUniversal
    {
        get
        {
            return _ToolTipUniversal;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolTipUniversal = value;
        }
    }

    internal virtual ToolStripMenuItem CGBPM
    {
        get
        {
            return _CGBPM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = CGBPM_CheckedChanged;
            if (_CGBPM != null)
            {
                _CGBPM.CheckedChanged -= value2;
            }
            _CGBPM = value;
            if (_CGBPM != null)
            {
                _CGBPM.CheckedChanged += value2;
            }
        }
    }

    internal virtual Button BGSlash
    {
        get
        {
            return _BGSlash;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BGSlash_Click;
            if (_BGSlash != null)
            {
                _BGSlash.Click -= value2;
            }
            _BGSlash = value;
            if (_BGSlash != null)
            {
                _BGSlash.Click += value2;
            }
        }
    }

    internal virtual ToolStripStatusLabel FSM
    {
        get
        {
            return _FSM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FSM = value;
        }
    }

    internal virtual ToolStripMenuItem mnGotoMeasure
    {
        get
        {
            return _mnGotoMeasure;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = mnGotoMeasure_Click;
            if (_mnGotoMeasure != null)
            {
                _mnGotoMeasure.Click -= value2;
            }
            _mnGotoMeasure = value;
            if (_mnGotoMeasure != null)
            {
                _mnGotoMeasure.Click += value2;
            }
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator24
    {
        get
        {
            return _ToolStripSeparator24;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator24 = value;
        }
    }

    internal virtual ToolStripSeparator ToolStripSeparator8
    {
        get
        {
            return _ToolStripSeparator8;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ToolStripSeparator8 = value;
        }
    }

    internal virtual ToolStripButton TBWavIncrease
    {
        get
        {
            return _TBWavIncrease;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = TBWavIncrease_Click;
            if (_TBWavIncrease != null)
            {
                _TBWavIncrease.Click -= value2;
            }
            _TBWavIncrease = value;
            if (_TBWavIncrease != null)
            {
                _TBWavIncrease.Click += value2;
            }
        }
    }

    internal virtual ToolStripStatusLabel TimeStatusLabel
    {
        get
        {
            return _TimeStatusLabel;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _TimeStatusLabel = value;
        }
    }

    internal virtual ToolStripButton BConvertStop
    {
        get
        {
            return _BConvertStop;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = BConvertStop_Click;
            if (_BConvertStop != null)
            {
                _BConvertStop.Click -= value2;
            }
            _BConvertStop = value;
            if (_BConvertStop != null)
            {
                _BConvertStop.Click += value2;
            }
        }
    }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(iBMSC.MainWindow));
            this.cmnLanguage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBLangDef = new System.Windows.Forms.ToolStripMenuItem();
            this.TBLangRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.TBLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnTheme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBThemeDef = new System.Windows.Forms.ToolStripMenuItem();
            this.TBThemeSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TBThemeRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TBThemeLoadComptability = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TBTheme = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.POptionsScroll = new System.Windows.Forms.Panel();
            this.POptions = new System.Windows.Forms.Panel();
            this.POExpansion = new System.Windows.Forms.Panel();
            this.POExpansionInner = new System.Windows.Forms.Panel();
            this.TExpansion = new System.Windows.Forms.TextBox();
            this.POExpansionResizer = new System.Windows.Forms.Button();
            this.POExpansionSwitch = new System.Windows.Forms.CheckBox();
            this.POBeat = new System.Windows.Forms.Panel();
            this.POBeatInner = new System.Windows.Forms.TableLayoutPanel();
            this.POBeatExpander = new System.Windows.Forms.CheckBox();
            this.POBeatResizer = new System.Windows.Forms.Button();
            this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.nBeatD = new System.Windows.Forms.NumericUpDown();
            this.BBeatApplyV = new System.Windows.Forms.Button();
            this.nBeatN = new System.Windows.Forms.NumericUpDown();
            this.BBeatApply = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.tBeatValue = new System.Windows.Forms.TextBox();
            this.LBeat = new System.Windows.Forms.ListBox();
            this.POBeatPart2 = new System.Windows.Forms.TableLayoutPanel();
            this.CBeatScale = new System.Windows.Forms.RadioButton();
            this.CBeatCut = new System.Windows.Forms.RadioButton();
            this.CBeatMeasure = new System.Windows.Forms.RadioButton();
            this.CBeatPreserve = new System.Windows.Forms.RadioButton();
            this.POBeatSwitch = new System.Windows.Forms.CheckBox();
            this.POWAV = new System.Windows.Forms.Panel();
            this.POWAVInner = new System.Windows.Forms.TableLayoutPanel();
            this.POWAVExpander = new System.Windows.Forms.CheckBox();
            this.LWAV = new System.Windows.Forms.ListBox();
            this.FlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BWAVUp = new System.Windows.Forms.Button();
            this.BWAVDown = new System.Windows.Forms.Button();
            this.BWAVBrowse = new System.Windows.Forms.Button();
            this.BWAVRemove = new System.Windows.Forms.Button();
            this.POWAVResizer = new System.Windows.Forms.Button();
            this.POWAVPart2 = new System.Windows.Forms.TableLayoutPanel();
            this.CWAVMultiSelect = new System.Windows.Forms.CheckBox();
            this.CWAVChangeLabel = new System.Windows.Forms.CheckBox();
            this.POWAVSwitch = new System.Windows.Forms.CheckBox();
            this.POWaveForm = new System.Windows.Forms.Panel();
            this.POWaveFormInner = new System.Windows.Forms.Panel();
            this.POWaveFormPart2 = new System.Windows.Forms.TableLayoutPanel();
            this.TWSaturation = new System.Windows.Forms.NumericUpDown();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TWTransparency = new System.Windows.Forms.NumericUpDown();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.TWPrecision = new System.Windows.Forms.NumericUpDown();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.TWWidth = new System.Windows.Forms.NumericUpDown();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.TWLeft = new System.Windows.Forms.NumericUpDown();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.TWSaturation2 = new System.Windows.Forms.TrackBar();
            this.TWLeft2 = new System.Windows.Forms.TrackBar();
            this.TWTransparency2 = new System.Windows.Forms.TrackBar();
            this.TWWidth2 = new System.Windows.Forms.TrackBar();
            this.TWPrecision2 = new System.Windows.Forms.TrackBar();
            this.POWaveFormExpander = new System.Windows.Forms.CheckBox();
            this.POWaveFormPart1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BWLoad = new System.Windows.Forms.Button();
            this.BWClear = new System.Windows.Forms.Button();
            this.BWLock = new System.Windows.Forms.CheckBox();
            this.TWFileName = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TWPosition2 = new System.Windows.Forms.TrackBar();
            this.TWPosition = new System.Windows.Forms.NumericUpDown();
            this.POWaveFormSwitch = new System.Windows.Forms.CheckBox();
            this.POGrid = new System.Windows.Forms.Panel();
            this.POGridInner = new System.Windows.Forms.Panel();
            this.POGridPart2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cVSLockL = new System.Windows.Forms.CheckBox();
            this.cVSLock = new System.Windows.Forms.CheckBox();
            this.cVSLockR = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.CGB = new System.Windows.Forms.NumericUpDown();
            this.POGridExpander = new System.Windows.Forms.CheckBox();
            this.POGridPart1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.CGHeight2 = new System.Windows.Forms.TrackBar();
            this.CGHeight = new System.Windows.Forms.NumericUpDown();
            this.PictureBox10 = new System.Windows.Forms.PictureBox();
            this.CGWidth2 = new System.Windows.Forms.TrackBar();
            this.CGWidth = new System.Windows.Forms.NumericUpDown();
            this.CGDisableVertical = new System.Windows.Forms.CheckBox();
            this.CGSnap = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.CGDivide = new System.Windows.Forms.NumericUpDown();
            this.CGSub = new System.Windows.Forms.NumericUpDown();
            this.BGSlash = new System.Windows.Forms.Button();
            this.POGridSwitch = new System.Windows.Forms.CheckBox();
            this.POHeader = new System.Windows.Forms.Panel();
            this.POHeaderInner = new System.Windows.Forms.Panel();
            this.POHeaderPart2 = new System.Windows.Forms.TableLayoutPanel();
            this.CHDifficulty = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.THExRank = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.CHLnObj = new System.Windows.Forms.ComboBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.THComment = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.THTotal = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.BHStageFile = new System.Windows.Forms.Button();
            this.BHBanner = new System.Windows.Forms.Button();
            this.Label19 = new System.Windows.Forms.Label();
            this.BHBackBMP = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.THBackBMP = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.THBanner = new System.Windows.Forms.TextBox();
            this.THStageFile = new System.Windows.Forms.TextBox();
            this.THSubTitle = new System.Windows.Forms.TextBox();
            this.THSubArtist = new System.Windows.Forms.TextBox();
            this.POHeaderExpander = new System.Windows.Forms.CheckBox();
            this.POHeaderPart1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label3 = new System.Windows.Forms.Label();
            this.THPlayLevel = new System.Windows.Forms.TextBox();
            this.CHRank = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.CHPlayer = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.THGenre = new System.Windows.Forms.TextBox();
            this.THBPM = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.THArtist = new System.Windows.Forms.TextBox();
            this.THTitle = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.POHeaderSwitch = new System.Windows.Forms.CheckBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.MRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnImportSM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnImportIBMSC = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.mnOpenR0 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenR1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenR2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenR3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenR4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.mnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGotoMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.mnTimeSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.mnMyO2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSys = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSTB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSOP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSLSplitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSRSplitter = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.CGShow = new System.Windows.Forms.ToolStripMenuItem();
            this.CGShowS = new System.Windows.Forms.ToolStripMenuItem();
            this.CGShowBG = new System.Windows.Forms.ToolStripMenuItem();
            this.CGShowM = new System.Windows.Forms.ToolStripMenuItem();
            this.CGShowMB = new System.Windows.Forms.ToolStripMenuItem();
            this.CGShowV = new System.Windows.Forms.ToolStripMenuItem();
            this.CGShowC = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.CGBPM = new System.Windows.Forms.ToolStripMenuItem();
            this.CGSTOP = new System.Windows.Forms.ToolStripMenuItem();
            this.CGSCROLL = new System.Windows.Forms.ToolStripMenuItem();
            this.CGBLP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNTInput = new System.Windows.Forms.ToolStripMenuItem();
            this.mnErrorCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPreviewOnClick = new System.Windows.Forms.ToolStripMenuItem();
            this.mnShowFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.mnGOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConversion = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnConversion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.POBLong = new System.Windows.Forms.ToolStripMenuItem();
            this.POBShort = new System.Windows.Forms.ToolStripMenuItem();
            this.POBLongShort = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.POBHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.POBVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.POBHiddenVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.POBModify = new System.Windows.Forms.ToolStripMenuItem();
            this.POBMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPlayB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStop = new System.Windows.Forms.ToolStripMenuItem();
            this.POConvert = new System.Windows.Forms.ToolStripDropDownButton();
            this.TBMain = new System.Windows.Forms.ToolStrip();
            this.TBNew = new System.Windows.Forms.ToolStripButton();
            this.TBOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.TBOpenR0 = new System.Windows.Forms.ToolStripMenuItem();
            this.TBOpenR1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TBOpenR2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TBOpenR3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TBOpenR4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.TBImportSM = new System.Windows.Forms.ToolStripMenuItem();
            this.TBImportIBMSC = new System.Windows.Forms.ToolStripMenuItem();
            this.TBSave = new System.Windows.Forms.ToolStripSplitButton();
            this.TBSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.TBExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBCut = new System.Windows.Forms.ToolStripButton();
            this.TBCopy = new System.Windows.Forms.ToolStripButton();
            this.TBPaste = new System.Windows.Forms.ToolStripButton();
            this.TBFind = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.TBStatistics = new System.Windows.Forms.ToolStripButton();
            this.TBMyO2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TBErrorCheck = new System.Windows.Forms.ToolStripButton();
            this.TBPreviewOnClick = new System.Windows.Forms.ToolStripButton();
            this.TBShowFileName = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.TBNTInput = new System.Windows.Forms.ToolStripButton();
            this.TBWavIncrease = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TBUndo = new System.Windows.Forms.ToolStripButton();
            this.TBRedo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TBTimeSelect = new System.Windows.Forms.ToolStripButton();
            this.TBSelect = new System.Windows.Forms.ToolStripButton();
            this.TBWrite = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TBPlayB = new System.Windows.Forms.ToolStripButton();
            this.TBPlay = new System.Windows.Forms.ToolStripButton();
            this.TBStop = new System.Windows.Forms.ToolStripButton();
            this.TBPOptions = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TBVOptions = new System.Windows.Forms.ToolStripButton();
            this.TBGOptions = new System.Windows.Forms.ToolStripButton();
            this.POBStorm = new System.Windows.Forms.ToolStripButton();
            this.pStatus = new System.Windows.Forms.Panel();
            this.FStatus2 = new System.Windows.Forms.StatusStrip();
            this.FSSS = new System.Windows.Forms.ToolStripButton();
            this.FSSL = new System.Windows.Forms.ToolStripButton();
            this.FSSH = new System.Windows.Forms.ToolStripButton();
            this.BVCReverse = new System.Windows.Forms.ToolStripButton();
            this.LblMultiply = new System.Windows.Forms.ToolStripStatusLabel();
            this.TVCM = new System.Windows.Forms.ToolStripTextBox();
            this.LblDivide = new System.Windows.Forms.ToolStripStatusLabel();
            this.TVCD = new System.Windows.Forms.ToolStripTextBox();
            this.BVCApply = new System.Windows.Forms.ToolStripButton();
            this.TVCBPM = new System.Windows.Forms.ToolStripTextBox();
            this.BVCCalculate = new System.Windows.Forms.ToolStripButton();
            this.BConvertStop = new System.Windows.Forms.ToolStripButton();
            this.FStatus = new System.Windows.Forms.StatusStrip();
            this.FSC = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSW = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSM = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSP1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSP3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSP2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSP4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FST = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSH = new System.Windows.Forms.ToolStripStatusLabel();
            this.FSE = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerMiddle = new System.Windows.Forms.Timer(this.components);
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.PMain = new System.Windows.Forms.Panel();
            this.PMainIn = new System.Windows.Forms.Panel();
            this.MainPanelScroll = new System.Windows.Forms.VScrollBar();
            this.HS = new System.Windows.Forms.HScrollBar();
            this.SpR = new System.Windows.Forms.Button();
            this.SpL = new System.Windows.Forms.Button();
            this.PMainR = new System.Windows.Forms.Panel();
            this.PMainInR = new System.Windows.Forms.Panel();
            this.RightPanelScroll = new System.Windows.Forms.VScrollBar();
            this.HSR = new System.Windows.Forms.HScrollBar();
            this.PMainL = new System.Windows.Forms.Panel();
            this.PMainInL = new System.Windows.Forms.Panel();
            this.LeftPanelScroll = new System.Windows.Forms.VScrollBar();
            this.HSL = new System.Windows.Forms.HScrollBar();
            this.POptionsResizer = new System.Windows.Forms.Button();
            this.ToolTipUniversal = new System.Windows.Forms.ToolTip(this.components);
            this.cmnLanguage.SuspendLayout();
            this.cmnTheme.SuspendLayout();
            this.POptionsScroll.SuspendLayout();
            this.POptions.SuspendLayout();
            this.POExpansion.SuspendLayout();
            this.POExpansionInner.SuspendLayout();
            this.POBeat.SuspendLayout();
            this.POBeatInner.SuspendLayout();
            this.TableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nBeatD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.nBeatN).BeginInit();
            this.POBeatPart2.SuspendLayout();
            this.POWAV.SuspendLayout();
            this.POWAVInner.SuspendLayout();
            this.FlowLayoutPanel3.SuspendLayout();
            this.POWAVPart2.SuspendLayout();
            this.POWaveForm.SuspendLayout();
            this.POWaveFormInner.SuspendLayout();
            this.POWaveFormPart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.TWSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWTransparency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPrecision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWSaturation2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWLeft2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWTransparency2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWWidth2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPrecision2).BeginInit();
            this.POWaveFormPart1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPosition2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPosition).BeginInit();
            this.POGrid.SuspendLayout();
            this.POGridInner.SuspendLayout();
            this.POGridPart2.SuspendLayout();
            this.TableLayoutPanel5.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.CGB).BeginInit();
            this.POGridPart1.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.CGHeight2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.CGHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.CGWidth2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.CGWidth).BeginInit();
            this.TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.CGDivide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.CGSub).BeginInit();
            this.POHeader.SuspendLayout();
            this.POHeaderInner.SuspendLayout();
            this.POHeaderPart2.SuspendLayout();
            this.POHeaderPart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.THBPM).BeginInit();
            this.Menu1.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.cmnConversion.SuspendLayout();
            this.TBMain.SuspendLayout();
            this.pStatus.SuspendLayout();
            this.FStatus2.SuspendLayout();
            this.FStatus.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            this.PMain.SuspendLayout();
            this.PMainR.SuspendLayout();
            this.PMainL.SuspendLayout();
            this.SuspendLayout();
            this.cmnLanguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[3]
                { this.TBLangDef, this.TBLangRefresh, this.ToolStripSeparator9 });
            this.cmnLanguage.Name = "cmnLanguage";
            this.cmnLanguage.OwnerItem = this.mnLanguage;
            System.Windows.Forms.ContextMenuStrip contextMenuStrip = this.cmnLanguage;
            System.Drawing.Size size = new System.Drawing.Size(121, 54);
            contextMenuStrip.Size = size;
            this.TBLangDef.Name = "TBLangDef";
            System.Windows.Forms.ToolStripMenuItem tBLangDef = this.TBLangDef;
            size = new System.Drawing.Size(120, 22);
            tBLangDef.Size = size;
            this.TBLangDef.Text = "(Default)";
            this.TBLangRefresh.Image = iBMSC.My.Resources.Resources.x16Refresh;
            this.TBLangRefresh.Name = "TBLangRefresh";
            System.Windows.Forms.ToolStripMenuItem tBLangRefresh = this.TBLangRefresh;
            size = new System.Drawing.Size(120, 22);
            tBLangRefresh.Size = size;
            this.TBLangRefresh.Text = "Refresh";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator = this.ToolStripSeparator9;
            size = new System.Drawing.Size(117, 6);
            toolStripSeparator.Size = size;
            this.TBLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBLanguage.DropDown = this.cmnLanguage;
            this.TBLanguage.Image = iBMSC.My.Resources.Resources.x16Language;
            this.TBLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBLanguage.Name = "TBLanguage";
            System.Windows.Forms.ToolStripDropDownButton tBLanguage = this.TBLanguage;
            size = new System.Drawing.Size(29, 22);
            tBLanguage.Size = size;
            this.TBLanguage.Text = "Language";
            this.mnLanguage.DropDown = this.cmnLanguage;
            this.mnLanguage.Image = iBMSC.My.Resources.Resources.x16Language;
            this.mnLanguage.Name = "mnLanguage";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = this.mnLanguage;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem.Size = size;
            this.mnLanguage.Text = "&Language";
            this.cmnTheme.Items.AddRange(new System.Windows.Forms.ToolStripItem[5]
            {
                this.TBThemeDef, this.TBThemeSave, this.TBThemeRefresh, this.TBThemeLoadComptability,
                this.ToolStripSeparator6
            });
            this.cmnTheme.Name = "cmnLanguage";
            this.cmnTheme.OwnerItem = this.mnTheme;
            System.Windows.Forms.ContextMenuStrip contextMenuStrip2 = this.cmnTheme;
            size = new System.Drawing.Size(246, 98);
            contextMenuStrip2.Size = size;
            this.TBThemeDef.Name = "TBThemeDef";
            System.Windows.Forms.ToolStripMenuItem tBThemeDef = this.TBThemeDef;
            size = new System.Drawing.Size(245, 22);
            tBThemeDef.Size = size;
            this.TBThemeDef.Text = "(Default)";
            this.TBThemeSave.Image = iBMSC.My.Resources.Resources.x16SaveAs;
            this.TBThemeSave.Name = "TBThemeSave";
            System.Windows.Forms.ToolStripMenuItem tBThemeSave = this.TBThemeSave;
            size = new System.Drawing.Size(245, 22);
            tBThemeSave.Size = size;
            this.TBThemeSave.Text = "Save Theme";
            this.TBThemeRefresh.Image = iBMSC.My.Resources.Resources.x16Refresh;
            this.TBThemeRefresh.Name = "TBThemeRefresh";
            System.Windows.Forms.ToolStripMenuItem tBThemeRefresh = this.TBThemeRefresh;
            size = new System.Drawing.Size(245, 22);
            tBThemeRefresh.Size = size;
            this.TBThemeRefresh.Text = "Refresh";
            this.TBThemeLoadComptability.Name = "TBThemeLoadComptability";
            System.Windows.Forms.ToolStripMenuItem tBThemeLoadComptability = this.TBThemeLoadComptability;
            size = new System.Drawing.Size(245, 22);
            tBThemeLoadComptability.Size = size;
            this.TBThemeLoadComptability.Text = "Load Theme File from iBMSC 2.x";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator6;
            size = new System.Drawing.Size(242, 6);
            toolStripSeparator2.Size = size;
            this.TBTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBTheme.DropDown = this.cmnTheme;
            this.TBTheme.Image = iBMSC.My.Resources.Resources.x16Theme;
            this.TBTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBTheme.Name = "TBTheme";
            System.Windows.Forms.ToolStripDropDownButton tBTheme = this.TBTheme;
            size = new System.Drawing.Size(29, 22);
            tBTheme.Size = size;
            this.TBTheme.Text = "Theme";
            this.mnTheme.DropDown = this.cmnTheme;
            this.mnTheme.Image = iBMSC.My.Resources.Resources.x16Theme;
            this.mnTheme.Name = "mnTheme";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2 = this.mnTheme;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem2.Size = size;
            this.mnTheme.Text = "&Theme";
            this.POptionsScroll.AutoScroll = true;
            this.POptionsScroll.Controls.Add(this.POptions);
            this.POptionsScroll.Dock = System.Windows.Forms.DockStyle.Right;
            System.Windows.Forms.Panel pOptionsScroll = this.POptionsScroll;
            System.Drawing.Point location = new System.Drawing.Point(882, 0);
            pOptionsScroll.Location = location;
            this.POptionsScroll.Name = "POptionsScroll";
            System.Windows.Forms.Panel pOptionsScroll2 = this.POptionsScroll;
            size = new System.Drawing.Size(200, 730);
            pOptionsScroll2.Size = size;
            this.POptionsScroll.TabIndex = 28;
            this.POptions.AutoSize = true;
            this.POptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POptions.Controls.Add(this.POExpansion);
            this.POptions.Controls.Add(this.POBeat);
            this.POptions.Controls.Add(this.POWAV);
            this.POptions.Controls.Add(this.POWaveForm);
            this.POptions.Controls.Add(this.POGrid);
            this.POptions.Controls.Add(this.POHeader);
            this.POptions.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOptions = this.POptions;
            location = new System.Drawing.Point(0, 0);
            pOptions.Location = location;
            this.POptions.Name = "POptions";
            System.Windows.Forms.Panel pOptions2 = this.POptions;
            size = new System.Drawing.Size(183, 1722);
            pOptions2.Size = size;
            this.POptions.TabIndex = 29;
            this.POExpansion.AutoSize = true;
            this.POExpansion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POExpansion.Controls.Add(this.POExpansionInner);
            this.POExpansion.Controls.Add(this.POExpansionSwitch);
            this.POExpansion.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOExpansion = this.POExpansion;
            location = new System.Drawing.Point(0, 1452);
            pOExpansion.Location = location;
            this.POExpansion.Name = "POExpansion";
            System.Windows.Forms.Panel pOExpansion2 = this.POExpansion;
            size = new System.Drawing.Size(183, 270);
            pOExpansion2.Size = size;
            this.POExpansion.TabIndex = 6;
            this.POExpansionInner.Controls.Add(this.TExpansion);
            this.POExpansionInner.Controls.Add(this.POExpansionResizer);
            this.POExpansionInner.Dock = System.Windows.Forms.DockStyle.Top;
            this.POExpansionInner.Font = new System.Drawing.Font("Consolas", 9f, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.Panel pOExpansionInner = this.POExpansionInner;
            location = new System.Drawing.Point(0, 20);
            pOExpansionInner.Location = location;
            this.POExpansionInner.Name = "POExpansionInner";
            System.Windows.Forms.Panel pOExpansionInner2 = this.POExpansionInner;
            size = new System.Drawing.Size(183, 250);
            pOExpansionInner2.Size = size;
            this.POExpansionInner.TabIndex = 7;
            this.POExpansionInner.Visible = false;
            this.TExpansion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TExpansion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TExpansion.HideSelection = false;
            System.Windows.Forms.TextBox tExpansion = this.TExpansion;
            location = new System.Drawing.Point(0, 0);
            tExpansion.Location = location;
            this.TExpansion.Multiline = true;
            this.TExpansion.Name = "TExpansion";
            this.TExpansion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            System.Windows.Forms.TextBox tExpansion2 = this.TExpansion;
            size = new System.Drawing.Size(183, 245);
            tExpansion2.Size = size;
            this.TExpansion.TabIndex = 0;
            this.TExpansion.WordWrap = false;
            this.POExpansionResizer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.POExpansionResizer.FlatAppearance.BorderSize = 0;
            this.POExpansionResizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Button pOExpansionResizer = this.POExpansionResizer;
            location = new System.Drawing.Point(0, 245);
            pOExpansionResizer.Location = location;
            System.Windows.Forms.Button pOExpansionResizer2 = this.POExpansionResizer;
            System.Windows.Forms.Padding margin = new System.Windows.Forms.Padding(0);
            pOExpansionResizer2.Margin = margin;
            this.POExpansionResizer.Name = "POExpansionResizer";
            System.Windows.Forms.Button pOExpansionResizer3 = this.POExpansionResizer;
            size = new System.Drawing.Size(183, 5);
            pOExpansionResizer3.Size = size;
            this.POExpansionResizer.TabIndex = 65;
            this.POExpansionResizer.TabStop = false;
            this.POExpansionResizer.UseVisualStyleBackColor = true;
            this.POExpansionSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.POExpansionSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.POExpansionSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POExpansionSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.POExpansionSwitch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.CheckBox pOExpansionSwitch = this.POExpansionSwitch;
            location = new System.Drawing.Point(0, 0);
            pOExpansionSwitch.Location = location;
            this.POExpansionSwitch.Name = "POExpansionSwitch";
            System.Windows.Forms.CheckBox pOExpansionSwitch2 = this.POExpansionSwitch;
            size = new System.Drawing.Size(183, 20);
            pOExpansionSwitch2.Size = size;
            this.POExpansionSwitch.TabIndex = 6;
            this.POExpansionSwitch.TabStop = false;
            this.POExpansionSwitch.Text = "Expansion Code";
            this.POExpansionSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POExpansionSwitch.UseCompatibleTextRendering = true;
            this.POExpansionSwitch.UseVisualStyleBackColor = false;
            this.POBeat.AutoSize = true;
            this.POBeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POBeat.Controls.Add(this.POBeatInner);
            this.POBeat.Controls.Add(this.POBeatSwitch);
            this.POBeat.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOBeat = this.POBeat;
            location = new System.Drawing.Point(0, 1182);
            pOBeat.Location = location;
            this.POBeat.Name = "POBeat";
            System.Windows.Forms.Panel pOBeat2 = this.POBeat;
            size = new System.Drawing.Size(183, 270);
            pOBeat2.Size = size;
            this.POBeat.TabIndex = 5;
            this.POBeatInner.ColumnCount = 1;
            this.POBeatInner.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POBeatInner.Controls.Add(this.POBeatExpander, 0, 1);
            this.POBeatInner.Controls.Add(this.POBeatResizer, 0, 4);
            this.POBeatInner.Controls.Add(this.TableLayoutPanel7, 0, 0);
            this.POBeatInner.Controls.Add(this.LBeat, 0, 3);
            this.POBeatInner.Controls.Add(this.POBeatPart2, 0, 2);
            this.POBeatInner.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOBeatInner = this.POBeatInner;
            location = new System.Drawing.Point(0, 20);
            pOBeatInner.Location = location;
            this.POBeatInner.Name = "POBeatInner";
            this.POBeatInner.RowCount = 5;
            this.POBeatInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POBeatInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POBeatInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POBeatInner.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POBeatInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOBeatInner2 = this.POBeatInner;
            size = new System.Drawing.Size(183, 250);
            pOBeatInner2.Size = size;
            this.POBeatInner.TabIndex = 6;
            this.POBeatInner.Visible = false;
            this.POBeatExpander.Appearance = System.Windows.Forms.Appearance.Button;
            this.POBeatExpander.AutoSize = true;
            this.POBeatExpander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POBeatExpander.Dock = System.Windows.Forms.DockStyle.Top;
            this.POBeatExpander.FlatAppearance.BorderSize = 0;
            this.POBeatExpander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            System.Windows.Forms.CheckBox pOBeatExpander = this.POBeatExpander;
            location = new System.Drawing.Point(0, 54);
            pOBeatExpander.Location = location;
            System.Windows.Forms.CheckBox pOBeatExpander2 = this.POBeatExpander;
            margin = new System.Windows.Forms.Padding(0);
            pOBeatExpander2.Margin = margin;
            this.POBeatExpander.Name = "POBeatExpander";
            System.Windows.Forms.CheckBox pOBeatExpander3 = this.POBeatExpander;
            size = new System.Drawing.Size(183, 25);
            pOBeatExpander3.Size = size;
            this.POBeatExpander.TabIndex = 65;
            this.POBeatExpander.TabStop = false;
            this.POBeatExpander.Text = "Expand...";
            this.POBeatExpander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POBeatExpander.UseVisualStyleBackColor = false;
            this.POBeatInner.SetColumnSpan(this.POBeatResizer, 2);
            this.POBeatResizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.POBeatResizer.FlatAppearance.BorderSize = 0;
            this.POBeatResizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Button pOBeatResizer = this.POBeatResizer;
            location = new System.Drawing.Point(0, 245);
            pOBeatResizer.Location = location;
            System.Windows.Forms.Button pOBeatResizer2 = this.POBeatResizer;
            margin = new System.Windows.Forms.Padding(0);
            pOBeatResizer2.Margin = margin;
            this.POBeatResizer.Name = "POBeatResizer";
            System.Windows.Forms.Button pOBeatResizer3 = this.POBeatResizer;
            size = new System.Drawing.Size(183, 5);
            pOBeatResizer3.Size = size;
            this.POBeatResizer.TabIndex = 64;
            this.POBeatResizer.TabStop = false;
            this.POBeatResizer.UseVisualStyleBackColor = true;
            this.TableLayoutPanel7.AutoSize = true;
            this.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel7.ColumnCount = 4;
            this.TableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.TableLayoutPanel7.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40f));
            this.TableLayoutPanel7.Controls.Add(this.nBeatD, 2, 0);
            this.TableLayoutPanel7.Controls.Add(this.BBeatApplyV, 3, 1);
            this.TableLayoutPanel7.Controls.Add(this.nBeatN, 0, 0);
            this.TableLayoutPanel7.Controls.Add(this.BBeatApply, 3, 0);
            this.TableLayoutPanel7.Controls.Add(this.Label7, 1, 0);
            this.TableLayoutPanel7.Controls.Add(this.tBeatValue, 0, 1);
            this.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel7;
            location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel7;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Margin = margin;
            this.TableLayoutPanel7.Name = "TableLayoutPanel7";
            this.TableLayoutPanel7.RowCount = 2;
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3 = this.TableLayoutPanel7;
            size = new System.Drawing.Size(183, 54);
            tableLayoutPanel3.Size = size;
            this.TableLayoutPanel7.TabIndex = 63;
            this.nBeatD.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.NumericUpDown numericUpDown = this.nBeatD;
            location = new System.Drawing.Point(66, 3);
            numericUpDown.Location = location;
            System.Windows.Forms.NumericUpDown numericUpDown2 = this.nBeatD;

            numericUpDown2.Maximum = 10000;
            this.nBeatD.Minimum = 1;
            this.nBeatD.Name = "nBeatD";
            System.Windows.Forms.NumericUpDown numericUpDown3 = this.nBeatD;
            size = new System.Drawing.Size(45, 23);
            numericUpDown3.Size = size;
            this.nBeatD.TabIndex = 37;
            this.nBeatD.Value = 4;
            this.BBeatApplyV.AutoSize = true;
            this.BBeatApplyV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BBeatApplyV.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.Button bBeatApplyV = this.BBeatApplyV;
            location = new System.Drawing.Point(114, 29);
            bBeatApplyV.Location = location;
            System.Windows.Forms.Button bBeatApplyV2 = this.BBeatApplyV;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            bBeatApplyV2.Margin = margin;
            this.BBeatApplyV.Name = "BBeatApplyV";
            System.Windows.Forms.Button bBeatApplyV3 = this.BBeatApplyV;
            size = new System.Drawing.Size(66, 25);
            bBeatApplyV3.Size = size;
            this.BBeatApplyV.TabIndex = 35;
            this.BBeatApplyV.Text = "Apply";
            this.BBeatApplyV.UseVisualStyleBackColor = true;
            this.nBeatN.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.NumericUpDown numericUpDown4 = this.nBeatN;
            location = new System.Drawing.Point(3, 3);
            numericUpDown4.Location = location;
            this.nBeatN.Maximum = 99999;
            this.nBeatN.Minimum = 1;
            this.nBeatN.Name = "nBeatN";
            System.Windows.Forms.NumericUpDown numericUpDown5 = this.nBeatN;
            size = new System.Drawing.Size(45, 23);
            numericUpDown5.Size = size;
            this.nBeatN.TabIndex = 27;
            this.nBeatN.Value = 4;
            this.BBeatApply.AutoSize = true;
            this.BBeatApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BBeatApply.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.Button bBeatApply = this.BBeatApply;
            location = new System.Drawing.Point(114, 2);
            bBeatApply.Location = location;
            System.Windows.Forms.Button bBeatApply2 = this.BBeatApply;
            margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            bBeatApply2.Margin = margin;
            this.BBeatApply.Name = "BBeatApply";
            System.Windows.Forms.Button bBeatApply3 = this.BBeatApply;
            size = new System.Drawing.Size(66, 25);
            bBeatApply3.Size = size;
            this.BBeatApply.TabIndex = 30;
            this.BBeatApply.Text = "Apply";
            this.BBeatApply.UseVisualStyleBackColor = true;
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label7.AutoSize = true;
            System.Windows.Forms.Label label = this.Label7;
            location = new System.Drawing.Point(51, 7);
            label.Location = location;
            System.Windows.Forms.Label label2 = this.Label7;
            margin = new System.Windows.Forms.Padding(0);
            label2.Margin = margin;
            this.Label7.Name = "Label7";
            System.Windows.Forms.Label label3 = this.Label7;
            size = new System.Drawing.Size(12, 15);
            label3.Size = size;
            this.Label7.TabIndex = 31;
            this.Label7.Text = "/";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableLayoutPanel7.SetColumnSpan(this.tBeatValue, 3);
            this.tBeatValue.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox textBox = this.tBeatValue;
            location = new System.Drawing.Point(3, 30);
            textBox.Location = location;
            System.Windows.Forms.TextBox textBox2 = this.tBeatValue;
            margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            textBox2.Margin = margin;
            this.tBeatValue.Name = "tBeatValue";
            System.Windows.Forms.TextBox textBox3 = this.tBeatValue;
            size = new System.Drawing.Size(108, 23);
            textBox3.Size = size;
            this.tBeatValue.TabIndex = 36;
            this.tBeatValue.Text = "1";
            this.LBeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBeat.Font = new System.Drawing.Font("Consolas", 9f, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, 0);
            this.LBeat.IntegralHeight = false;
            this.LBeat.ItemHeight = 14;
            this.LBeat.Items.AddRange(new object[1] { "000: 15.984375 (1023/64)" });
            System.Windows.Forms.ListBox lBeat = this.LBeat;
            location = new System.Drawing.Point(3, 155);
            lBeat.Location = location;
            System.Windows.Forms.ListBox lBeat2 = this.LBeat;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lBeat2.Margin = margin;
            this.LBeat.Name = "LBeat";
            this.LBeat.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            System.Windows.Forms.ListBox lBeat3 = this.LBeat;
            size = new System.Drawing.Size(177, 90);
            lBeat3.Size = size;
            this.LBeat.TabIndex = 26;
            this.POBeatPart2.AutoSize = true;
            this.POBeatPart2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POBeatPart2.ColumnCount = 1;
            this.POBeatPart2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POBeatPart2.Controls.Add(this.CBeatScale, 0, 3);
            this.POBeatPart2.Controls.Add(this.CBeatCut, 0, 2);
            this.POBeatPart2.Controls.Add(this.CBeatMeasure, 0, 1);
            this.POBeatPart2.Controls.Add(this.CBeatPreserve, 0, 0);
            this.POBeatPart2.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel pOBeatPart = this.POBeatPart2;
            location = new System.Drawing.Point(0, 79);
            pOBeatPart.Location = location;
            System.Windows.Forms.TableLayoutPanel pOBeatPart2 = this.POBeatPart2;
            margin = new System.Windows.Forms.Padding(0);
            pOBeatPart2.Margin = margin;
            this.POBeatPart2.Name = "POBeatPart2";
            this.POBeatPart2.RowCount = 4;
            this.POBeatPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POBeatPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POBeatPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POBeatPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOBeatPart3 = this.POBeatPart2;
            size = new System.Drawing.Size(183, 76);
            pOBeatPart3.Size = size;
            this.POBeatPart2.TabIndex = 66;
            this.POBeatPart2.Visible = false;
            this.CBeatScale.AutoSize = true;
            System.Windows.Forms.RadioButton cBeatScale = this.CBeatScale;
            location = new System.Drawing.Point(3, 57);
            cBeatScale.Location = location;
            System.Windows.Forms.RadioButton cBeatScale2 = this.CBeatScale;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cBeatScale2.Margin = margin;
            this.CBeatScale.Name = "CBeatScale";
            System.Windows.Forms.RadioButton cBeatScale3 = this.CBeatScale;
            size = new System.Drawing.Size(151, 19);
            cBeatScale3.Size = size;
            this.CBeatScale.TabIndex = 3;
            this.CBeatScale.Text = "Scale to measure length";
            this.CBeatScale.UseVisualStyleBackColor = true;
            this.CBeatCut.AutoEllipsis = true;
            this.CBeatCut.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.RadioButton cBeatCut = this.CBeatCut;
            location = new System.Drawing.Point(3, 38);
            cBeatCut.Location = location;
            System.Windows.Forms.RadioButton cBeatCut2 = this.CBeatCut;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cBeatCut2.Margin = margin;
            this.CBeatCut.Name = "CBeatCut";
            System.Windows.Forms.RadioButton cBeatCut3 = this.CBeatCut;
            size = new System.Drawing.Size(177, 19);
            cBeatCut3.Size = size;
            this.CBeatCut.TabIndex = 2;
            this.CBeatCut.Text = "Keep measure position and cut overflow";
            this.CBeatCut.UseVisualStyleBackColor = true;
            this.CBeatMeasure.AutoSize = true;
            System.Windows.Forms.RadioButton cBeatMeasure = this.CBeatMeasure;
            location = new System.Drawing.Point(3, 19);
            cBeatMeasure.Location = location;
            System.Windows.Forms.RadioButton cBeatMeasure2 = this.CBeatMeasure;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cBeatMeasure2.Margin = margin;
            this.CBeatMeasure.Name = "CBeatMeasure";
            System.Windows.Forms.RadioButton cBeatMeasure3 = this.CBeatMeasure;
            size = new System.Drawing.Size(145, 19);
            cBeatMeasure3.Size = size;
            this.CBeatMeasure.TabIndex = 1;
            this.CBeatMeasure.Text = "Keep measure position";
            this.CBeatMeasure.UseVisualStyleBackColor = true;
            this.CBeatPreserve.AutoSize = true;
            this.CBeatPreserve.Checked = true;
            System.Windows.Forms.RadioButton cBeatPreserve = this.CBeatPreserve;
            location = new System.Drawing.Point(3, 0);
            cBeatPreserve.Location = location;
            System.Windows.Forms.RadioButton cBeatPreserve2 = this.CBeatPreserve;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cBeatPreserve2.Margin = margin;
            this.CBeatPreserve.Name = "CBeatPreserve";
            System.Windows.Forms.RadioButton cBeatPreserve3 = this.CBeatPreserve;
            size = new System.Drawing.Size(145, 19);
            cBeatPreserve3.Size = size;
            this.CBeatPreserve.TabIndex = 0;
            this.CBeatPreserve.TabStop = true;
            this.CBeatPreserve.Text = "Keep absolute position";
            this.CBeatPreserve.UseVisualStyleBackColor = true;
            this.POBeatSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.POBeatSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.POBeatSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POBeatSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.POBeatSwitch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.CheckBox pOBeatSwitch = this.POBeatSwitch;
            location = new System.Drawing.Point(0, 0);
            pOBeatSwitch.Location = location;
            this.POBeatSwitch.Name = "POBeatSwitch";
            System.Windows.Forms.CheckBox pOBeatSwitch2 = this.POBeatSwitch;
            size = new System.Drawing.Size(183, 20);
            pOBeatSwitch2.Size = size;
            this.POBeatSwitch.TabIndex = 5;
            this.POBeatSwitch.TabStop = false;
            this.POBeatSwitch.Text = "Beat";
            this.POBeatSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POBeatSwitch.UseCompatibleTextRendering = true;
            this.POBeatSwitch.UseVisualStyleBackColor = false;
            this.POWAV.AllowDrop = true;
            this.POWAV.AutoSize = true;
            this.POWAV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POWAV.Controls.Add(this.POWAVInner);
            this.POWAV.Controls.Add(this.POWAVSwitch);
            this.POWAV.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOWAV = this.POWAV;
            location = new System.Drawing.Point(0, 912);
            pOWAV.Location = location;
            this.POWAV.Name = "POWAV";
            System.Windows.Forms.Panel pOWAV2 = this.POWAV;
            size = new System.Drawing.Size(183, 270);
            pOWAV2.Size = size;
            this.POWAV.TabIndex = 4;
            this.POWAVInner.ColumnCount = 1;
            this.POWAVInner.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POWAVInner.Controls.Add(this.POWAVExpander, 0, 1);
            this.POWAVInner.Controls.Add(this.LWAV, 0, 3);
            this.POWAVInner.Controls.Add(this.FlowLayoutPanel3, 0, 0);
            this.POWAVInner.Controls.Add(this.POWAVResizer, 0, 4);
            this.POWAVInner.Controls.Add(this.POWAVPart2, 0, 2);
            this.POWAVInner.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOWAVInner = this.POWAVInner;
            location = new System.Drawing.Point(0, 20);
            pOWAVInner.Location = location;
            this.POWAVInner.Name = "POWAVInner";
            this.POWAVInner.RowCount = 5;
            this.POWAVInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POWAVInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POWAVInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POWAVInner.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POWAVInner.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOWAVInner2 = this.POWAVInner;
            size = new System.Drawing.Size(183, 250);
            pOWAVInner2.Size = size;
            this.POWAVInner.TabIndex = 5;
            this.POWAVExpander.Appearance = System.Windows.Forms.Appearance.Button;
            this.POWAVExpander.AutoSize = true;
            this.POWAVExpander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POWAVExpander.Dock = System.Windows.Forms.DockStyle.Top;
            this.POWAVExpander.FlatAppearance.BorderSize = 0;
            this.POWAVExpander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            System.Windows.Forms.CheckBox pOWAVExpander = this.POWAVExpander;
            location = new System.Drawing.Point(0, 30);
            pOWAVExpander.Location = location;
            System.Windows.Forms.CheckBox pOWAVExpander2 = this.POWAVExpander;
            margin = new System.Windows.Forms.Padding(0);
            pOWAVExpander2.Margin = margin;
            this.POWAVExpander.Name = "POWAVExpander";
            System.Windows.Forms.CheckBox pOWAVExpander3 = this.POWAVExpander;
            size = new System.Drawing.Size(183, 25);
            pOWAVExpander3.Size = size;
            this.POWAVExpander.TabIndex = 34;
            this.POWAVExpander.TabStop = false;
            this.POWAVExpander.Text = "Expand...";
            this.POWAVExpander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POWAVExpander.UseVisualStyleBackColor = false;
            this.LWAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LWAV.Font = new System.Drawing.Font("Consolas", 9f, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, 0);
            this.LWAV.IntegralHeight = false;
            this.LWAV.ItemHeight = 14;
            System.Windows.Forms.ListBox lWAV = this.LWAV;
            location = new System.Drawing.Point(3, 93);
            lWAV.Location = location;
            System.Windows.Forms.ListBox lWAV2 = this.LWAV;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lWAV2.Margin = margin;
            this.LWAV.Name = "LWAV";
            this.LWAV.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            System.Windows.Forms.ListBox lWAV3 = this.LWAV;
            size = new System.Drawing.Size(177, 152);
            lWAV3.Size = size;
            this.LWAV.TabIndex = 25;
            this.FlowLayoutPanel3.AutoSize = true;
            this.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel3.Controls.Add(this.BWAVUp);
            this.FlowLayoutPanel3.Controls.Add(this.BWAVDown);
            this.FlowLayoutPanel3.Controls.Add(this.BWAVBrowse);
            this.FlowLayoutPanel3.Controls.Add(this.BWAVRemove);
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel = this.FlowLayoutPanel3;
            location = new System.Drawing.Point(3, 3);
            flowLayoutPanel.Location = location;
            this.FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2 = this.FlowLayoutPanel3;
            size = new System.Drawing.Size(96, 24);
            flowLayoutPanel2.Size = size;
            this.FlowLayoutPanel3.TabIndex = 26;
            this.FlowLayoutPanel3.WrapContents = false;
            this.BWAVUp.Image = iBMSC.My.Resources.Resources.x16Up;
            System.Windows.Forms.Button bWAVUp = this.BWAVUp;
            location = new System.Drawing.Point(0, 0);
            bWAVUp.Location = location;
            System.Windows.Forms.Button bWAVUp2 = this.BWAVUp;
            margin = new System.Windows.Forms.Padding(0);
            bWAVUp2.Margin = margin;
            this.BWAVUp.Name = "BWAVUp";
            System.Windows.Forms.Button bWAVUp3 = this.BWAVUp;
            size = new System.Drawing.Size(24, 24);
            bWAVUp3.Size = size;
            this.BWAVUp.TabIndex = 26;
            this.ToolTipUniversal.SetToolTip(this.BWAVUp, "Move Up");
            this.BWAVUp.UseVisualStyleBackColor = true;
            this.BWAVDown.Image = iBMSC.My.Resources.Resources.x16Down;
            System.Windows.Forms.Button bWAVDown = this.BWAVDown;
            location = new System.Drawing.Point(24, 0);
            bWAVDown.Location = location;
            System.Windows.Forms.Button bWAVDown2 = this.BWAVDown;
            margin = new System.Windows.Forms.Padding(0);
            bWAVDown2.Margin = margin;
            this.BWAVDown.Name = "BWAVDown";
            System.Windows.Forms.Button bWAVDown3 = this.BWAVDown;
            size = new System.Drawing.Size(24, 24);
            bWAVDown3.Size = size;
            this.BWAVDown.TabIndex = 27;
            this.ToolTipUniversal.SetToolTip(this.BWAVDown, "Move Down");
            this.BWAVDown.UseVisualStyleBackColor = true;
            this.BWAVBrowse.Image = iBMSC.My.Resources.Resources.x16PlayerBrowse;
            System.Windows.Forms.Button bWAVBrowse = this.BWAVBrowse;
            location = new System.Drawing.Point(48, 0);
            bWAVBrowse.Location = location;
            System.Windows.Forms.Button bWAVBrowse2 = this.BWAVBrowse;
            margin = new System.Windows.Forms.Padding(0);
            bWAVBrowse2.Margin = margin;
            this.BWAVBrowse.Name = "BWAVBrowse";
            System.Windows.Forms.Button bWAVBrowse3 = this.BWAVBrowse;
            size = new System.Drawing.Size(24, 24);
            bWAVBrowse3.Size = size;
            this.BWAVBrowse.TabIndex = 30;
            this.ToolTipUniversal.SetToolTip(this.BWAVBrowse, "Browse");
            this.BWAVBrowse.UseVisualStyleBackColor = true;
            this.BWAVRemove.Image = iBMSC.My.Resources.Resources.x16Remove;
            System.Windows.Forms.Button bWAVRemove = this.BWAVRemove;
            location = new System.Drawing.Point(72, 0);
            bWAVRemove.Location = location;
            System.Windows.Forms.Button bWAVRemove2 = this.BWAVRemove;
            margin = new System.Windows.Forms.Padding(0);
            bWAVRemove2.Margin = margin;
            this.BWAVRemove.Name = "BWAVRemove";
            System.Windows.Forms.Button bWAVRemove3 = this.BWAVRemove;
            size = new System.Drawing.Size(24, 24);
            bWAVRemove3.Size = size;
            this.BWAVRemove.TabIndex = 31;
            this.ToolTipUniversal.SetToolTip(this.BWAVRemove, "Remove");
            this.BWAVRemove.UseVisualStyleBackColor = true;
            this.POWAVResizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.POWAVResizer.FlatAppearance.BorderSize = 0;
            this.POWAVResizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Button pOWAVResizer = this.POWAVResizer;
            location = new System.Drawing.Point(0, 245);
            pOWAVResizer.Location = location;
            System.Windows.Forms.Button pOWAVResizer2 = this.POWAVResizer;
            margin = new System.Windows.Forms.Padding(0);
            pOWAVResizer2.Margin = margin;
            this.POWAVResizer.Name = "POWAVResizer";
            System.Windows.Forms.Button pOWAVResizer3 = this.POWAVResizer;
            size = new System.Drawing.Size(183, 5);
            pOWAVResizer3.Size = size;
            this.POWAVResizer.TabIndex = 33;
            this.POWAVResizer.TabStop = false;
            this.POWAVResizer.UseVisualStyleBackColor = true;
            this.POWAVPart2.AutoSize = true;
            this.POWAVPart2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POWAVPart2.ColumnCount = 1;
            this.POWAVPart2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POWAVPart2.Controls.Add(this.CWAVMultiSelect, 0, 0);
            this.POWAVPart2.Controls.Add(this.CWAVChangeLabel, 0, 1);
            this.POWAVPart2.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel pOWAVPart = this.POWAVPart2;
            location = new System.Drawing.Point(0, 55);
            pOWAVPart.Location = location;
            System.Windows.Forms.TableLayoutPanel pOWAVPart2 = this.POWAVPart2;
            margin = new System.Windows.Forms.Padding(0);
            pOWAVPart2.Margin = margin;
            this.POWAVPart2.Name = "POWAVPart2";
            this.POWAVPart2.RowCount = 2;
            this.POWAVPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POWAVPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOWAVPart3 = this.POWAVPart2;
            size = new System.Drawing.Size(183, 38);
            pOWAVPart3.Size = size;
            this.POWAVPart2.TabIndex = 35;
            this.POWAVPart2.Visible = false;
            this.CWAVMultiSelect.AutoSize = true;
            this.CWAVMultiSelect.Checked = true;
            this.CWAVMultiSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            System.Windows.Forms.CheckBox cWAVMultiSelect = this.CWAVMultiSelect;
            location = new System.Drawing.Point(3, 0);
            cWAVMultiSelect.Location = location;
            System.Windows.Forms.CheckBox cWAVMultiSelect2 = this.CWAVMultiSelect;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cWAVMultiSelect2.Margin = margin;
            this.CWAVMultiSelect.Name = "CWAVMultiSelect";
            System.Windows.Forms.CheckBox cWAVMultiSelect3 = this.CWAVMultiSelect;
            size = new System.Drawing.Size(154, 19);
            cWAVMultiSelect3.Size = size;
            this.CWAVMultiSelect.TabIndex = 0;
            this.CWAVMultiSelect.Text = "Allow Multiple Selection";
            this.CWAVMultiSelect.UseVisualStyleBackColor = true;
            this.CWAVChangeLabel.AutoSize = true;
            this.CWAVChangeLabel.Checked = true;
            this.CWAVChangeLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            System.Windows.Forms.CheckBox cWAVChangeLabel = this.CWAVChangeLabel;
            location = new System.Drawing.Point(3, 19);
            cWAVChangeLabel.Location = location;
            System.Windows.Forms.CheckBox cWAVChangeLabel2 = this.CWAVChangeLabel;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cWAVChangeLabel2.Margin = margin;
            this.CWAVChangeLabel.Name = "CWAVChangeLabel";
            System.Windows.Forms.CheckBox cWAVChangeLabel3 = this.CWAVChangeLabel;
            size = new System.Drawing.Size(155, 19);
            cWAVChangeLabel3.Size = size;
            this.CWAVChangeLabel.TabIndex = 1;
            this.CWAVChangeLabel.Text = "Synchronize Note Labels";
            this.CWAVChangeLabel.UseVisualStyleBackColor = true;
            this.POWAVSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.POWAVSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.POWAVSwitch.Checked = true;
            this.POWAVSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.POWAVSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POWAVSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.POWAVSwitch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.CheckBox pOWAVSwitch = this.POWAVSwitch;
            location = new System.Drawing.Point(0, 0);
            pOWAVSwitch.Location = location;
            this.POWAVSwitch.Name = "POWAVSwitch";
            System.Windows.Forms.CheckBox pOWAVSwitch2 = this.POWAVSwitch;
            size = new System.Drawing.Size(183, 20);
            pOWAVSwitch2.Size = size;
            this.POWAVSwitch.TabIndex = 4;
            this.POWAVSwitch.TabStop = false;
            this.POWAVSwitch.Text = "#WAV (Sounds List)";
            this.POWAVSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POWAVSwitch.UseCompatibleTextRendering = true;
            this.POWAVSwitch.UseVisualStyleBackColor = false;
            this.POWaveForm.AutoSize = true;
            this.POWaveForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POWaveForm.Controls.Add(this.POWaveFormInner);
            this.POWaveForm.Controls.Add(this.POWaveFormSwitch);
            this.POWaveForm.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOWaveForm = this.POWaveForm;
            location = new System.Drawing.Point(0, 669);
            pOWaveForm.Location = location;
            this.POWaveForm.Name = "POWaveForm";
            System.Windows.Forms.Panel pOWaveForm2 = this.POWaveForm;
            size = new System.Drawing.Size(183, 243);
            pOWaveForm2.Size = size;
            this.POWaveForm.TabIndex = 3;
            this.POWaveFormInner.AutoSize = true;
            this.POWaveFormInner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POWaveFormInner.Controls.Add(this.POWaveFormPart2);
            this.POWaveFormInner.Controls.Add(this.POWaveFormExpander);
            this.POWaveFormInner.Controls.Add(this.POWaveFormPart1);
            this.POWaveFormInner.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOWaveFormInner = this.POWaveFormInner;
            location = new System.Drawing.Point(0, 20);
            pOWaveFormInner.Location = location;
            this.POWaveFormInner.Name = "POWaveFormInner";
            System.Windows.Forms.Panel pOWaveFormInner2 = this.POWaveFormInner;
            size = new System.Drawing.Size(183, 223);
            pOWaveFormInner2.Size = size;
            this.POWaveFormInner.TabIndex = 29;
            this.POWaveFormInner.Visible = false;
            this.POWaveFormPart2.AutoSize = true;
            this.POWaveFormPart2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POWaveFormPart2.ColumnCount = 3;
            this.POWaveFormPart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.POWaveFormPart2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70f));
            this.POWaveFormPart2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.POWaveFormPart2.Controls.Add(this.TWSaturation, 2, 4);
            this.POWaveFormPart2.Controls.Add(this.PictureBox2, 0, 0);
            this.POWaveFormPart2.Controls.Add(this.TWTransparency, 2, 3);
            this.POWaveFormPart2.Controls.Add(this.PictureBox3, 0, 1);
            this.POWaveFormPart2.Controls.Add(this.TWPrecision, 2, 2);
            this.POWaveFormPart2.Controls.Add(this.PictureBox4, 0, 2);
            this.POWaveFormPart2.Controls.Add(this.TWWidth, 2, 1);
            this.POWaveFormPart2.Controls.Add(this.PictureBox5, 0, 3);
            this.POWaveFormPart2.Controls.Add(this.TWLeft, 2, 0);
            this.POWaveFormPart2.Controls.Add(this.PictureBox6, 0, 4);
            this.POWaveFormPart2.Controls.Add(this.TWSaturation2, 1, 4);
            this.POWaveFormPart2.Controls.Add(this.TWLeft2, 1, 0);
            this.POWaveFormPart2.Controls.Add(this.TWTransparency2, 1, 3);
            this.POWaveFormPart2.Controls.Add(this.TWWidth2, 1, 1);
            this.POWaveFormPart2.Controls.Add(this.TWPrecision2, 1, 2);
            this.POWaveFormPart2.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOWaveFormPart = this.POWaveFormPart2;
            location = new System.Drawing.Point(0, 83);
            pOWaveFormPart.Location = location;
            this.POWaveFormPart2.Name = "POWaveFormPart2";
            this.POWaveFormPart2.RowCount = 5;
            this.POWaveFormPart2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            this.POWaveFormPart2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            this.POWaveFormPart2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            this.POWaveFormPart2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            this.POWaveFormPart2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            System.Windows.Forms.TableLayoutPanel pOWaveFormPart2 = this.POWaveFormPart2;
            size = new System.Drawing.Size(183, 140);
            pOWaveFormPart2.Size = size;
            this.POWaveFormPart2.TabIndex = 5;
            this.TWSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWSaturation.Increment = new decimal(new int[4] { 50, 0, 0, 0 });
            System.Windows.Forms.NumericUpDown tWSaturation = this.TWSaturation;
            location = new System.Drawing.Point(137, 112);
            tWSaturation.Location = location;
            System.Windows.Forms.NumericUpDown tWSaturation2 = this.TWSaturation;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tWSaturation2.Margin = margin;
            this.TWSaturation.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
            this.TWSaturation.Name = "TWSaturation";
            System.Windows.Forms.NumericUpDown tWSaturation3 = this.TWSaturation;
            size = new System.Drawing.Size(43, 23);
            tWSaturation3.Size = size;
            this.TWSaturation.TabIndex = 68;
            this.PictureBox2.Image = iBMSC.My.Resources.Resources.WAVLeft;
            System.Windows.Forms.PictureBox pictureBox = this.PictureBox2;
            location = new System.Drawing.Point(3, 0);
            pictureBox.Location = location;
            System.Windows.Forms.PictureBox pictureBox2 = this.PictureBox2;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox2.Margin = margin;
            this.PictureBox2.Name = "PictureBox2";
            System.Windows.Forms.PictureBox pictureBox3 = this.PictureBox2;
            size = new System.Drawing.Size(24, 24);
            pictureBox3.Size = size;
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 60;
            this.PictureBox2.TabStop = false;
            this.TWTransparency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWTransparency.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
            System.Windows.Forms.NumericUpDown tWTransparency = this.TWTransparency;
            location = new System.Drawing.Point(137, 84);
            tWTransparency.Location = location;
            System.Windows.Forms.NumericUpDown tWTransparency2 = this.TWTransparency;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tWTransparency2.Margin = margin;
            this.TWTransparency.Maximum = new decimal(new int[4] { 255, 0, 0, 0 });
            this.TWTransparency.Name = "TWTransparency";
            System.Windows.Forms.NumericUpDown tWTransparency3 = this.TWTransparency;
            size = new System.Drawing.Size(43, 23);
            tWTransparency3.Size = size;
            this.TWTransparency.TabIndex = 69;
            this.TWTransparency.Value = new decimal(new int[4] { 80, 0, 0, 0 });
            this.PictureBox3.Image = iBMSC.My.Resources.Resources.WAVWidth;
            System.Windows.Forms.PictureBox pictureBox4 = this.PictureBox3;
            location = new System.Drawing.Point(3, 28);
            pictureBox4.Location = location;
            System.Windows.Forms.PictureBox pictureBox5 = this.PictureBox3;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox5.Margin = margin;
            this.PictureBox3.Name = "PictureBox3";
            System.Windows.Forms.PictureBox pictureBox6 = this.PictureBox3;
            size = new System.Drawing.Size(24, 24);
            pictureBox6.Size = size;
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 61;
            this.PictureBox3.TabStop = false;
            this.TWPrecision.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.NumericUpDown tWPrecision = this.TWPrecision;
            location = new System.Drawing.Point(137, 56);
            tWPrecision.Location = location;
            System.Windows.Forms.NumericUpDown tWPrecision2 = this.TWPrecision;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tWPrecision2.Margin = margin;
            this.TWPrecision.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
            this.TWPrecision.Name = "TWPrecision";
            System.Windows.Forms.NumericUpDown tWPrecision3 = this.TWPrecision;
            size = new System.Drawing.Size(43, 23);
            tWPrecision3.Size = size;
            this.TWPrecision.TabIndex = 46;
            this.TWPrecision.Value = new decimal(new int[4] { 5, 0, 0, 0 });
            this.PictureBox4.Image = iBMSC.My.Resources.Resources.WAVPrecision;
            System.Windows.Forms.PictureBox pictureBox7 = this.PictureBox4;
            location = new System.Drawing.Point(3, 56);
            pictureBox7.Location = location;
            System.Windows.Forms.PictureBox pictureBox8 = this.PictureBox4;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox8.Margin = margin;
            this.PictureBox4.Name = "PictureBox4";
            System.Windows.Forms.PictureBox pictureBox9 = this.PictureBox4;
            size = new System.Drawing.Size(24, 24);
            pictureBox9.Size = size;
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox4.TabIndex = 62;
            this.PictureBox4.TabStop = false;
            this.TWWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWWidth.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
            System.Windows.Forms.NumericUpDown tWWidth = this.TWWidth;
            location = new System.Drawing.Point(137, 28);
            tWWidth.Location = location;
            System.Windows.Forms.NumericUpDown tWWidth2 = this.TWWidth;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tWWidth2.Margin = margin;
            this.TWWidth.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
            this.TWWidth.Name = "TWWidth";
            System.Windows.Forms.NumericUpDown tWWidth3 = this.TWWidth;
            size = new System.Drawing.Size(43, 23);
            tWWidth3.Size = size;
            this.TWWidth.TabIndex = 45;
            this.TWWidth.Value = new decimal(new int[4] { 200, 0, 0, 0 });
            this.PictureBox5.Image = iBMSC.My.Resources.Resources.WAVTransparency;
            System.Windows.Forms.PictureBox pictureBox10 = this.PictureBox5;
            location = new System.Drawing.Point(3, 84);
            pictureBox10.Location = location;
            System.Windows.Forms.PictureBox pictureBox11 = this.PictureBox5;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox11.Margin = margin;
            this.PictureBox5.Name = "PictureBox5";
            System.Windows.Forms.PictureBox pictureBox12 = this.PictureBox5;
            size = new System.Drawing.Size(24, 24);
            pictureBox12.Size = size;
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox5.TabIndex = 67;
            this.PictureBox5.TabStop = false;
            this.TWLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWLeft.Increment = new decimal(new int[4] { 5, 0, 0, 0 });
            System.Windows.Forms.NumericUpDown tWLeft = this.TWLeft;
            location = new System.Drawing.Point(137, 0);
            tWLeft.Location = location;
            System.Windows.Forms.NumericUpDown tWLeft2 = this.TWLeft;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tWLeft2.Margin = margin;
            this.TWLeft.Maximum = new decimal(new int[4] { 800, 0, 0, 0 });
            this.TWLeft.Name = "TWLeft";
            System.Windows.Forms.NumericUpDown tWLeft3 = this.TWLeft;
            size = new System.Drawing.Size(43, 23);
            tWLeft3.Size = size;
            this.TWLeft.TabIndex = 44;
            this.TWLeft.Value = new decimal(new int[4] { 50, 0, 0, 0 });
            this.PictureBox6.Image = iBMSC.My.Resources.Resources.WAVSaturation;
            System.Windows.Forms.PictureBox pictureBox13 = this.PictureBox6;
            location = new System.Drawing.Point(3, 112);
            pictureBox13.Location = location;
            System.Windows.Forms.PictureBox pictureBox14 = this.PictureBox6;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox14.Margin = margin;
            this.PictureBox6.Name = "PictureBox6";
            System.Windows.Forms.PictureBox pictureBox15 = this.PictureBox6;
            size = new System.Drawing.Size(24, 24);
            pictureBox15.Size = size;
            this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox6.TabIndex = 66;
            this.PictureBox6.TabStop = false;
            this.TWSaturation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWSaturation2.LargeChange = 200;
            System.Windows.Forms.TrackBar tWSaturation4 = this.TWSaturation2;
            location = new System.Drawing.Point(30, 112);
            tWSaturation4.Location = location;
            System.Windows.Forms.TrackBar tWSaturation5 = this.TWSaturation2;
            margin = new System.Windows.Forms.Padding(0);
            tWSaturation5.Margin = margin;
            this.TWSaturation2.Maximum = 1000;
            this.TWSaturation2.Name = "TWSaturation2";
            System.Windows.Forms.TrackBar tWSaturation6 = this.TWSaturation2;
            size = new System.Drawing.Size(107, 28);
            tWSaturation6.Size = size;
            this.TWSaturation2.SmallChange = 50;
            this.TWSaturation2.TabIndex = 70;
            this.TWSaturation2.TickFrequency = 200;
            this.TWLeft2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWLeft2.LargeChange = 50;
            System.Windows.Forms.TrackBar tWLeft4 = this.TWLeft2;
            location = new System.Drawing.Point(30, 0);
            tWLeft4.Location = location;
            System.Windows.Forms.TrackBar tWLeft5 = this.TWLeft2;
            margin = new System.Windows.Forms.Padding(0);
            tWLeft5.Margin = margin;
            this.TWLeft2.Maximum = 800;
            this.TWLeft2.Name = "TWLeft2";
            System.Windows.Forms.TrackBar tWLeft6 = this.TWLeft2;
            size = new System.Drawing.Size(107, 28);
            tWLeft6.Size = size;
            this.TWLeft2.SmallChange = 10;
            this.TWLeft2.TabIndex = 63;
            this.TWLeft2.TickFrequency = 100;
            this.TWLeft2.Value = 50;
            this.TWTransparency2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWTransparency2.LargeChange = 64;
            System.Windows.Forms.TrackBar tWTransparency4 = this.TWTransparency2;
            location = new System.Drawing.Point(30, 84);
            tWTransparency4.Location = location;
            System.Windows.Forms.TrackBar tWTransparency5 = this.TWTransparency2;
            margin = new System.Windows.Forms.Padding(0);
            tWTransparency5.Margin = margin;
            this.TWTransparency2.Maximum = 255;
            this.TWTransparency2.Name = "TWTransparency2";
            System.Windows.Forms.TrackBar tWTransparency6 = this.TWTransparency2;
            size = new System.Drawing.Size(107, 28);
            tWTransparency6.Size = size;
            this.TWTransparency2.SmallChange = 8;
            this.TWTransparency2.TabIndex = 71;
            this.TWTransparency2.TickFrequency = 64;
            this.TWTransparency2.Value = 80;
            this.TWWidth2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWWidth2.LargeChange = 50;
            System.Windows.Forms.TrackBar tWWidth4 = this.TWWidth2;
            location = new System.Drawing.Point(30, 28);
            tWWidth4.Location = location;
            System.Windows.Forms.TrackBar tWWidth5 = this.TWWidth2;
            margin = new System.Windows.Forms.Padding(0);
            tWWidth5.Margin = margin;
            this.TWWidth2.Maximum = 1000;
            this.TWWidth2.Name = "TWWidth2";
            System.Windows.Forms.TrackBar tWWidth6 = this.TWWidth2;
            size = new System.Drawing.Size(107, 28);
            tWWidth6.Size = size;
            this.TWWidth2.SmallChange = 10;
            this.TWWidth2.TabIndex = 64;
            this.TWWidth2.TickFrequency = 100;
            this.TWWidth2.Value = 200;
            this.TWPrecision2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWPrecision2.LargeChange = 4;
            System.Windows.Forms.TrackBar tWPrecision4 = this.TWPrecision2;
            location = new System.Drawing.Point(30, 56);
            tWPrecision4.Location = location;
            System.Windows.Forms.TrackBar tWPrecision5 = this.TWPrecision2;
            margin = new System.Windows.Forms.Padding(0);
            tWPrecision5.Margin = margin;
            this.TWPrecision2.Maximum = 50;
            this.TWPrecision2.Name = "TWPrecision2";
            System.Windows.Forms.TrackBar tWPrecision6 = this.TWPrecision2;
            size = new System.Drawing.Size(107, 28);
            tWPrecision6.Size = size;
            this.TWPrecision2.TabIndex = 65;
            this.TWPrecision2.TickFrequency = 5;
            this.TWPrecision2.Value = 5;
            this.POWaveFormExpander.Appearance = System.Windows.Forms.Appearance.Button;
            this.POWaveFormExpander.AutoSize = true;
            this.POWaveFormExpander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POWaveFormExpander.Dock = System.Windows.Forms.DockStyle.Top;
            this.POWaveFormExpander.FlatAppearance.BorderSize = 0;
            this.POWaveFormExpander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            System.Windows.Forms.CheckBox pOWaveFormExpander = this.POWaveFormExpander;
            location = new System.Drawing.Point(0, 58);
            pOWaveFormExpander.Location = location;
            System.Windows.Forms.CheckBox pOWaveFormExpander2 = this.POWaveFormExpander;
            margin = new System.Windows.Forms.Padding(0);
            pOWaveFormExpander2.Margin = margin;
            this.POWaveFormExpander.Name = "POWaveFormExpander";
            System.Windows.Forms.CheckBox pOWaveFormExpander3 = this.POWaveFormExpander;
            size = new System.Drawing.Size(183, 25);
            pOWaveFormExpander3.Size = size;
            this.POWaveFormExpander.TabIndex = 29;
            this.POWaveFormExpander.TabStop = false;
            this.POWaveFormExpander.Text = "Expand...";
            this.POWaveFormExpander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POWaveFormExpander.UseVisualStyleBackColor = false;
            this.POWaveFormPart1.AutoSize = true;
            this.POWaveFormPart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POWaveFormPart1.ColumnCount = 1;
            this.POWaveFormPart1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POWaveFormPart1.Controls.Add(this.TableLayoutPanel1, 0, 0);
            this.POWaveFormPart1.Controls.Add(this.TableLayoutPanel6, 0, 1);
            this.POWaveFormPart1.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOWaveFormPart3 = this.POWaveFormPart1;
            location = new System.Drawing.Point(0, 0);
            pOWaveFormPart3.Location = location;
            this.POWaveFormPart1.Name = "POWaveFormPart1";
            this.POWaveFormPart1.RowCount = 2;
            this.POWaveFormPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POWaveFormPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOWaveFormPart4 = this.POWaveFormPart1;
            size = new System.Drawing.Size(183, 58);
            pOWaveFormPart4.Size = size;
            this.POWaveFormPart1.TabIndex = 4;
            this.TableLayoutPanel1.AutoSize = true;
            this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.TableLayoutPanel1.Controls.Add(this.FlowLayoutPanel1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TWFileName, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel4 = this.TableLayoutPanel1;
            location = new System.Drawing.Point(0, 0);
            tableLayoutPanel4.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel5 = this.TableLayoutPanel1;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel5.Margin = margin;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel6 = this.TableLayoutPanel1;
            size = new System.Drawing.Size(183, 30);
            tableLayoutPanel6.Size = size;
            this.TableLayoutPanel1.TabIndex = 0;
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.BWLoad);
            this.FlowLayoutPanel1.Controls.Add(this.BWClear);
            this.FlowLayoutPanel1.Controls.Add(this.BWLock);
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3 = this.FlowLayoutPanel1;
            location = new System.Drawing.Point(3, 3);
            flowLayoutPanel3.Location = location;
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4 = this.FlowLayoutPanel1;
            size = new System.Drawing.Size(72, 24);
            flowLayoutPanel4.Size = size;
            this.FlowLayoutPanel1.TabIndex = 72;
            this.FlowLayoutPanel1.WrapContents = false;
            this.BWLoad.Image = iBMSC.My.Resources.Resources.x16Add;
            System.Windows.Forms.Button bWLoad = this.BWLoad;
            location = new System.Drawing.Point(0, 0);
            bWLoad.Location = location;
            System.Windows.Forms.Button bWLoad2 = this.BWLoad;
            margin = new System.Windows.Forms.Padding(0);
            bWLoad2.Margin = margin;
            this.BWLoad.Name = "BWLoad";
            System.Windows.Forms.Button bWLoad3 = this.BWLoad;
            size = new System.Drawing.Size(24, 24);
            bWLoad3.Size = size;
            this.BWLoad.TabIndex = 40;
            this.ToolTipUniversal.SetToolTip(this.BWLoad, "Load WaveForm");
            this.BWLoad.UseVisualStyleBackColor = true;
            this.BWClear.Image = iBMSC.My.Resources.Resources.x16Remove;
            System.Windows.Forms.Button bWClear = this.BWClear;
            location = new System.Drawing.Point(24, 0);
            bWClear.Location = location;
            System.Windows.Forms.Button bWClear2 = this.BWClear;
            margin = new System.Windows.Forms.Padding(0);
            bWClear2.Margin = margin;
            this.BWClear.Name = "BWClear";
            System.Windows.Forms.Button bWClear3 = this.BWClear;
            size = new System.Drawing.Size(24, 24);
            bWClear3.Size = size;
            this.BWClear.TabIndex = 41;
            this.ToolTipUniversal.SetToolTip(this.BWClear, "Clear WaveForm");
            this.BWClear.UseVisualStyleBackColor = true;
            this.BWLock.Appearance = System.Windows.Forms.Appearance.Button;
            this.BWLock.Checked = true;
            this.BWLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BWLock.Image = iBMSC.My.Resources.Resources.x16Lock;
            System.Windows.Forms.CheckBox bWLock = this.BWLock;
            location = new System.Drawing.Point(48, 0);
            bWLock.Location = location;
            System.Windows.Forms.CheckBox bWLock2 = this.BWLock;
            margin = new System.Windows.Forms.Padding(0);
            bWLock2.Margin = margin;
            this.BWLock.Name = "BWLock";
            System.Windows.Forms.CheckBox bWLock3 = this.BWLock;
            size = new System.Drawing.Size(24, 24);
            bWLock3.Size = size;
            this.BWLock.TabIndex = 0;
            this.ToolTipUniversal.SetToolTip(this.BWLock, "Lock to BGM");
            this.BWLock.UseVisualStyleBackColor = true;
            this.TWFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tWFileName = this.TWFileName;
            location = new System.Drawing.Point(81, 3);
            tWFileName.Location = location;
            this.TWFileName.Name = "TWFileName";
            this.TWFileName.ReadOnly = true;
            System.Windows.Forms.TextBox tWFileName2 = this.TWFileName;
            size = new System.Drawing.Size(99, 23);
            tWFileName2.Size = size;
            this.TWFileName.TabIndex = 42;
            this.TWFileName.Text = "(None)";
            this.TableLayoutPanel6.AutoSize = true;
            this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel6.ColumnCount = 3;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60f));
            this.TableLayoutPanel6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40f));
            this.TableLayoutPanel6.Controls.Add(this.PictureBox1, 0, 0);
            this.TableLayoutPanel6.Controls.Add(this.TWPosition2, 1, 0);
            this.TableLayoutPanel6.Controls.Add(this.TWPosition, 2, 0);
            this.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel7 = this.TableLayoutPanel6;
            location = new System.Drawing.Point(0, 30);
            tableLayoutPanel7.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel8 = this.TableLayoutPanel6;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel8.Margin = margin;
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 1;
            this.TableLayoutPanel6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel9 = this.TableLayoutPanel6;
            size = new System.Drawing.Size(183, 28);
            tableLayoutPanel9.Size = size;
            this.TableLayoutPanel6.TabIndex = 1;
            this.PictureBox1.Image = iBMSC.My.Resources.Resources.WAVOffset;
            System.Windows.Forms.PictureBox pictureBox16 = this.PictureBox1;
            location = new System.Drawing.Point(3, 0);
            pictureBox16.Location = location;
            System.Windows.Forms.PictureBox pictureBox17 = this.PictureBox1;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox17.Margin = margin;
            this.PictureBox1.Name = "PictureBox1";
            System.Windows.Forms.PictureBox pictureBox18 = this.PictureBox1;
            size = new System.Drawing.Size(24, 24);
            pictureBox18.Size = size;
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 59;
            this.PictureBox1.TabStop = false;
            this.TWPosition2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWPosition2.Enabled = false;
            this.TWPosition2.LargeChange = 24;
            System.Windows.Forms.TrackBar tWPosition = this.TWPosition2;
            location = new System.Drawing.Point(30, 0);
            tWPosition.Location = location;
            System.Windows.Forms.TrackBar tWPosition2 = this.TWPosition2;
            margin = new System.Windows.Forms.Padding(0);
            tWPosition2.Margin = margin;
            this.TWPosition2.Maximum = 960;
            this.TWPosition2.Name = "TWPosition2";
            System.Windows.Forms.TrackBar tWPosition3 = this.TWPosition2;
            size = new System.Drawing.Size(91, 28);
            tWPosition3.Size = size;
            this.TWPosition2.TabIndex = 58;
            this.TWPosition2.TickFrequency = 192;
            this.TWPosition.DecimalPlaces = 2;
            this.TWPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TWPosition.Enabled = false;
            System.Windows.Forms.NumericUpDown tWPosition4 = this.TWPosition;
            location = new System.Drawing.Point(121, 0);
            tWPosition4.Location = location;
            System.Windows.Forms.NumericUpDown tWPosition5 = this.TWPosition;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tWPosition5.Margin = margin;
            this.TWPosition.Maximum = new decimal(new int[4] { 192000, 0, 0, 0 });
            this.TWPosition.Name = "TWPosition";
            System.Windows.Forms.NumericUpDown tWPosition6 = this.TWPosition;
            size = new System.Drawing.Size(59, 23);
            tWPosition6.Size = size;
            this.TWPosition.TabIndex = 43;
            this.POWaveFormSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.POWaveFormSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.POWaveFormSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POWaveFormSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.POWaveFormSwitch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.CheckBox pOWaveFormSwitch = this.POWaveFormSwitch;
            location = new System.Drawing.Point(0, 0);
            pOWaveFormSwitch.Location = location;
            this.POWaveFormSwitch.Name = "POWaveFormSwitch";
            System.Windows.Forms.CheckBox pOWaveFormSwitch2 = this.POWaveFormSwitch;
            size = new System.Drawing.Size(183, 20);
            pOWaveFormSwitch2.Size = size;
            this.POWaveFormSwitch.TabIndex = 3;
            this.POWaveFormSwitch.TabStop = false;
            this.POWaveFormSwitch.Text = "WaveForm";
            this.POWaveFormSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POWaveFormSwitch.UseCompatibleTextRendering = true;
            this.POWaveFormSwitch.UseVisualStyleBackColor = false;
            this.POGrid.AutoSize = true;
            this.POGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POGrid.Controls.Add(this.POGridInner);
            this.POGrid.Controls.Add(this.POGridSwitch);
            this.POGrid.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOGrid = this.POGrid;
            location = new System.Drawing.Point(0, 439);
            pOGrid.Location = location;
            this.POGrid.Name = "POGrid";
            System.Windows.Forms.Panel pOGrid2 = this.POGrid;
            size = new System.Drawing.Size(183, 230);
            pOGrid2.Size = size;
            this.POGrid.TabIndex = 2;
            this.POGridInner.AutoSize = true;
            this.POGridInner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POGridInner.Controls.Add(this.POGridPart2);
            this.POGridInner.Controls.Add(this.POGridExpander);
            this.POGridInner.Controls.Add(this.POGridPart1);
            this.POGridInner.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOGridInner = this.POGridInner;
            location = new System.Drawing.Point(0, 20);
            pOGridInner.Location = location;
            this.POGridInner.Name = "POGridInner";
            System.Windows.Forms.Panel pOGridInner2 = this.POGridInner;
            size = new System.Drawing.Size(183, 210);
            pOGridInner2.Size = size;
            this.POGridInner.TabIndex = 3;
            this.POGridPart2.AutoSize = true;
            this.POGridPart2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POGridPart2.ColumnCount = 1;
            this.POGridPart2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POGridPart2.Controls.Add(this.TableLayoutPanel5, 0, 1);
            this.POGridPart2.Controls.Add(this.TableLayoutPanel4, 0, 0);
            this.POGridPart2.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOGridPart = this.POGridPart2;
            location = new System.Drawing.Point(0, 152);
            pOGridPart.Location = location;
            this.POGridPart2.Name = "POGridPart2";
            this.POGridPart2.RowCount = 2;
            this.POGridPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POGridPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POGridPart2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
            System.Windows.Forms.TableLayoutPanel pOGridPart2 = this.POGridPart2;
            size = new System.Drawing.Size(183, 58);
            pOGridPart2.Size = size;
            this.POGridPart2.TabIndex = 0;
            this.TableLayoutPanel5.AutoSize = true;
            this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel5.ColumnCount = 2;
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.TableLayoutPanel5.Controls.Add(this.FlowLayoutPanel2, 1, 0);
            this.TableLayoutPanel5.Controls.Add(this.Label5, 0, 0);
            this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel10 = this.TableLayoutPanel5;
            location = new System.Drawing.Point(0, 29);
            tableLayoutPanel10.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel11 = this.TableLayoutPanel5;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel11.Margin = margin;
            this.TableLayoutPanel5.Name = "TableLayoutPanel5";
            this.TableLayoutPanel5.RowCount = 1;
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel12 = this.TableLayoutPanel5;
            size = new System.Drawing.Size(183, 29);
            tableLayoutPanel12.Size = size;
            this.TableLayoutPanel5.TabIndex = 46;
            this.FlowLayoutPanel2.AutoSize = true;
            this.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel2.Controls.Add(this.cVSLockL);
            this.FlowLayoutPanel2.Controls.Add(this.cVSLock);
            this.FlowLayoutPanel2.Controls.Add(this.cVSLockR);
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5 = this.FlowLayoutPanel2;
            location = new System.Drawing.Point(115, 3);
            flowLayoutPanel5.Location = location;
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6 = this.FlowLayoutPanel2;
            size = new System.Drawing.Size(65, 23);
            flowLayoutPanel6.Size = size;
            this.FlowLayoutPanel2.TabIndex = 72;
            this.FlowLayoutPanel2.WrapContents = false;
            this.cVSLockL.Appearance = System.Windows.Forms.Appearance.Button;
            this.cVSLockL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cVSLockL.Image = iBMSC.My.Resources.Resources.x16Lock;
            System.Windows.Forms.CheckBox checkBox = this.cVSLockL;
            location = new System.Drawing.Point(0, 0);
            checkBox.Location = location;
            System.Windows.Forms.CheckBox checkBox2 = this.cVSLockL;
            margin = new System.Windows.Forms.Padding(0);
            checkBox2.Margin = margin;
            this.cVSLockL.Name = "cVSLockL";
            System.Windows.Forms.CheckBox checkBox3 = this.cVSLockL;
            size = new System.Drawing.Size(23, 23);
            checkBox3.Size = size;
            this.cVSLockL.TabIndex = 38;
            this.cVSLockL.Tag = "0";
            this.ToolTipUniversal.SetToolTip(this.cVSLockL, "Lock Left Editing Panel");
            this.cVSLock.Appearance = System.Windows.Forms.Appearance.Button;
            this.cVSLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cVSLock.Image = iBMSC.My.Resources.Resources.x16Lock;
            System.Windows.Forms.CheckBox checkBox4 = this.cVSLock;
            location = new System.Drawing.Point(23, 0);
            checkBox4.Location = location;
            System.Windows.Forms.CheckBox checkBox5 = this.cVSLock;
            margin = new System.Windows.Forms.Padding(0);
            checkBox5.Margin = margin;
            this.cVSLock.Name = "cVSLock";
            System.Windows.Forms.CheckBox checkBox6 = this.cVSLock;
            size = new System.Drawing.Size(23, 23);
            checkBox6.Size = size;
            this.cVSLock.TabIndex = 40;
            this.cVSLock.Tag = "1";
            this.ToolTipUniversal.SetToolTip(this.cVSLock, "Lock Middle Editing Panel");
            this.cVSLockR.Appearance = System.Windows.Forms.Appearance.Button;
            this.cVSLockR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cVSLockR.Image = iBMSC.My.Resources.Resources.x16Lock;
            System.Windows.Forms.CheckBox checkBox7 = this.cVSLockR;
            location = new System.Drawing.Point(46, 0);
            checkBox7.Location = location;
            System.Windows.Forms.CheckBox checkBox8 = this.cVSLockR;
            margin = new System.Windows.Forms.Padding(0);
            checkBox8.Margin = margin;
            this.cVSLockR.Name = "cVSLockR";
            System.Windows.Forms.CheckBox checkBox9 = this.cVSLockR;
            size = new System.Drawing.Size(23, 23);
            checkBox9.Size = size;
            this.cVSLockR.TabIndex = 41;
            this.cVSLockR.Tag = "2";
            this.ToolTipUniversal.SetToolTip(this.cVSLockR, "Lock Right Editing Panel");
            this.Label5.AutoSize = true;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.Label label4 = this.Label5;
            location = new System.Drawing.Point(3, 0);
            label4.Location = location;
            this.Label5.Name = "Label5";
            System.Windows.Forms.Label label5 = this.Label5;
            size = new System.Drawing.Size(106, 29);
            label5.Size = size;
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Vertical Scroll Lock";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableLayoutPanel4.AutoSize = true;
            this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel4.ColumnCount = 2;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.TableLayoutPanel4.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.CGB, 1, 0);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel13 = this.TableLayoutPanel4;
            location = new System.Drawing.Point(0, 0);
            tableLayoutPanel13.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel14 = this.TableLayoutPanel4;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel14.Margin = margin;
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 1;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel15 = this.TableLayoutPanel4;
            size = new System.Drawing.Size(183, 29);
            tableLayoutPanel15.Size = size;
            this.TableLayoutPanel4.TabIndex = 44;
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.Label label6 = this.Label1;
            location = new System.Drawing.Point(3, 0);
            label6.Location = location;
            this.Label1.Name = "Label1";
            System.Windows.Forms.Label label7 = this.Label1;
            size = new System.Drawing.Size(126, 29);
            label7.Size = size;
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Number of B Columns";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CGB.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.NumericUpDown cGB = this.CGB;
            location = new System.Drawing.Point(135, 3);
            cGB.Location = location;
            this.CGB.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
            this.CGB.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.CGB.Name = "CGB";
            System.Windows.Forms.NumericUpDown cGB2 = this.CGB;
            size = new System.Drawing.Size(45, 23);
            cGB2.Size = size;
            this.CGB.TabIndex = 35;
            this.CGB.Value = new decimal(new int[4] { 15, 0, 0, 0 });
            this.POGridExpander.Appearance = System.Windows.Forms.Appearance.Button;
            this.POGridExpander.AutoSize = true;
            this.POGridExpander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POGridExpander.Dock = System.Windows.Forms.DockStyle.Top;
            this.POGridExpander.FlatAppearance.BorderSize = 0;
            this.POGridExpander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            System.Windows.Forms.CheckBox pOGridExpander = this.POGridExpander;
            location = new System.Drawing.Point(0, 127);
            pOGridExpander.Location = location;
            System.Windows.Forms.CheckBox pOGridExpander2 = this.POGridExpander;
            margin = new System.Windows.Forms.Padding(0);
            pOGridExpander2.Margin = margin;
            this.POGridExpander.Name = "POGridExpander";
            System.Windows.Forms.CheckBox pOGridExpander3 = this.POGridExpander;
            size = new System.Drawing.Size(183, 25);
            pOGridExpander3.Size = size;
            this.POGridExpander.TabIndex = 27;
            this.POGridExpander.TabStop = false;
            this.POGridExpander.Text = "Expand...";
            this.POGridExpander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POGridExpander.UseVisualStyleBackColor = false;
            this.POGridPart1.AutoSize = true;
            this.POGridPart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POGridPart1.ColumnCount = 1;
            this.POGridPart1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POGridPart1.Controls.Add(this.TableLayoutPanel3, 0, 1);
            this.POGridPart1.Controls.Add(this.CGDisableVertical, 0, 3);
            this.POGridPart1.Controls.Add(this.CGSnap, 0, 2);
            this.POGridPart1.Controls.Add(this.TableLayoutPanel2, 0, 0);
            this.POGridPart1.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOGridPart3 = this.POGridPart1;
            location = new System.Drawing.Point(0, 0);
            pOGridPart3.Location = location;
            this.POGridPart1.Name = "POGridPart1";
            this.POGridPart1.RowCount = 4;
            this.POGridPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POGridPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POGridPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POGridPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POGridPart1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
            System.Windows.Forms.TableLayoutPanel pOGridPart4 = this.POGridPart1;
            size = new System.Drawing.Size(183, 127);
            pOGridPart4.Size = size;
            this.POGridPart1.TabIndex = 11;
            this.TableLayoutPanel3.AutoSize = true;
            this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel3.ColumnCount = 3;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70f));
            this.TableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.TableLayoutPanel3.Controls.Add(this.PictureBox9, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.CGHeight2, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.CGHeight, 2, 0);
            this.TableLayoutPanel3.Controls.Add(this.PictureBox10, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.CGWidth2, 1, 1);
            this.TableLayoutPanel3.Controls.Add(this.CGWidth, 2, 1);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel16 = this.TableLayoutPanel3;
            location = new System.Drawing.Point(0, 30);
            tableLayoutPanel16.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel17 = this.TableLayoutPanel3;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel17.Margin = margin;
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            this.TableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28f));
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel18 = this.TableLayoutPanel3;
            size = new System.Drawing.Size(183, 56);
            tableLayoutPanel18.Size = size;
            this.TableLayoutPanel3.TabIndex = 12;
            this.PictureBox9.Image = iBMSC.My.Resources.Resources.lgheight;
            System.Windows.Forms.PictureBox pictureBox19 = this.PictureBox9;
            location = new System.Drawing.Point(3, 0);
            pictureBox19.Location = location;
            System.Windows.Forms.PictureBox pictureBox20 = this.PictureBox9;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox20.Margin = margin;
            this.PictureBox9.Name = "PictureBox9";
            System.Windows.Forms.PictureBox pictureBox21 = this.PictureBox9;
            size = new System.Drawing.Size(24, 24);
            pictureBox21.Size = size;
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox9.TabIndex = 27;
            this.PictureBox9.TabStop = false;
            this.CGHeight2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CGHeight2.LargeChange = 4;
            System.Windows.Forms.TrackBar cGHeight = this.CGHeight2;
            location = new System.Drawing.Point(30, 0);
            cGHeight.Location = location;
            System.Windows.Forms.TrackBar cGHeight2 = this.CGHeight2;
            margin = new System.Windows.Forms.Padding(0);
            cGHeight2.Margin = margin;
            this.CGHeight2.Maximum = 20;
            this.CGHeight2.Minimum = 1;
            this.CGHeight2.Name = "CGHeight2";
            System.Windows.Forms.TrackBar cGHeight3 = this.CGHeight2;
            size = new System.Drawing.Size(107, 28);
            cGHeight3.Size = size;
            this.CGHeight2.TabIndex = 29;
            this.CGHeight2.TickFrequency = 2;
            this.CGHeight2.Value = 4;
            this.CGHeight.DecimalPlaces = 2;
            this.CGHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CGHeight.Increment = new decimal(new int[4] { 25, 0, 0, 131072 });
            System.Windows.Forms.NumericUpDown cGHeight4 = this.CGHeight;
            location = new System.Drawing.Point(137, 0);
            cGHeight4.Location = location;
            System.Windows.Forms.NumericUpDown cGHeight5 = this.CGHeight;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            cGHeight5.Margin = margin;
            this.CGHeight.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
            this.CGHeight.Minimum = new decimal(new int[4] { 25, 0, 0, 131072 });
            this.CGHeight.Name = "CGHeight";
            System.Windows.Forms.NumericUpDown cGHeight6 = this.CGHeight;
            size = new System.Drawing.Size(43, 23);
            cGHeight6.Size = size;
            this.CGHeight.TabIndex = 23;
            this.CGHeight.Value = new decimal(new int[4] { 1, 0, 0, 0 });
            this.PictureBox10.Image = iBMSC.My.Resources.Resources.lgwidth;
            System.Windows.Forms.PictureBox pictureBox22 = this.PictureBox10;
            location = new System.Drawing.Point(3, 28);
            pictureBox22.Location = location;
            System.Windows.Forms.PictureBox pictureBox23 = this.PictureBox10;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            pictureBox23.Margin = margin;
            this.PictureBox10.Name = "PictureBox10";
            System.Windows.Forms.PictureBox pictureBox24 = this.PictureBox10;
            size = new System.Drawing.Size(24, 24);
            pictureBox24.Size = size;
            this.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox10.TabIndex = 28;
            this.PictureBox10.TabStop = false;
            this.CGWidth2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CGWidth2.LargeChange = 4;
            System.Windows.Forms.TrackBar cGWidth = this.CGWidth2;
            location = new System.Drawing.Point(30, 28);
            cGWidth.Location = location;
            System.Windows.Forms.TrackBar cGWidth2 = this.CGWidth2;
            margin = new System.Windows.Forms.Padding(0);
            cGWidth2.Margin = margin;
            this.CGWidth2.Maximum = 20;
            this.CGWidth2.Minimum = 1;
            this.CGWidth2.Name = "CGWidth2";
            System.Windows.Forms.TrackBar cGWidth3 = this.CGWidth2;
            size = new System.Drawing.Size(107, 28);
            cGWidth3.Size = size;
            this.CGWidth2.TabIndex = 30;
            this.CGWidth2.TickFrequency = 2;
            this.CGWidth2.Value = 4;
            this.CGWidth.DecimalPlaces = 2;
            this.CGWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CGWidth.Increment = new decimal(new int[4] { 25, 0, 0, 131072 });
            System.Windows.Forms.NumericUpDown cGWidth4 = this.CGWidth;
            location = new System.Drawing.Point(137, 28);
            cGWidth4.Location = location;
            System.Windows.Forms.NumericUpDown cGWidth5 = this.CGWidth;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            cGWidth5.Margin = margin;
            this.CGWidth.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
            this.CGWidth.Minimum = new decimal(new int[4] { 25, 0, 0, 131072 });
            this.CGWidth.Name = "CGWidth";
            System.Windows.Forms.NumericUpDown cGWidth6 = this.CGWidth;
            size = new System.Drawing.Size(43, 23);
            cGWidth6.Size = size;
            this.CGWidth.TabIndex = 24;
            this.CGWidth.Value = new decimal(new int[4] { 1, 0, 0, 0 });
            this.CGDisableVertical.AutoSize = true;
            System.Windows.Forms.CheckBox cGDisableVertical = this.CGDisableVertical;
            location = new System.Drawing.Point(3, 108);
            cGDisableVertical.Location = location;
            System.Windows.Forms.CheckBox cGDisableVertical2 = this.CGDisableVertical;
            margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            cGDisableVertical2.Margin = margin;
            this.CGDisableVertical.Name = "CGDisableVertical";
            System.Windows.Forms.CheckBox cGDisableVertical3 = this.CGDisableVertical;
            size = new System.Drawing.Size(162, 19);
            cGDisableVertical3.Size = size;
            this.CGDisableVertical.TabIndex = 45;
            this.CGDisableVertical.Text = "Disable vertical moves (D)";
            this.CGDisableVertical.UseVisualStyleBackColor = true;
            this.CGSnap.AutoSize = true;
            this.CGSnap.Checked = true;
            this.CGSnap.CheckState = System.Windows.Forms.CheckState.Checked;
            System.Windows.Forms.CheckBox cGSnap = this.CGSnap;
            location = new System.Drawing.Point(3, 89);
            cGSnap.Location = location;
            System.Windows.Forms.CheckBox cGSnap2 = this.CGSnap;
            margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            cGSnap2.Margin = margin;
            this.CGSnap.Name = "CGSnap";
            System.Windows.Forms.CheckBox cGSnap3 = this.CGSnap;
            size = new System.Drawing.Size(109, 19);
            cGSnap3.Size = size;
            this.CGSnap.TabIndex = 10;
            this.CGSnap.Text = "Snap to grid (G)";
            this.CGSnap.UseVisualStyleBackColor = true;
            this.TableLayoutPanel2.AutoSize = true;
            this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel2.ColumnCount = 4;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel2.Controls.Add(this.PictureBox7, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.CGDivide, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.CGSub, 2, 0);
            this.TableLayoutPanel2.Controls.Add(this.BGSlash, 3, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel19 = this.TableLayoutPanel2;
            location = new System.Drawing.Point(0, 0);
            tableLayoutPanel19.Location = location;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel20 = this.TableLayoutPanel2;
            margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel20.Margin = margin;
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel21 = this.TableLayoutPanel2;
            size = new System.Drawing.Size(183, 30);
            tableLayoutPanel21.Size = size;
            this.TableLayoutPanel2.TabIndex = 11;
            this.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox7.Image = iBMSC.My.Resources.Resources.lgpartition;
            System.Windows.Forms.PictureBox pictureBox25 = this.PictureBox7;
            location = new System.Drawing.Point(3, 3);
            pictureBox25.Location = location;
            this.PictureBox7.Name = "PictureBox7";
            System.Windows.Forms.PictureBox pictureBox26 = this.PictureBox7;
            size = new System.Drawing.Size(24, 24);
            pictureBox26.Size = size;
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox7.TabIndex = 25;
            this.PictureBox7.TabStop = false;
            this.CGDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.NumericUpDown cGDivide = this.CGDivide;
            location = new System.Drawing.Point(33, 3);
            cGDivide.Location = location;
            this.CGDivide.Maximum = new decimal(new int[4] { 1920, 0, 0, 0 });
            this.CGDivide.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.CGDivide.Name = "CGDivide";
            System.Windows.Forms.NumericUpDown cGDivide2 = this.CGDivide;
            size = new System.Drawing.Size(58, 23);
            cGDivide2.Size = size;
            this.CGDivide.TabIndex = 36;
            this.CGDivide.Value = new decimal(new int[4] { 16, 0, 0, 0 });
            this.CGSub.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.NumericUpDown cGSub = this.CGSub;
            location = new System.Drawing.Point(97, 3);
            cGSub.Location = location;
            this.CGSub.Maximum = new decimal(new int[4] { 1920, 0, 0, 0 });
            this.CGSub.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
            this.CGSub.Name = "CGSub";
            System.Windows.Forms.NumericUpDown cGSub2 = this.CGSub;
            size = new System.Drawing.Size(58, 23);
            cGSub2.Size = size;
            this.CGSub.TabIndex = 37;
            this.CGSub.Value = new decimal(new int[4] { 4, 0, 0, 0 });
            this.BGSlash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BGSlash.Image = iBMSC.My.Resources.Resources.Shortcut;
            System.Windows.Forms.Button bGSlash = this.BGSlash;
            location = new System.Drawing.Point(158, 4);
            bGSlash.Location = location;
            System.Windows.Forms.Button bGSlash2 = this.BGSlash;
            margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            bGSlash2.Margin = margin;
            this.BGSlash.Name = "BGSlash";
            System.Windows.Forms.Button bGSlash3 = this.BGSlash;
            size = new System.Drawing.Size(22, 22);
            bGSlash3.Size = size;
            this.BGSlash.TabIndex = 38;
            this.BGSlash.UseVisualStyleBackColor = true;
            this.POGridSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.POGridSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.POGridSwitch.Checked = true;
            this.POGridSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.POGridSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POGridSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.POGridSwitch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.CheckBox pOGridSwitch = this.POGridSwitch;
            location = new System.Drawing.Point(0, 0);
            pOGridSwitch.Location = location;
            this.POGridSwitch.Name = "POGridSwitch";
            System.Windows.Forms.CheckBox pOGridSwitch2 = this.POGridSwitch;
            size = new System.Drawing.Size(183, 20);
            pOGridSwitch2.Size = size;
            this.POGridSwitch.TabIndex = 2;
            this.POGridSwitch.TabStop = false;
            this.POGridSwitch.Text = "Grid";
            this.POGridSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POGridSwitch.UseCompatibleTextRendering = true;
            this.POGridSwitch.UseVisualStyleBackColor = false;
            this.POHeader.AutoSize = true;
            this.POHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POHeader.Controls.Add(this.POHeaderInner);
            this.POHeader.Controls.Add(this.POHeaderSwitch);
            this.POHeader.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOHeader = this.POHeader;
            location = new System.Drawing.Point(0, 0);
            pOHeader.Location = location;
            this.POHeader.Name = "POHeader";
            System.Windows.Forms.Panel pOHeader2 = this.POHeader;
            size = new System.Drawing.Size(183, 439);
            pOHeader2.Size = size;
            this.POHeader.TabIndex = 1;
            this.POHeaderInner.AutoSize = true;
            this.POHeaderInner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POHeaderInner.Controls.Add(this.POHeaderPart2);
            this.POHeaderInner.Controls.Add(this.POHeaderExpander);
            this.POHeaderInner.Controls.Add(this.POHeaderPart1);
            this.POHeaderInner.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.Panel pOHeaderInner = this.POHeaderInner;
            location = new System.Drawing.Point(0, 20);
            pOHeaderInner.Location = location;
            this.POHeaderInner.Name = "POHeaderInner";
            System.Windows.Forms.Panel pOHeaderInner2 = this.POHeaderInner;
            size = new System.Drawing.Size(183, 419);
            pOHeaderInner2.Size = size;
            this.POHeaderInner.TabIndex = 2;
            this.POHeaderPart2.AutoSize = true;
            this.POHeaderPart2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POHeaderPart2.ColumnCount = 3;
            this.POHeaderPart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.POHeaderPart2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POHeaderPart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.POHeaderPart2.Controls.Add(this.CHDifficulty, 1, 5);
            this.POHeaderPart2.Controls.Add(this.Label13, 2, 6);
            this.POHeaderPart2.Controls.Add(this.THExRank, 1, 6);
            this.POHeaderPart2.Controls.Add(this.Label25, 2, 7);
            this.POHeaderPart2.Controls.Add(this.CHLnObj, 1, 9);
            this.POHeaderPart2.Controls.Add(this.Label23, 0, 6);
            this.POHeaderPart2.Controls.Add(this.Label21, 0, 5);
            this.POHeaderPart2.Controls.Add(this.THComment, 1, 8);
            this.POHeaderPart2.Controls.Add(this.Label24, 0, 9);
            this.POHeaderPart2.Controls.Add(this.Label15, 0, 0);
            this.POHeaderPart2.Controls.Add(this.THTotal, 1, 7);
            this.POHeaderPart2.Controls.Add(this.Label20, 0, 7);
            this.POHeaderPart2.Controls.Add(this.BHStageFile, 2, 2);
            this.POHeaderPart2.Controls.Add(this.BHBanner, 2, 3);
            this.POHeaderPart2.Controls.Add(this.Label19, 0, 8);
            this.POHeaderPart2.Controls.Add(this.BHBackBMP, 2, 4);
            this.POHeaderPart2.Controls.Add(this.Label17, 0, 1);
            this.POHeaderPart2.Controls.Add(this.Label16, 0, 2);
            this.POHeaderPart2.Controls.Add(this.Label12, 0, 3);
            this.POHeaderPart2.Controls.Add(this.THBackBMP, 1, 4);
            this.POHeaderPart2.Controls.Add(this.Label11, 0, 4);
            this.POHeaderPart2.Controls.Add(this.THBanner, 1, 3);
            this.POHeaderPart2.Controls.Add(this.THStageFile, 1, 2);
            this.POHeaderPart2.Controls.Add(this.THSubTitle, 1, 0);
            this.POHeaderPart2.Controls.Add(this.THSubArtist, 1, 1);
            this.POHeaderPart2.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOHeaderPart = this.POHeaderPart2;
            location = new System.Drawing.Point(0, 186);
            pOHeaderPart.Location = location;
            this.POHeaderPart2.Name = "POHeaderPart2";
            this.POHeaderPart2.RowCount = 10;
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOHeaderPart2 = this.POHeaderPart2;
            size = new System.Drawing.Size(183, 233);
            pOHeaderPart2.Size = size;
            this.POHeaderPart2.TabIndex = 27;
            this.POHeaderPart2.SetColumnSpan(this.CHDifficulty, 2);
            this.CHDifficulty.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CHDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CHDifficulty.Items.AddRange(new object[6]
            {
                "None", "1 - EZ / Beginner", "2 - NM / Normal", "3 - HD / Hyper", "4 - MX / Another", "5 - SC / Insane"
            });
            System.Windows.Forms.ComboBox cHDifficulty = this.CHDifficulty;
            location = new System.Drawing.Point(67, 118);
            cHDifficulty.Location = location;
            System.Windows.Forms.ComboBox cHDifficulty2 = this.CHDifficulty;
            margin = new System.Windows.Forms.Padding(0);
            cHDifficulty2.Margin = margin;
            this.CHDifficulty.Name = "CHDifficulty";
            System.Windows.Forms.ComboBox cHDifficulty3 = this.CHDifficulty;
            size = new System.Drawing.Size(116, 23);
            cHDifficulty3.Size = size;
            this.CHDifficulty.TabIndex = 63;
            this.Label13.AutoSize = true;
            this.Label13.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.Label label8 = this.Label13;
            location = new System.Drawing.Point(158, 141);
            label8.Location = location;
            System.Windows.Forms.Label label9 = this.Label13;
            margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label9.Margin = margin;
            this.Label13.Name = "Label13";
            System.Windows.Forms.Label label10 = this.Label13;
            size = new System.Drawing.Size(25, 23);
            label10.Size = size;
            this.Label13.TabIndex = 63;
            this.Label13.Text = "(%)";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.THExRank.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHExRank = this.THExRank;
            location = new System.Drawing.Point(67, 141);
            tHExRank.Location = location;
            System.Windows.Forms.TextBox tHExRank2 = this.THExRank;
            margin = new System.Windows.Forms.Padding(0);
            tHExRank2.Margin = margin;
            this.THExRank.Name = "THExRank";
            System.Windows.Forms.TextBox tHExRank3 = this.THExRank;
            size = new System.Drawing.Size(88, 23);
            tHExRank3.Size = size;
            this.THExRank.TabIndex = 27;
            this.Label25.AutoSize = true;
            this.Label25.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.Label label11 = this.Label25;
            location = new System.Drawing.Point(158, 164);
            label11.Location = location;
            System.Windows.Forms.Label label12 = this.Label25;
            margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label12.Margin = margin;
            this.Label25.Name = "Label25";
            System.Windows.Forms.Label label13 = this.Label25;
            size = new System.Drawing.Size(25, 23);
            label13.Size = size;
            this.Label25.TabIndex = 23;
            this.Label25.Text = "(%)";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.POHeaderPart2.SetColumnSpan(this.CHLnObj, 2);
            this.CHLnObj.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHLnObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CHLnObj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CHLnObj.Items.AddRange(new object[1296]
            {
                "None (#LnType 1)", "01", "02", "03", "04", "05", "06", "07", "08", "09",
                "0A", "0B", "0C", "0D", "0E", "0F", "0G", "0H", "0I", "0J",
                "0K", "0L", "0M", "0N", "0O", "0P", "0Q", "0R", "0S", "0T",
                "0U", "0V", "0W", "0X", "0Y", "0Z", "10", "11", "12", "13",
                "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D",
                "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N",
                "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X",
                "1Y", "1Z", "20", "21", "22", "23", "24", "25", "26", "27",
                "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H",
                "2I", "2J", "2K", "2L", "2M", "2N", "2O", "2P", "2Q", "2R",
                "2S", "2T", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31",
                "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B",
                "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L",
                "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V",
                "3W", "3X", "3Y", "3Z", "40", "41", "42", "43", "44", "45",
                "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F",
                "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P",
                "4Q", "4R", "4S", "4T", "4U", "4V", "4W", "4X", "4Y", "4Z",
                "50", "51", "52", "53", "54", "55", "56", "57", "58", "59",
                "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J",
                "5K", "5L", "5M", "5N", "5O", "5P", "5Q", "5R", "5S", "5T",
                "5U", "5V", "5W", "5X", "5Y", "5Z", "60", "61", "62", "63",
                "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D",
                "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N",
                "6O", "6P", "6Q", "6R", "6S", "6T", "6U", "6V", "6W", "6X",
                "6Y", "6Z", "70", "71", "72", "73", "74", "75", "76", "77",
                "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "7G", "7H",
                "7I", "7J", "7K", "7L", "7M", "7N", "7O", "7P", "7Q", "7R",
                "7S", "7T", "7U", "7V", "7W", "7X", "7Y", "7Z", "80", "81",
                "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B",
                "8C", "8D", "8E", "8F", "8G", "8H", "8I", "8J", "8K", "8L",
                "8M", "8N", "8O", "8P", "8Q", "8R", "8S", "8T", "8U", "8V",
                "8W", "8X", "8Y", "8Z", "90", "91", "92", "93", "94", "95",
                "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F",
                "9G", "9H", "9I", "9J", "9K", "9L", "9M", "9N", "9O", "9P",
                "9Q", "9R", "9S", "9T", "9U", "9V", "9W", "9X", "9Y", "9Z",
                "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9",
                "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ",
                "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT",
                "AU", "AV", "AW", "AX", "AY", "AZ", "B0", "B1", "B2", "B3",
                "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD",
                "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN",
                "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX",
                "BY", "BZ", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7",
                "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH",
                "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR",
                "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D0", "D1",
                "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB",
                "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL",
                "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV",
                "DW", "DX", "DY", "DZ", "E0", "E1", "E2", "E3", "E4", "E5",
                "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF",
                "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP",
                "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ",
                "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9",
                "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ",
                "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT",
                "FU", "FV", "FW", "FX", "FY", "FZ", "G0", "G1", "G2", "G3",
                "G4", "G5", "G6", "G7", "G8", "G9", "GA", "GB", "GC", "GD",
                "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN",
                "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX",
                "GY", "GZ", "H0", "H1", "H2", "H3", "H4", "H5", "H6", "H7",
                "H8", "H9", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH",
                "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR",
                "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", "I0", "I1",
                "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "IA", "IB",
                "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL",
                "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV",
                "IW", "IX", "IY", "IZ", "J0", "J1", "J2", "J3", "J4", "J5",
                "J6", "J7", "J8", "J9", "JA", "JB", "JC", "JD", "JE", "JF",
                "JG", "JH", "JI", "JJ", "JK", "JL", "JM", "JN", "JO", "JP",
                "JQ", "JR", "JS", "JT", "JU", "JV", "JW", "JX", "JY", "JZ",
                "K0", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9",
                "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ",
                "KK", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KT",
                "KU", "KV", "KW", "KX", "KY", "KZ", "L0", "L1", "L2", "L3",
                "L4", "L5", "L6", "L7", "L8", "L9", "LA", "LB", "LC", "LD",
                "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN",
                "LO", "LP", "LQ", "LR", "LS", "LT", "LU", "LV", "LW", "LX",
                "LY", "LZ", "M0", "M1", "M2", "M3", "M4", "M5", "M6", "M7",
                "M8", "M9", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH",
                "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR",
                "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "N0", "N1",
                "N2", "N3", "N4", "N5", "N6", "N7", "N8", "N9", "NA", "NB",
                "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NK", "NL",
                "NM", "NN", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV",
                "NW", "NX", "NY", "NZ", "O0", "O1", "O2", "O3", "O4", "O5",
                "O6", "O7", "O8", "O9", "OA", "OB", "OC", "OD", "OE", "OF",
                "OG", "OH", "OI", "OJ", "OK", "OL", "OM", "ON", "OO", "OP",
                "OQ", "OR", "OS", "OT", "OU", "OV", "OW", "OX", "OY", "OZ",
                "P0", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9",
                "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ",
                "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT",
                "PU", "PV", "PW", "PX", "PY", "PZ", "Q0", "Q1", "Q2", "Q3",
                "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "QA", "QB", "QC", "QD",
                "QE", "QF", "QG", "QH", "QI", "QJ", "QK", "QL", "QM", "QN",
                "QO", "QP", "QQ", "QR", "QS", "QT", "QU", "QV", "QW", "QX",
                "QY", "QZ", "R0", "R1", "R2", "R3", "R4", "R5", "R6", "R7",
                "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH",
                "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR",
                "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "S0", "S1",
                "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB",
                "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL",
                "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV",
                "SW", "SX", "SY", "SZ", "T0", "T1", "T2", "T3", "T4", "T5",
                "T6", "T7", "T8", "T9", "TA", "TB", "TC", "TD", "TE", "TF",
                "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP",
                "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ",
                "U0", "U1", "U2", "U3", "U4", "U5", "U6", "U7", "U8", "U9",
                "UA", "UB", "UC", "UD", "UE", "UF", "UG", "UH", "UI", "UJ",
                "UK", "UL", "UM", "UN", "UO", "UP", "UQ", "UR", "US", "UT",
                "UU", "UV", "UW", "UX", "UY", "UZ", "V0", "V1", "V2", "V3",
                "V4", "V5", "V6", "V7", "V8", "V9", "VA", "VB", "VC", "VD",
                "VE", "VF", "VG", "VH", "VI", "VJ", "VK", "VL", "VM", "VN",
                "VO", "VP", "VQ", "VR", "VS", "VT", "VU", "VV", "VW", "VX",
                "VY", "VZ", "W0", "W1", "W2", "W3", "W4", "W5", "W6", "W7",
                "W8", "W9", "WA", "WB", "WC", "WD", "WE", "WF", "WG", "WH",
                "WI", "WJ", "WK", "WL", "WM", "WN", "WO", "WP", "WQ", "WR",
                "WS", "WT", "WU", "WV", "WW", "WX", "WY", "WZ", "X0", "X1",
                "X2", "X3", "X4", "X5", "X6", "X7", "X8", "X9", "XA", "XB",
                "XC", "XD", "XE", "XF", "XG", "XH", "XI", "XJ", "XK", "XL",
                "XM", "XN", "XO", "XP", "XQ", "XR", "XS", "XT", "XU", "XV",
                "XW", "XX", "XY", "XZ", "Y0", "Y1", "Y2", "Y3", "Y4", "Y5",
                "Y6", "Y7", "Y8", "Y9", "YA", "YB", "YC", "YD", "YE", "YF",
                "YG", "YH", "YI", "YJ", "YK", "YL", "YM", "YN", "YO", "YP",
                "YQ", "YR", "YS", "YT", "YU", "YV", "YW", "YX", "YY", "YZ",
                "Z0", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z7", "Z8", "Z9",
                "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ",
                "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZQ", "ZR", "ZS", "ZT",
                "ZU", "ZV", "ZW", "ZX", "ZY", "ZZ"
            });
            System.Windows.Forms.ComboBox cHLnObj = this.CHLnObj;
            location = new System.Drawing.Point(67, 210);
            cHLnObj.Location = location;
            System.Windows.Forms.ComboBox cHLnObj2 = this.CHLnObj;
            margin = new System.Windows.Forms.Padding(0);
            cHLnObj2.Margin = margin;
            this.CHLnObj.Name = "CHLnObj";
            System.Windows.Forms.ComboBox cHLnObj3 = this.CHLnObj;
            size = new System.Drawing.Size(116, 23);
            cHLnObj3.Size = size;
            this.CHLnObj.TabIndex = 28;
            this.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label23.AutoSize = true;
            System.Windows.Forms.Label label14 = this.Label23;
            location = new System.Drawing.Point(20, 145);
            label14.Location = location;
            this.Label23.Name = "Label23";
            System.Windows.Forms.Label label15 = this.Label23;
            size = new System.Drawing.Size(44, 15);
            label15.Size = size;
            this.Label23.TabIndex = 26;
            this.Label23.Text = "ExRank";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label21.AutoSize = true;
            System.Windows.Forms.Label label16 = this.Label21;
            location = new System.Drawing.Point(9, 122);
            label16.Location = location;
            this.Label21.Name = "Label21";
            System.Windows.Forms.Label label17 = this.Label21;
            size = new System.Drawing.Size(55, 15);
            label17.Size = size;
            this.Label21.TabIndex = 25;
            this.Label21.Text = "Difficulty";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.POHeaderPart2.SetColumnSpan(this.THComment, 2);
            this.THComment.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHComment = this.THComment;
            location = new System.Drawing.Point(67, 187);
            tHComment.Location = location;
            System.Windows.Forms.TextBox tHComment2 = this.THComment;
            margin = new System.Windows.Forms.Padding(0);
            tHComment2.Margin = margin;
            this.THComment.Name = "THComment";
            System.Windows.Forms.TextBox tHComment3 = this.THComment;
            size = new System.Drawing.Size(116, 23);
            tHComment3.Size = size;
            this.THComment.TabIndex = 19;
            this.Label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label24.AutoSize = true;
            System.Windows.Forms.Label label18 = this.Label24;
            location = new System.Drawing.Point(25, 214);
            label18.Location = location;
            this.Label24.Name = "Label24";
            System.Windows.Forms.Label label19 = this.Label24;
            size = new System.Drawing.Size(39, 15);
            label19.Size = size;
            this.Label24.TabIndex = 27;
            this.Label24.Text = "LnObj";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label15.AutoSize = true;
            System.Windows.Forms.Label label20 = this.Label15;
            location = new System.Drawing.Point(14, 4);
            label20.Location = location;
            this.Label15.Name = "Label15";
            System.Windows.Forms.Label label21 = this.Label15;
            size = new System.Drawing.Size(50, 15);
            label21.Size = size;
            this.Label15.TabIndex = 6;
            this.Label15.Text = "SubTitle";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.THTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHTotal = this.THTotal;
            location = new System.Drawing.Point(67, 164);
            tHTotal.Location = location;
            System.Windows.Forms.TextBox tHTotal2 = this.THTotal;
            margin = new System.Windows.Forms.Padding(0);
            tHTotal2.Margin = margin;
            this.THTotal.Name = "THTotal";
            System.Windows.Forms.TextBox tHTotal3 = this.THTotal;
            size = new System.Drawing.Size(88, 23);
            tHTotal3.Size = size;
            this.THTotal.TabIndex = 5;
            this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label20.AutoSize = true;
            System.Windows.Forms.Label label22 = this.Label20;
            location = new System.Drawing.Point(30, 168);
            label22.Location = location;
            this.Label20.Name = "Label20";
            System.Windows.Forms.Label label23 = this.Label20;
            size = new System.Drawing.Size(34, 15);
            label23.Size = size;
            this.Label20.TabIndex = 5;
            this.Label20.Text = "Total";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BHStageFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BHStageFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            System.Windows.Forms.Button bHStageFile = this.BHStageFile;
            location = new System.Drawing.Point(158, 46);
            bHStageFile.Location = location;
            System.Windows.Forms.Button bHStageFile2 = this.BHStageFile;
            margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            bHStageFile2.Margin = margin;
            this.BHStageFile.Name = "BHStageFile";
            System.Windows.Forms.Button bHStageFile3 = this.BHStageFile;
            size = new System.Drawing.Size(25, 24);
            bHStageFile3.Size = size;
            this.BHStageFile.TabIndex = 20;
            this.BHStageFile.Text = "...";
            this.BHStageFile.UseVisualStyleBackColor = true;
            this.BHBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BHBanner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            System.Windows.Forms.Button bHBanner = this.BHBanner;
            location = new System.Drawing.Point(158, 70);
            bHBanner.Location = location;
            System.Windows.Forms.Button bHBanner2 = this.BHBanner;
            margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            bHBanner2.Margin = margin;
            this.BHBanner.Name = "BHBanner";
            System.Windows.Forms.Button bHBanner3 = this.BHBanner;
            size = new System.Drawing.Size(25, 24);
            bHBanner3.Size = size;
            this.BHBanner.TabIndex = 21;
            this.BHBanner.Text = "...";
            this.BHBanner.UseVisualStyleBackColor = true;
            this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label19.AutoSize = true;
            System.Windows.Forms.Label label24 = this.Label19;
            location = new System.Drawing.Point(3, 191);
            label24.Location = location;
            this.Label19.Name = "Label19";
            System.Windows.Forms.Label label25 = this.Label19;
            size = new System.Drawing.Size(61, 15);
            label25.Size = size;
            this.Label19.TabIndex = 13;
            this.Label19.Text = "Comment";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BHBackBMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BHBackBMP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            System.Windows.Forms.Button bHBackBMP = this.BHBackBMP;
            location = new System.Drawing.Point(158, 94);
            bHBackBMP.Location = location;
            System.Windows.Forms.Button bHBackBMP2 = this.BHBackBMP;
            margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            bHBackBMP2.Margin = margin;
            this.BHBackBMP.Name = "BHBackBMP";
            System.Windows.Forms.Button bHBackBMP3 = this.BHBackBMP;
            size = new System.Drawing.Size(25, 24);
            bHBackBMP3.Size = size;
            this.BHBackBMP.TabIndex = 22;
            this.BHBackBMP.Text = "...";
            this.BHBackBMP.UseVisualStyleBackColor = true;
            this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label17.AutoSize = true;
            System.Windows.Forms.Label label26 = this.Label17;
            location = new System.Drawing.Point(9, 27);
            label26.Location = location;
            this.Label17.Name = "Label17";
            System.Windows.Forms.Label label27 = this.Label17;
            size = new System.Drawing.Size(55, 15);
            label27.Size = size;
            this.Label17.TabIndex = 7;
            this.Label17.Text = "SubArtist";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label16.AutoSize = true;
            System.Windows.Forms.Label label28 = this.Label16;
            location = new System.Drawing.Point(7, 50);
            label28.Location = location;
            this.Label16.Name = "Label16";
            System.Windows.Forms.Label label29 = this.Label16;
            size = new System.Drawing.Size(57, 15);
            label29.Size = size;
            this.Label16.TabIndex = 9;
            this.Label16.Text = "Stage File";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label12.AutoSize = true;
            System.Windows.Forms.Label label30 = this.Label12;
            location = new System.Drawing.Point(20, 74);
            label30.Location = location;
            this.Label12.Name = "Label12";
            System.Windows.Forms.Label label31 = this.Label12;
            size = new System.Drawing.Size(44, 15);
            label31.Size = size;
            this.Label12.TabIndex = 13;
            this.Label12.Text = "Banner";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.THBackBMP.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHBackBMP = this.THBackBMP;
            location = new System.Drawing.Point(67, 94);
            tHBackBMP.Location = location;
            System.Windows.Forms.TextBox tHBackBMP2 = this.THBackBMP;
            margin = new System.Windows.Forms.Padding(0);
            tHBackBMP2.Margin = margin;
            this.THBackBMP.Name = "THBackBMP";
            System.Windows.Forms.TextBox tHBackBMP3 = this.THBackBMP;
            size = new System.Drawing.Size(88, 23);
            tHBackBMP3.Size = size;
            this.THBackBMP.TabIndex = 17;
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label11.AutoSize = true;
            System.Windows.Forms.Label label32 = this.Label11;
            location = new System.Drawing.Point(4, 98);
            label32.Location = location;
            this.Label11.Name = "Label11";
            System.Windows.Forms.Label label33 = this.Label11;
            size = new System.Drawing.Size(60, 15);
            label33.Size = size;
            this.Label11.TabIndex = 16;
            this.Label11.Text = "Back BMP";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.THBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHBanner = this.THBanner;
            location = new System.Drawing.Point(67, 70);
            tHBanner.Location = location;
            System.Windows.Forms.TextBox tHBanner2 = this.THBanner;
            margin = new System.Windows.Forms.Padding(0);
            tHBanner2.Margin = margin;
            this.THBanner.Name = "THBanner";
            System.Windows.Forms.TextBox tHBanner3 = this.THBanner;
            size = new System.Drawing.Size(88, 23);
            tHBanner3.Size = size;
            this.THBanner.TabIndex = 19;
            this.THStageFile.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHStageFile = this.THStageFile;
            location = new System.Drawing.Point(67, 46);
            tHStageFile.Location = location;
            System.Windows.Forms.TextBox tHStageFile2 = this.THStageFile;
            margin = new System.Windows.Forms.Padding(0);
            tHStageFile2.Margin = margin;
            this.THStageFile.Name = "THStageFile";
            System.Windows.Forms.TextBox tHStageFile3 = this.THStageFile;
            size = new System.Drawing.Size(88, 23);
            tHStageFile3.Size = size;
            this.THStageFile.TabIndex = 18;
            this.POHeaderPart2.SetColumnSpan(this.THSubTitle, 2);
            this.THSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHSubTitle = this.THSubTitle;
            location = new System.Drawing.Point(67, 0);
            tHSubTitle.Location = location;
            System.Windows.Forms.TextBox tHSubTitle2 = this.THSubTitle;
            margin = new System.Windows.Forms.Padding(0);
            tHSubTitle2.Margin = margin;
            this.THSubTitle.Name = "THSubTitle";
            System.Windows.Forms.TextBox tHSubTitle3 = this.THSubTitle;
            size = new System.Drawing.Size(116, 23);
            tHSubTitle3.Size = size;
            this.THSubTitle.TabIndex = 6;
            this.POHeaderPart2.SetColumnSpan(this.THSubArtist, 2);
            this.THSubArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHSubArtist = this.THSubArtist;
            location = new System.Drawing.Point(67, 23);
            tHSubArtist.Location = location;
            System.Windows.Forms.TextBox tHSubArtist2 = this.THSubArtist;
            margin = new System.Windows.Forms.Padding(0);
            tHSubArtist2.Margin = margin;
            this.THSubArtist.Name = "THSubArtist";
            System.Windows.Forms.TextBox tHSubArtist3 = this.THSubArtist;
            size = new System.Drawing.Size(116, 23);
            tHSubArtist3.Size = size;
            this.THSubArtist.TabIndex = 7;
            this.POHeaderExpander.Appearance = System.Windows.Forms.Appearance.Button;
            this.POHeaderExpander.AutoSize = true;
            this.POHeaderExpander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POHeaderExpander.Dock = System.Windows.Forms.DockStyle.Top;
            this.POHeaderExpander.FlatAppearance.BorderSize = 0;
            this.POHeaderExpander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            System.Windows.Forms.CheckBox pOHeaderExpander = this.POHeaderExpander;
            location = new System.Drawing.Point(0, 161);
            pOHeaderExpander.Location = location;
            System.Windows.Forms.CheckBox pOHeaderExpander2 = this.POHeaderExpander;
            margin = new System.Windows.Forms.Padding(0);
            pOHeaderExpander2.Margin = margin;
            this.POHeaderExpander.Name = "POHeaderExpander";
            System.Windows.Forms.CheckBox pOHeaderExpander3 = this.POHeaderExpander;
            size = new System.Drawing.Size(183, 25);
            pOHeaderExpander3.Size = size;
            this.POHeaderExpander.TabIndex = 26;
            this.POHeaderExpander.TabStop = false;
            this.POHeaderExpander.Text = "Expand...";
            this.POHeaderExpander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POHeaderExpander.UseVisualStyleBackColor = false;
            this.POHeaderPart1.AutoSize = true;
            this.POHeaderPart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POHeaderPart1.ColumnCount = 2;
            this.POHeaderPart1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.POHeaderPart1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.POHeaderPart1.Controls.Add(this.Label3, 0, 0);
            this.POHeaderPart1.Controls.Add(this.THPlayLevel, 1, 6);
            this.POHeaderPart1.Controls.Add(this.CHRank, 1, 5);
            this.POHeaderPart1.Controls.Add(this.Label10, 0, 5);
            this.POHeaderPart1.Controls.Add(this.CHPlayer, 1, 4);
            this.POHeaderPart1.Controls.Add(this.Label4, 0, 1);
            this.POHeaderPart1.Controls.Add(this.THGenre, 1, 2);
            this.POHeaderPart1.Controls.Add(this.THBPM, 1, 3);
            this.POHeaderPart1.Controls.Add(this.Label2, 0, 2);
            this.POHeaderPart1.Controls.Add(this.THArtist, 1, 1);
            this.POHeaderPart1.Controls.Add(this.THTitle, 1, 0);
            this.POHeaderPart1.Controls.Add(this.Label9, 0, 3);
            this.POHeaderPart1.Controls.Add(this.Label8, 0, 4);
            this.POHeaderPart1.Controls.Add(this.Label6, 0, 6);
            this.POHeaderPart1.Dock = System.Windows.Forms.DockStyle.Top;
            System.Windows.Forms.TableLayoutPanel pOHeaderPart3 = this.POHeaderPart1;
            location = new System.Drawing.Point(0, 0);
            pOHeaderPart3.Location = location;
            this.POHeaderPart1.Name = "POHeaderPart1";
            this.POHeaderPart1.RowCount = 7;
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.POHeaderPart1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            System.Windows.Forms.TableLayoutPanel pOHeaderPart4 = this.POHeaderPart1;
            size = new System.Drawing.Size(183, 161);
            pOHeaderPart4.Size = size;
            this.POHeaderPart1.TabIndex = 25;
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label3.AutoSize = true;
            System.Windows.Forms.Label label34 = this.Label3;
            location = new System.Drawing.Point(32, 4);
            label34.Location = location;
            this.Label3.Name = "Label3";
            System.Windows.Forms.Label label35 = this.Label3;
            size = new System.Drawing.Size(30, 15);
            label35.Size = size;
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Title";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.THPlayLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHPlayLevel = this.THPlayLevel;
            location = new System.Drawing.Point(65, 138);
            tHPlayLevel.Location = location;
            System.Windows.Forms.TextBox tHPlayLevel2 = this.THPlayLevel;
            margin = new System.Windows.Forms.Padding(0);
            tHPlayLevel2.Margin = margin;
            this.THPlayLevel.Name = "THPlayLevel";
            System.Windows.Forms.TextBox tHPlayLevel3 = this.THPlayLevel;
            size = new System.Drawing.Size(118, 23);
            tHPlayLevel3.Size = size;
            this.THPlayLevel.TabIndex = 8;
            this.CHRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CHRank.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CHRank.Items.AddRange(new object[5]
                { "0 - Very Hard", "1 - Hard", "2 - Normal", "3 - Easy", "4 - Very Easy" });
            System.Windows.Forms.ComboBox cHRank = this.CHRank;
            location = new System.Drawing.Point(65, 115);
            cHRank.Location = location;
            System.Windows.Forms.ComboBox cHRank2 = this.CHRank;
            margin = new System.Windows.Forms.Padding(0);
            cHRank2.Margin = margin;
            this.CHRank.Name = "CHRank";
            System.Windows.Forms.ComboBox cHRank3 = this.CHRank;
            size = new System.Drawing.Size(118, 23);
            cHRank3.Size = size;
            this.CHRank.TabIndex = 15;
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label10.AutoSize = true;
            System.Windows.Forms.Label label36 = this.Label10;
            location = new System.Drawing.Point(29, 119);
            label36.Location = location;
            this.Label10.Name = "Label10";
            System.Windows.Forms.Label label37 = this.Label10;
            size = new System.Drawing.Size(33, 15);
            label37.Size = size;
            this.Label10.TabIndex = 16;
            this.Label10.Text = "Rank";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CHPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CHPlayer.Items.AddRange(new object[3] { "1 - Single Play", "2 - Couple Play", "3 - Double Play" });
            System.Windows.Forms.ComboBox cHPlayer = this.CHPlayer;
            location = new System.Drawing.Point(65, 92);
            cHPlayer.Location = location;
            System.Windows.Forms.ComboBox cHPlayer2 = this.CHPlayer;
            margin = new System.Windows.Forms.Padding(0);
            cHPlayer2.Margin = margin;
            this.CHPlayer.Name = "CHPlayer";
            System.Windows.Forms.ComboBox cHPlayer3 = this.CHPlayer;
            size = new System.Drawing.Size(118, 23);
            cHPlayer3.Size = size;
            this.CHPlayer.TabIndex = 14;
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label4.AutoSize = true;
            System.Windows.Forms.Label label38 = this.Label4;
            location = new System.Drawing.Point(27, 27);
            label38.Location = location;
            this.Label4.Name = "Label4";
            System.Windows.Forms.Label label39 = this.Label4;
            size = new System.Drawing.Size(35, 15);
            label39.Size = size;
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Artist";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.THGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHGenre = this.THGenre;
            location = new System.Drawing.Point(65, 46);
            tHGenre.Location = location;
            System.Windows.Forms.TextBox tHGenre2 = this.THGenre;
            margin = new System.Windows.Forms.Padding(0);
            tHGenre2.Margin = margin;
            this.THGenre.Name = "THGenre";
            System.Windows.Forms.TextBox tHGenre3 = this.THGenre;
            size = new System.Drawing.Size(118, 23);
            tHGenre3.Size = size;
            this.THGenre.TabIndex = 5;
            this.THBPM.DecimalPlaces = 4;
            this.THBPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.THBPM.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
            System.Windows.Forms.NumericUpDown tHBPM = this.THBPM;
            location = new System.Drawing.Point(65, 69);
            tHBPM.Location = location;
            System.Windows.Forms.NumericUpDown tHBPM2 = this.THBPM;
            margin = new System.Windows.Forms.Padding(0);
            tHBPM2.Margin = margin;
            this.THBPM.Maximum = new decimal(new int[4] { 655359999, 0, 0, 262144 });
            this.THBPM.Minimum = new decimal(new int[4] { 1, 0, 0, 262144 });
            this.THBPM.Name = "THBPM";
            System.Windows.Forms.NumericUpDown tHBPM3 = this.THBPM;
            size = new System.Drawing.Size(118, 23);
            tHBPM3.Size = size;
            this.THBPM.TabIndex = 10;
            this.THBPM.Value = new decimal(new int[4] { 120, 0, 0, 0 });
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label2.AutoSize = true;
            System.Windows.Forms.Label label40 = this.Label2;
            location = new System.Drawing.Point(24, 50);
            label40.Location = location;
            this.Label2.Name = "Label2";
            System.Windows.Forms.Label label41 = this.Label2;
            size = new System.Drawing.Size(38, 15);
            label41.Size = size;
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Genre";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.THArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHArtist = this.THArtist;
            location = new System.Drawing.Point(65, 23);
            tHArtist.Location = location;
            System.Windows.Forms.TextBox tHArtist2 = this.THArtist;
            margin = new System.Windows.Forms.Padding(0);
            tHArtist2.Margin = margin;
            this.THArtist.Name = "THArtist";
            System.Windows.Forms.TextBox tHArtist3 = this.THArtist;
            size = new System.Drawing.Size(118, 23);
            tHArtist3.Size = size;
            this.THArtist.TabIndex = 7;
            this.THTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.TextBox tHTitle = this.THTitle;
            location = new System.Drawing.Point(65, 0);
            tHTitle.Location = location;
            System.Windows.Forms.TextBox tHTitle2 = this.THTitle;
            margin = new System.Windows.Forms.Padding(0);
            tHTitle2.Margin = margin;
            this.THTitle.Name = "THTitle";
            System.Windows.Forms.TextBox tHTitle3 = this.THTitle;
            size = new System.Drawing.Size(118, 23);
            tHTitle3.Size = size;
            this.THTitle.TabIndex = 6;
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label9.AutoSize = true;
            System.Windows.Forms.Label label42 = this.Label9;
            location = new System.Drawing.Point(30, 73);
            label42.Location = location;
            this.Label9.Name = "Label9";
            System.Windows.Forms.Label label43 = this.Label9;
            size = new System.Drawing.Size(32, 15);
            label43.Size = size;
            this.Label9.TabIndex = 9;
            this.Label9.Text = "BPM";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label8.AutoSize = true;
            System.Windows.Forms.Label label44 = this.Label8;
            location = new System.Drawing.Point(23, 96);
            label44.Location = location;
            this.Label8.Name = "Label8";
            System.Windows.Forms.Label label45 = this.Label8;
            size = new System.Drawing.Size(39, 15);
            label45.Size = size;
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Player";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label6.AutoSize = true;
            System.Windows.Forms.Label label46 = this.Label6;
            location = new System.Drawing.Point(3, 142);
            label46.Location = location;
            this.Label6.Name = "Label6";
            System.Windows.Forms.Label label47 = this.Label6;
            size = new System.Drawing.Size(59, 15);
            label47.Size = size;
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Play Level";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.POHeaderSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.POHeaderSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.POHeaderSwitch.Checked = true;
            this.POHeaderSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.POHeaderSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POHeaderSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.POHeaderSwitch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            System.Windows.Forms.CheckBox pOHeaderSwitch = this.POHeaderSwitch;
            location = new System.Drawing.Point(0, 0);
            pOHeaderSwitch.Location = location;
            this.POHeaderSwitch.Name = "POHeaderSwitch";
            System.Windows.Forms.CheckBox pOHeaderSwitch2 = this.POHeaderSwitch;
            size = new System.Drawing.Size(183, 20);
            pOHeaderSwitch2.Size = size;
            this.POHeaderSwitch.TabIndex = 1;
            this.POHeaderSwitch.TabStop = false;
            this.POHeaderSwitch.Text = "Header";
            this.POHeaderSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.POHeaderSwitch.UseCompatibleTextRendering = true;
            this.POHeaderSwitch.UseVisualStyleBackColor = false;
            this.Timer1.Interval = 15;
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.MInsert, this.MRemove });
            this.Menu1.Name = "Menu1";
            System.Windows.Forms.ContextMenuStrip menu = this.Menu1;
            size = new System.Drawing.Size(166, 48);
            menu.Size = size;
            this.MInsert.Image = iBMSC.My.Resources.Resources.x16Add;
            this.MInsert.Name = "MInsert";
            System.Windows.Forms.ToolStripMenuItem mInsert = this.MInsert;
            size = new System.Drawing.Size(165, 22);
            mInsert.Size = size;
            this.MInsert.Text = "Insert Measure";
            this.MRemove.Image = iBMSC.My.Resources.Resources.x16Remove;
            this.MRemove.Name = "MRemove";
            System.Windows.Forms.ToolStripMenuItem mRemove = this.MRemove;
            size = new System.Drawing.Size(165, 22);
            mRemove.Size = size;
            this.MRemove.Text = "Remove Measure";
            this.AutoSaveTimer.Enabled = true;
            this.AutoSaveTimer.Interval = 300000;
            this.mnMain.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnMain.Dock = System.Windows.Forms.DockStyle.None;
            System.Windows.Forms.MenuStrip menuStrip = this.mnMain;
            margin = new System.Windows.Forms.Padding(2);
            menuStrip.GripMargin = margin;
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[6]
                { this.mnFile, this.mnEdit, this.mnSys, this.mnOptions, this.mnConversion, this.mnPreview });
            this.mnMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            System.Windows.Forms.MenuStrip menuStrip2 = this.mnMain;
            location = new System.Drawing.Point(0, 0);
            menuStrip2.Location = location;
            this.mnMain.Name = "mnMain";
            System.Windows.Forms.MenuStrip menuStrip3 = this.mnMain;
            size = new System.Drawing.Size(876, 23);
            menuStrip3.Size = size;
            this.mnMain.TabIndex = 57;
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[16]
            {
                this.mnNew, this.mnOpen, this.mnImportSM, this.mnImportIBMSC, this.ToolStripSeparator14, this.mnSave,
                this.mnSaveAs, this.mnExport, this.ToolStripSeparator15, this.mnOpenR0,
                this.mnOpenR1, this.mnOpenR2, this.mnOpenR3, this.mnOpenR4, this.ToolStripSeparator16, this.mnQuit
            });
            this.mnFile.Name = "mnFile";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3 = this.mnFile;
            size = new System.Drawing.Size(37, 19);
            toolStripMenuItem3.Size = size;
            this.mnFile.Text = "&File";
            this.mnNew.Image = iBMSC.My.Resources.Resources.x16New;
            this.mnNew.Name = "mnNew";
            this.mnNew.ShortcutKeys = System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.Control;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4 = this.mnNew;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem4.Size = size;
            this.mnNew.Text = "&New";
            this.mnOpen.Image = iBMSC.My.Resources.Resources.x16Open;
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.ShortcutKeys = System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Control;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5 = this.mnOpen;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem5.Size = size;
            this.mnOpen.Text = "&Open";
            this.mnImportSM.Image = iBMSC.My.Resources.Resources.x16Import2;
            this.mnImportSM.Name = "mnImportSM";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6 = this.mnImportSM;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem6.Size = size;
            this.mnImportSM.Text = "Import from .S&M file";
            this.mnImportIBMSC.Image = iBMSC.My.Resources.Resources.x16Import2;
            this.mnImportIBMSC.Name = "mnImportIBMSC";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7 = this.mnImportIBMSC;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem7.Size = size;
            this.mnImportIBMSC.Text = "Import from .&IBMSC file";
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator14;
            size = new System.Drawing.Size(196, 6);
            toolStripSeparator3.Size = size;
            this.mnSave.Image = iBMSC.My.Resources.Resources.x16Save;
            this.mnSave.Name = "mnSave";
            this.mnSave.ShortcutKeys = System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.Control;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8 = this.mnSave;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem8.Size = size;
            this.mnSave.Text = "&Save";
            this.mnSaveAs.Image = iBMSC.My.Resources.Resources.x16SaveAs;
            this.mnSaveAs.Name = "mnSaveAs";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9 = this.mnSaveAs;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem9.Size = size;
            this.mnSaveAs.Text = "Save &As...";
            this.mnExport.Image = iBMSC.My.Resources.Resources.x16Export;
            this.mnExport.Name = "mnExport";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10 = this.mnExport;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem10.Size = size;
            this.mnExport.Text = "&Export .IBMSC file";
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator15;
            size = new System.Drawing.Size(196, 6);
            toolStripSeparator4.Size = size;
            this.mnOpenR0.Enabled = false;
            this.mnOpenR0.Name = "mnOpenR0";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11 = this.mnOpenR0;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem11.Size = size;
            this.mnOpenR0.Tag = "0";
            this.mnOpenR0.Text = "Recent #0";
            this.mnOpenR1.Enabled = false;
            this.mnOpenR1.Name = "mnOpenR1";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12 = this.mnOpenR1;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem12.Size = size;
            this.mnOpenR1.Tag = "1";
            this.mnOpenR1.Text = "Recent #1";
            this.mnOpenR2.Enabled = false;
            this.mnOpenR2.Name = "mnOpenR2";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13 = this.mnOpenR2;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem13.Size = size;
            this.mnOpenR2.Tag = "2";
            this.mnOpenR2.Text = "Recent #2";
            this.mnOpenR3.Enabled = false;
            this.mnOpenR3.Name = "mnOpenR3";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14 = this.mnOpenR3;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem14.Size = size;
            this.mnOpenR3.Tag = "3";
            this.mnOpenR3.Text = "Recent #3";
            this.mnOpenR4.Enabled = false;
            this.mnOpenR4.Name = "mnOpenR4";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15 = this.mnOpenR4;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem15.Size = size;
            this.mnOpenR4.Tag = "4";
            this.mnOpenR4.Text = "Recent #4";
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator5 = this.ToolStripSeparator16;
            size = new System.Drawing.Size(196, 6);
            toolStripSeparator5.Size = size;
            this.mnQuit.Name = "mnQuit";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16 = this.mnQuit;
            size = new System.Drawing.Size(199, 22);
            toolStripMenuItem16.Size = size;
            this.mnQuit.Text = "&Quit";
            this.mnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[18]
            {
                this.mnUndo, this.mnRedo, this.ToolStripSeparator17, this.mnCut, this.mnCopy, this.mnPaste,
                this.mnDelete, this.mnSelectAll, this.mnGotoMeasure, this.ToolStripSeparator18,
                this.mnFind, this.mnStatistics, this.ToolStripSeparator19, this.mnTimeSelect, this.mnSelect,
                this.mnWrite, this.ToolStripSeparator23, this.mnMyO2
            });
            this.mnEdit.Name = "mnEdit";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17 = this.mnEdit;
            size = new System.Drawing.Size(39, 19);
            toolStripMenuItem17.Size = size;
            this.mnEdit.Text = "&Edit";
            this.mnUndo.Enabled = false;
            this.mnUndo.Image = iBMSC.My.Resources.Resources.x16Undo;
            this.mnUndo.Name = "mnUndo";
            this.mnUndo.ShortcutKeyDisplayString = "Ctrl+Z";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18 = this.mnUndo;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem18.Size = size;
            this.mnUndo.Text = "&Undo";
            this.mnRedo.Enabled = false;
            this.mnRedo.Image = iBMSC.My.Resources.Resources.x16Redo;
            this.mnRedo.Name = "mnRedo";
            this.mnRedo.ShortcutKeyDisplayString = "Ctrl+Y";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19 = this.mnRedo;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem19.Size = size;
            this.mnRedo.Text = "&Redo";
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator17;
            size = new System.Drawing.Size(230, 6);
            toolStripSeparator6.Size = size;
            this.mnCut.Image = iBMSC.My.Resources.Resources.x16Cut;
            this.mnCut.Name = "mnCut";
            this.mnCut.ShortcutKeyDisplayString = "Ctrl+X";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20 = this.mnCut;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem20.Size = size;
            this.mnCut.Text = "Cu&t";
            this.mnCopy.Image = iBMSC.My.Resources.Resources.x16Copy;
            this.mnCopy.Name = "mnCopy";
            this.mnCopy.ShortcutKeyDisplayString = "Ctrl+C";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21 = this.mnCopy;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem21.Size = size;
            this.mnCopy.Text = "&Copy";
            this.mnPaste.Image = iBMSC.My.Resources.Resources.x16Paste;
            this.mnPaste.Name = "mnPaste";
            this.mnPaste.ShortcutKeyDisplayString = "Ctrl+V";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22 = this.mnPaste;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem22.Size = size;
            this.mnPaste.Text = "&Paste";
            this.mnDelete.Image = iBMSC.My.Resources.Resources.x16Remove;
            this.mnDelete.Name = "mnDelete";
            this.mnDelete.ShortcutKeyDisplayString = "Del";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23 = this.mnDelete;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem23.Size = size;
            this.mnDelete.Text = "De&lete";
            this.mnSelectAll.Name = "mnSelectAll";
            this.mnSelectAll.ShortcutKeyDisplayString = "Ctrl+A";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24 = this.mnSelectAll;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem24.Size = size;
            this.mnSelectAll.Text = "Select &All";
            this.mnGotoMeasure.Name = "mnGotoMeasure";
            this.mnGotoMeasure.ShortcutKeys = System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.Control;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25 = this.mnGotoMeasure;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem25.Size = size;
            this.mnGotoMeasure.Text = "Go To Measure...";
            this.ToolStripSeparator18.Name = "ToolStripSeparator18";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator18;
            size = new System.Drawing.Size(230, 6);
            toolStripSeparator7.Size = size;
            this.mnFind.Image = iBMSC.My.Resources.Resources.x16Find;
            this.mnFind.Name = "mnFind";
            this.mnFind.ShortcutKeyDisplayString = "Ctrl+F";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26 = this.mnFind;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem26.Size = size;
            this.mnFind.Text = "&Find / Delete / Replace";
            this.mnStatistics.Image = iBMSC.My.Resources.Resources.x16Statistics;
            this.mnStatistics.Name = "mnStatistics";
            this.mnStatistics.ShortcutKeyDisplayString = "Ctrl+T";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27 = this.mnStatistics;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem27.Size = size;
            this.mnStatistics.Text = "St&atistics";
            this.ToolStripSeparator19.Name = "ToolStripSeparator19";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator8 = this.ToolStripSeparator19;
            size = new System.Drawing.Size(230, 6);
            toolStripSeparator8.Size = size;
            this.mnTimeSelect.CheckOnClick = true;
            this.mnTimeSelect.Image = iBMSC.My.Resources.Resources.x16TimeSelection;
            this.mnTimeSelect.Name = "mnTimeSelect";
            this.mnTimeSelect.ShortcutKeys = System.Windows.Forms.Keys.F1;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28 = this.mnTimeSelect;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem28.Size = size;
            this.mnTimeSelect.Text = "T&ime Selection Tool";
            this.mnSelect.Checked = true;
            this.mnSelect.CheckOnClick = true;
            this.mnSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnSelect.Image = iBMSC.My.Resources.Resources.x16Select;
            this.mnSelect.Name = "mnSelect";
            this.mnSelect.ShortcutKeys = System.Windows.Forms.Keys.F2;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29 = this.mnSelect;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem29.Size = size;
            this.mnSelect.Text = "&Select Tool";
            this.mnWrite.CheckOnClick = true;
            this.mnWrite.Image = iBMSC.My.Resources.Resources.x16Pen;
            this.mnWrite.Name = "mnWrite";
            this.mnWrite.ShortcutKeys = System.Windows.Forms.Keys.F3;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30 = this.mnWrite;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem30.Size = size;
            this.mnWrite.Text = "&Write Tool";
            this.ToolStripSeparator23.Name = "ToolStripSeparator23";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator9 = this.ToolStripSeparator23;
            size = new System.Drawing.Size(230, 6);
            toolStripSeparator9.Size = size;
            this.mnMyO2.Image = iBMSC.My.Resources.Resources.x16MyO2;
            this.mnMyO2.Name = "mnMyO2";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31 = this.mnMyO2;
            size = new System.Drawing.Size(233, 22);
            toolStripMenuItem31.Size = size;
            this.mnMyO2.Text = "MyO2 ToolBox (Chinese Only)";
            this.mnSys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[19]
            {
                this.mnSMenu, this.mnSTB, this.mnSOP, this.mnSStatus, this.mnSLSplitter, this.mnSRSplitter,
                this.ToolStripSeparator21, this.CGShow, this.CGShowS, this.CGShowBG,
                this.CGShowM, this.CGShowMB, this.CGShowV, this.CGShowC, this.ToolStripSeparator22, this.CGBPM,
                this.CGSTOP, this.CGSCROLL, this.CGBLP
            });
            this.mnSys.Name = "mnSys";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32 = this.mnSys;
            size = new System.Drawing.Size(44, 19);
            toolStripMenuItem32.Size = size;
            this.mnSys.Text = "&View";
            this.mnSMenu.Checked = true;
            this.mnSMenu.CheckOnClick = true;
            this.mnSMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnSMenu.Name = "mnSMenu";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33 = this.mnSMenu;
            size = new System.Drawing.Size(172, 22);
            toolStripMenuItem33.Size = size;
            this.mnSMenu.Text = "&Main Menu";
            this.mnSMenu.Visible = false;
            this.mnSTB.Checked = true;
            this.mnSTB.CheckOnClick = true;
            this.mnSTB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnSTB.Name = "mnSTB";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34 = this.mnSTB;
            size = new System.Drawing.Size(172, 22);
            toolStripMenuItem34.Size = size;
            this.mnSTB.Text = "&ToolBar";
            this.mnSOP.Checked = true;
            this.mnSOP.CheckOnClick = true;
            this.mnSOP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnSOP.Name = "mnSOP";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35 = this.mnSOP;
            size = new System.Drawing.Size(172, 22);
            toolStripMenuItem35.Size = size;
            this.mnSOP.Text = "&Options Panel";
            this.mnSStatus.Checked = true;
            this.mnSStatus.CheckOnClick = true;
            this.mnSStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnSStatus.Name = "mnSStatus";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36 = this.mnSStatus;
            size = new System.Drawing.Size(172, 22);
            toolStripMenuItem36.Size = size;
            this.mnSStatus.Text = "&Status Bar";
            this.mnSLSplitter.CheckOnClick = true;
            this.mnSLSplitter.Name = "mnSLSplitter";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37 = this.mnSLSplitter;
            size = new System.Drawing.Size(172, 22);
            toolStripMenuItem37.Size = size;
            this.mnSLSplitter.Text = "&Left Splitter";
            this.mnSRSplitter.CheckOnClick = true;
            this.mnSRSplitter.Name = "mnSRSplitter";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem38 = this.mnSRSplitter;
            size = new System.Drawing.Size(172, 22);
            toolStripMenuItem38.Size = size;
            this.mnSRSplitter.Text = "&Right Splitter";
            this.ToolStripSeparator21.Name = "ToolStripSeparator21";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator10 = this.ToolStripSeparator21;
            size = new System.Drawing.Size(169, 6);
            toolStripSeparator10.Size = size;
            this.CGShow.Checked = true;
            this.CGShow.CheckOnClick = true;
            this.CGShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShow.Name = "CGShow";
            System.Windows.Forms.ToolStripMenuItem cGShow = this.CGShow;
            size = new System.Drawing.Size(172, 22);
            cGShow.Size = size;
            this.CGShow.Text = "Grid";
            this.CGShowS.Checked = true;
            this.CGShowS.CheckOnClick = true;
            this.CGShowS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShowS.Name = "CGShowS";
            System.Windows.Forms.ToolStripMenuItem cGShowS = this.CGShowS;
            size = new System.Drawing.Size(172, 22);
            cGShowS.Size = size;
            this.CGShowS.Text = "Sub";
            this.CGShowBG.Checked = true;
            this.CGShowBG.CheckOnClick = true;
            this.CGShowBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShowBG.Name = "CGShowBG";
            System.Windows.Forms.ToolStripMenuItem cGShowBG = this.CGShowBG;
            size = new System.Drawing.Size(172, 22);
            cGShowBG.Size = size;
            this.CGShowBG.Text = "BackGround";
            this.CGShowM.Checked = true;
            this.CGShowM.CheckOnClick = true;
            this.CGShowM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShowM.Name = "CGShowM";
            System.Windows.Forms.ToolStripMenuItem cGShowM = this.CGShowM;
            size = new System.Drawing.Size(172, 22);
            cGShowM.Size = size;
            this.CGShowM.Text = "Measure Index";
            this.CGShowMB.Checked = true;
            this.CGShowMB.CheckOnClick = true;
            this.CGShowMB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShowMB.Name = "CGShowMB";
            System.Windows.Forms.ToolStripMenuItem cGShowMB = this.CGShowMB;
            size = new System.Drawing.Size(172, 22);
            cGShowMB.Size = size;
            this.CGShowMB.Text = "Measure Line";
            this.CGShowV.Checked = true;
            this.CGShowV.CheckOnClick = true;
            this.CGShowV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShowV.Name = "CGShowV";
            System.Windows.Forms.ToolStripMenuItem cGShowV = this.CGShowV;
            size = new System.Drawing.Size(172, 22);
            cGShowV.Size = size;
            this.CGShowV.Text = "Vertical Line";
            this.CGShowC.Checked = true;
            this.CGShowC.CheckOnClick = true;
            this.CGShowC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGShowC.Name = "CGShowC";
            System.Windows.Forms.ToolStripMenuItem cGShowC = this.CGShowC;
            size = new System.Drawing.Size(172, 22);
            cGShowC.Size = size;
            this.CGShowC.Text = "Column Caption";
            this.ToolStripSeparator22.Name = "ToolStripSeparator22";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator11 = this.ToolStripSeparator22;
            size = new System.Drawing.Size(169, 6);
            toolStripSeparator11.Size = size;
            this.CGBPM.Checked = true;
            this.CGBPM.CheckOnClick = true;
            this.CGBPM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGBPM.Name = "CGBPM";
            System.Windows.Forms.ToolStripMenuItem cGBPM = this.CGBPM;
            size = new System.Drawing.Size(172, 22);
            cGBPM.Size = size;
            this.CGBPM.Text = "BPM";
            this.CGSTOP.Checked = true;
            this.CGSTOP.CheckOnClick = true;
            this.CGSTOP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGSTOP.Name = "CGSTOP";
            System.Windows.Forms.ToolStripMenuItem cGSTOP = this.CGSTOP;
            size = new System.Drawing.Size(172, 22);
            cGSTOP.Size = size;
            this.CGSTOP.Text = "STOP";
            this.CGSCROLL.Checked = true;
            this.CGSCROLL.CheckOnClick = true;
            this.CGSCROLL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CGSCROLL.Name = "CGSCROLL";
            System.Windows.Forms.ToolStripMenuItem cGSCROLL = this.CGSCROLL;
            size = new System.Drawing.Size(172, 22);
            cGSCROLL.Size = size;
            this.CGSCROLL.Text = "SCROLL";
            this.CGBLP.Checked = true;
            this.CGBLP.CheckOnClick = true;
            this.CGBLP.Name = "CGBLP";
            System.Windows.Forms.ToolStripMenuItem cGBLP = this.CGBLP;
            size = new System.Drawing.Size(172, 22);
            cGBLP.Size = size;
            this.CGBLP.Text = "BGA / Layer / Poor";
            this.mnOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[10]
            {
                this.mnNTInput, this.mnErrorCheck, this.mnPreviewOnClick, this.mnShowFileName,
                this.ToolStripSeparator20, this.mnGOptions, this.mnVOptions, this.mnPOptions, this.mnLanguage,
                this.mnTheme
            });
            this.mnOptions.Name = "mnOptions";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39 = this.mnOptions;
            size = new System.Drawing.Size(61, 19);
            toolStripMenuItem39.Size = size;
            this.mnOptions.Text = "&Options";
            this.mnNTInput.Checked = true;
            this.mnNTInput.CheckOnClick = true;
            this.mnNTInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnNTInput.Image = iBMSC.My.Resources.Resources.x16NTInput;
            this.mnNTInput.Name = "mnNTInput";
            this.mnNTInput.ShortcutKeys = System.Windows.Forms.Keys.F8;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40 = this.mnNTInput;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem40.Size = size;
            this.mnNTInput.Text = "L&N Input Style - NT/BMSE";
            this.mnErrorCheck.Checked = true;
            this.mnErrorCheck.CheckOnClick = true;
            this.mnErrorCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnErrorCheck.Image = iBMSC.My.Resources.Resources.x16CheckError;
            this.mnErrorCheck.Name = "mnErrorCheck";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41 = this.mnErrorCheck;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem41.Size = size;
            this.mnErrorCheck.Text = "&Error Check";
            this.mnPreviewOnClick.Checked = true;
            this.mnPreviewOnClick.CheckOnClick = true;
            this.mnPreviewOnClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnPreviewOnClick.Image = iBMSC.My.Resources.Resources.x16PreviewOnClick;
            this.mnPreviewOnClick.Name = "mnPreviewOnClick";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem42 = this.mnPreviewOnClick;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem42.Size = size;
            this.mnPreviewOnClick.Text = "Preview on &Click";
            this.mnShowFileName.CheckOnClick = true;
            this.mnShowFileName.Image = iBMSC.My.Resources.Resources.x16ShowFileNameN;
            this.mnShowFileName.Name = "mnShowFileName";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem43 = this.mnShowFileName;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem43.Size = size;
            this.mnShowFileName.Text = "Show &File Name on Notes";
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator12 = this.ToolStripSeparator20;
            size = new System.Drawing.Size(226, 6);
            toolStripSeparator12.Size = size;
            this.mnGOptions.Image = iBMSC.My.Resources.Resources.x16GeneralOptions;
            this.mnGOptions.Name = "mnGOptions";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem44 = this.mnGOptions;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem44.Size = size;
            this.mnGOptions.Text = "&General Options";
            this.mnVOptions.Image = iBMSC.My.Resources.Resources.x16VisualOptions;
            this.mnVOptions.Name = "mnVOptions";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem45 = this.mnVOptions;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem45.Size = size;
            this.mnVOptions.Text = "&Visual Options";
            this.mnPOptions.Image = iBMSC.My.Resources.Resources.x16PlayerOptions;
            this.mnPOptions.Name = "mnPOptions";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem46 = this.mnPOptions;
            size = new System.Drawing.Size(229, 22);
            toolStripMenuItem46.Size = size;
            this.mnPOptions.Text = "&Player Options";
            this.mnConversion.DropDown = this.cmnConversion;
            this.mnConversion.Name = "mnConversion";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem47 = this.mnConversion;
            size = new System.Drawing.Size(84, 19);
            toolStripMenuItem47.Size = size;
            this.mnConversion.Text = "&Conversions";
            this.cmnConversion.Items.AddRange(new System.Windows.Forms.ToolStripItem[10]
            {
                this.POBLong, this.POBShort, this.POBLongShort, this.ToolStripSeparator10, this.POBHidden,
                this.POBVisible, this.POBHiddenVisible, this.ToolStripSeparator11, this.POBModify, this.POBMirror
            });
            this.cmnConversion.Name = "cmnLanguage";
            this.cmnConversion.OwnerItem = this.POConvert;
            System.Windows.Forms.ContextMenuStrip contextMenuStrip3 = this.cmnConversion;
            size = new System.Drawing.Size(222, 192);
            contextMenuStrip3.Size = size;
            this.POBLong.Enabled = false;
            this.POBLong.Image = iBMSC.My.Resources.Resources.ConvertNotesL;
            this.POBLong.Name = "POBLong";
            System.Windows.Forms.ToolStripMenuItem pOBLong = this.POBLong;
            size = new System.Drawing.Size(221, 22);
            pOBLong.Size = size;
            this.POBLong.Text = "→ &Long Note";
            this.POBShort.Image = iBMSC.My.Resources.Resources.ConvertNotesN;
            this.POBShort.Name = "POBShort";
            System.Windows.Forms.ToolStripMenuItem pOBShort = this.POBShort;
            size = new System.Drawing.Size(221, 22);
            pOBShort.Size = size;
            this.POBShort.Text = "→ &Short Note";
            this.POBLongShort.Enabled = false;
            this.POBLongShort.Image = iBMSC.My.Resources.Resources.ConvertNotes;
            this.POBLongShort.Name = "POBLongShort";
            System.Windows.Forms.ToolStripMenuItem pOBLongShort = this.POBLongShort;
            size = new System.Drawing.Size(221, 22);
            pOBLongShort.Size = size;
            this.POBLongShort.Text = "Long Note ↔ Short Note";
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator13 = this.ToolStripSeparator10;
            size = new System.Drawing.Size(218, 6);
            toolStripSeparator13.Size = size;
            this.POBHidden.Image = iBMSC.My.Resources.Resources.ConvertNotesH;
            this.POBHidden.Name = "POBHidden";
            System.Windows.Forms.ToolStripMenuItem pOBHidden = this.POBHidden;
            size = new System.Drawing.Size(221, 22);
            pOBHidden.Size = size;
            this.POBHidden.Text = "→ &Hidden Note";
            this.POBVisible.Image = iBMSC.My.Resources.Resources.ConvertNotesV;
            this.POBVisible.Name = "POBVisible";
            System.Windows.Forms.ToolStripMenuItem pOBVisible = this.POBVisible;
            size = new System.Drawing.Size(221, 22);
            pOBVisible.Size = size;
            this.POBVisible.Text = "→ &Visible Note";
            this.POBHiddenVisible.Image = iBMSC.My.Resources.Resources.ConvertNotesHV;
            this.POBHiddenVisible.Name = "POBHiddenVisible";
            System.Windows.Forms.ToolStripMenuItem pOBHiddenVisible = this.POBHiddenVisible;
            size = new System.Drawing.Size(221, 22);
            pOBHiddenVisible.Size = size;
            this.POBHiddenVisible.Text = "Hidden Note ↔ Visible Note";
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator14 = this.ToolStripSeparator11;
            size = new System.Drawing.Size(218, 6);
            toolStripSeparator14.Size = size;
            this.POBModify.Image = iBMSC.My.Resources.Resources.x16ModifyLabel;
            this.POBModify.Name = "POBModify";
            System.Windows.Forms.ToolStripMenuItem pOBModify = this.POBModify;
            size = new System.Drawing.Size(221, 22);
            pOBModify.Size = size;
            this.POBModify.Text = "&Modify Labels";
            this.POBMirror.Image = iBMSC.My.Resources.Resources.x16Mirror;
            this.POBMirror.Name = "POBMirror";
            System.Windows.Forms.ToolStripMenuItem pOBMirror = this.POBMirror;
            size = new System.Drawing.Size(221, 22);
            pOBMirror.Size = size;
            this.POBMirror.Text = "Mi&rror";
            this.mnPreview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3]
                { this.mnPlayB, this.mnPlay, this.mnStop });
            this.mnPreview.Name = "mnPreview";
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem48 = this.mnPreview;
            size = new System.Drawing.Size(60, 19);
            toolStripMenuItem48.Size = size;
            this.mnPreview.Text = "&Preview";
            this.mnPlayB.Image = iBMSC.My.Resources.Resources.x16PlayB;
            this.mnPlayB.Name = "mnPlayB";
            this.mnPlayB.ShortcutKeys = System.Windows.Forms.Keys.F5;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem49 = this.mnPlayB;
            size = new System.Drawing.Size(201, 22);
            toolStripMenuItem49.Size = size;
            this.mnPlayB.Text = "Play from &beginning";
            this.mnPlay.Image = iBMSC.My.Resources.Resources.x16Play;
            this.mnPlay.Name = "mnPlay";
            this.mnPlay.ShortcutKeys = System.Windows.Forms.Keys.F6;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50 = this.mnPlay;
            size = new System.Drawing.Size(201, 22);
            toolStripMenuItem50.Size = size;
            this.mnPlay.Text = "&Play from here";
            this.mnStop.Image = iBMSC.My.Resources.Resources.x16Stop;
            this.mnStop.Name = "mnStop";
            this.mnStop.ShortcutKeys = System.Windows.Forms.Keys.F7;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem51 = this.mnStop;
            size = new System.Drawing.Size(201, 22);
            toolStripMenuItem51.Size = size;
            this.mnStop.Text = "&Stop";
            this.POConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.POConvert.DropDown = this.cmnConversion;
            this.POConvert.Image = iBMSC.My.Resources.Resources.ConvertNotes;
            this.POConvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.POConvert.Name = "POConvert";
            System.Windows.Forms.ToolStripDropDownButton pOConvert = this.POConvert;
            size = new System.Drawing.Size(29, 22);
            pOConvert.Size = size;
            this.POConvert.Text = "Convert Notes";
            this.TBMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.TBMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TBMain.Dock = System.Windows.Forms.DockStyle.None;
            this.TBMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[37]
            {
                this.TBNew, this.TBOpen, this.TBSave, this.ToolStripSeparator1, this.TBCut, this.TBCopy, this.TBPaste,
                this.TBFind, this.ToolStripSeparator24, this.TBStatistics,
                this.POConvert, this.TBMyO2, this.ToolStripSeparator4, this.TBErrorCheck, this.TBPreviewOnClick,
                this.TBShowFileName, this.ToolStripSeparator8, this.TBNTInput, this.TBWavIncrease,
                this.ToolStripSeparator2,
                this.TBUndo, this.TBRedo, this.ToolStripSeparator5, this.TBTimeSelect, this.TBSelect, this.TBWrite,
                this.ToolStripSeparator3, this.TBPlayB, this.TBPlay, this.TBStop,
                this.TBPOptions, this.ToolStripSeparator7, this.TBVOptions, this.TBGOptions, this.TBLanguage,
                this.TBTheme, this.POBStorm
            });
            System.Windows.Forms.ToolStrip tBMain = this.TBMain;
            location = new System.Drawing.Point(3, 23);
            tBMain.Location = location;
            this.TBMain.Name = "TBMain";
            System.Windows.Forms.ToolStrip tBMain2 = this.TBMain;
            size = new System.Drawing.Size(805, 25);
            tBMain2.Size = size;
            this.TBMain.TabIndex = 64;
            this.TBMain.Text = "Main Toolbar";
            this.TBNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBNew.Image = iBMSC.My.Resources.Resources.x16New;
            this.TBNew.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TBNew.Name = "TBNew";
            System.Windows.Forms.ToolStripButton tBNew = this.TBNew;
            size = new System.Drawing.Size(23, 22);
            tBNew.Size = size;
            this.TBNew.Text = "New (Ctrl+N)";
            this.TBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8]
            {
                this.TBOpenR0, this.TBOpenR1, this.TBOpenR2, this.TBOpenR3, this.TBOpenR4, this.ToolStripSeparator12,
                this.TBImportSM, this.TBImportIBMSC
            });
            this.TBOpen.Image = iBMSC.My.Resources.Resources.x16Open;
            this.TBOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBOpen.Name = "TBOpen";
            System.Windows.Forms.ToolStripSplitButton tBOpen = this.TBOpen;
            size = new System.Drawing.Size(32, 22);
            tBOpen.Size = size;
            this.TBOpen.Text = "Open (Ctrl+O)";
            this.TBOpenR0.Enabled = false;
            this.TBOpenR0.Name = "TBOpenR0";
            System.Windows.Forms.ToolStripMenuItem tBOpenR = this.TBOpenR0;
            size = new System.Drawing.Size(199, 22);
            tBOpenR.Size = size;
            this.TBOpenR0.Tag = "0";
            this.TBOpenR0.Text = "Recent #0";
            this.TBOpenR1.Enabled = false;
            this.TBOpenR1.Name = "TBOpenR1";
            System.Windows.Forms.ToolStripMenuItem tBOpenR2 = this.TBOpenR1;
            size = new System.Drawing.Size(199, 22);
            tBOpenR2.Size = size;
            this.TBOpenR1.Tag = "1";
            this.TBOpenR1.Text = "Recent #1";
            this.TBOpenR2.Enabled = false;
            this.TBOpenR2.Name = "TBOpenR2";
            System.Windows.Forms.ToolStripMenuItem tBOpenR3 = this.TBOpenR2;
            size = new System.Drawing.Size(199, 22);
            tBOpenR3.Size = size;
            this.TBOpenR2.Tag = "2";
            this.TBOpenR2.Text = "Recent #2";
            this.TBOpenR3.Enabled = false;
            this.TBOpenR3.Name = "TBOpenR3";
            System.Windows.Forms.ToolStripMenuItem tBOpenR4 = this.TBOpenR3;
            size = new System.Drawing.Size(199, 22);
            tBOpenR4.Size = size;
            this.TBOpenR3.Tag = "3";
            this.TBOpenR3.Text = "Recent #3";
            this.TBOpenR4.Enabled = false;
            this.TBOpenR4.Name = "TBOpenR4";
            System.Windows.Forms.ToolStripMenuItem tBOpenR5 = this.TBOpenR4;
            size = new System.Drawing.Size(199, 22);
            tBOpenR5.Size = size;
            this.TBOpenR4.Tag = "4";
            this.TBOpenR4.Text = "Recent #4";
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator15 = this.ToolStripSeparator12;
            size = new System.Drawing.Size(196, 6);
            toolStripSeparator15.Size = size;
            this.TBImportSM.Image = iBMSC.My.Resources.Resources.x16Import2;
            this.TBImportSM.Name = "TBImportSM";
            System.Windows.Forms.ToolStripMenuItem tBImportSM = this.TBImportSM;
            size = new System.Drawing.Size(199, 22);
            tBImportSM.Size = size;
            this.TBImportSM.Text = "Import from .SM file";
            this.TBImportIBMSC.Image = iBMSC.My.Resources.Resources.x16Import2;
            this.TBImportIBMSC.Name = "TBImportIBMSC";
            System.Windows.Forms.ToolStripMenuItem tBImportIBMSC = this.TBImportIBMSC;
            size = new System.Drawing.Size(199, 22);
            tBImportIBMSC.Size = size;
            this.TBImportIBMSC.Text = "Import from .IBMSC file";
            this.TBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2]
                { this.TBSaveAs, this.TBExport });
            this.TBSave.Image = iBMSC.My.Resources.Resources.x16Save;
            this.TBSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBSave.Name = "TBSave";
            System.Windows.Forms.ToolStripSplitButton tBSave = this.TBSave;
            size = new System.Drawing.Size(32, 22);
            tBSave.Size = size;
            this.TBSave.Text = "Save (Ctrl+S)";
            this.TBSaveAs.Image = iBMSC.My.Resources.Resources.x16SaveAs;
            this.TBSaveAs.Name = "TBSaveAs";
            System.Windows.Forms.ToolStripMenuItem tBSaveAs = this.TBSaveAs;
            size = new System.Drawing.Size(167, 22);
            tBSaveAs.Size = size;
            this.TBSaveAs.Text = "Save As...";
            this.TBExport.Image = iBMSC.My.Resources.Resources.x16Export;
            this.TBExport.Name = "TBExport";
            System.Windows.Forms.ToolStripMenuItem tBExport = this.TBExport;
            size = new System.Drawing.Size(167, 22);
            tBExport.Size = size;
            this.TBExport.Text = "Export .IBMSC file";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator16 = this.ToolStripSeparator1;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator16.Size = size;
            this.TBCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBCut.Image = iBMSC.My.Resources.Resources.x16Cut;
            this.TBCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBCut.Name = "TBCut";
            System.Windows.Forms.ToolStripButton tBCut = this.TBCut;
            size = new System.Drawing.Size(23, 22);
            tBCut.Size = size;
            this.TBCut.Text = "Cut (Ctrl+X)";
            this.TBCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBCopy.Image = iBMSC.My.Resources.Resources.x16Copy;
            this.TBCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBCopy.Name = "TBCopy";
            System.Windows.Forms.ToolStripButton tBCopy = this.TBCopy;
            size = new System.Drawing.Size(23, 22);
            tBCopy.Size = size;
            this.TBCopy.Text = "Copy (Ctrl+C)";
            this.TBPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBPaste.Image = iBMSC.My.Resources.Resources.x16Paste;
            this.TBPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBPaste.Name = "TBPaste";
            System.Windows.Forms.ToolStripButton tBPaste = this.TBPaste;
            size = new System.Drawing.Size(23, 22);
            tBPaste.Size = size;
            this.TBPaste.Text = "Paste (Ctrl+V)";
            this.TBFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBFind.Image = iBMSC.My.Resources.Resources.x16Find;
            this.TBFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBFind.Name = "TBFind";
            System.Windows.Forms.ToolStripButton tBFind = this.TBFind;
            size = new System.Drawing.Size(23, 22);
            tBFind.Size = size;
            this.TBFind.Text = "Find / Delete / Replace (Ctrl+F)";
            this.ToolStripSeparator24.Name = "ToolStripSeparator24";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator17 = this.ToolStripSeparator24;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator17.Size = size;
            this.TBStatistics.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.TBStatistics.Image = iBMSC.My.Resources.Resources.x16Statistics;
            this.TBStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBStatistics.Name = "TBStatistics";
            System.Windows.Forms.ToolStripButton tBStatistics = this.TBStatistics;
            size = new System.Drawing.Size(34, 22);
            tBStatistics.Size = size;
            this.TBStatistics.Text = "0";
            this.TBStatistics.ToolTipText = "Statistics (Ctrl+T)";
            this.TBMyO2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBMyO2.Image = iBMSC.My.Resources.Resources.x16MyO2;
            this.TBMyO2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBMyO2.Name = "TBMyO2";
            System.Windows.Forms.ToolStripButton tBMyO = this.TBMyO2;
            size = new System.Drawing.Size(23, 22);
            tBMyO.Size = size;
            this.TBMyO2.Text = "MyO2 ToolBox (Chinese Only)";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator18 = this.ToolStripSeparator4;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator18.Size = size;
            this.TBErrorCheck.Checked = true;
            this.TBErrorCheck.CheckOnClick = true;
            this.TBErrorCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TBErrorCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBErrorCheck.Image = iBMSC.My.Resources.Resources.x16CheckError;
            this.TBErrorCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBErrorCheck.Name = "TBErrorCheck";
            System.Windows.Forms.ToolStripButton tBErrorCheck = this.TBErrorCheck;
            size = new System.Drawing.Size(23, 22);
            tBErrorCheck.Size = size;
            this.TBErrorCheck.Text = "Error Check";
            this.TBPreviewOnClick.Checked = true;
            this.TBPreviewOnClick.CheckOnClick = true;
            this.TBPreviewOnClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TBPreviewOnClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBPreviewOnClick.Image = iBMSC.My.Resources.Resources.x16PreviewOnClick;
            this.TBPreviewOnClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBPreviewOnClick.Name = "TBPreviewOnClick";
            System.Windows.Forms.ToolStripButton tBPreviewOnClick = this.TBPreviewOnClick;
            size = new System.Drawing.Size(23, 22);
            tBPreviewOnClick.Size = size;
            this.TBPreviewOnClick.Text = "Preview On Click";
            this.TBShowFileName.CheckOnClick = true;
            this.TBShowFileName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBShowFileName.Image = iBMSC.My.Resources.Resources.x16ShowFileNameN;
            this.TBShowFileName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBShowFileName.Name = "TBShowFileName";
            System.Windows.Forms.ToolStripButton tBShowFileName = this.TBShowFileName;
            size = new System.Drawing.Size(23, 22);
            tBShowFileName.Size = size;
            this.TBShowFileName.Text = "Show File Name on Notes";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator19 = this.ToolStripSeparator8;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator19.Size = size;
            this.TBNTInput.Checked = true;
            this.TBNTInput.CheckOnClick = true;
            this.TBNTInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TBNTInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBNTInput.Image = iBMSC.My.Resources.Resources.x16NTInput;
            this.TBNTInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBNTInput.Name = "TBNTInput";
            System.Windows.Forms.ToolStripButton tBNTInput = this.TBNTInput;
            size = new System.Drawing.Size(23, 22);
            tBNTInput.Size = size;
            this.TBNTInput.Text = "LongNote Input Style - NoteTool/BMSE";
            this.TBWavIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBWavIncrease.Image = (System.Drawing.Image)resources.GetObject("TBWavIncrease.Image");
            this.TBWavIncrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBWavIncrease.Name = "TBWavIncrease";
            System.Windows.Forms.ToolStripButton tBWavIncrease = this.TBWavIncrease;
            size = new System.Drawing.Size(23, 22);
            tBWavIncrease.Size = size;
            this.TBWavIncrease.Text = "Autoincrease WAV when writing";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator20 = this.ToolStripSeparator2;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator20.Size = size;
            this.TBUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBUndo.Enabled = false;
            this.TBUndo.Image = iBMSC.My.Resources.Resources.x16Undo;
            this.TBUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBUndo.Name = "TBUndo";
            System.Windows.Forms.ToolStripButton tBUndo = this.TBUndo;
            size = new System.Drawing.Size(23, 22);
            tBUndo.Size = size;
            this.TBUndo.Text = "Undo (Ctrl+Z)";
            this.TBRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBRedo.Enabled = false;
            this.TBRedo.Image = iBMSC.My.Resources.Resources.x16Redo;
            this.TBRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBRedo.Name = "TBRedo";
            System.Windows.Forms.ToolStripButton tBRedo = this.TBRedo;
            size = new System.Drawing.Size(23, 22);
            tBRedo.Size = size;
            this.TBRedo.Text = "Redo (Ctrl+Y)";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator21 = this.ToolStripSeparator5;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator21.Size = size;
            this.TBTimeSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBTimeSelect.Image = iBMSC.My.Resources.Resources.x16TimeSelection;
            this.TBTimeSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBTimeSelect.Name = "TBTimeSelect";
            System.Windows.Forms.ToolStripButton tBTimeSelect = this.TBTimeSelect;
            size = new System.Drawing.Size(23, 22);
            tBTimeSelect.Size = size;
            this.TBTimeSelect.Text = "Time Selection Tool (F1)";
            this.TBSelect.Checked = true;
            this.TBSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TBSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBSelect.Image = iBMSC.My.Resources.Resources.x16Select;
            this.TBSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBSelect.Name = "TBSelect";
            System.Windows.Forms.ToolStripButton tBSelect = this.TBSelect;
            size = new System.Drawing.Size(23, 22);
            tBSelect.Size = size;
            this.TBSelect.Text = "Select Tool (F2)";
            this.TBWrite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBWrite.Image = iBMSC.My.Resources.Resources.x16Pen;
            this.TBWrite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBWrite.Name = "TBWrite";
            System.Windows.Forms.ToolStripButton tBWrite = this.TBWrite;
            size = new System.Drawing.Size(23, 22);
            tBWrite.Size = size;
            this.TBWrite.Text = "Write Tool (F3)";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator22 = this.ToolStripSeparator3;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator22.Size = size;
            this.TBPlayB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBPlayB.Image = iBMSC.My.Resources.Resources.x16PlayB;
            this.TBPlayB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBPlayB.Name = "TBPlayB";
            System.Windows.Forms.ToolStripButton tBPlayB = this.TBPlayB;
            size = new System.Drawing.Size(23, 22);
            tBPlayB.Size = size;
            this.TBPlayB.Text = "Play from beginning (F5)";
            this.TBPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBPlay.Image = iBMSC.My.Resources.Resources.x16Play;
            this.TBPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBPlay.Name = "TBPlay";
            System.Windows.Forms.ToolStripButton tBPlay = this.TBPlay;
            size = new System.Drawing.Size(23, 22);
            tBPlay.Size = size;
            this.TBPlay.Text = "Play from here (F6)";
            this.TBStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBStop.Image = iBMSC.My.Resources.Resources.x16Stop;
            this.TBStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBStop.Name = "TBStop";
            System.Windows.Forms.ToolStripButton tBStop = this.TBStop;
            size = new System.Drawing.Size(23, 22);
            tBStop.Size = size;
            this.TBStop.Text = "Stop (F7)";
            this.TBPOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBPOptions.Image = iBMSC.My.Resources.Resources.x16PlayerOptions;
            this.TBPOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBPOptions.Name = "TBPOptions";
            System.Windows.Forms.ToolStripButton tBPOptions = this.TBPOptions;
            size = new System.Drawing.Size(23, 22);
            tBPOptions.Size = size;
            this.TBPOptions.Text = "Player Options";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            System.Windows.Forms.ToolStripSeparator toolStripSeparator23 = this.ToolStripSeparator7;
            size = new System.Drawing.Size(6, 25);
            toolStripSeparator23.Size = size;
            this.TBVOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBVOptions.Image = iBMSC.My.Resources.Resources.x16VisualOptions;
            this.TBVOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBVOptions.Name = "TBVOptions";
            System.Windows.Forms.ToolStripButton tBVOptions = this.TBVOptions;
            size = new System.Drawing.Size(23, 22);
            tBVOptions.Size = size;
            this.TBVOptions.Text = "Visual Options";
            this.TBGOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBGOptions.Image = iBMSC.My.Resources.Resources.x16GeneralOptions;
            this.TBGOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBGOptions.Name = "TBGOptions";
            System.Windows.Forms.ToolStripButton tBGOptions = this.TBGOptions;
            size = new System.Drawing.Size(23, 22);
            tBGOptions.Size = size;
            this.TBGOptions.Text = "General Options";
            this.POBStorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.POBStorm.Image = iBMSC.My.Resources.Resources.x16Storm;
            this.POBStorm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.POBStorm.Name = "POBStorm";
            System.Windows.Forms.ToolStripButton pOBStorm = this.POBStorm;
            size = new System.Drawing.Size(23, 22);
            pOBStorm.Size = size;
            this.POBStorm.Text = "Storm";
            this.POBStorm.Visible = false;
            this.pStatus.AutoSize = true;
            this.pStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pStatus.Controls.Add(this.FStatus2);
            this.pStatus.Controls.Add(this.FStatus);
            this.pStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            System.Windows.Forms.Panel panel = this.pStatus;
            location = new System.Drawing.Point(0, 708);
            panel.Location = location;
            this.pStatus.Name = "pStatus";
            System.Windows.Forms.Panel panel2 = this.pStatus;
            size = new System.Drawing.Size(876, 22);
            panel2.Size = size;
            this.pStatus.TabIndex = 62;
            this.FStatus2.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.FStatus2.Items.AddRange(new System.Windows.Forms.ToolStripItem[12]
            {
                this.FSSS, this.FSSL, this.FSSH, this.BVCReverse, this.LblMultiply, this.TVCM, this.LblDivide,
                this.TVCD, this.BVCApply, this.TVCBPM,
                this.BVCCalculate, this.BConvertStop
            });
            System.Windows.Forms.StatusStrip fStatus = this.FStatus2;
            location = new System.Drawing.Point(0, 0);
            fStatus.Location = location;
            this.FStatus2.Name = "FStatus2";
            this.FStatus2.ShowItemToolTips = true;
            System.Windows.Forms.StatusStrip fStatus2 = this.FStatus2;
            size = new System.Drawing.Size(876, 22);
            fStatus2.Size = size;
            this.FStatus2.TabIndex = 0;
            this.FStatus2.Text = "Status";
            this.FStatus2.Visible = false;
            this.FSSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FSSS.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.FSSS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FSSS.Name = "FSSS";
            System.Windows.Forms.ToolStripButton fSSS = this.FSSS;
            size = new System.Drawing.Size(23, 20);
            fSSS.Size = size;
            this.FSSS.Text = "0";
            this.FSSS.ToolTipText = "Selection Start Position";
            this.FSSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FSSL.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.FSSL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FSSL.Name = "FSSL";
            System.Windows.Forms.ToolStripButton fSSL = this.FSSL;
            size = new System.Drawing.Size(23, 20);
            fSSL.Size = size;
            this.FSSL.Text = "0";
            this.FSSL.ToolTipText = "Selection Length";
            this.FSSH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FSSH.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.FSSH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FSSH.Name = "FSSH";
            System.Windows.Forms.ToolStripButton fSSH = this.FSSH;
            size = new System.Drawing.Size(23, 20);
            fSSH.Size = size;
            this.FSSH.Text = "0";
            this.FSSH.ToolTipText = "Selection Split Position";
            this.BVCReverse.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.BVCReverse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BVCReverse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BVCReverse.Name = "BVCReverse";
            System.Windows.Forms.ToolStripButton bVCReverse = this.BVCReverse;
            size = new System.Drawing.Size(102, 20);
            bVCReverse.Size = size;
            this.BVCReverse.Text = "Reverse Selection";
            this.LblMultiply.Name = "LblMultiply";
            System.Windows.Forms.ToolStripStatusLabel lblMultiply = this.LblMultiply;
            size = new System.Drawing.Size(15, 17);
            lblMultiply.Size = size;
            this.LblMultiply.Text = "×";
            this.TVCM.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.TVCM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVCM.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.TVCM.Name = "TVCM";
            System.Windows.Forms.ToolStripTextBox tVCM = this.TVCM;
            size = new System.Drawing.Size(60, 22);
            tVCM.Size = size;
            this.TVCM.Text = "2";
            this.TVCM.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LblDivide.Name = "LblDivide";
            System.Windows.Forms.ToolStripStatusLabel lblDivide = this.LblDivide;
            size = new System.Drawing.Size(15, 17);
            lblDivide.Size = size;
            this.LblDivide.Text = "÷";
            this.TVCD.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.TVCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVCD.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.TVCD.Name = "TVCD";
            System.Windows.Forms.ToolStripTextBox tVCD = this.TVCD;
            size = new System.Drawing.Size(60, 22);
            tVCD.Size = size;
            this.TVCD.Text = "1";
            this.TVCD.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BVCApply.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.BVCApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BVCApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BVCApply.Name = "BVCApply";
            System.Windows.Forms.ToolStripButton bVCApply = this.BVCApply;
            size = new System.Drawing.Size(95, 20);
            bVCApply.Size = size;
            this.BVCApply.Text = "Expand By Ratio";
            this.BVCApply.ToolTipText =
                "This will expand notes and selection by the ratio next to this button. Ignores center bar.";
            this.TVCBPM.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.TVCBPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVCBPM.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.TVCBPM.Name = "TVCBPM";
            System.Windows.Forms.ToolStripTextBox tVCBPM = this.TVCBPM;
            size = new System.Drawing.Size(80, 22);
            tVCBPM.Size = size;
            this.TVCBPM.Text = "120";
            this.TVCBPM.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BVCCalculate.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.BVCCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BVCCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BVCCalculate.Name = "BVCCalculate";
            System.Windows.Forms.ToolStripButton bVCCalculate = this.BVCCalculate;
            size = new System.Drawing.Size(104, 20);
            bVCCalculate.Size = size;
            this.BVCCalculate.Text = "Relocate By Value";
            this.BVCCalculate.ToolTipText =
                "This will move notes within the selection and preserve the selection, given the BPM value next to this button. Considers center bar.";
            this.BConvertStop.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.BConvertStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BConvertStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BConvertStop.Name = "BConvertStop";
            System.Windows.Forms.ToolStripButton bConvertStop = this.BConvertStop;
            size = new System.Drawing.Size(117, 20);
            bConvertStop.Size = size;
            this.BConvertStop.Text = "Transform Into Stop";
            this.BConvertStop.ToolTipText =
                "This will move notes within the selection and preserve the selection, given the BPM value next to this button. Considers center bar.";
            this.FStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.FStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[11]
            {
                this.FSC, this.FSW, this.FSM, this.FSP1, this.FSP3, this.FSP2, this.FSP4, this.TimeStatusLabel,
                this.FST, this.FSH,
                this.FSE
            });
            System.Windows.Forms.StatusStrip fStatus3 = this.FStatus;
            location = new System.Drawing.Point(0, 0);
            fStatus3.Location = location;
            this.FStatus.Name = "FStatus";
            this.FStatus.ShowItemToolTips = true;
            System.Windows.Forms.StatusStrip fStatus4 = this.FStatus;
            size = new System.Drawing.Size(876, 22);
            fStatus4.Size = size;
            this.FStatus.SizingGrip = false;
            this.FStatus.TabIndex = 62;
            this.FStatus.Text = "Status";
            this.FSC.AutoSize = false;
            this.FSC.Name = "FSC";
            System.Windows.Forms.ToolStripStatusLabel fSC = this.FSC;
            size = new System.Drawing.Size(70, 17);
            fSC.Size = size;
            this.FSC.Text = "BPM";
            this.FSC.ToolTipText = "Column Caption";
            this.FSW.AutoSize = false;
            this.FSW.ForeColor = System.Drawing.Color.FromArgb(128, 64, 0);
            this.FSW.Name = "FSW";
            System.Windows.Forms.ToolStripStatusLabel fSW = this.FSW;
            size = new System.Drawing.Size(40, 17);
            fSW.Size = size;
            this.FSW.Text = "01";
            this.FSW.ToolTipText = "Note Index";
            this.FSM.AutoSize = false;
            this.FSM.ForeColor = System.Drawing.Color.Teal;
            this.FSM.Name = "FSM";
            System.Windows.Forms.ToolStripStatusLabel fSM = this.FSM;
            size = new System.Drawing.Size(40, 17);
            fSM.Size = size;
            this.FSM.Text = "000";
            this.FSM.ToolTipText = "Measure Index";
            this.FSP1.AutoSize = false;
            this.FSP1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.FSP1.Name = "FSP1";
            System.Windows.Forms.ToolStripStatusLabel fSP = this.FSP1;
            size = new System.Drawing.Size(170, 17);
            fSP.Size = size;
            this.FSP1.Text = "9.41176470588235 / 9999";
            this.FSP1.ToolTipText = "Grid Resolution";
            this.FSP3.AutoSize = false;
            this.FSP3.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.FSP3.ForeColor = System.Drawing.Color.Maroon;
            this.FSP3.Name = "FSP3";
            System.Windows.Forms.ToolStripStatusLabel fSP2 = this.FSP3;
            size = new System.Drawing.Size(85, 17);
            fSP2.Size = size;
            this.FSP3.Text = "9999 / 9999";
            this.FSP3.ToolTipText = "Reduced Resolution";
            this.FSP2.AutoSize = false;
            this.FSP2.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.FSP2.ForeColor = System.Drawing.Color.Green;
            this.FSP2.Name = "FSP2";
            System.Windows.Forms.ToolStripStatusLabel fSP3 = this.FSP2;
            size = new System.Drawing.Size(170, 17);
            fSP3.Size = size;
            this.FSP2.Text = "112.941176470588 / 9999";
            this.FSP2.ToolTipText = "Measure Resolution";
            this.FSP4.AutoSize = false;
            this.FSP4.Name = "FSP4";
            System.Windows.Forms.ToolStripStatusLabel fSP4 = this.FSP4;
            size = new System.Drawing.Size(115, 17);
            fSP4.Size = size;
            this.FSP4.Text = "112.941176470588";
            this.FSP4.ToolTipText = "Absolute Position";
            this.TimeStatusLabel.Name = "TimeStatusLabel";
            System.Windows.Forms.ToolStripStatusLabel timeStatusLabel = this.TimeStatusLabel;
            size = new System.Drawing.Size(55, 17);
            timeStatusLabel.Size = size;
            this.TimeStatusLabel.Text = "00:00:000";
            this.FST.ForeColor = System.Drawing.Color.Olive;
            this.FST.LinkColor = System.Drawing.Color.FromArgb(0, 0, 255);
            this.FST.Name = "FST";
            System.Windows.Forms.ToolStripStatusLabel fST = this.FST;
            size = new System.Drawing.Size(64, 17);
            fST.Size = size;
            this.FST.Text = "Length = 0";
            this.FSH.ForeColor = System.Drawing.Color.Blue;
            this.FSH.Name = "FSH";
            System.Windows.Forms.ToolStripStatusLabel fSH = this.FSH;
            size = new System.Drawing.Size(46, 17);
            fSH.Size = size;
            this.FSH.Text = "Hidden";
            this.FSE.ForeColor = System.Drawing.Color.Red;
            this.FSE.Name = "FSE";
            System.Windows.Forms.ToolStripStatusLabel fSE = this.FSE;
            size = new System.Drawing.Size(32, 17);
            fSE.Size = size;
            this.FSE.Text = "Error";
            this.TimerMiddle.Interval = 15;
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.PMain);
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.SpR);
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.SpL);
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.PMainR);
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.PMainL);
            System.Windows.Forms.ToolStripContentPanel contentPanel = this.ToolStripContainer1.ContentPanel;
            size = new System.Drawing.Size(876, 660);
            contentPanel.Size = size;
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.ToolStripContainer toolStripContainer = this.ToolStripContainer1;
            location = new System.Drawing.Point(0, 0);
            toolStripContainer.Location = location;
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            System.Windows.Forms.ToolStripContainer toolStripContainer2 = this.ToolStripContainer1;
            size = new System.Drawing.Size(876, 708);
            toolStripContainer2.Size = size;
            this.ToolStripContainer1.TabIndex = 65;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.mnMain);
            this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.TBMain);
            this.PMain.BackColor = System.Drawing.Color.Black;
            this.PMain.Controls.Add(this.PMainIn);
            this.PMain.Controls.Add(this.MainPanelScroll);
            this.PMain.Controls.Add(this.HS);
            this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMain.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            this.PMain.ForeColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel pMain = this.PMain;
            location = new System.Drawing.Point(5, 0);
            pMain.Location = location;
            this.PMain.Name = "PMain";
            System.Windows.Forms.Panel pMain2 = this.PMain;
            size = new System.Drawing.Size(866, 660);
            pMain2.Size = size;
            this.PMain.TabIndex = 58;
            this.PMain.Tag = "1";
            this.PMainIn.BackColor = System.Drawing.Color.Black;
            this.PMainIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMainIn.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            this.PMainIn.ForeColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel pMainIn = this.PMainIn;
            location = new System.Drawing.Point(0, 0);
            pMainIn.Location = location;
            this.PMainIn.Name = "PMainIn";
            System.Windows.Forms.Panel pMainIn2 = this.PMainIn;
            size = new System.Drawing.Size(849, 643);
            pMainIn2.Size = size;
            this.PMainIn.TabIndex = 0;
            this.PMainIn.TabStop = true;
            this.PMainIn.Tag = "1";
            this.MainPanelScroll.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.MainPanelScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainPanelScroll.LargeChange = 592;
            System.Windows.Forms.VScrollBar mainPanelScroll = this.MainPanelScroll;
            location = new System.Drawing.Point(849, 0);
            mainPanelScroll.Location = location;
            this.MainPanelScroll.Maximum = 591;
            this.MainPanelScroll.Minimum = -10000;
            this.MainPanelScroll.Name = "MainPanelScroll";
            System.Windows.Forms.VScrollBar mainPanelScroll2 = this.MainPanelScroll;
            size = new System.Drawing.Size(17, 643);
            mainPanelScroll2.Size = size;
            this.MainPanelScroll.SmallChange = 12;
            this.MainPanelScroll.TabIndex = 2;
            this.MainPanelScroll.Tag = "1";
            this.HS.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.HS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HS.LargeChange = 777;
            System.Windows.Forms.HScrollBar hS = this.HS;
            location = new System.Drawing.Point(0, 643);
            hS.Location = location;
            this.HS.Maximum = 1233;
            this.HS.Name = "HS";
            System.Windows.Forms.HScrollBar hS2 = this.HS;
            size = new System.Drawing.Size(866, 17);
            hS2.Size = size;
            this.HS.TabIndex = 3;
            this.HS.Tag = "1";
            this.SpR.Dock = System.Windows.Forms.DockStyle.Right;
            this.SpR.FlatAppearance.BorderSize = 0;
            this.SpR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Button spR = this.SpR;
            location = new System.Drawing.Point(871, 0);
            spR.Location = location;
            this.SpR.Name = "SpR";
            System.Windows.Forms.Button spR2 = this.SpR;
            size = new System.Drawing.Size(5, 660);
            spR2.Size = size;
            this.SpR.TabIndex = 59;
            this.SpR.TabStop = false;
            this.SpR.UseVisualStyleBackColor = true;
            this.SpR.Visible = false;
            this.SpL.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpL.FlatAppearance.BorderSize = 0;
            this.SpL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Button spL = this.SpL;
            location = new System.Drawing.Point(0, 0);
            spL.Location = location;
            this.SpL.Name = "SpL";
            System.Windows.Forms.Button spL2 = this.SpL;
            size = new System.Drawing.Size(5, 660);
            spL2.Size = size;
            this.SpL.TabIndex = 60;
            this.SpL.TabStop = false;
            this.SpL.UseVisualStyleBackColor = true;
            this.SpL.Visible = false;
            this.PMainR.BackColor = System.Drawing.Color.Black;
            this.PMainR.Controls.Add(this.PMainInR);
            this.PMainR.Controls.Add(this.RightPanelScroll);
            this.PMainR.Controls.Add(this.HSR);
            this.PMainR.Dock = System.Windows.Forms.DockStyle.Right;
            this.PMainR.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            this.PMainR.ForeColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel pMainR = this.PMainR;
            location = new System.Drawing.Point(876, 0);
            pMainR.Location = location;
            this.PMainR.Name = "PMainR";
            System.Windows.Forms.Panel pMainR2 = this.PMainR;
            size = new System.Drawing.Size(0, 660);
            pMainR2.Size = size;
            this.PMainR.TabIndex = 56;
            this.PMainR.Tag = "2";
            this.PMainInR.BackColor = System.Drawing.Color.Black;
            this.PMainInR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMainInR.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            this.PMainInR.ForeColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel pMainInR = this.PMainInR;
            location = new System.Drawing.Point(0, 0);
            pMainInR.Location = location;
            this.PMainInR.Name = "PMainInR";
            System.Windows.Forms.Panel pMainInR2 = this.PMainInR;
            size = new System.Drawing.Size(0, 643);
            pMainInR2.Size = size;
            this.PMainInR.TabIndex = 0;
            this.PMainInR.TabStop = true;
            this.PMainInR.Tag = "2";
            this.RightPanelScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanelScroll.LargeChange = 592;
            System.Windows.Forms.VScrollBar rightPanelScroll = this.RightPanelScroll;
            location = new System.Drawing.Point(-17, 0);
            rightPanelScroll.Location = location;
            this.RightPanelScroll.Maximum = 591;
            this.RightPanelScroll.Minimum = -10000;
            this.RightPanelScroll.Name = "RightPanelScroll";
            System.Windows.Forms.VScrollBar rightPanelScroll2 = this.RightPanelScroll;
            size = new System.Drawing.Size(17, 643);
            rightPanelScroll2.Size = size;
            this.RightPanelScroll.SmallChange = 12;
            this.RightPanelScroll.TabIndex = 2;
            this.RightPanelScroll.Tag = "2";
            this.HSR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HSR.LargeChange = 777;
            System.Windows.Forms.HScrollBar hSR = this.HSR;
            location = new System.Drawing.Point(0, 643);
            hSR.Location = location;
            this.HSR.Maximum = 1233;
            this.HSR.Name = "HSR";
            System.Windows.Forms.HScrollBar hSR2 = this.HSR;
            size = new System.Drawing.Size(0, 17);
            hSR2.Size = size;
            this.HSR.TabIndex = 3;
            this.HSR.Tag = "2";
            this.PMainL.BackColor = System.Drawing.Color.Black;
            this.PMainL.Controls.Add(this.PMainInL);
            this.PMainL.Controls.Add(this.LeftPanelScroll);
            this.PMainL.Controls.Add(this.HSL);
            this.PMainL.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMainL.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            this.PMainL.ForeColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel pMainL = this.PMainL;
            location = new System.Drawing.Point(0, 0);
            pMainL.Location = location;
            this.PMainL.Name = "PMainL";
            System.Windows.Forms.Panel pMainL2 = this.PMainL;
            size = new System.Drawing.Size(0, 660);
            pMainL2.Size = size;
            this.PMainL.TabIndex = 54;
            this.PMainL.Tag = "0";
            this.PMainInL.BackColor = System.Drawing.Color.Black;
            this.PMainInL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMainInL.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, 0);
            this.PMainInL.ForeColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel pMainInL = this.PMainInL;
            location = new System.Drawing.Point(0, 0);
            pMainInL.Location = location;
            this.PMainInL.Name = "PMainInL";
            System.Windows.Forms.Panel pMainInL2 = this.PMainInL;
            size = new System.Drawing.Size(0, 643);
            pMainInL2.Size = size;
            this.PMainInL.TabIndex = 0;
            this.PMainInL.TabStop = true;
            this.PMainInL.Tag = "0";
            this.LeftPanelScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftPanelScroll.LargeChange = 592;
            System.Windows.Forms.VScrollBar leftPanelScroll = this.LeftPanelScroll;
            location = new System.Drawing.Point(-17, 0);
            leftPanelScroll.Location = location;
            this.LeftPanelScroll.Maximum = 591;
            this.LeftPanelScroll.Minimum = -10000;
            this.LeftPanelScroll.Name = "LeftPanelScroll";
            System.Windows.Forms.VScrollBar leftPanelScroll2 = this.LeftPanelScroll;
            size = new System.Drawing.Size(17, 643);
            leftPanelScroll2.Size = size;
            this.LeftPanelScroll.SmallChange = 12;
            this.LeftPanelScroll.TabIndex = 2;
            this.LeftPanelScroll.Tag = "0";
            this.HSL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HSL.LargeChange = 777;
            System.Windows.Forms.HScrollBar hSL = this.HSL;
            location = new System.Drawing.Point(0, 643);
            hSL.Location = location;
            this.HSL.Maximum = 1233;
            this.HSL.Name = "HSL";
            System.Windows.Forms.HScrollBar hSL2 = this.HSL;
            size = new System.Drawing.Size(0, 17);
            hSL2.Size = size;
            this.HSL.TabIndex = 3;
            this.HSL.Tag = "0";
            this.POptionsResizer.AutoSize = true;
            this.POptionsResizer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.POptionsResizer.Dock = System.Windows.Forms.DockStyle.Right;
            this.POptionsResizer.FlatAppearance.BorderSize = 0;
            this.POptionsResizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            System.Windows.Forms.Button pOptionsResizer = this.POptionsResizer;
            location = new System.Drawing.Point(876, 0);
            pOptionsResizer.Location = location;
            this.POptionsResizer.Name = "POptionsResizer";
            System.Windows.Forms.Button pOptionsResizer2 = this.POptionsResizer;
            size = new System.Drawing.Size(6, 730);
            pOptionsResizer2.Size = size;
            this.POptionsResizer.TabIndex = 67;
            this.POptionsResizer.TabStop = false;
            this.POptionsResizer.UseVisualStyleBackColor = true;
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            size = new System.Drawing.Size(1082, 730);
            this.ClientSize = size;
            this.Controls.Add(this.ToolStripContainer1);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.POptionsResizer);
            this.Controls.Add(this.POptionsScroll);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, 0);
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnMain;
            this.Name = "MainWindow";
            this.cmnLanguage.ResumeLayout(false);
            this.cmnTheme.ResumeLayout(false);
            this.POptionsScroll.ResumeLayout(false);
            this.POptionsScroll.PerformLayout();
            this.POptions.ResumeLayout(false);
            this.POptions.PerformLayout();
            this.POExpansion.ResumeLayout(false);
            this.POExpansionInner.ResumeLayout(false);
            this.POExpansionInner.PerformLayout();
            this.POBeat.ResumeLayout(false);
            this.POBeatInner.ResumeLayout(false);
            this.POBeatInner.PerformLayout();
            this.TableLayoutPanel7.ResumeLayout(false);
            this.TableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nBeatD).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.nBeatN).EndInit();
            this.POBeatPart2.ResumeLayout(false);
            this.POBeatPart2.PerformLayout();
            this.POWAV.ResumeLayout(false);
            this.POWAVInner.ResumeLayout(false);
            this.POWAVInner.PerformLayout();
            this.FlowLayoutPanel3.ResumeLayout(false);
            this.POWAVPart2.ResumeLayout(false);
            this.POWAVPart2.PerformLayout();
            this.POWaveForm.ResumeLayout(false);
            this.POWaveForm.PerformLayout();
            this.POWaveFormInner.ResumeLayout(false);
            this.POWaveFormInner.PerformLayout();
            this.POWaveFormPart2.ResumeLayout(false);
            this.POWaveFormPart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.TWSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWTransparency).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPrecision).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWSaturation2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWLeft2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWTransparency2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWWidth2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPrecision2).EndInit();
            this.POWaveFormPart1.ResumeLayout(false);
            this.POWaveFormPart1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            this.TableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPosition2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TWPosition).EndInit();
            this.POGrid.ResumeLayout(false);
            this.POGrid.PerformLayout();
            this.POGridInner.ResumeLayout(false);
            this.POGridInner.PerformLayout();
            this.POGridPart2.ResumeLayout(false);
            this.POGridPart2.PerformLayout();
            this.TableLayoutPanel5.ResumeLayout(false);
            this.TableLayoutPanel5.PerformLayout();
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.CGB).EndInit();
            this.POGridPart1.ResumeLayout(false);
            this.POGridPart1.PerformLayout();
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.CGHeight2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.CGHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.CGWidth2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.CGWidth).EndInit();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.CGDivide).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.CGSub).EndInit();
            this.POHeader.ResumeLayout(false);
            this.POHeader.PerformLayout();
            this.POHeaderInner.ResumeLayout(false);
            this.POHeaderInner.PerformLayout();
            this.POHeaderPart2.ResumeLayout(false);
            this.POHeaderPart2.PerformLayout();
            this.POHeaderPart1.ResumeLayout(false);
            this.POHeaderPart1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.THBPM).EndInit();
            this.Menu1.ResumeLayout(false);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.cmnConversion.ResumeLayout(false);
            this.TBMain.ResumeLayout(false);
            this.TBMain.PerformLayout();
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            this.FStatus2.ResumeLayout(false);
            this.FStatus2.PerformLayout();
            this.FStatus.ResumeLayout(false);
            this.FStatus.PerformLayout();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            this.PMain.ResumeLayout(false);
            this.PMainR.ResumeLayout(false);
            this.PMainL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Panel _POptionsScroll;

        private ListBox _LWAV;

        private Timer _Timer1;

        private ToolStripMenuItem _MInsert;

        private ToolStripMenuItem _MRemove;

        private ContextMenuStrip _Menu1;

        private Timer _AutoSaveTimer;

        private MenuStrip _mnMain;

        private ToolStripMenuItem _mnFile;

        private ToolStripMenuItem _mnNew;

        private ToolStripMenuItem _mnOpen;

        private ToolStripMenuItem _mnImportSM;

        private ToolStripMenuItem _mnImportIBMSC;

        private ToolStripSeparator _ToolStripSeparator14;

        private ToolStripMenuItem _mnSave;

        private ToolStripMenuItem _mnSaveAs;

        private ToolStripMenuItem _mnExport;

        private ToolStripSeparator _ToolStripSeparator15;

        private ToolStripMenuItem _mnOpenR0;

        private ToolStripMenuItem _mnOpenR1;

        private ToolStripMenuItem _mnOpenR2;

        private ToolStripMenuItem _mnOpenR3;

        private ToolStripMenuItem _mnOpenR4;

        private ToolStripSeparator _ToolStripSeparator16;

        private ToolStripMenuItem _mnQuit;

        private ToolStripMenuItem _mnEdit;

        private ToolStripMenuItem _mnUndo;

        private ToolStripMenuItem _mnRedo;

        private ToolStripSeparator _ToolStripSeparator17;

        private ToolStripMenuItem _mnCut;

        private ToolStripMenuItem _mnCopy;

        private ToolStripMenuItem _mnPaste;

        private ToolStripSeparator _ToolStripSeparator18;

        private ToolStripMenuItem _mnFind;

        private ToolStripMenuItem _mnStatistics;

        private ToolStripMenuItem _mnDelete;

        private ToolStripMenuItem _mnSelectAll;

        private ToolStripMenuItem _mnMyO2;

        private ToolStripSeparator _ToolStripSeparator19;

        private ToolStripMenuItem _mnOptions;

        private ToolStripMenuItem _mnPreview;

        private ToolStripMenuItem _mnPlayB;

        private ToolStripMenuItem _mnPlay;

        private ToolStripMenuItem _mnStop;

        private ToolStripMenuItem _mnTimeSelect;

        private ToolStripMenuItem _mnSelect;

        private ToolStripMenuItem _mnWrite;

        private ToolStripSeparator _ToolStripSeparator23;

        private ToolStripMenuItem _mnConversion;

        private ToolStripMenuItem _mnErrorCheck;

        private ToolStripMenuItem _mnPreviewOnClick;

        private ToolStripMenuItem _mnShowFileName;

        private ToolStripSeparator _ToolStripSeparator20;

        private ToolStripMenuItem _mnGOptions;

        private ToolStripMenuItem _mnVOptions;

        private ToolStripMenuItem _mnLanguage;

        private ToolStripMenuItem _mnTheme;

        private ContextMenuStrip _cmnLanguage;

        private ToolStripMenuItem _TBLangDef;

        private ToolStripSeparator _ToolStripSeparator9;

        private ContextMenuStrip _cmnTheme;

        private ToolStripMenuItem _TBThemeDef;

        private ToolStripMenuItem _TBThemeSave;

        private ToolStripMenuItem _TBThemeRefresh;

        private ToolStripSeparator _ToolStripSeparator6;

        private ContextMenuStrip _cmnConversion;

        private ToolStripMenuItem _POBLong;

        private ToolStripMenuItem _POBShort;

        private ToolStripMenuItem _POBLongShort;

        private ToolStripSeparator _ToolStripSeparator10;

        private ToolStripMenuItem _POBHidden;

        private ToolStripMenuItem _POBVisible;

        private ToolStripMenuItem _POBHiddenVisible;

        private ToolStripSeparator _ToolStripSeparator11;

        private ToolStripMenuItem _POBMirror;

        private ToolStripMenuItem _POBModify;

        private ToolStripMenuItem _mnSys;

        private ToolStripMenuItem _mnSMenu;

        private ToolStripMenuItem _mnSTB;

        private ToolStripMenuItem _mnSOP;

        private ToolStripMenuItem _mnSStatus;

        private ToolStripMenuItem _mnSLSplitter;

        private ToolStripMenuItem _mnSRSplitter;

        private ToolStripMenuItem _mnNTInput;

        private ToolStripMenuItem _TBLangRefresh;

        private NumericUpDown _CGSub;

        private NumericUpDown _CGDivide;

        private PictureBox _PictureBox7;

        private CheckBox _CGSnap;

        private CheckBox _BWLock;

        private NumericUpDown _TWSaturation;

        private NumericUpDown _TWTransparency;

        private NumericUpDown _TWPrecision;

        private NumericUpDown _TWWidth;

        private NumericUpDown _TWLeft;

        private NumericUpDown _TWPosition;

        private PictureBox _PictureBox5;

        private PictureBox _PictureBox6;

        private PictureBox _PictureBox4;

        private PictureBox _PictureBox3;

        private PictureBox _PictureBox2;

        private PictureBox _PictureBox1;

        private TrackBar _TWSaturation2;

        private TrackBar _TWTransparency2;

        private TrackBar _TWPrecision2;

        private TrackBar _TWWidth2;

        private TrackBar _TWLeft2;

        private TrackBar _TWPosition2;

        private TextBox _TWFileName;

        private Button _BWClear;

        private Button _BWLoad;

        private ToolStrip _TBMain;

        private ToolStripButton _TBNew;

        private ToolStripSplitButton _TBOpen;

        private ToolStripMenuItem _TBOpenR0;

        private ToolStripMenuItem _TBOpenR1;

        private ToolStripMenuItem _TBOpenR2;

        private ToolStripMenuItem _TBOpenR3;

        private ToolStripMenuItem _TBOpenR4;

        private ToolStripSeparator _ToolStripSeparator12;

        private ToolStripMenuItem _TBImportSM;

        private ToolStripMenuItem _TBImportIBMSC;

        private ToolStripSplitButton _TBSave;

        private ToolStripMenuItem _TBSaveAs;

        private ToolStripMenuItem _TBExport;

        private ToolStripSeparator _ToolStripSeparator1;

        private ToolStripButton _TBCut;

        private ToolStripButton _TBCopy;

        private ToolStripButton _TBPaste;

        private ToolStripButton _TBFind;

        private ToolStripButton _TBStatistics;

        private Panel _pStatus;

        private StatusStrip _FStatus;

        private ToolStripStatusLabel _FSC;

        private ToolStripStatusLabel _FSP1;

        private ToolStripStatusLabel _FSP2;

        private ToolStripStatusLabel _FSP3;

        private ToolStripStatusLabel _FSP4;

        private ToolStripStatusLabel _FST;

        private ToolStripStatusLabel _FSH;

        private ToolStripStatusLabel _FSE;

        private StatusStrip _FStatus2;

        private ToolStripButton _BVCReverse;

        private ToolStripStatusLabel _LblMultiply;

        private ToolStripTextBox _TVCBPM;

        private ToolStripTextBox _TVCM;

        private ToolStripStatusLabel _LblDivide;

        private ToolStripTextBox _TVCD;

        private ToolStripButton _BVCApply;

        private ToolStripButton _BVCCalculate;

        private ToolStripStatusLabel _FSW;

        private ToolStripButton _FSSS;

        private ToolStripButton _FSSL;

        private ToolStripButton _FSSH;

        private TextBox _TExpansion;

        private Timer _TimerMiddle;

        private ToolStripSeparator _ToolStripSeparator21;

        private ToolStripMenuItem _CGShow;

        private ToolStripMenuItem _CGShowS;

        private ToolStripMenuItem _CGShowBG;

        private ToolStripMenuItem _CGShowM;

        private ToolStripMenuItem _CGShowMB;

        private ToolStripMenuItem _CGShowV;

        private ToolStripMenuItem _CGShowC;

        private ToolStripSeparator _ToolStripSeparator22;

        private ToolStripMenuItem _CGBLP;

        private ToolStripMenuItem _CGSTOP;

        private ToolStripMenuItem _CGSCROLL;

        private NumericUpDown _nBeatN;

        private ListBox _LBeat;

        private Label _Label7;

        private Button _BBeatApply;

        private ToolStripMenuItem _mnPOptions;

        private ToolStripContainer _ToolStripContainer1;

        private Panel _PMain;

        private Panel _PMainIn;

        private VScrollBar _MainPanelScroll;

        private HScrollBar _HS;

        private Panel _PMainR;

        private Panel _PMainInR;

        private VScrollBar _RightPanelScroll;

        private HScrollBar _HSR;

        private Panel _PMainL;

        private Panel _PMainInL;

        private VScrollBar _LeftPanelScroll;

        private HScrollBar _HSL;

        private ToolStripDropDownButton _POConvert;

        private ToolStripDropDownButton _TBLanguage;

        private ToolStripDropDownButton _TBTheme;

        private ToolStripButton _TBMyO2;

        private ToolStripSeparator _ToolStripSeparator4;

        private ToolStripButton _TBErrorCheck;

        private ToolStripButton _TBPreviewOnClick;

        private ToolStripButton _TBShowFileName;

        private ToolStripSeparator _ToolStripSeparator2;

        private ToolStripButton _TBUndo;

        private ToolStripButton _TBRedo;

        private ToolStripSeparator _ToolStripSeparator5;

        private ToolStripButton _TBNTInput;

        private ToolStripButton _TBTimeSelect;

        private ToolStripButton _TBSelect;

        private ToolStripButton _TBWrite;

        private ToolStripSeparator _ToolStripSeparator3;

        private ToolStripButton _TBPlayB;

        private ToolStripButton _TBPlay;

        private ToolStripButton _TBStop;

        private ToolStripButton _TBPOptions;

        private ToolStripSeparator _ToolStripSeparator7;

        private ToolStripButton _TBVOptions;

        private ToolStripButton _TBGOptions;

        private ToolStripButton _POBStorm;

        private Panel _POptions;

        private Panel _POHeader;

        private CheckBox _POHeaderSwitch;

        private Panel _POGrid;

        private CheckBox _POGridSwitch;

        private Panel _POHeaderInner;

        private TableLayoutPanel _POHeaderPart2;

        private TextBox _THExRank;

        private Label _Label25;

        private ComboBox _CHLnObj;

        private Label _Label23;

        private Label _Label21;

        private TextBox _THComment;

        private Label _Label24;

        private Label _Label15;

        private TextBox _THTotal;

        private Label _Label20;

        private Button _BHStageFile;

        private Button _BHBanner;

        private Label _Label19;

        private Button _BHBackBMP;

        private Label _Label17;

        private Label _Label16;

        private Label _Label12;

        private TextBox _THBackBMP;

        private Label _Label11;

        private TextBox _THBanner;

        private TextBox _THStageFile;

        private TextBox _THSubTitle;

        private TextBox _THSubArtist;

        private CheckBox _POHeaderExpander;

        private TableLayoutPanel _POHeaderPart1;

        private Label _Label3;

        private TextBox _THPlayLevel;

        private ComboBox _CHRank;

        private Label _Label10;

        private ComboBox _CHPlayer;

        private ComboBox _CHDifficulty;

        private Label _Label4;

        private TextBox _THGenre;

        private NumericUpDown _THBPM;

        private Label _Label2;

        private TextBox _THArtist;

        private TextBox _THTitle;

        private Label _Label9;

        private Label _Label8;

        private Label _Label6;

        private TableLayoutPanel _POGridPart1;

        private TableLayoutPanel _TableLayoutPanel2;

        private Panel _POGridInner;

        private TableLayoutPanel _POGridPart2;

        private TableLayoutPanel _TableLayoutPanel5;

        private CheckBox _cVSLockR;

        private Label _Label5;

        private CheckBox _cVSLock;

        private CheckBox _cVSLockL;

        private CheckBox _CGDisableVertical;

        private TableLayoutPanel _TableLayoutPanel4;

        private Label _Label1;

        private NumericUpDown _CGB;

        private CheckBox _POGridExpander;

        private TableLayoutPanel _TableLayoutPanel3;

        private PictureBox _PictureBox9;

        private TrackBar _CGHeight2;

        private NumericUpDown _CGHeight;

        private PictureBox _PictureBox10;

        private TrackBar _CGWidth2;

        private NumericUpDown _CGWidth;

        private Panel _POWaveForm;

        private CheckBox _POWaveFormSwitch;

        private Panel _POWaveFormInner;

        private TableLayoutPanel _POWaveFormPart2;

        private CheckBox _POWaveFormExpander;

        private TableLayoutPanel _POWaveFormPart1;

        private TableLayoutPanel _TableLayoutPanel1;

        private TableLayoutPanel _TableLayoutPanel6;

        private FlowLayoutPanel _FlowLayoutPanel1;

        private FlowLayoutPanel _FlowLayoutPanel2;

        private Panel _POWAV;

        private TableLayoutPanel _POWAVInner;

        private CheckBox _POWAVSwitch;

        private Panel _POBeat;

        private TableLayoutPanel _POBeatInner;

        private CheckBox _POBeatSwitch;

        private FlowLayoutPanel _FlowLayoutPanel3;

        private Button _BWAVUp;

        private Button _BWAVDown;

        private Button _BWAVBrowse;

        private Button _BWAVRemove;

        private Panel _POExpansion;

        private Panel _POExpansionInner;

        private CheckBox _POExpansionSwitch;

        private Button _POWAVResizer;

        private TableLayoutPanel _TableLayoutPanel7;

        private Button _POExpansionResizer;

        private Button _POBeatResizer;

        private Button _POptionsResizer;

        private Button _SpR;

        private Button _SpL;

        private ToolStripMenuItem _TBThemeLoadComptability;

        private CheckBox _POWAVExpander;

        private TableLayoutPanel _POWAVPart2;

        private CheckBox _CWAVMultiSelect;

        private CheckBox _CWAVChangeLabel;

        private NumericUpDown _nBeatD;

        private Button _BBeatApplyV;

        private TextBox _tBeatValue;

        private CheckBox _POBeatExpander;

        private TableLayoutPanel _POBeatPart2;

        private RadioButton _CBeatScale;

        private RadioButton _CBeatCut;

        private RadioButton _CBeatMeasure;

        private RadioButton _CBeatPreserve;

        private Label _Label13;

        private ToolTip _ToolTipUniversal;

        private ToolStripMenuItem _CGBPM;

        private Button _BGSlash;

        private ToolStripStatusLabel _FSM;

        private ToolStripMenuItem _mnGotoMeasure;

        private ToolStripSeparator _ToolStripSeparator24;

        private ToolStripSeparator _ToolStripSeparator8;

        private ToolStripButton _TBWavIncrease;

        private ToolStripStatusLabel _TimeStatusLabel;

        private ToolStripButton _BConvertStop;
    }
}