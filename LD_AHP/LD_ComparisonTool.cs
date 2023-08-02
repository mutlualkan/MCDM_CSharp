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
    public partial class LD_ComparisonTool : UserControl
    {
        public LD_ComparisonTool()
        {
            InitializeComponent();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NumericUpDown nud = sender as NumericUpDown;
                if (nud != null)
                {
                    if ((Double)nud.Value >= 0.001 | (Double)nud.Value <= 9.000)
                    {
                        Double pbV = (Double)nud.Value * 100;
                        Double NnudV = 1 / (Double)nud.Value;
                        //if (nud.Name == "nudL") { pbL.Value = (Int32)pbV; nudR.Value = (Decimal) NnudV; }
                        //else if (nud.Name == "nudR") { pbR.Value = (Int32)pbV; nudL.Value = (Decimal)NnudV; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
