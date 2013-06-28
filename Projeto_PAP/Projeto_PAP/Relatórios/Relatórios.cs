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
    public partial class Relatórios : Form
    {
        public Relatórios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatAlunoTurma frm = new RelatAlunoTurma();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelOcorrencias frm = new RelOcorrencias();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelAlunoEnc frm = new RelAlunoEnc();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
