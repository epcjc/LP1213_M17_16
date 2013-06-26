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

        private void RelatAlunoTurma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.FillAlunoTurma(this.Database1DataSet.DataTable2);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
