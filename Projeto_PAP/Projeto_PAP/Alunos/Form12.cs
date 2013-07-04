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
            this.dataTable2TableAdapter.FillAlunoTurma(this.database1DataSet.DataTable2);
            this.dataTable2DataGridView.Refresh();

        }
        
        
        public Form12()
        {
            InitializeComponent();
        }

       
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.FillAlunoTurma(this.database1DataSet.DataTable2);
           

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
    }
}
