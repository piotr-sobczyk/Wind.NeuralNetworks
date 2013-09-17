using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neural_computing_machine.Forms
{
    public partial class HopfieldSimple : Form
    {
        HopfieldNetwork network;
        
        public HopfieldSimple()
        {
            InitializeComponent();
            this.network = new HopfieldNetwork(4);
            RefreshMatrixPreview();
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            bool[] inputPattern = new bool[4];
            ReadPattern(inputPattern);

            bool[] resultPattern = network.Present(inputPattern);
            ShowPattern(resultPattern);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            bool[] pattern = new bool[4];
            ReadPattern(pattern);

            network.Train(pattern);
            RefreshMatrixPreview();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            network = new HopfieldNetwork(4);
            RefreshMatrixPreview();
        }

        private void ReadPattern(bool[] pattern)
        {
            pattern[0] = Convert.ToBoolean(this.nudInput1.Value);
            pattern[1] = Convert.ToBoolean(this.nudInput2.Value);
            pattern[2] = Convert.ToBoolean(this.nudInput3.Value);
            pattern[3] = Convert.ToBoolean(this.nudInput4.Value);
        }

        private void ShowPattern(bool[] pattern)
        {
            tbResult1.Text = Convert.ToString(pattern[0]);
            tbResult2.Text = Convert.ToString(pattern[1]);
            tbResult3.Text = Convert.ToString(pattern[2]);
            tbResult4.Text = Convert.ToString(pattern[3]);
        }

        private void RefreshMatrixPreview()
        {
            dgvMatrixPreview.Rows.Clear();

            for (int i = 0; i < network.LayerMatrix.Rows; ++i)
            {
                dgvMatrixPreview.Rows.Add(network.LayerMatrix[i, 0], network.LayerMatrix[i, 1],
                    network.LayerMatrix[i, 2], network.LayerMatrix[i, 3]);
            }
        }
    }
}
