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
    public partial class LD_NormalizationMatrix : DataGridView
    {
        public LD_ComparisonMatrix LdComparisonMatrix { get; set; }
        public Dictionary<int, string> myCriteries { get; set; }
        public Dictionary<string, double> cMTCV { get; set; } // ComparisonMatrixTotalColumnValues
        public float[,] ComparisonMatrix { get; set; }
        public float[,] NormalizationMatrix { get; set; }

        public LD_NormalizationMatrix()
        {
            InitializeComponent();
        }

        private void LdComparisonMatrixChange(object sender, EventArgs e)
        {
            try
            {
                //if (LdComparisonMatrix != null)
                //{
                //    myCriteries = LdComparisonMatrix.myCriteries;
                //    cMTCV = LdComparisonMatrix.TotalColumnsValuesMatrix(myCriteries.Count);
                //    ComparisonMatrix = LdComparisonMatrix.ComparisonMatrix(myCriteries.Count);
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CreateNormalizationMatrix()
        {
            try
            {
                ClearMatrix();
                if (LdComparisonMatrix != null)
                {
                    myCriteries = LdComparisonMatrix.myCriteries;
                    cMTCV = LdComparisonMatrix.TotalColumnsValuesMatrix(myCriteries.Count);
                    ComparisonMatrix = LdComparisonMatrix.ComparisonMatrix(myCriteries.Count);
                    CreateColumns4Matrix();
                    CreateRows4Matrix();
                    CalculateNormalizationMatrix();
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
                        dgvtbc.ReadOnly = true;
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
                    for (int i = 0; i < myCriteries.Count; i++)
                    {
                        this[myCriteries.Count, i].Value = myCriteries[i].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CalculateNormalizationMatrix()
        {
            try
            {
                int nofc=myCriteries.Count;
                float[,] cm = ComparisonMatrix;
                float[,] nm = new float[nofc, nofc];
                for (int i = 0; i < nofc; i++)
                {
                    for (int j = 0; j < nofc; j++)
                    {
                        Double nmvl = cm[j,i] / cMTCV[myCriteries[i]];
                        this[i,j].Value = (float)nmvl;
                        //nm[j, i] = cm[j, i];
                        nm[j, i] = (float)nmvl;
                    }
                }
                NormalizationMatrix = nm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
    }
}
