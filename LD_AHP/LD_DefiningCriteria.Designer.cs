namespace LD_AHP
{
    partial class LD_DefiningCriteria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Criteria");
            this.criteriaList = new System.Windows.Forms.TreeView();
            this.mcl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dcc = new System.Windows.Forms.ToolStripMenuItem();
            this.mcl.SuspendLayout();
            this.SuspendLayout();
            // 
            // criteriaList
            // 
            this.criteriaList.ContextMenuStrip = this.mcl;
            this.criteriaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criteriaList.Location = new System.Drawing.Point(0, 0);
            this.criteriaList.Name = "criteriaList";
            treeNode1.Name = "Criteria";
            treeNode1.Text = "Criteria";
            this.criteriaList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.criteriaList.Size = new System.Drawing.Size(299, 405);
            this.criteriaList.TabIndex = 0;
            // 
            // mcl
            // 
            this.mcl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.removeSelected,
            this.toolStripSeparator2,
            this.dcc});
            this.mcl.Name = "mcl";
            this.mcl.ShowImageMargin = false;
            this.mcl.Size = new System.Drawing.Size(236, 107);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Black;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // removeSelected
            // 
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(235, 22);
            this.removeSelected.Text = "Remove Selected";
            this.removeSelected.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // dcc
            // 
            this.dcc.Name = "dcc";
            this.dcc.Size = new System.Drawing.Size(235, 22);
            this.dcc.Text = "Defining Criteria Checkout";
            this.dcc.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // LD_DefiningCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.criteriaList);
            this.Name = "LD_DefiningCriteria";
            this.Size = new System.Drawing.Size(299, 405);
            this.mcl.ResumeLayout(false);
            this.mcl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView criteriaList;
        private System.Windows.Forms.ContextMenuStrip mcl;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem dcc;
    }
}
