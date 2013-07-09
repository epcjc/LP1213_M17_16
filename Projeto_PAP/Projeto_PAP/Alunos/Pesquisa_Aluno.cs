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
            // TODO: This line of code loads data into the 'database1DataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.FillAlunoTurma(this.database1DataSet.DataTable2);

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.FillByPesAluno(this.database1DataSet.DataTable2, this.textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
