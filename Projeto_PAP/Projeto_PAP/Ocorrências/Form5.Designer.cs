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
            System.Windows.Forms.Label testemunhasLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label resultado_FinalLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label alunoLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label encarregado_EducacaoLabel;
            System.Windows.Forms.Label diretor_TurmaLabel;
            this.label10 = new System.Windows.Forms.Label();
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.OcorrenciaTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.alunoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.AlunoTableAdapter();
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.enc_EducaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.enc_EducaçãoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Enc_EducaçãoTableAdapter();
            this.dataTable3TableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.DataTable3TableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            testemunhasLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            resultado_FinalLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            alunoLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            encarregado_EducacaoLabel = new System.Windows.Forms.Label();
            diretor_TurmaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enc_EducaçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testemunhasLabel
            // 
            testemunhasLabel.AutoSize = true;
            testemunhasLabel.Location = new System.Drawing.Point(312, 20);
            testemunhasLabel.Name = "testemunhasLabel";
            testemunhasLabel.Size = new System.Drawing.Size(74, 13);
            testemunhasLabel.TabIndex = 29;
            testemunhasLabel.Text = "Testemunhas:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(610, 20);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 35;
            dataLabel.Text = "Data:";
            // 
            // resultado_FinalLabel
            // 
            resultado_FinalLabel.AutoSize = true;
            resultado_FinalLabel.Location = new System.Drawing.Point(601, 69);
            resultado_FinalLabel.Name = "resultado_FinalLabel";
            resultado_FinalLabel.Size = new System.Drawing.Size(83, 13);
            resultado_FinalLabel.TabIndex = 37;
            resultado_FinalLabel.Text = "Resultado Final:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(22, 94);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 27;
            observacoesLabel.Text = "Observacoes:";
            // 
            // alunoLabel
            // 
            alunoLabel.AutoSize = true;
            alunoLabel.Location = new System.Drawing.Point(22, 15);
            alunoLabel.Name = "alunoLabel";
            alunoLabel.Size = new System.Drawing.Size(37, 13);
            alunoLabel.TabIndex = 41;
            alunoLabel.Text = "Aluno:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(22, 51);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(54, 13);
            professorLabel.TabIndex = 44;
            professorLabel.Text = "Professor:";
            // 
            // encarregado_EducacaoLabel
            // 
            encarregado_EducacaoLabel.AutoSize = true;
            encarregado_EducacaoLabel.Location = new System.Drawing.Point(310, 80);
            encarregado_EducacaoLabel.Name = "encarregado_EducacaoLabel";
            encarregado_EducacaoLabel.Size = new System.Drawing.Size(84, 13);
            encarregado_EducacaoLabel.TabIndex = 47;
            encarregado_EducacaoLabel.Text = "Enc. Educação:";
            // 
            // diretor_TurmaLabel
            // 
            diretor_TurmaLabel.AutoSize = true;
            diretor_TurmaLabel.Location = new System.Drawing.Point(310, 121);
            diretor_TurmaLabel.Name = "diretor_TurmaLabel";
            diretor_TurmaLabel.Size = new System.Drawing.Size(74, 13);
            diretor_TurmaLabel.TabIndex = 50;
            diretor_TurmaLabel.Text = "Diretor Turma:";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(871, 45);
            this.label10.TabIndex = 19;
            this.label10.Text = "Escola Profissional Centro Juvenil de Campanhã";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataMember = "Ocorrencia";
            this.ocorrenciaBindingSource.DataSource = this.database1DataSet;
            // 
            // ocorrenciaTableAdapter
            // 
            this.ocorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Encarregado_EducacaoTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = this.ocorrenciaTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(702, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 39;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.alunoBindingSource;
            this.comboBox1.DisplayMember = "Aluno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.ValueMember = "ID_Aluno";
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.professoresBindingSource;
            this.comboBox2.DisplayMember = "Professor";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.ValueMember = "ID_Professor";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.enc_EducaçãoBindingSource;
            this.comboBox3.DisplayMember = "Encarregado_Educacao";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(412, 77);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 48;
            this.comboBox3.ValueMember = "ID_Aluno";
            // 
            // enc_EducaçãoBindingSource
            // 
            this.enc_EducaçãoBindingSource.DataMember = "Enc_Educação";
            this.enc_EducaçãoBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.dataTable3BindingSource;
            this.comboBox4.DisplayMember = "Diretor_Turma";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(412, 118);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(150, 21);
            this.comboBox4.TabIndex = 51;
            this.comboBox4.ValueMember = "ID_Aluno";
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 91);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 48);
            this.textBox2.TabIndex = 54;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(412, 15);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 47);
            this.textBox3.TabIndex = 55;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(702, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 56;
            // 
            // enc_EducaçãoTableAdapter
            // 
            this.enc_EducaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
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
            this.splitContainer1.Size = new System.Drawing.Size(871, 253);
            this.splitContainer1.SplitterDistance = 45;
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
            this.splitContainer2.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(testemunhasLabel);
            this.splitContainer2.Panel1.Controls.Add(resultado_FinalLabel);
            this.splitContainer2.Panel1.Controls.Add(dataLabel);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(observacoesLabel);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox4);
            this.splitContainer2.Panel1.Controls.Add(alunoLabel);
            this.splitContainer2.Panel1.Controls.Add(diretor_TurmaLabel);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer2.Panel1.Controls.Add(professorLabel);
            this.splitContainer2.Panel1.Controls.Add(encarregado_EducacaoLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(871, 204);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(871, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 28);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 253);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form5";
            this.Text = "Inserir Ocorrência";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enc_EducaçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private Database1DataSetTableAdapters.OcorrenciaTableAdapter ocorrenciaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private Database1DataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource enc_EducaçãoBindingSource;
        private Database1DataSetTableAdapters.Enc_EducaçãoTableAdapter enc_EducaçãoTableAdapter;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private Database1DataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}