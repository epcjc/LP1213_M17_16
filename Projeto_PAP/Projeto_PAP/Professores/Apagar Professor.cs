﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class Apagar_Professor : Form
    {
        public Apagar_Professor()
        {
            InitializeComponent();
        }

        

        private void Apagar_Professor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escolaDataSet.Professores);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.professoresTableAdapter.DeleteProfessor(Convert.ToInt16(this.comboBox1.SelectedValue));
                MessageBox.Show("Eliminado com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
