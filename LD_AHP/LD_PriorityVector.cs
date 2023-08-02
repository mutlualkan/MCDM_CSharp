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
    public partial class LD_PriorityVector : TreeView
    {
        public LD_NormalizationMatrix LdNormalizationMatrix { get; set; }
        public Dictionary<int, string> myCriteries { get; set; }
        public float[,] NormalizationMatrix { get; set; }
        public Dictionary<string,float> PriorityVector { get; set; }

        public LD_PriorityVector()
        {
            InitializeComponent();
        }
        public void CreatePriorityVector()
        {
            try
            {
                ClearVector();
                if (this.LdNormalizationMatrix != null)
                {
                    this.NormalizationMatrix = LdNormalizationMatrix.NormalizationMatrix;
                    this.myCriteries = this.LdNormalizationMatrix.myCriteries;
                    CalculateVector();
                    ListingPriority();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);

                //throw;
            }
        }
        private void ClearVector()
        {
            try
            {
                this.Nodes.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);

                //throw;
            }
        }
        private void CalculateVector()
        {
            try
            {
                Dictionary<string, float> pv = new Dictionary<string, float>();
                if (NormalizationMatrix.Length > 0 & myCriteries.Count>0)
                {
                    for (int i = 0; i < myCriteries.Count; i++)
                    {
                        float sumrow = 0;
                        for (int j = 0; j < myCriteries.Count; j++)
                        {
                            sumrow = sumrow + NormalizationMatrix[i,j];
                        }
                        Double sumrowval = Math.Round((Double)sumrow / myCriteries.Count,5);
                        pv.Add(myCriteries[i].ToString(), (float)sumrowval);
                    }
                    PriorityVector = pv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);

                //throw;
            }
        }
        private void ListingPriority()
        {
            try
            {
                Double sofc = 0;
                Dictionary<string, float> pv = this.PriorityVector;
                TreeNode goal = new TreeNode();
                goal.Text = "Priority Vector : ";
                this.Nodes.Add(goal);
                for (int i = 0; i < pv.Count; i++)
                {
                    TreeNode cp = new TreeNode();
                    cp.Name = "C_" + myCriteries[i].ToString() + "_P";
                    cp.Text=myCriteries[i].ToString() + " : " + pv[myCriteries[i].ToString()];
                    sofc = sofc + pv[myCriteries[i].ToString()];
                    this.Nodes[0].Nodes.Add(cp);
                }
                sofc = Math.Round(sofc, 3);
                //goal.Text = sofc.ToString();
                goal.Nodes.Add("Sum of Priority Vector Values : " + sofc.ToString());
                this.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);

                //throw;
            }
        }
    }
}
