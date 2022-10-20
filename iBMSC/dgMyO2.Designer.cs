using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace iBMSC
{
    public partial class dgMyO2 : Form
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iBMSC.dgMyO2));
        this.Label1 = new System.Windows.Forms.Label();
        this.Label4 = new System.Windows.Forms.Label();
        this.vBPM = new System.Windows.Forms.NumericUpDown();
        this.bApply1 = new System.Windows.Forms.Button();
this.bApply1.Click += new EventHandler(bApply1_Click);
        this.bApply2 = new System.Windows.Forms.Button();
this.bApply2.Click += new EventHandler(bApply2_Click);
        this.bApply3 = new System.Windows.Forms.Button();
this.bApply3.Click += new EventHandler(bApply3_Click);
        this.lResult = new System.Windows.Forms.DataGridView();
this.lResult.CellEndEdit += new DataGridViewCellEventHandler(lResult_CellEndEdit);
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
this.vBPM.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
        resources.ApplyResources(this.vBPM, "vBPM");
this.vBPM.Maximum=new decimal(new int[4] { 655359999, 0, 0, 262144 });
this.vBPM.Minimum=new decimal(new int[4] { 1, 0, 0, 262144 });
        this.vBPM.Name = "vBPM";
this.vBPM.Value=new decimal(new int[4] { 120, 0, 0, 0 });
        resources.ApplyResources(this.bApply1, "bApply1");
        this.bApply1.Name = "bApply1";
this.bApply1.Click += new EventHandler(bApply1_Click);
        this.bApply1.UseVisualStyleBackColor = true;
        resources.ApplyResources(this.bApply2, "bApply2");
        this.bApply2.Name = "bApply2";
this.bApply2.Click += new EventHandler(bApply2_Click);
        this.bApply2.UseVisualStyleBackColor = true;
        resources.ApplyResources(this.bApply3, "bApply3");
        this.bApply3.Name = "bApply3";
this.bApply3.Click += new EventHandler(bApply3_Click);
        this.bApply3.UseVisualStyleBackColor = true;
        this.lResult.AllowUserToAddRows = false;
this.lResult.CellEndEdit += new DataGridViewCellEventHandler(lResult_CellEndEdit);
        this.lResult.AllowUserToDeleteRows = false;
        this.lResult.AllowUserToResizeColumns = false;
new System.Windows.Forms.DataGridViewCellStyle().BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
this.lResult.AlternatingRowsDefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
        this.lResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
new System.Windows.Forms.DataGridViewCellStyle().BackColor = System.Drawing.SystemColors.Control;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Segoe UI", 9f);
new System.Windows.Forms.DataGridViewCellStyle().ForeColor = System.Drawing.SystemColors.WindowText;
new System.Windows.Forms.DataGridViewCellStyle().SelectionBackColor = System.Drawing.SystemColors.Highlight;
new System.Windows.Forms.DataGridViewCellStyle().SelectionForeColor = System.Drawing.SystemColors.HighlightText;
new System.Windows.Forms.DataGridViewCellStyle().WrapMode = System.Windows.Forms.DataGridViewTriState.False;
this.lResult.ColumnHeadersDefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
        this.lResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.lResult.Columns.AddRange(this.Index, this.Measure, this.ColumnName, this.Grid, this.LongNote, this.Hidden, this.AdjTo64, this.D64, this.D48);
        resources.ApplyResources(this.lResult, "lResult");
        this.lResult.Name = "lResult";
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
this.Index.DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
        resources.ApplyResources(this.Index, "Index");
        this.Index.Name = "Index";
        this.Index.ReadOnly = true;
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
this.Measure.DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
        resources.ApplyResources(this.Measure, "Measure");
        this.Measure.Name = "Measure";
        this.Measure.ReadOnly = true;
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
this.ColumnName.DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
        resources.ApplyResources(this.ColumnName, "ColumnName");
        this.ColumnName.Name = "ColumnName";
        this.ColumnName.ReadOnly = true;
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
this.Grid.DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
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
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
new System.Windows.Forms.DataGridViewCellStyle().ForeColor = System.Drawing.Color.Maroon;
this.D64.DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
        resources.ApplyResources(this.D64, "D64");
        this.D64.Name = "D64";
        this.D64.ReadOnly = true;
new System.Windows.Forms.DataGridViewCellStyle().Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
new System.Windows.Forms.DataGridViewCellStyle().Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
new System.Windows.Forms.DataGridViewCellStyle().ForeColor = System.Drawing.Color.Navy;
this.D48.DefaultCellStyle=new System.Windows.Forms.DataGridViewCellStyle();
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

internal Label Label1;
internal Label Label4;
internal NumericUpDown vBPM;
internal Button bApply1;
internal Button bApply2;
internal Button bApply3;
internal DataGridView lResult;
internal DataGridViewTextBoxColumn Index;
internal DataGridViewTextBoxColumn Measure;
internal DataGridViewTextBoxColumn ColumnName;
internal DataGridViewTextBoxColumn Grid;
internal DataGridViewCheckBoxColumn LongNote;
internal DataGridViewCheckBoxColumn Hidden;
internal DataGridViewCheckBoxColumn AdjTo64;
internal DataGridViewTextBoxColumn D64;
internal DataGridViewTextBoxColumn D48;
    }
}
