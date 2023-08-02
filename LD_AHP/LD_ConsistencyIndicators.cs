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
    public partial class LD_ConsistencyIndicators : TreeView
    {
        public float L { get; set; }
        public float ConsistencyRatio { get; set; }
        public float RandomIndex { get; set; }
        public float ConsistencyIndicator { get; set; }
        public LD_EigenVector LdEigenVector { get; set; }
        public Dictionary<string, float> EigenVector { get; set; }
        public Dictionary<int,string> myCriteries { get; set; }

        //values are for the following dimensions of the requirements matrix
        //0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
        public static double[] randomIndices = {0.00, 0.00, 0.00, 0.58, 0.90, 1.12, 1.24, 1.32, 1.41, 1.45,	1.49, 1.51, 1.48, 1.56, 1.57, 1.59, 1.605, 1.61, 1.615, 1.62, 1.625};
        
        public LD_ConsistencyIndicators()
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
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ClearNodes()
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
        private void CalculateLambda()
        {
            try
            {
                float Lambda = 0;
                if (EigenVector.Count > 0 & myCriteries.Count > 0)
                {
                    for (int i = 0; i < EigenVector.Count; i++)
                    {
                        Double tevv = (Double)EigenVector[myCriteries[i + 1].ToString()];
                        Lambda = Lambda + (float)tevv;
                    }
                    this.L = Lambda / myCriteries.Count;
                }
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }
        private void ListingResults()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
