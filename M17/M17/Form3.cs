using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet.Encarregado_Educação' table. You can move, or remove it, as needed.
            this.encarregado_EducaçãoTableAdapter.FillEnc_Ed(this.baseDadosDataSet.Encarregado_Educação);

        }
    }
}
