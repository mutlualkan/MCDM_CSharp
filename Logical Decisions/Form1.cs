using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LD_AHP;


namespace Logical_Decisions
{
    public partial class Form1 : Form
    {
        public Dictionary<int,string> myCriteries{ get; set; }

        Dictionary<int, string> mCs = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //LD_AHPs usercontrol = new LD_AHPs() { Dock=DockStyle.Fill };
                //Form container=new Form();
                //container.Controls.Add(usercontrol);
                //container.ShowDialog();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                bool itemC = false;
                foreach (var item in listBox1.Items)
                {
                    if (textBox1.Text == item.ToString())
                        itemC = true;
                }
                if (itemC)
                    MessageBox.Show("Bu kriter daha önce eklenmiş. Gerekli düzeltmeyi yaptıktan sonra tekrar deneyiniz.");
                else
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 & listBox1.SelectedItems.Count>0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mCs.Clear();
            if (listBox1.Items.Count > 1)
            {
                for (int i = 1; i <= listBox1.Items.Count; i++)
                {
                    mCs.Add(i,listBox1.Items[i-1].ToString());
                }
            }
            //tabControl1.SelectedIndex = 2;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //for (int i = 1; i <= mCs.Count; i++) //Kolonları oluştur.
                //{
                //    DataGridViewTextBoxColumn dgvtbc = new DataGridViewTextBoxColumn();
                //    dgvtbc.HeaderText = mCs[i];
                //    dgvtbc.Name = "CC" + i;
                //    dgvtbc.SortMode = DataGridViewColumnSortMode.NotSortable;
                //    km.Columns.Add(dgvtbc);
                //}
                //for (int i = 1; i <= mCs.Count; i++) //Satırları oluştur.
                //{
                //    DataGridViewRow dgvr = new DataGridViewRow();
                //    km.Rows.Add(mCs[i]);
                //}
                //for (int i = 1; i < km.Columns.Count; i++) //Her kriterin kendine olan üstünlüğünü 1 ve değiştirilemez yap.
                //{
                //    km.Rows[i - 1].Cells[i].Value = "1";
                //    km.Rows[i - 1].Cells[i].ReadOnly = true;
                //    km.Rows[i - 1].Cells[i].Style.BackColor = Color.DarkGray;
                //}
                //for (int i = 1; i < km.Columns.Count-1; i++) //Readonly hücreleri belirle.
                //{
                //    for (int j = 1; j < km.Columns.Count - 1; j++)
                //    {
                //        if (i >= j)
                //        {
                //            km.Rows[i].Cells[j].ReadOnly = true;
                //            km.Rows[i].Cells[j].Style.BackColor = Color.DarkGray;
                //            km.Rows[i].Cells[j].Style.ForeColor = Color.White;
                //        }
                //    }
                //}



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.StackTrace);
                //throw;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //Sütun değerlerini topla
        {

        }

        private void button6_Click(object sender, EventArgs e) //Sütun Toplamları Vektörünü oluştur
        {
            ldcm.TotalColumnsValuesMatrix(mCs.Count);
        }

        private void button7_Click(object sender, EventArgs e)  //Karşılaştırma Matrisini onayla
        {
            ldcm.ComparisonMatrix(mCs.Count);
        }

        private void button8_Click(object sender, EventArgs e) //Normalizasyon matrisini çağır ve oluştur.
        {
            //tabControl1.SelectedIndex = 3;

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ldcm.myCriteries = mCs;
            ldcm.CreateMatrix();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mCs.Count; i++)
            {
                ldcm.SumProcess4ColumnValues(i);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ldnm.LdComparisonMatrix = this.ldcm;
            ldnm.CreateNormalizationMatrix();
            
            ldpv.LdNormalizationMatrix = this.ldnm;
            ldpv.CreatePriorityVector();

            ldmv.LdComparisonMatrix = this.ldcm;
            ldmv.LdPriorityVector = this.ldpv;
            ldmv.Multiplication();

            ldev.MultiplicationDict = ldmv.MultiplicationDict;
            ldev.PriorityVector = ldpv.PriorityVector;
            ldev.CrateEigenVector();

            ldcr.EigenVector = ldev.EigenVector;
            ldcr.myCriteries = ldev.myCriteries;
            ldcr.Calculate();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ldpv.LdNormalizationMatrix = this.ldnm;
            ldpv.CreatePriorityVector();
        }

        private void karşılaştırmaMatirisiİleÖncelikVektörününÇarpımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ldmv.LdComparisonMatrix = this.ldcm;
            ldmv.LdPriorityVector = this.ldpv;
            ldmv.Multiplication();

        }



        //private Dictionary<string, string> ComparisonList()
        //{
        //    try
        //    {
        //        Dictionary<string, string> tpl = new Dictionary<string, string>();
        //        for (int i = 1; i <= Faktoriyel(mCs.Count); i++)
        //        {
        //            tpl.Add(mCs[i].ToString(),mCs[i + 1].ToString());                    
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + " / " + ex.StackTrace);
        //        return null;
        //        //throw;
        //    }
        //}

        //private int Faktoriyel(int indis)
        //{
        //    try
        //    {
        //        int fk = 1;
        //        for (int i = 1; i < indis; i++)
        //        {
        //            fk = fk * i;
        //        }
        //        return fk;
        //    }
        //    catch (Exception)
        //    {
        //        return -1;
        //        //throw;
        //    }
        //}
    }
}
