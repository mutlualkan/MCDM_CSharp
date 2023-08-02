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
    public partial class LD_ComparisonToolBS : UserControl
    {
        public string ComparisonLeftName { get; set; }
        public string ComparisonRightName { get; set; }
        public float ComparisonLeftValue { get; set; }
        public float ComparisonRightValue { get; set; }

        float VL, VR;

        public LD_ComparisonToolBS()
        {
            InitializeComponent();
        }

        private void ComparisonButtons_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Button cb = sender as Button;
                if (cb != null)
                {
                    switch (cb.Name)
                    {
                        case "CL9": VL = 9; VR = 1; break;
                        case "CL8": VL = 8; VR = 1; break;
                        case "CL7": VL = 7; VR = 1; break;
                        case "CL6": VL = 6; VR = 1; break;
                        case "CL5": VL = 5; VR = 1; break;
                        case "CL4": VL = 4; VR = 1; break;
                        case "CL3": VL = 3; VR = 1; break;
                        case "CL2": VL = 2; VR = 1; break;
                        case "CN": VL = 1; VR = 1; break;
                        case "CR2": VR = 2; VL = 1; break;
                        case "CR3": VR = 3; VL = 1; break;
                        case "CR4": VR = 4; VL = 1; break;
                        case "CR5": VR = 5; VL = 1; break;
                        case "CR6": VR = 6; VL = 1; break;
                        case "CR7": VR = 7; VL = 1; break;
                        case "CR8": VR = 8; VL = 1; break;
                        case "CR9": VR = 9; VL = 1; break;
                        default:
                            break;
                    }
                    if (VL > VR) VR = 1 / VL; else VL = 1 / VR;
                    V4CL.Text = VL.ToString();
                    V4CR.Text = VR.ToString();
                    ComparisonLeftValue = VL;
                    ComparisonRightValue = VR;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " / " + ex.StackTrace);
                //throw;
            }
        }
    }
}
