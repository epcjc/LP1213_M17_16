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
    public partial class Form1 : Form
    {
        public void atualizarDataGrid()
        {
            this.professoresTableAdapter.Fill(this.escolaDataSet.Professores);
            this.professoresDataGridView.Refresh();
        }
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escolaDataSet.Professores);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apagar_Professor frm = new Apagar_Professor();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pesquisar_Professor frm = new Pesquisar_Professor();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);

        }
    }
}
