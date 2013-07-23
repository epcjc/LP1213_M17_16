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
    public partial class frmGerirOcorrencia : Form
    {
        private int _id_ocorrencia;

        public int Id_ocorrencia
        {
            get;
            set;
        }

        public frmGerirOcorrencia()
        {
            InitializeComponent();
        }

        private void frmGerirOcorrencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.OcorrenciaTestemunhas' table. You can move, or remove it, as needed.
            this.ocorrenciaTestemunhasTableAdapter.Fill(this.database1DataSet1.OcorrenciaTestemunhas);

            // TODO: This line of code loads data into the 'database1DataSet1.AlunosOcorrencia' table. You can move, or remove it, as needed.
            this.alunosOcorrenciaTableAdapter.FillByIdOcorrencia(this.database1DataSet1.AlunosOcorrencia, Id_ocorrencia);

            if (database1DataSet1.OcorrenciaTestemunhas.Rows.Count == 0)
            {
                this.button2.Visible = false;
            }
            else {
                this.button2.Visible = true;
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerAuto frm = new frmVerAuto();

            DataRowView drv = (DataRowView) this.listBox1.SelectedItem;
            frm.Id_ocorrenciaTestemunha = Convert.ToInt16(drv[0]);
           
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovoAuto frm = new frmNovoAuto();
            frm.Id_ocorrencia = Id_ocorrencia;

            frm.ShowDialog();

            this.ocorrenciaTestemunhasTableAdapter.Fill(this.database1DataSet1.OcorrenciaTestemunhas);

        }
    }
}
