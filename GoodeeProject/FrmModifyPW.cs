﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmModifyPW : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;
<<<<<<< HEAD
        private string email;
        public string Email { get { return email; } set { email = value; } }
        public FrmModifyPW()
        {
            InitializeComponent();
            Frm_DrawLine();
            FrmSendEmail frm = (FrmSendEmail)Owner;
            email = frm.Email;
=======

        public FrmModifyPW()
        {
            InitializeComponent();
>>>>>>> 996aec1cc9d09b2f48bbda1986dd0beb3bb2a7fe
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }
        
        public void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }
<<<<<<< HEAD
=======

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
>>>>>>> 996aec1cc9d09b2f48bbda1986dd0beb3bb2a7fe
    }
}