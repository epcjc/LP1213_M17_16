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
    public partial class frmOcorrenciasAbertas : Form
    {
        public frmOcorrenciasAbertas()
        {
            InitializeComponent();
        }

        private void ocorrenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ocorrenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void frmOcorrenciasAbertas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.FillByAbertas(this.database1DataSet1.Ocorrencia);

        }

        private void ocorrenciaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
