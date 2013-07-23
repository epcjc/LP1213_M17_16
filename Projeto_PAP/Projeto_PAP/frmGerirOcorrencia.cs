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

        public Boolean fechouOcorrencia;

        public frmGerirOcorrencia()
        {
            InitializeComponent();
        }

        private void frmGerirOcorrencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.Fill(this.database1DataSet1.Ocorrencia);
            
            
            // TODO: This line of code loads data into the 'database1DataSet1.OcorrenciaTestemunhas' table. You can move, or remove it, as needed.
            this.ocorrenciaTestemunhasTableAdapter.FillByIdOcorrencia(this.database1DataSet1.OcorrenciaTestemunhas, Id_ocorrencia);

            // TODO: This line of code loads data into the 'database1DataSet1.AlunosOcorrencia' table. You can move, or remove it, as needed.
            this.alunosOcorrenciaTableAdapter.FillByIdOcorrencia(this.database1DataSet1.AlunosOcorrencia, Id_ocorrencia);

            if (database1DataSet1.OcorrenciaTestemunhas.Rows.Count == 0)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
            }
            else {
                this.button2.Enabled = true;
                this.button3.Enabled = true;
                }

            this.comboBox1.SelectedIndex = 0;

            fechouOcorrencia = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerAuto frm = new frmVerAuto();

            DataRowView drv = (DataRowView) this.listBox1.SelectedItem;
            frm.Id_ocorrenciaTestemunha = Convert.ToInt16(drv[0]);
            frm.mostraAlterar = true;
           
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovoAuto frm = new frmNovoAuto();
            frm.Id_ocorrencia = Id_ocorrencia;

            frm.ShowDialog();

            this.ocorrenciaTestemunhasTableAdapter.FillByIdOcorrencia(this.database1DataSet1.OcorrenciaTestemunhas, Id_ocorrencia);

            if (database1DataSet1.OcorrenciaTestemunhas.Rows.Count == 0)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
            }
            else
            {
                this.button2.Enabled = true;
                this.button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.listBox1.SelectedItem;
            this.ocorrenciaTestemunhasTableAdapter.EliminarTestemunho(Convert.ToInt16(drv[0]));

            this.ocorrenciaTestemunhasTableAdapter.FillByIdOcorrencia(this.database1DataSet1.OcorrenciaTestemunhas, Id_ocorrencia);

            if (database1DataSet1.OcorrenciaTestemunhas.Rows.Count == 0)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
            }
            else
            {
                this.button2.Enabled = true;
                this.button3.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {
                if (this.textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Medida não pode ser vazia");
                    return;
                }

                if (database1DataSet1.OcorrenciaTestemunhas.Rows.Count == 0) {
                     MessageBox.Show("Não existem autos!");
                    return;
                }

                this.ocorrenciaTableAdapter.AtualizarMedida(this.comboBox1.SelectedItem.ToString(),
                    this.textBox1.Text, Id_ocorrencia);
                MessageBox.Show("Ocorrência fechada");

                fechouOcorrencia = true;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


           

        }
    }
}
