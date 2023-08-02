namespace Logical_Decisions
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menu4ldcm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu4ldnm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ldcm = new LD_AHP.LD_ComparisonMatrix();
            this.ldnm = new LD_AHP.LD_NormalizationMatrix();
            this.ldpv = new LD_AHP.LD_PriorityVector();
            this.ldmv = new LD_AHP.LD_MultiplicationCMPV();
            this.ldev = new LD_AHP.LD_EigenVector();
            this.ldcr = new LD_AHP.LD_ConsistencyRatio();
            this.lD_DefiningCriteria1 = new LD_AHP.LD_DefiningCriteria();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menu4ldcm.SuspendLayout();
            this.menu4ldnm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldnm)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 519);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lD_DefiningCriteria1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kriterler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kriter Girişini Sonlandır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 238);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Seçileni Kaldır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kriter Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ldcm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ldnm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ldpv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ldmv, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ldev, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ldcr, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 487);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // menu4ldcm
            // 
            this.menu4ldcm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menu4ldcm.Name = "menu4ldcm";
            this.menu4ldcm.Size = new System.Drawing.Size(245, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem1.Text = "Karşılaştırma Matrisini Oluştur";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem2.Text = "Sütun Toplamlarını Oluştur";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem3.Text = "Normalizasyon Matrisini Oluştur";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menu4ldnm
            // 
            this.menu4ldnm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem});
            this.menu4ldnm.Name = "menu4ldnm";
            this.menu4ldnm.Size = new System.Drawing.Size(352, 48);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(351, 22);
            this.toolStripMenuItem4.Text = "Öncelik Vektörünü Oluştur";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem
            // 
            this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem.Name = "karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem";
            this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem.Text = "Karşılaştırma Matirisi ile Öncelik Vektörünün Çarpımı";
            this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem.Click += new System.EventHandler(this.karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem_Click);
            // 
            // ldcm
            // 
            this.ldcm.AllowUserToAddRows = false;
            this.ldcm.AllowUserToDeleteRows = false;
            this.ldcm.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ldcm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldcm.ContextMenuStrip = this.menu4ldcm;
            this.ldcm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldcm.Location = new System.Drawing.Point(3, 3);
            this.ldcm.MultiSelect = false;
            this.ldcm.myCriteries = null;
            this.ldcm.Name = "ldcm";
            this.ldcm.Processes = null;
            this.ldcm.RowHeadersVisible = false;
            this.ldcm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ldcm.ShowEditingIcon = false;
            this.ldcm.Size = new System.Drawing.Size(556, 237);
            this.ldcm.TabIndex = 0;
            // 
            // ldnm
            // 
            this.ldnm.AllowUserToAddRows = false;
            this.ldnm.AllowUserToDeleteRows = false;
            this.ldnm.BackgroundColor = System.Drawing.Color.DarkGray;
            this.ldnm.cMTCV = null;
            this.ldnm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldnm.ComparisonMatrix = null;
            this.ldnm.ContextMenuStrip = this.menu4ldnm;
            this.ldnm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldnm.LdComparisonMatrix = this.ldcm;
            this.ldnm.Location = new System.Drawing.Point(3, 246);
            this.ldnm.MultiSelect = false;
            this.ldnm.myCriteries = null;
            this.ldnm.Name = "ldnm";
            this.ldnm.NormalizationMatrix = null;
            this.ldnm.RowHeadersVisible = false;
            this.ldnm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ldnm.ShowEditingIcon = false;
            this.ldnm.Size = new System.Drawing.Size(556, 238);
            this.ldnm.TabIndex = 7;
            // 
            // ldpv
            // 
            this.ldpv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldpv.LdNormalizationMatrix = null;
            this.ldpv.Location = new System.Drawing.Point(565, 246);
            this.ldpv.myCriteries = null;
            this.ldpv.Name = "ldpv";
            this.ldpv.NormalizationMatrix = null;
            this.ldpv.PriorityVector = null;
            this.ldpv.Size = new System.Drawing.Size(181, 238);
            this.ldpv.TabIndex = 8;
            // 
            // ldmv
            // 
            this.ldmv.ComparisonMatrix = null;
            this.ldmv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldmv.LdComparisonMatrix = this.ldcm;
            this.ldmv.LdPriorityVector = this.ldpv;
            this.ldmv.Location = new System.Drawing.Point(752, 246);
            this.ldmv.MultiplicationDict = null;
            this.ldmv.myCriteries = null;
            this.ldmv.Name = "ldmv";
            this.ldmv.PriorityVector = null;
            this.ldmv.Size = new System.Drawing.Size(183, 238);
            this.ldmv.TabIndex = 9;
            // 
            // ldev
            // 
            this.ldev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldev.EigenVector = null;
            this.ldev.LdMultiplicationCMPV = this.ldmv;
            this.ldev.LdPriorityVector = this.ldpv;
            this.ldev.Location = new System.Drawing.Point(752, 3);
            this.ldev.MultiplicationDict = null;
            this.ldev.myCriteries = null;
            this.ldev.Name = "ldev";
            this.ldev.PriorityVector = null;
            this.ldev.Size = new System.Drawing.Size(183, 237);
            this.ldev.TabIndex = 10;
            // 
            // ldcr
            // 
            this.ldcr.ConsistencyIndicator = 0F;
            this.ldcr.ConsistencyRatio = 0F;
            this.ldcr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ldcr.EigenVector = null;
            this.ldcr.L = 0F;
            this.ldcr.LdEigenVector = this.ldev;
            this.ldcr.Location = new System.Drawing.Point(565, 3);
            this.ldcr.myCriteries = null;
            this.ldcr.Name = "ldcr";
            this.ldcr.RandomIndex = 0F;
            this.ldcr.Results = null;
            this.ldcr.Size = new System.Drawing.Size(181, 237);
            this.ldcr.TabIndex = 11;
            // 
            // lD_DefiningCriteria1
            // 
            this.lD_DefiningCriteria1.Location = new System.Drawing.Point(342, 48);
            this.lD_DefiningCriteria1.Name = "lD_DefiningCriteria1";
            this.lD_DefiningCriteria1.Size = new System.Drawing.Size(299, 405);
            this.lD_DefiningCriteria1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menu4ldcm.ResumeLayout(false);
            this.menu4ldnm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ldcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldnm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private LD_AHP.LD_ComparisonMatrix ldcm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LD_AHP.LD_NormalizationMatrix ldnm;
        private System.Windows.Forms.ContextMenuStrip menu4ldcm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private LD_AHP.LD_PriorityVector ldpv;
        private System.Windows.Forms.ContextMenuStrip menu4ldnm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private LD_AHP.LD_MultiplicationCMPV ldmv;
        private System.Windows.Forms.ToolStripMenuItem karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem;
        private LD_AHP.LD_EigenVector ldev;
        private LD_AHP.LD_ConsistencyRatio ldcr;
        private LD_AHP.LD_DefiningCriteria lD_DefiningCriteria1;
    }
}

