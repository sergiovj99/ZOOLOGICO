﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOOLOGICO
{
    public partial class LisAves : Form
    {
        public LisAves()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Localizacion localizacion = new Localizacion();
            localizacion.Show();
        }
    }
}
