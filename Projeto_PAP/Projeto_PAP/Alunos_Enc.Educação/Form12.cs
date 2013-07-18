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
    public partial class Form12 : Form
    {
        public void atualizarDataGrid()
        {
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);
            this.alunosDataGridView.Refresh();
        }
        
        
        public Form12()
        {
            InitializeComponent();
        }

       
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apagar_Aluno frm = new Apagar_Aluno();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pesquisa_Aluno frm = new Pesquisa_Aluno();
            frm.ShowDialog();
            atualizarDataGrid();
        }

    }
}
