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
    public partial class Form4 : Form
    {
        public void atualizarDataGrid()
        {
            //this.faltasTableAdapter.FillOcorrência(this.database1DataSet.Faltas);
            //this.faltasDataGridView.Refresh();

        }
        
        
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.escolaDataSet.DataTable1);
            
            
         }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Apagar_Ocorrência frm = new Apagar_Ocorrência();
            frm.ShowDialog();
            atualizarDataGrid();
            
        }


        

       

       
       
    }
}
