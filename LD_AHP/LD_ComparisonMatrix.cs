using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LD_AHP
{
    public partial class LD_ComparisonMatrix : DataGridView
    {
        public LD_DefiningCriteria LdDefiningCriteria { get; set; }
        public Dictionary<int, string> myCriteries { get; set; }
        public ContextMenuStrip Processes{ get; set; }

        public LD_ComparisonMatrix()
        {
            InitializeComponent();
        }
        public void CreateMatrix()
        {
            try
            {
                ClearMatrix();
                if (LdDefiningCriteria != null)
                {
                    this.myCriteries = LdDefiningCriteria.myCriteries;
                    CreateColumns4Matrix();
                    CreateRows4Matrix();
                    DefineDiagonal4Matrix();
                    DefineReadonlyCells4Matrix();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void ClearMatrix()
        {
            try
            {
                this.Rows.Clear();
                this.Columns.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CreateColumns4Matrix()
        {
            try
            {
                if (myCriteries != null & myCriteries.Count > 0)
                {
                    for (int i = 0; i < myCriteries.Count; i++) //Kolonları oluştur.
                    {
                        DataGridViewTextBoxColumn dgvtbc = new DataGridViewTextBoxColumn();
                        dgvtbc.HeaderText = myCriteries[i];
                        dgvtbc.Name = "CC" + i;
                        dgvtbc.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvtbc.DefaultCellStyle.Format = "0.###";
                        this.Columns.Add(dgvtbc);
                    }
                    DataGridViewTextBoxColumn dgvtc = new DataGridViewTextBoxColumn();
                    dgvtc.DefaultCellStyle.BackColor = SystemColors.ButtonFace;
                    dgvtc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvtc.ReadOnly = true;
                    this.Columns.Add(dgvtc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CreateRows4Matrix()
        {
            try
            {
                if (myCriteries != null & myCriteries.Count > 0)
                {
                    for (int i = 0; i < myCriteries.Count; i++) //Satırları oluştur.
                    {
                        DataGridViewRow dgvr = new DataGridViewRow();
                        this.Rows.Add();
                    }
                    this.Rows.Add();
                    for (int i = 0; i < myCriteries.Count; i++)
                    {
                        this[myCriteries.Count, i].Value = myCriteries[i].ToString();
                    }
                    this[myCriteries.Count, myCriteries.Count].Value = "Sum of column values";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void DefineDiagonal4Matrix()
        {
            try
            {
                if (myCriteries != null & myCriteries.Count > 0)
                {
                    for (int i = 0; i < this.Columns.Count-1; i++) //Her kriterin kendine olan üstünlüğünü 1 ve değiştirilemez yap.
                    {
                        this.Rows[i].Cells[i].Value = "1";
                        this.Rows[i].Cells[i].ReadOnly = true;
                        this.Rows[i].Cells[i].Style.BackColor = Color.DarkGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void DefineReadonlyCells4Matrix()
        {
            try
            {
                if (myCriteries != null & myCriteries.Count > 0)
                {
                    for (int i = 0; i < this.Columns.Count - 1; i++) //Readonly hücreleri belirle.
                    {
                        for (int j = 0; j < this.Columns.Count - 1; j++)
                        {
                            if (i >= j)
                            {
                                this.Rows[i].Cells[j].ReadOnly = true;
                                this.Rows[i].Cells[j].Style.BackColor = Color.DarkGray;
                                this.Rows[i].Cells[j].Style.ForeColor = Color.White;
                            }
                            if (this[j, i].Value == null) this[j, i].Value = 1;
                        }
                    }
                    for (int i = 0; i < myCriteries.Count; i++)
                    {
                        this.Rows[this.Rows.Count-1].Cells[i].ReadOnly = true;
                        this.Rows[this.Rows.Count-1].Cells[i].Style.BackColor = Color.Yellow;
                        this.Rows[this.Rows.Count-1].Cells[i].Style.ForeColor = Color.Maroon;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        public void LD_ComparisonMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IsValueTypeNumeric(this[e.ColumnIndex, e.RowIndex].Value.ToString()))
                {
                    float dgr = float.Parse(this[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if (dgr <= 9.5 & dgr > 0)
                    {
                        if (e.RowIndex < this.Rows.Count - 1)
                        {
                            if (!this[e.ColumnIndex, e.RowIndex].ReadOnly)
                            {
                                float ydgr = 1 / (float)dgr;
                                if (dgr < 1) ydgr = (float)Math.Round(ydgr);
                                this[e.RowIndex, e.ColumnIndex].Value = ydgr;
                            }
                        }
                        //SumProcess4ColumnValues(e.ColumnIndex);
                    }
                    else if (dgr>9.5 & e.RowIndex == this.Rows.Count-1)
                        this[e.ColumnIndex, e.RowIndex].Value = dgr;
                    else
                    {
                        MessageBox.Show("Girdiğiniz değer olması gereken aralıkta değil, tekrar deneyiniz.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace + "/" + ex.InnerException);

            }
        }
        public void SumProcess4ColumnValues(int columnindex)
        {
            try
            {
                float nullvalue = 0;
                float sumvalues = 0;
                if (columnindex >= 0)
                {
                    for (int i = 0; i < myCriteries.Count; i++)
                    {
                        if (this[columnindex, i].Value != null)
                        {
                            Double vl=Convert.ToDouble(this[columnindex, i].Value.ToString());
                            sumvalues = sumvalues + (float)vl;
                        }
                        //if ((float)this[columnindex, i].Value != null & (float)this[columnindex, i].Value > 0)
                        else
                            sumvalues += nullvalue;
                    }
                    this[columnindex, this.Rows.Count-1].Value = sumvalues;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace + "###" + columnindex);
            }
        }
        private bool IsValueTypeNumeric(string vl)
        {
            try
            {
                if (vl != null)
                {
                    Double value = Convert.ToDouble(vl);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Dictionary<string, double> TotalColumnsValuesMatrix(int rowindex)
        {
            try
            {
                Dictionary<string, double> tcvm = new Dictionary<string, double>();
                for (int i = 0; i < myCriteries.Count; i++)
                {
                    Double vl = Convert.ToDouble(this.Rows[rowindex].Cells[i].Value);
                    tcvm.Add(myCriteries[i].ToString(), (float)vl);
                }
                if (tcvm.Count == myCriteries.Count) { return tcvm; }
                else return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
                return null;
            }
        }
        public float[,] ComparisonMatrix(int cc)
        {
            try
            {
                float[,] cm=new float[cc,cc];
                for (int i = 0; i < this.Rows.Count-1; i++)
                {
                    for (int j = 0; j < this.Columns.Count-1; j++)
                    {
                        Double vl = Convert.ToDouble(this.Rows[i].Cells[j].Value);
                        cm[i, j] = (float)vl;
                    }
                }
                if (cm.Length == cc * cc) { return cm; }
                else return null;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
