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
    public partial class Pesquisa_DiretorTurma : Form
    {
        public Pesquisa_DiretorTurma()
        {
            InitializeComponent();
        }

        private void Pesquisa_DiretorTurma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Turma_DiretorTurma' table. You can move, or remove it, as needed.
            this.turma_DiretorTurmaTableAdapter.FillDiretorTurma(this.database1DataSet.Turma_DiretorTurma);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.turma_DiretorTurmaTableAdapter.FillByPesDT(this.database1DataSet.Turma_DiretorTurma, this.textBox1.Text);
        }
    }
}
