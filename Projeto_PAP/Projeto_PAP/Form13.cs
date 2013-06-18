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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.FillAlunoTurma(this.database1DataSet.DataTable2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
