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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.professor_TurmaTableAdapter.FillByPesDiretor_Turma(this.escolaDataSet.Professor_Turma, this.textBox1.Text);
        }
    }
}
