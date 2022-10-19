using System;
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
public class dgMyO2 : Form
{
    public struct Adj
    {
        public int Measure;

        public int ColumnIndex;

        public string ColumnName;

        public string Grid;

        public bool LongNote;

        public bool Hidden;

        public bool AdjTo64;

        public int D64;

        public int D48;
    }

    private IContainer components;

    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [AccessedThroughProperty("Label4")]
    private Label _Label4;

    [AccessedThroughProperty("vBPM")]
    private NumericUpDown _vBPM;

    [AccessedThroughProperty("bApply1")]
    private Button _bApply1;

    [AccessedThroughProperty("bApply2")]
    private Button _bApply2;

    [AccessedThroughProperty("bApply3")]
    private Button _bApply3;

    [AccessedThroughProperty("lResult")]
    private DataGridView _lResult;

    [AccessedThroughProperty("Index")]
    private DataGridViewTextBoxColumn _Index;

    [AccessedThroughProperty("Measure")]
    private DataGridViewTextBoxColumn _Measure;

    [AccessedThroughProperty("ColumnName")]
    private DataGridViewTextBoxColumn _ColumnName;

    [AccessedThroughProperty("Grid")]
    private DataGridViewTextBoxColumn _Grid;

    [AccessedThroughProperty("LongNote")]
    private DataGridViewCheckBoxColumn _LongNote;

    [AccessedThroughProperty("Hidden")]
    private DataGridViewCheckBoxColumn _Hidden;

    [AccessedThroughProperty("AdjTo64")]
    private DataGridViewCheckBoxColumn _AdjTo64;

    [AccessedThroughProperty("D64")]
    private DataGridViewTextBoxColumn _D64;

    [AccessedThroughProperty("D48")]
    private DataGridViewTextBoxColumn _D48;

    private Adj[] Aj;

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

    internal virtual NumericUpDown vBPM
    {
        get
        {
            return _vBPM;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _vBPM = value;
        }
    }

    internal virtual Button bApply1
    {
        get
        {
            return _bApply1;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = bApply1_Click;
            if (_bApply1 != null)
            {
                _bApply1.Click -= value2;
            }
            _bApply1 = value;
            if (_bApply1 != null)
            {
                _bApply1.Click += value2;
            }
        }
    }

    internal virtual Button bApply2
    {
        get
        {
            return _bApply2;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = bApply2_Click;
            if (_bApply2 != null)
            {
                _bApply2.Click -= value2;
            }
            _bApply2 = value;
            if (_bApply2 != null)
            {
                _bApply2.Click += value2;
            }
        }
    }

    internal virtual Button bApply3
    {
        get
        {
            return _bApply3;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler value2 = bApply3_Click;
            if (_bApply3 != null)
            {
                _bApply3.Click -= value2;
            }
            _bApply3 = value;
            if (_bApply3 != null)
            {
                _bApply3.Click += value2;
            }
        }
    }

    internal virtual DataGridView lResult
    {
        get
        {
            return _lResult;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            DataGridViewCellEventHandler value2 = lResult_CellEndEdit;
            if (_lResult != null)
            {
                _lResult.CellEndEdit -= value2;
            }
            _lResult = value;
            if (_lResult != null)
            {
                _lResult.CellEndEdit += value2;
            }
        }
    }

    internal virtual DataGridViewTextBoxColumn Index
    {
        get
        {
            return _Index;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Index = value;
        }
    }

    internal virtual DataGridViewTextBoxColumn Measure
    {
        get
        {
            return _Measure;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Measure = value;
        }
    }

    internal virtual DataGridViewTextBoxColumn ColumnName
    {
        get
        {
            return _ColumnName;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _ColumnName = value;
        }
    }

    internal virtual DataGridViewTextBoxColumn Grid
    {
        get
        {
            return _Grid;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Grid = value;
        }
    }

    internal virtual DataGridViewCheckBoxColumn LongNote
    {
        get
        {
            return _LongNote;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _LongNote = value;
        }
    }

    internal virtual DataGridViewCheckBoxColumn Hidden
    {
        get
        {
            return _Hidden;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _Hidden = value;
        }
    }

