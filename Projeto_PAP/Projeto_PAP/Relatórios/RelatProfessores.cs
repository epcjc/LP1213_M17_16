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
    public partial class RelatAlunoTurma : Form
    {
        public RelatAlunoTurma()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelatAlunoTurma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EscolaDataSet.Professores' table. You can move, or remove it, as needed.
            this.ProfessoresTableAdapter.Fill(this.EscolaDataSet.Professores);
            // TODO: This line of code loads data into the 'Database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.AlunoTableAdapter.Fill(this.Database1DataSet.Aluno);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
