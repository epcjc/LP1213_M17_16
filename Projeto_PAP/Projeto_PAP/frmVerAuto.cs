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
    public partial class frmVerAuto : Form
    {
        private int _id_ocorrenciaTestemunha;

        public int Id_ocorrenciaTestemunha
        {
            get;
            set;
        }

        

        public frmVerAuto()
        {
            InitializeComponent();
        }

        private void ocorrenciaTestemunhasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void frmVerAuto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.OcorrenciaTestemunhas' table. You can move, or remove it, as needed.
            this.ocorrenciaTestemunhasTableAdapter.FillByCod(this.database1DataSet1.OcorrenciaTestemunhas, Id_ocorrenciaTestemunha);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
