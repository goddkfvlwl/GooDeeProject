using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class Agreement_enterprise : UserControl
    {
        public Agreement_enterprise()
        {
            InitializeComponent();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
            
            
        }

        private void iTalk_Button_13_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_Button_15_Click(object sender, EventArgs e)
        {
            
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionFont = fontDialog1.Font;
            }
        }

        private void iTalk_Button_16_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
