namespace Projeto_PAP
{
    partial class frmVerDetalhesOcorrencia
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
            System.Windows.Forms.Label contactoEELabel;
            System.Windows.Forms.Label encarregado_EducacaoLabel;
            System.Windows.Forms.Label alunoLabel;
            System.Windows.Forms.Label data_FactosLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.database1DataSet1 = new Projeto_PAP.Database1DataSet1();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager();
            this.ocorrenciaTestemunhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTestemunhasTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter();
            this.alunosOcorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosOcorrenciaTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.AlunosOcorrenciaTableAdapter();
            this.alunoTextBox = new System.Windows.Forms.TextBox();
            this.encarregado_EducacaoTextBox = new System.Windows.Forms.TextBox();
            this.contactoEETextBox = new System.Windows.Forms.TextBox();
            this.data_FactosDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.detalhes_MedidaTextBox = new System.Windows.Forms.TextBox();
            this.medida_DisciplinarTextBox = new System.Windows.Forms.TextBox();
            contactoEELabel = new System.Windows.Forms.Label();
            encarregado_EducacaoLabel = new System.Windows.Forms.Label();
            alunoLabel = new System.Windows.Forms.Label();
            data_FactosLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosOcorrenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contactoEETextBox);
            this.groupBox1.Controls.Add(this.encarregado_EducacaoTextBox);
            this.groupBox1.Controls.Add(contactoEELabel);
            this.groupBox1.Controls.Add(encarregado_EducacaoLabel);
            this.groupBox1.Location = new System.Drawing.Point(26, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encarregado Educação";
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
            // encarregado_EducacaoLabel
            // 
            encarregado_EducacaoLabel.AutoSize = true;
            encarregado_EducacaoLabel.Location = new System.Drawing.Point(18, 47);
            encarregado_EducacaoLabel.Name = "encarregado_EducacaoLabel";
            encarregado_EducacaoLabel.Size = new System.Drawing.Size(38, 13);
            encarregado_EducacaoLabel.TabIndex = 4;
            encarregado_EducacaoLabel.Text = "Nome:";
            // 
            // alunoLabel
            // 
            alunoLabel.AutoSize = true;
            alunoLabel.Location = new System.Drawing.Point(23, 26);
            alunoLabel.Name = "alunoLabel";
            alunoLabel.Size = new System.Drawing.Size(37, 13);
            alunoLabel.TabIndex = 7;
            alunoLabel.Text = "Aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Autos:";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.ocorrenciaTestemunhasBindingSource;
            this.listBox1.DisplayMember = "nome_testemunha";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(534, 269);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 147);
            this.listBox1.TabIndex = 12;
            this.listBox1.ValueMember = "id_testemunha";
            // 
            // data_FactosLabel
            // 
            data_FactosLabel.AutoSize = true;
            data_FactosLabel.Enabled = false;
            data_FactosLabel.Location = new System.Drawing.Point(551, 23);
            data_FactosLabel.Name = "data_FactosLabel";
            data_FactosLabel.Size = new System.Drawing.Size(68, 13);
            data_FactosLabel.TabIndex = 10;
            data_FactosLabel.Text = "Data Factos:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.medida_DisciplinarTextBox);
            this.groupBox2.Controls.Add(this.detalhes_MedidaTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 242);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disciplinar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(750, 520);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Fechar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo Medida Disciplinar:";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataMember = "Ocorrencia";
            this.ocorrenciaBindingSource.DataSource = this.database1DataSet1;
            // 
            // ocorrenciaTableAdapter
            // 
            this.ocorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Medida_DisciplinarTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = this.ocorrenciaTableAdapter;
            this.tableAdapterManager.OcorrenciaTestemunhasTableAdapter = this.ocorrenciaTestemunhasTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ocorrenciaTestemunhasBindingSource
            // 
            this.ocorrenciaTestemunhasBindingSource.DataMember = "OcorrenciaTestemunhas";
            this.ocorrenciaTestemunhasBindingSource.DataSource = this.database1DataSet1;
            // 
            // ocorrenciaTestemunhasTableAdapter
            // 
            this.ocorrenciaTestemunhasTableAdapter.ClearBeforeFill = true;
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
            // alunoTextBox
            // 
            this.alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosOcorrenciaBindingSource, "Aluno", true));
            this.alunoTextBox.Location = new System.Drawing.Point(66, 23);
            this.alunoTextBox.Name = "alunoTextBox";
            this.alunoTextBox.Size = new System.Drawing.Size(179, 20);
            this.alunoTextBox.TabIndex = 16;
            // 
            // encarregado_EducacaoTextBox
            // 
            this.encarregado_EducacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosOcorrenciaBindingSource, "Encarregado_Educacao", true));
            this.encarregado_EducacaoTextBox.Location = new System.Drawing.Point(82, 40);
            this.encarregado_EducacaoTextBox.Name = "encarregado_EducacaoTextBox";
            this.encarregado_EducacaoTextBox.Size = new System.Drawing.Size(137, 20);
            this.encarregado_EducacaoTextBox.TabIndex = 7;
            // 
            // contactoEETextBox
            // 
            this.contactoEETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosOcorrenciaBindingSource, "contactoEE", true));
            this.contactoEETextBox.Location = new System.Drawing.Point(82, 74);
            this.contactoEETextBox.Name = "contactoEETextBox";
            this.contactoEETextBox.Size = new System.Drawing.Size(137, 20);
            this.contactoEETextBox.TabIndex = 8;
            // 
            // data_FactosDateTimePicker
            // 
            this.data_FactosDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ocorrenciaBindingSource, "Data_Factos", true));
            this.data_FactosDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_FactosDateTimePicker.Location = new System.Drawing.Point(625, 19);
            this.data_FactosDateTimePicker.Name = "data_FactosDateTimePicker";
            this.data_FactosDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_FactosDateTimePicker.TabIndex = 17;
            // 
            // detalhes_MedidaTextBox
            // 
            this.detalhes_MedidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Detalhes_Medida", true));
            this.detalhes_MedidaTextBox.Location = new System.Drawing.Point(21, 96);
            this.detalhes_MedidaTextBox.Multiline = true;
            this.detalhes_MedidaTextBox.Name = "detalhes_MedidaTextBox";
            this.detalhes_MedidaTextBox.Size = new System.Drawing.Size(372, 126);
            this.detalhes_MedidaTextBox.TabIndex = 14;
            // 
            // medida_DisciplinarTextBox
            // 
            this.medida_DisciplinarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Medida_Disciplinar", true));
            this.medida_DisciplinarTextBox.Location = new System.Drawing.Point(154, 46);
            this.medida_DisciplinarTextBox.Name = "medida_DisciplinarTextBox";
            this.medida_DisciplinarTextBox.Size = new System.Drawing.Size(239, 20);
            this.medida_DisciplinarTextBox.TabIndex = 15;
            // 
            // frmVerDetalhesOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 555);
            this.Controls.Add(this.data_FactosDateTimePicker);
            this.Controls.Add(this.alunoTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(data_FactosLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(alunoLabel);
            this.Name = "frmVerDetalhesOcorrencia";
            this.Text = "frmVerDetalhesOcorrencia";
            this.Load += new System.EventHandler(this.frmVerDetalhesOcorrencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosOcorrenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private Database1DataSet1TableAdapters.OcorrenciaTableAdapter ocorrenciaTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter ocorrenciaTestemunhasTableAdapter;
        private System.Windows.Forms.BindingSource ocorrenciaTestemunhasBindingSource;
        private System.Windows.Forms.BindingSource alunosOcorrenciaBindingSource;
        private Database1DataSet1TableAdapters.AlunosOcorrenciaTableAdapter alunosOcorrenciaTableAdapter;
        private System.Windows.Forms.TextBox contactoEETextBox;
        private System.Windows.Forms.TextBox encarregado_EducacaoTextBox;
        private System.Windows.Forms.TextBox alunoTextBox;
        private System.Windows.Forms.DateTimePicker data_FactosDateTimePicker;
        private System.Windows.Forms.TextBox detalhes_MedidaTextBox;
        private System.Windows.Forms.TextBox medida_DisciplinarTextBox;
    }
}