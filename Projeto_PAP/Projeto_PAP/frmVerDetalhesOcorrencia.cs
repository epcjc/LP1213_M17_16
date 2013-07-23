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
    public partial class frmVerDetalhesOcorrencia : Form
    {
        private int _id_ocorrencia;

        public int Id_ocorrencia
        {
            get;
            set;
        }


        public frmVerDetalhesOcorrencia()
        {
            InitializeComponent();
        }

        private void frmVerDetalhesOcorrencia_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet1.OcorrenciaTestemunhas' table. You can move, or remove it, as needed.
            this.ocorrenciaTestemunhasTableAdapter.FillByIdOcorrencia(this.database1DataSet1.OcorrenciaTestemunhas, Id_ocorrencia);
            // TODO: This line of code loads data into the 'database1DataSet1.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.FillByIdOcorrencia(this.database1DataSet1.Ocorrencia, Id_ocorrencia);
            

            // TODO: This line of code loads data into the 'database1DataSet1.AlunosOcorrencia' table. You can move, or remove it, as needed.
            this.alunosOcorrenciaTableAdapter.FillByIdOcorrencia(this.database1DataSet1.AlunosOcorrencia, Id_ocorrencia);
        }

        private void ocorrenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerAuto frm = new frmVerAuto();

            DataRowView drv = (DataRowView)this.listBox1.SelectedItem;
            frm.Id_ocorrenciaTestemunha = Convert.ToInt16(drv[0]);
            frm.mostraAlterar = false;
            frm.ShowDialog();
        }
    }
}
