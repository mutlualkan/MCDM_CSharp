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
    public partial class LD_MultiplicationCMPV : TreeView
    {
        public LD_ComparisonMatrix LdComparisonMatrix { get; set; }
        public float[,] ComparisonMatrix { get; set; }
        public LD_PriorityVector LdPriorityVector { get; set; }
        public Dictionary<string, float> PriorityVector { get; set; }
        public Dictionary<int, string> myCriteries { get; set; }
        public Dictionary<string, float> MultiplicationDict { get; set; }

        public LD_MultiplicationCMPV()
        {
            InitializeComponent();
        }
        public void Multiplication()
        {
            try
            {
                ClearVector();
                if (LdComparisonMatrix != null & LdPriorityVector!=null)
                {
                    this.myCriteries = LdComparisonMatrix.myCriteries;
                    this.ComparisonMatrix = LdComparisonMatrix.ComparisonMatrix(myCriteries.Count);
                    this.PriorityVector = LdPriorityVector.PriorityVector;
                    this.CalculateMultiplication();
                    this.ListingMultiplication();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void ClearVector()
        {
            try
            {
                this.Nodes.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CalculateMultiplication()
        {
            try
            {
                Dictionary<string, float> mpm = new Dictionary<string, float>();
                if (ComparisonMatrix.Length > 0 & PriorityVector.Count > 0 & myCriteries.Count > 0)
                {
                    for (int i = 0; i < myCriteries.Count; i++)
                    {
                        float ttls = 0;
                        for (int j = 0; j < myCriteries.Count; j++)
                        {
                            Double dvl = (Double)this.ComparisonMatrix[i, j] * (Double)PriorityVector[myCriteries[j].ToString()];
                            ttls = ttls + (float)dvl;
                        }
                        ttls = (float)Math.Round(ttls, 3);
                        mpm.Add(myCriteries[i].ToString(), (float)ttls);
                    }
                    MultiplicationDict = mpm;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void ListingMultiplication()
        {
            try
            {
                Double cofc = 0;
                Dictionary<string, float> mpl = this.MultiplicationDict;
                TreeNode goal = new TreeNode();
                goal.Text = "Multiplication : ";
                this.Nodes.Add(goal);
                for (int i = 0; i < mpl.Count; i++)
                {
                    TreeNode cp = new TreeNode();
                    cp.Name = "C_" + myCriteries[i].ToString() + "_Mp";
                    cp.Text=myCriteries[i].ToString() + " : " + mpl[myCriteries[i].ToString()];
                    cofc = cofc + mpl[myCriteries[i].ToString()];
                    this.Nodes[0].Nodes.Add(cp);
                }
                cofc = Math.Round(cofc, 3);
                //goal.Text = cofc.ToString();
                this.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }

    }
}
