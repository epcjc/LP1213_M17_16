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
    public partial class frmOcorrenciaPorAluno : Form
    {
        public frmOcorrenciaPorAluno()
        {
            InitializeComponent();
        }

        private void frmOcorrenciaPorAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.Fill(this.database1DataSet1.Ocorrencia);
            // TODO: This line of code loads data into the 'database1DataSet1.OcorrenciaTestemunhas' table. You can move, or remove it, as needed.
            this.ocorrenciaTestemunhasTableAdapter.Fill(this.database1DataSet1.OcorrenciaTestemunhas);
            // TODO: This line of code loads data into the 'database1DataSet1.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet1.Aluno);
            // TODO: This line of code loads data into the 'database1DataSet1.AlunosOcorrencia' table. You can move, or remove it, as needed.
            this.alunosOcorrenciaTableAdapter.Fill(this.database1DataSet1.AlunosOcorrencia);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.Rows[e.RowIndex];
            frmVerDetalhesOcorrencia frm = new frmVerDetalhesOcorrencia();
            frm.Id_ocorrencia = Convert.ToInt16(dgvr.Cells[0].Value);
            frm.ShowDialog();

           

            frm.Dispose();
        }


    }
}
