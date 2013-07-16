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
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
            this.alunoDataGridView.Refresh();
        }
        
        
        public Form12()
        {
            InitializeComponent();
        }

       
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
            atualizarDataGrid();
            
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

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pesquisa_EncEduc frm = new Pesquisa_EncEduc();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Apagar_EncEducação frm = new Apagar_EncEducação();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        
    }
}
