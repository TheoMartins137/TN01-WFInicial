﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_ex1_Click(object sender, EventArgs e)
        {
            FormEx001 formEx01 = new FormEx001();
            formEx01.ShowDialog();
        }

        private void btn_ex2_Click(object sender, EventArgs e)
        {
            FormEx002 formEx02 = new FormEx002();
            formEx02.ShowDialog();
        }

        private void btn_ex3_Click(object sender, EventArgs e)
        {
            FormEx003 formEx03 = new FormEx003();
            formEx03.ShowDialog();
        }

        private void btn_ex4_Click(object sender, EventArgs e)
        {
            FormEx004 formEx04 = new FormEx004();
            formEx04.ShowDialog();
        }

        private void btn_ex5_Click(object sender, EventArgs e)
        {
            FormEx005 formEx05 = new FormEx005();
            formEx05.ShowDialog();
        }

        private void btn_ex6_Click(object sender, EventArgs e)
        {
            FormEx006 formEx06 = new FormEx006();
            formEx06.ShowDialog();
        }

        private void btn_ex7_Click(object sender, EventArgs e)
        {
            FormEx007 formEx07 = new FormEx007();
            formEx07.ShowDialog();
        }

        private void btn_ex8_Click(object sender, EventArgs e)
        {
            FormEx008 formEx08 = new FormEx008();
            formEx08.ShowDialog();
        }

        private void btn_ex9_Click(object sender, EventArgs e)
        {
            FormEx009 formEx09 = new FormEx009();
            formEx09.ShowDialog();
        }

        private void btn_ex10_Click(object sender, EventArgs e)
        {
            FormEx010 formEx10 = new FormEx010();
            formEx10.ShowDialog();
        }

        private void btn_ex11_Click(object sender, EventArgs e)
        {
            FormEx011 formEx11 = new FormEx011();
            formEx11.ShowDialog();
        }

        private void btn_ex12_Click(object sender, EventArgs e)
        {
            FormEx012 formEx12 = new FormEx012();
            formEx12.ShowDialog();
        }
    }
}
