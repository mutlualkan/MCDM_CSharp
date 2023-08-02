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
    public partial class LD_ConsistencyRatio : TreeView
    {
        public float L { get; set; }
        public float ConsistencyRatio { get; set; }
        public float RandomIndex { get; set; }
        public float ConsistencyIndicator { get; set; }
        public LD_EigenVector LdEigenVector { get; set; }
        public Dictionary<string, float> EigenVector { get; set; }
        public Dictionary<int,string> myCriteries { get; set; }
        public Dictionary<string,float> Results { get; set; }
        private Dictionary<int,string> Labelofresults { get; set; }

        //values are for the following dimensions of the requirements matrix
        //0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
        public static double[] randomIndices = {0.00, 0.00, 0.00, 0.58, 0.90, 1.12, 1.24, 1.32, 1.41, 1.45,	1.49, 1.51, 1.48, 1.56, 1.57, 1.59, 1.605, 1.61, 1.615, 1.62, 1.625};
        
        public LD_ConsistencyRatio()
        {
            InitializeComponent();
        }
        public void Calculate()
        {
            try
            {
                ClearNodes();
                if (LdEigenVector != null)
                {
                    this.EigenVector = LdEigenVector.EigenVector;
                    this.myCriteries = LdEigenVector.myCriteries;
                    CalculateLambda();
                    CalculateConsistencyIndicator();
                    CalculateConsistencyRatio();
                    CreateResultValues();
                    ListingResults();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void ClearNodes()
        {
            try
            {
                this.Nodes.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CalculateLambda()
        {
            try
            {
                float Lambda = 0;
                if (EigenVector.Count > 0 & myCriteries.Count > 0)
                {
                    for (int i = 0; i < EigenVector.Count; i++)
                    {
                        Double tevv = (Double)EigenVector[myCriteries[i].ToString()];
                        Lambda = Lambda + (float)tevv;
                    }
                    this.L = Lambda / myCriteries.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CalculateConsistencyIndicator()
        {
            try
            {
                float CI = 0;
                if (L > 0 & myCriteries.Count > 0)
                {
                    CI = (L - myCriteries.Count) / (myCriteries.Count - 1);
                }
                this.ConsistencyIndicator = CI;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CalculateConsistencyRatio()
        {
            try
            {
                float CR = 0;
                if (this.ConsistencyIndicator > 0 & myCriteries.Count > 2)
                {
                    CR = (float) (this.ConsistencyIndicator / randomIndices[myCriteries.Count]);
                }
                this.ConsistencyRatio = CR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CreateResultValues()
        {
            try
            {
                Dictionary<string, float> resultList = new Dictionary<string, float>();
                Dictionary<int, string> lofr = new Dictionary<int, string>();
                lofr.Add(0, "Lambda : ");
                resultList.Add(lofr[0].ToString(), (float)this.L);
                lofr.Add(1, "Consistency Indicator : ");
                resultList.Add(lofr[1].ToString(), (float) this.ConsistencyIndicator);
                lofr.Add(2, "Number of Criteria : ");
                resultList.Add(lofr[2].ToString(), (float)this.myCriteries.Count);
                lofr.Add(3, "Random Index : ");
                resultList.Add(lofr[3].ToString(), (float)randomIndices[myCriteries.Count] );
                lofr.Add(4, "Consistency Ratio : ");
                resultList.Add(lofr[4].ToString(), this.ConsistencyRatio);
                this.Labelofresults = lofr;
                this.Results = resultList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void ListingResults()
        {
            try
            {
                TreeNode tn = new TreeNode();
                tn.Name = "AHP_Results";
                tn.Text = "Consistency for AHP :";
                
                this.Nodes.Add(tn);
                for (int i = 0; i < Results.Count; i++)
                {
                    TreeNode rn = new TreeNode();
                    rn.Name = Labelofresults[i].Replace(":", "").Replace(" ", "").ToString();
                    rn.Text = Labelofresults[i].ToString() + Results[Labelofresults[i].ToString()];
                    tn.Nodes.Add(rn);
                }
                TreeNode crn = new TreeNode();
                crn.Name = "Result";
                if (this.ConsistencyRatio <= 0.10)
                {
                    crn.Text = "Result : CONSISTENT";
                    crn.BackColor = Color.DarkGreen;
                    crn.ForeColor = Color.White;
                }
                else
                {
                    crn.Text = "Consistency Result : NOT CONSISTENT";
                    crn.BackColor = Color.Red;
                    crn.ForeColor = Color.White;
                }
                tn.Nodes.Add(crn);
                this.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
    }
}
