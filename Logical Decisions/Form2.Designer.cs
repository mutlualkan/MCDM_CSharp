namespace Logical_Decisions
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menu4ldcm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ldpv = new LD_AHP.LD_PriorityVector();
            this.ldnm = new LD_AHP.LD_NormalizationMatrix();
            this.ldcm = new LD_AHP.LD_ComparisonMatrix();
            this.lddc = new LD_AHP.LD_DefiningCriteria();
            this.ldmv = new LD_AHP.LD_MultiplicationCMPV();
            this.ldev = new LD_AHP.LD_EigenVector();
            this.ldcr = new LD_AHP.LD_ConsistencyRatio();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menu4ldcm.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldnm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldcm)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lddc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ldcm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ldnm, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ldpv, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ldmv, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(703, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 259);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menu4ldcm
            // 
            this.menu4ldcm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menu4ldcm.Name = "menu4ldcm";
            this.menu4ldcm.Size = new System.Drawing.Size(245, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem1.Text = "Karşılaştırma Matrisini Oluştur";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem2.Text = "Sütun Toplamlarını Oluştur";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem3.Text = "Normalizasyon Matrisini Oluştur";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.ldev, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ldcr, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(703, 268);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(170, 259);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ldpv
            // 
            this.ldpv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldpv.LdNormalizationMatrix = this.ldnm;
            this.ldpv.Location = new System.Drawing.Point(3, 3);
            this.ldpv.myCriteries = null;
            this.ldpv.Name = "ldpv";
            this.ldpv.NormalizationMatrix = null;
            this.ldpv.PriorityVector = null;
            this.ldpv.Size = new System.Drawing.Size(164, 123);
            this.ldpv.TabIndex = 0;
            // 
            // ldnm
            // 
            this.ldnm.AllowUserToAddRows = false;
            this.ldnm.AllowUserToDeleteRows = false;
            this.ldnm.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ldnm.cMTCV = null;
            this.ldnm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldnm.ComparisonMatrix = null;
            this.ldnm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldnm.LdComparisonMatrix = this.ldcm;
            this.ldnm.Location = new System.Drawing.Point(178, 268);
            this.ldnm.MultiSelect = false;
            this.ldnm.myCriteries = null;
            this.ldnm.Name = "ldnm";
            this.ldnm.NormalizationMatrix = null;
            this.ldnm.RowHeadersVisible = false;
            this.ldnm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ldnm.ShowEditingIcon = false;
            this.ldnm.Size = new System.Drawing.Size(519, 259);
            this.ldnm.TabIndex = 4;
            // 
            // ldcm
            // 
            this.ldcm.AllowUserToAddRows = false;
            this.ldcm.AllowUserToDeleteRows = false;
            this.ldcm.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ldcm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldcm.ContextMenuStrip = this.menu4ldcm;
            this.ldcm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldcm.LdDefiningCriteria = this.lddc;
            this.ldcm.Location = new System.Drawing.Point(178, 3);
            this.ldcm.MultiSelect = false;
            this.ldcm.myCriteries = null;
            this.ldcm.Name = "ldcm";
            this.ldcm.Processes = null;
            this.ldcm.RowHeadersVisible = false;
            this.ldcm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ldcm.ShowEditingIcon = false;
            this.ldcm.Size = new System.Drawing.Size(519, 259);
            this.ldcm.TabIndex = 3;
            // 
            // lddc
            // 
            this.lddc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lddc.Location = new System.Drawing.Point(3, 3);
            this.lddc.myCriteries = null;
            this.lddc.Name = "lddc";
            this.lddc.Size = new System.Drawing.Size(169, 259);
            this.lddc.TabIndex = 2;
            // 
            // ldmv
            // 
            this.ldmv.ComparisonMatrix = null;
            this.ldmv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldmv.LdComparisonMatrix = this.ldcm;
            this.ldmv.LdPriorityVector = this.ldpv;
            this.ldmv.Location = new System.Drawing.Point(3, 132);
            this.ldmv.MultiplicationDict = null;
            this.ldmv.myCriteries = null;
            this.ldmv.Name = "ldmv";
            this.ldmv.PriorityVector = null;
            this.ldmv.Size = new System.Drawing.Size(164, 124);
            this.ldmv.TabIndex = 1;
            // 
            // ldev
            // 
            this.ldev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldev.EigenVector = null;
            this.ldev.LdMultiplicationCMPV = this.ldmv;
            this.ldev.LdPriorityVector = this.ldpv;
            this.ldev.Location = new System.Drawing.Point(3, 3);
            this.ldev.MultiplicationDict = null;
            this.ldev.myCriteries = null;
            this.ldev.Name = "ldev";
            this.ldev.PriorityVector = null;
            this.ldev.Size = new System.Drawing.Size(164, 123);
            this.ldev.TabIndex = 0;
            // 
            // ldcr
            // 
            this.ldcr.ConsistencyIndicator = 0F;
            this.ldcr.ConsistencyRatio = 0F;
            this.ldcr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldcr.EigenVector = null;
            this.ldcr.L = 0F;
            this.ldcr.LdEigenVector = this.ldev;
            this.ldcr.Location = new System.Drawing.Point(3, 132);
            this.ldcr.myCriteries = null;
            this.ldcr.Name = "ldcr";
            this.ldcr.RandomIndex = 0F;
            this.ldcr.Results = null;
            this.ldcr.Size = new System.Drawing.Size(164, 124);
            this.ldcr.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menu4ldcm.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ldnm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldcm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private LD_AHP.LD_PriorityVector ldpv;
        private LD_AHP.LD_MultiplicationCMPV ldmv;
        private LD_AHP.LD_EigenVector ldev;
        private LD_AHP.LD_ConsistencyRatio ldcr;
        private LD_AHP.LD_DefiningCriteria lddc;
        private LD_AHP.LD_ComparisonMatrix ldcm;
        private LD_AHP.LD_NormalizationMatrix ldnm;
        private System.Windows.Forms.ContextMenuStrip menu4ldcm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}