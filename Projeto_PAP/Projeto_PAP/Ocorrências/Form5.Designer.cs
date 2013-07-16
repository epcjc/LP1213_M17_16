namespace Projeto_PAP
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label alunoLabel;
            System.Windows.Forms.Label turmaLabel;
            System.Windows.Forms.Label encarregado_EducacaoLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label via_ContactoLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label diretor_TurmaLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label testemunhasLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label resultado_FinalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.turmaDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.faltasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faltasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.FaltasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.turmaDTTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.TurmaDTTableAdapter();
            alunoLabel = new System.Windows.Forms.Label();
            turmaLabel = new System.Windows.Forms.Label();
            encarregado_EducacaoLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            via_ContactoLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            diretor_TurmaLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            testemunhasLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            resultado_FinalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turmaDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faltasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alunoLabel
            // 
            alunoLabel.AutoSize = true;
            alunoLabel.Location = new System.Drawing.Point(28, 15);
            alunoLabel.Name = "alunoLabel";
            alunoLabel.Size = new System.Drawing.Size(34, 13);
            alunoLabel.TabIndex = 2;
            alunoLabel.Text = "Aluno";
            // 
            // turmaLabel
            // 
            turmaLabel.AutoSize = true;
            turmaLabel.Location = new System.Drawing.Point(24, 51);
            turmaLabel.Name = "turmaLabel";
            turmaLabel.Size = new System.Drawing.Size(37, 13);
            turmaLabel.TabIndex = 4;
            turmaLabel.Text = "Turma";
            // 
            // encarregado_EducacaoLabel
            // 
            encarregado_EducacaoLabel.AutoSize = true;
            encarregado_EducacaoLabel.Location = new System.Drawing.Point(12, 78);
            encarregado_EducacaoLabel.Name = "encarregado_EducacaoLabel";
            encarregado_EducacaoLabel.Size = new System.Drawing.Size(68, 26);
            encarregado_EducacaoLabel.TabIndex = 6;
            encarregado_EducacaoLabel.Text = "Encarregado\r\nEducação";
            encarregado_EducacaoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(15, 120);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(56, 13);
            contactoLabel.TabIndex = 8;
            contactoLabel.Text = "Telemóvel";
            // 
            // via_ContactoLabel
            // 
            via_ContactoLabel.AutoSize = true;
            via_ContactoLabel.Location = new System.Drawing.Point(17, 149);
            via_ContactoLabel.Name = "via_ContactoLabel";
            via_ContactoLabel.Size = new System.Drawing.Size(50, 26);
            via_ContactoLabel.TabIndex = 10;
            via_ContactoLabel.Text = "Via \r\nContacto";
            via_ContactoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(291, 16);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(51, 13);
            professorLabel.TabIndex = 12;
            professorLabel.Text = "Professor";
            // 
            // diretor_TurmaLabel
            // 
            diretor_TurmaLabel.AutoSize = true;
            diretor_TurmaLabel.Location = new System.Drawing.Point(281, 56);
            diretor_TurmaLabel.Name = "diretor_TurmaLabel";
            diretor_TurmaLabel.Size = new System.Drawing.Size(71, 13);
            diretor_TurmaLabel.TabIndex = 14;
            diretor_TurmaLabel.Text = "Diretor Turma";
            diretor_TurmaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(282, 97);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(70, 13);
            observacoesLabel.TabIndex = 16;
            observacoesLabel.Text = "Observações";
            // 
            // testemunhasLabel
            // 
            testemunhasLabel.AutoSize = true;
            testemunhasLabel.Location = new System.Drawing.Point(550, 21);
            testemunhasLabel.Name = "testemunhasLabel";
            testemunhasLabel.Size = new System.Drawing.Size(71, 13);
            testemunhasLabel.TabIndex = 18;
            testemunhasLabel.Text = "Testemunhas";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(570, 96);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(30, 13);
            dataLabel.TabIndex = 20;
            dataLabel.Text = "Data";
            // 
            // resultado_FinalLabel
            // 
            resultado_FinalLabel.AutoSize = true;
            resultado_FinalLabel.Location = new System.Drawing.Point(559, 141);
            resultado_FinalLabel.Name = "resultado_FinalLabel";
            resultado_FinalLabel.Size = new System.Drawing.Size(58, 26);
            resultado_FinalLabel.TabIndex = 22;
            resultado_FinalLabel.Text = "Resultado \r\nFinal";
            resultado_FinalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(799, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Escola Profissional Centro Juvenil de Campanhã";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(799, 297);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 57;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox8);
            this.splitContainer2.Panel1.Controls.Add(this.textBox7);
            this.splitContainer2.Panel1.Controls.Add(this.textBox6);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(alunoLabel);
            this.splitContainer2.Panel1.Controls.Add(turmaLabel);
            this.splitContainer2.Panel1.Controls.Add(encarregado_EducacaoLabel);
            this.splitContainer2.Panel1.Controls.Add(contactoLabel);
            this.splitContainer2.Panel1.Controls.Add(via_ContactoLabel);
            this.splitContainer2.Panel1.Controls.Add(professorLabel);
            this.splitContainer2.Panel1.Controls.Add(diretor_TurmaLabel);
            this.splitContainer2.Panel1.Controls.Add(observacoesLabel);
            this.splitContainer2.Panel1.Controls.Add(testemunhasLabel);
            this.splitContainer2.Panel1.Controls.Add(dataLabel);
            this.splitContainer2.Panel1.Controls.Add(resultado_FinalLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(799, 264);
            this.splitContainer2.SplitterDistance = 202;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 37;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.turmaDTBindingSource;
            this.comboBox3.DisplayMember = "Turma";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(85, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 21);
            this.comboBox3.TabIndex = 36;
            this.comboBox3.ValueMember = "ID_Turma";
            // 
            // turmaDTBindingSource
            // 
            this.turmaDTBindingSource.DataMember = "TurmaDT";
            this.turmaDTBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(627, 144);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 20);
            this.textBox8.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(627, 16);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(156, 58);
            this.textBox7.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(363, 94);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 79);
            this.textBox6.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.turmaDTBindingSource;
            this.comboBox2.DisplayMember = "Diretor_Turma";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(363, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.ValueMember = "ID_Turma";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.professoresBindingSource;
            this.comboBox1.DisplayMember = "Professor";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "ID_Professor";
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.database1DataSet;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(96, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 36);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // faltasBindingSource
            // 
            this.faltasBindingSource.DataMember = "Faltas";
            this.faltasBindingSource.DataSource = this.database1DataSet;
            // 
            // faltasTableAdapter
            // 
            this.faltasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Encarregado_EducacaoTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // turmaDTTableAdapter
            // 
            this.turmaDTTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 297);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Inserir Ocorrência";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turmaDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faltasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource faltasBindingSource;
        private Database1DataSetTableAdapters.FaltasTableAdapter faltasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Database1DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource turmaDTBindingSource;
        private Database1DataSetTableAdapters.TurmaDTTableAdapter turmaDTTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
    }
}