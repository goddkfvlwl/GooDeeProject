﻿using System;
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
    public partial class CtlModifyMemberInfo : UserControl
    {
        public CtlModifyMemberInfo()
        {
            InitializeComponent();
            
        }

        private void btnSearhAddr_Click(object sender, EventArgs e)
        {
            FrmSearchAddr sa = new FrmSearchAddr();
            sa.Show();
        }
    }
}
