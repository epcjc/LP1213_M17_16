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
    public partial class Apagar_Aluno : Form
    {
        public Apagar_Aluno()
        {
            InitializeComponent();
        }

        

        private void Apagar_Aluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.alunosTableAdapter.DeleteAluno(Convert.ToString(this.comboBox1.SelectedValue));
                
                MessageBox.Show("Eliminado com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