    internal virtual DataGridViewCheckBoxColumn AdjTo64
    {
        get
        {
            return _AdjTo64;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _AdjTo64 = value;
        }
    }

    internal virtual DataGridViewTextBoxColumn D64
    {
        get
        {
            return _D64;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _D64 = value;
        }
    }

    internal virtual DataGridViewTextBoxColumn D48
    {
        get
        {
            return _D48;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _D48 = value;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iBMSC.dgMyO2));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.vBPM = new System.Windows.Forms.NumericUpDown();
        this.bApply1 = new System.Windows.Forms.Button();
        this.bApply2 = new System.Windows.Forms.Button();
        this.bApply3 = new System.Windows.Forms.Button();
        this.lResult = new System.Windows.Forms.DataGridView();
        this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.LongNote = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.Hidden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.AdjTo64 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.D64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.D48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)this.vBPM).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.lResult).BeginInit();
        this.SuspendLayout();
        resources.ApplyResources(this.Label1, "Label1");
        this.Label1.Name = "Label1";
        resources.ApplyResources(this.Label4, "Label4");
        this.Label4.Name = "Label4";
        this.vBPM.DecimalPlaces = 4;
        System.Windows.Forms.NumericUpDown numericUpDown = this.vBPM;
        decimal increment = new decimal(new int[4] { 10, 0, 0, 0 });
        numericUpDown.Increment = increment;
        resources.ApplyResources(this.vBPM, "vBPM");
        increment = (this.vBPM.Maximum = new decimal(new int[4] { 655359999, 0, 0, 262144 }));
        increment = (this.vBPM.Minimum = new decimal(new int[4] { 1, 0, 0, 262144 }));
        this.vBPM.Name = "vBPM";
        increment = (this.vBPM.Value = new decimal(new int[4] { 120, 0, 0, 0 }));
        resources.ApplyResources(this.bApply1, "bApply1");
        this.bApply1.Name = "bApply1";
        this.bApply1.UseVisualStyleBackColor = true;
        resources.ApplyResources(this.bApply2, "bApply2");
        this.bApply2.Name = "bApply2";
        this.bApply2.UseVisualStyleBackColor = true;
        resources.ApplyResources(this.bApply3, "bApply3");
        this.bApply3.Name = "bApply3";
        this.bApply3.UseVisualStyleBackColor = true;
        this.lResult.AllowUserToAddRows = false;
        this.lResult.AllowUserToDeleteRows = false;
        this.lResult.AllowUserToResizeColumns = false;
        dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
        this.lResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
        this.lResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9f);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.lResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.lResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.lResult.Columns.AddRange(this.Index, this.Measure, this.ColumnName, this.Grid, this.LongNote, this.Hidden, this.AdjTo64, this.D64, this.D48);
        resources.ApplyResources(this.lResult, "lResult");
        this.lResult.Name = "lResult";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.Index.DefaultCellStyle = dataGridViewCellStyle3;
        resources.ApplyResources(this.Index, "Index");
        this.Index.Name = "Index";
        this.Index.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.Measure.DefaultCellStyle = dataGridViewCellStyle4;
        resources.ApplyResources(this.Measure, "Measure");
        this.Measure.Name = "Measure";
        this.Measure.ReadOnly = true;
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.ColumnName.DefaultCellStyle = dataGridViewCellStyle5;
        resources.ApplyResources(this.ColumnName, "ColumnName");
        this.ColumnName.Name = "ColumnName";
        this.ColumnName.ReadOnly = true;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.Grid.DefaultCellStyle = dataGridViewCellStyle6;
        resources.ApplyResources(this.Grid, "Grid");
        this.Grid.Name = "Grid";
        this.Grid.ReadOnly = true;
        this.LongNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        resources.ApplyResources(this.LongNote, "LongNote");
        this.LongNote.Name = "LongNote";
        this.LongNote.ReadOnly = true;
        this.Hidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        resources.ApplyResources(this.Hidden, "Hidden");
        this.Hidden.Name = "Hidden";
        this.Hidden.ReadOnly = true;
        this.AdjTo64.FlatStyle = System.Windows.Forms.FlatStyle.System;
        resources.ApplyResources(this.AdjTo64, "AdjTo64");
        this.AdjTo64.Name = "AdjTo64";
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
        this.D64.DefaultCellStyle = dataGridViewCellStyle7;
        resources.ApplyResources(this.D64, "D64");
        this.D64.Name = "D64";
        this.D64.ReadOnly = true;
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Navy;
        this.D48.DefaultCellStyle = dataGridViewCellStyle8;
        resources.ApplyResources(this.D48, "D48");
        this.D48.Name = "D48";
        this.D48.ReadOnly = true;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        resources.ApplyResources(this, "$this");
        this.Controls.Add(this.lResult);
        this.Controls.Add(this.bApply3);
        this.Controls.Add(this.bApply2);
        this.Controls.Add(this.bApply1);
        this.Controls.Add(this.vBPM);
        this.Controls.Add(this.Label4);
        this.Controls.Add(this.Label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "dgMyO2";
        this.TopMost = true;
        ((System.ComponentModel.ISupportInitialize)this.vBPM).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.lResult).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void fMyO2_Load(object sender, EventArgs e)
    {
        Font = MyProject.Forms.MainWindow.Font;
        vBPM.Value = MyProject.Forms.MainWindow.THBPM.Value;
    }

    private void AddAdjItem(Adj xAj, int Index)
    {
        lResult.Rows.Add();
        int rowIndex = checked(lResult.Rows.Count - 1);
        lResult[0, rowIndex].Value = Index;
        lResult[1, rowIndex].Value = xAj.Measure;
        lResult[2, rowIndex].Value = xAj.ColumnName;
        lResult[3, rowIndex].Value = xAj.Grid;
        lResult[4, rowIndex].Value = xAj.LongNote;
        lResult[5, rowIndex].Value = xAj.Hidden;
        lResult[6, rowIndex].Value = xAj.AdjTo64;
        lResult[7, rowIndex].Value = xAj.D64;
        lResult[8, rowIndex].Value = xAj.D48;
    }

    private void bApply1_Click(object sender, EventArgs e)
    {
        MyProject.Forms.MainWindow.MyO2ConstBPM(Convert.ToInt32(decimal.Multiply(vBPM.Value, new decimal(10000L))));
    }

    private void bApply2_Click(object sender, EventArgs e)
    {
        string[] array = MyProject.Forms.MainWindow.MyO2GridCheck();
        checked
        {
            Aj = new Adj[Information.UBound(array) + 1];
            lResult.Rows.Clear();
            int num = Information.UBound(Aj);
            for (int i = 0; i <= num; i++)
            {
                string[] array2 = Microsoft.VisualBasic.Strings.Split(array[i], "_");
                Adj[] aj = Aj;
                int num2 = i;
                aj[num2].Measure = (int)Math.Round(Conversion.Val(array2[0]));
                aj[num2].ColumnIndex = (int)Math.Round(Conversion.Val(array2[1]));
                aj[num2].ColumnName = array2[2];
                aj[num2].Grid = array2[3];
                aj[num2].LongNote = Conversion.Val(array2[4]) != 0.0;
                aj[num2].Hidden = Conversion.Val(array2[5]) != 0.0;
                aj[num2].AdjTo64 = Conversion.Val(array2[6]) != 0.0;
                aj[num2].D64 = (int)Math.Round(Conversion.Val(array2[7]));
                aj[num2].D48 = (int)Math.Round(Conversion.Val(array2[8]));
                AddAdjItem(Aj[i], i);
            }
        }
    }

    private void bApply3_Click(object sender, EventArgs e)
    {
        MyProject.Forms.MainWindow.MyO2GridAdjust(Aj);
    }

    public dgMyO2()
    {
        base.Load += fMyO2_Load;
        Aj = new Adj[0];
        InitializeComponent();
    }

    private void lResult_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 6 && e.RowIndex >= 0)
        {
            Aj[checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(lResult[0, e.RowIndex].Value))))].AdjTo64 = Conversions.ToBoolean(lResult[6, e.RowIndex].Value);
        }
    }
}
