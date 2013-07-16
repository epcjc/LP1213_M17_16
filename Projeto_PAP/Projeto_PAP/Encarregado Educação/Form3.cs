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
    public partial class Form3 : Form
    {
        public void atualizarDataGrid()
        {
            this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            this.encarregado_EducacaoDataGridView.Refresh();

        }
        
        
        
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            
           
            

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apagar_EncEducação frm = new Apagar_EncEducação();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pesquisa_EncEduc frm = new Pesquisa_EncEduc();
            frm.ShowDialog();
            atualizarDataGrid();
        }

        

        

  

    }
}
