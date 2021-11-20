using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_08_03_ManyButtons_bpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UxBlueButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void UxRedButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void UxWhiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
