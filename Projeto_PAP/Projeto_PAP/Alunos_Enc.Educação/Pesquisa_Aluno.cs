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
    public partial class Pesquisa_Aluno : Form
    {
        public Pesquisa_Aluno()
        {
            InitializeComponent();
        }

        private void Pesquisa_Aluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
            

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.alunoTableAdapter.FillByPesAluno(this.database1DataSet.Aluno, this.textBox1.Text);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
