﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv_3Etapa
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm1.Show();
        }

        Contratante contrata = new Contratante();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contrata.Show();
        }

        Servico service = new Servico();   
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            service.Show();
        }
    }
}
