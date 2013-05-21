using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet.Aluno_Ocorrência' table. You can move, or remove it, as needed.
            //this.aluno_OcorrênciaTableAdapter.FillOcorrência(this.baseDadosDataSet.Aluno_Ocorrência);
            // TODO: This line of code loads data into the 'baseDadosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.baseDadosDataSet.Alunos);
          
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.aluno_OcorrênciaTableAdapter.FillOcorrência(this.baseDadosDataSet.Aluno_Ocorrência);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
