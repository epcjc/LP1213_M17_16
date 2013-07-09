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
    public partial class RelOcorrencias : Form
    {
        public RelOcorrencias()
        {
            InitializeComponent();
        }

        private void RelOcorrencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Aluno_Ocorrencia' table. You can move, or remove it, as needed.
            this.Aluno_OcorrenciaTableAdapter.FillOcorrencia(this.Database1DataSet.Aluno_Ocorrencia);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
