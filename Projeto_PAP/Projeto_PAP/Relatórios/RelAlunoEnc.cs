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
    public partial class RelAlunoEnc : Form
    {
        public RelAlunoEnc()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RelAlunoEnc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EscolaDataSet.Alunos' table. You can move, or remove it, as needed.
            this.AlunosTableAdapter.Fill(this.EscolaDataSet.Alunos);
            // TODO: This line of code loads data into the 'Database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            this.Aluno_EncTableAdapter.FillAlunoEncEduc(this.Database1DataSet.Aluno_Enc);

            this.reportViewer1.RefreshReport();
          
        }
    }
}
