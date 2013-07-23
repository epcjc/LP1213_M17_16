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
    public partial class frmNovoAuto : Form
    {

        private int _id_ocorrencia;

        public int Id_ocorrencia
        {
            get;
            set;
        }

        public frmNovoAuto()
        {
            InitializeComponent();
        }

        private void frmNovoAuto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet1.Aluno);
            // TODO: This line of code loads data into the 'database1DataSet1.OcorrenciaTestemunhas' table. You can move, or remove it, as needed.
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DataRowView drv = (DataRowView)this.comboBox1.SelectedItem;


                this.ocorrenciaTestemunhasTableAdapter.Insert(Id_ocorrencia,
                Convert.ToInt16(drv[0]),
                drv[1].ToString(),
                this.textBox1.Text, this.dateTimePicker1.Value);
                this.Close();
            }
            catch { 
            }
            
           
        }

        private void ocorrenciaTestemunhasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
