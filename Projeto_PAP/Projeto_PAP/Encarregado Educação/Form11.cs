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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        public void atualizarDataGrid()
        {
            //this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            //this.aluno_EncDataGridView.Refresh();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            //this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
           
        }

        private void aluno_EncBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aluno_EncBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            atualizarDataGrid();
        }

        
        

        

      

        

        
    }
}
