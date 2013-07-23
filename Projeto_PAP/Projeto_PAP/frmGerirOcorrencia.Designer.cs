namespace Projeto_PAP
{
    partial class frmGerirOcorrencia
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
            System.Windows.Forms.Label data_FactosLabel;
            System.Windows.Forms.Label alunoLabel;
            System.Windows.Forms.Label encarregado_EducacaoLabel;
            System.Windows.Forms.Label contactoEELabel;
            this.database1DataSet1 = new Projeto_PAP.Database1DataSet1();
            this.alunosOcorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosOcorrenciaTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.AlunosOcorrenciaTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager();
            this.data_FactosDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.alunoTextBox = new System.Windows.Forms.TextBox();
            this.encarregado_EducacaoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactoEETextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ocorrenciaTestemunhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ocorrenciaTestemunhasTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            data_FactosLabel = new System.Windows.Forms.Label();
            alunoLabel = new System.Windows.Forms.Label();
            encarregado_EducacaoLabel = new System.Windows.Forms.Label();
            contactoEELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosOcorrenciaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_FactosLabel
            // 
            data_FactosLabel.AutoSize = true;
            data_FactosLabel.Enabled = false;
            data_FactosLabel.Location = new System.Drawing.Point(486, 25);
            data_FactosLabel.Name = "data_FactosLabel";
            data_FactosLabel.Size = new System.Drawing.Size(68, 13);
            data_FactosLabel.TabIndex = 1;
            data_FactosLabel.Text = "Data Factos:";
            // 
            // alunoLabel
            // 
            alunoLabel.AutoSize = true;
            alunoLabel.Location = new System.Drawing.Point(15, 28);
            alunoLabel.Name = "alunoLabel";
            alunoLabel.Size = new System.Drawing.Size(37, 13);
            alunoLabel.TabIndex = 2;
            alunoLabel.Text = "Aluno:";
            // 
            // encarregado_EducacaoLabel
            // 
            encarregado_EducacaoLabel.AutoSize = true;
            encarregado_EducacaoLabel.Location = new System.Drawing.Point(18, 47);
            encarregado_EducacaoLabel.Name = "encarregado_EducacaoLabel";
            encarregado_EducacaoLabel.Size = new System.Drawing.Size(38, 13);
            encarregado_EducacaoLabel.TabIndex = 4;
            encarregado_EducacaoLabel.Text = "Nome:";
            // 
            // contactoEELabel
            // 
            contactoEELabel.AutoSize = true;
            contactoEELabel.Location = new System.Drawing.Point(18, 77);
            contactoEELabel.Name = "contactoEELabel";
            contactoEELabel.Size = new System.Drawing.Size(53, 13);
            contactoEELabel.TabIndex = 5;
            contactoEELabel.Text = "Contacto:";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosOcorrenciaBindingSource
            // 
            this.alunosOcorrenciaBindingSource.DataMember = "AlunosOcorrencia";
            this.alunosOcorrenciaBindingSource.DataSource = this.database1DataSet1;
            // 
            // alunosOcorrenciaTableAdapter
            // 
            this.alunosOcorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Medida_DisciplinarTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTestemunhasTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // data_FactosDateTimePicker
            // 
            this.data_FactosDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosOcorrenciaBindingSource, "Data_Factos", true));
            this.data_FactosDateTimePicker.Enabled = false;
            this.data_FactosDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_FactosDateTimePicker.Location = new System.Drawing.Point(560, 21);
            this.data_FactosDateTimePicker.Name = "data_FactosDateTimePicker";
            this.data_FactosDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.data_FactosDateTimePicker.TabIndex = 2;
            // 
            // alunoTextBox
            // 
            this.alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosOcorrenciaBindingSource, "Aluno", true));
            this.alunoTextBox.Location = new System.Drawing.Point(58, 25);
            this.alunoTextBox.Name = "alunoTextBox";
            this.alunoTextBox.Size = new System.Drawing.Size(282, 20);
            this.alunoTextBox.TabIndex = 3;
            // 
            // encarregado_EducacaoTextBox
            // 
            this.encarregado_EducacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosOcorrenciaBindingSource, "Encarregado_Educacao", true));
            this.encarregado_EducacaoTextBox.Location = new System.Drawing.Point(82, 44);
            this.encarregado_EducacaoTextBox.Name = "encarregado_EducacaoTextBox";
            this.encarregado_EducacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.encarregado_EducacaoTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(contactoEELabel);
            this.groupBox1.Controls.Add(this.contactoEETextBox);
            this.groupBox1.Controls.Add(encarregado_EducacaoLabel);
            this.groupBox1.Controls.Add(this.encarregado_EducacaoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encarregado Educação";
            // 
            // contactoEETextBox
            // 
            this.contactoEETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosOcorrenciaBindingSource, "contactoEE", true));
            this.contactoEETextBox.Location = new System.Drawing.Point(82, 74);
            this.contactoEETextBox.Name = "contactoEETextBox";
            this.contactoEETextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoEETextBox.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.ocorrenciaTestemunhasBindingSource;
            this.listBox1.DisplayMember = "nome_testemunha";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(410, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 147);
            this.listBox1.TabIndex = 7;
            this.listBox1.ValueMember = "id_testemunha";
            // 
            // ocorrenciaTestemunhasBindingSource
            // 
            this.ocorrenciaTestemunhasBindingSource.DataMember = "OcorrenciaTestemunhas";
            this.ocorrenciaTestemunhasBindingSource.DataSource = this.database1DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inserir Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ocorrenciaTestemunhasTableAdapter
            // 
            this.ocorrenciaTestemunhasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(18, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disciplinar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Corretiva",
            "Sancionatória"});
            this.comboBox1.Location = new System.Drawing.Point(114, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Medida Disciplinar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 131);
            this.textBox1.TabIndex = 12;
            // 
            // frmGerirOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(alunoLabel);
            this.Controls.Add(this.alunoTextBox);
            this.Controls.Add(data_FactosLabel);
            this.Controls.Add(this.data_FactosDateTimePicker);
            this.Name = "frmGerirOcorrencia";
            this.Text = "frmGerirOcorrencia";
            this.Load += new System.EventHandler(this.frmGerirOcorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosOcorrenciaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource alunosOcorrenciaBindingSource;
        private Database1DataSet1TableAdapters.AlunosOcorrenciaTableAdapter alunosOcorrenciaTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker data_FactosDateTimePicker;
        private System.Windows.Forms.TextBox alunoTextBox;
        private System.Windows.Forms.TextBox encarregado_EducacaoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contactoEETextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource ocorrenciaTestemunhasBindingSource;
        private Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter ocorrenciaTestemunhasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}