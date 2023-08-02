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
    public partial class LD_EigenVector : TreeView
    {
        public LD_PriorityVector LdPriorityVector { get; set; }
        public LD_MultiplicationCMPV LdMultiplicationCMPV { get; set; }
        public Dictionary<string, float> PriorityVector { get; set; }
        public Dictionary<string, float> MultiplicationDict { get; set; }
        public Dictionary<string, float> EigenVector { get; set; }
        public Dictionary<int, string> myCriteries { get; set; }

        public LD_EigenVector()
        {
            InitializeComponent();
        }
        public void CrateEigenVector()
        {
            try
            {
                this.ClearVector();
                if (LdPriorityVector != null & LdMultiplicationCMPV != null)
                {
                    this.PriorityVector = LdPriorityVector.PriorityVector;
                    this.MultiplicationDict = LdMultiplicationCMPV.MultiplicationDict;
                    this.myCriteries = LdMultiplicationCMPV.myCriteries;
                    this.CalculateEigenVector();
                    this.ListingEigenVector();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void CalculateEigenVector()
        {
            try
            {
                Dictionary<string, float> ev = new Dictionary<string, float>();
                if (PriorityVector.Count > 0 & MultiplicationDict.Count > 0 & PriorityVector.Count == MultiplicationDict.Count)
                {
                    for (int i = 0; i < PriorityVector.Count; i++)
                    {
                        Double evv = (Double)MultiplicationDict[myCriteries[i].ToString()] / PriorityVector[myCriteries[i].ToString()];
                        ev.Add(myCriteries[i].ToString(), (float)evv);
                    }
                    this.EigenVector = ev;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/" + ex.StackTrace);
            }
        }
        private void ListingEigenVector()
        {
            try
            {
                Double eofc = 0;
                Dictionary<string, float> mpl = this.EigenVector;
                TreeNode goal = new TreeNode();
                goal.Text = "Eigen Vector : ";
                this.Nodes.Add(goal);
                for (int i = 0; i < mpl.Count; i++)
                {
                    TreeNode cp = new TreeNode();
                    cp.Name = "C_" + myCriteries[i].ToString() + "_Mp";
                    cp.Text = myCriteries[i].ToString() + " : " + mpl[myCriteries[i].ToString()];
                    eofc = eofc + mpl[myCriteries[i].ToString()];
                    this.Nodes[0].Nodes.Add(cp);
                }
                eofc = Math.Round(eofc, 3);
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
