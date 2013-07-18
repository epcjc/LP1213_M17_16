using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class Form13 : Form
    {
        public void atualizarDataGrid()
        {
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);
            this.alunosDataGridView.Refresh();
        }
        
        
        
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
            this.Close();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);
            atualizarDataGrid();

        }

        
    }
}
