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
    public partial class Form10 : Form
    {
        public void atualizarDataGrid()
        {
            this.diretor_TurmaTableAdapter.Fill(this.database1DataSet.Diretor_Turma);
            this.diretor_TurmaDataGridView.Refresh();
        }
        
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Diretor_Turma' table. You can move, or remove it, as needed.
            this.diretor_TurmaTableAdapter.Fill(this.database1DataSet.Diretor_Turma);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
            this.Close();
        }

        

        private void diretor_TurmaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diretor_TurmaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            atualizarDataGrid();
        }


        

        

       

       
    }
}
