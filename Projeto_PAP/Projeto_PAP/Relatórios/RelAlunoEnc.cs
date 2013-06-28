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

        private void RelAlunoEnc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Enc_Educação' table. You can move, or remove it, as needed.
            this.Enc_EducaçãoTableAdapter.FillEncEducação(this.Database1DataSet.Enc_Educação);

            this.reportViewer1.RefreshReport();
        }
    }
}
