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
    public partial class RelCursoTurma : Form
    {
        public RelCursoTurma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelCursoTurma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EscolaDataSet.Turma_Curso' table. You can move, or remove it, as needed.
            this.Turma_CursoTableAdapter.Fill(this.EscolaDataSet.Turma_Curso);

            this.reportViewer1.RefreshReport();
        }
    }
}
