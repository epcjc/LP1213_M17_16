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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.OcorrenciaTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager();
            this.alunoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.AlunoTableAdapter();
            this.diretor_TurmaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Diretor_TurmaTableAdapter();
            this.encarregado_EducacaoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Encarregado_EducacaoTableAdapter();
            this.professoresTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.ProfessoresTableAdapter();
            this.resultado_FinalTextBox = new System.Windows.Forms.TextBox();
            this.testemunhasTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.encarregado_EducacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.diretor_TurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.encarregado_EducacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diretor_TurmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testemunhasLabel
            // 
            testemunhasLabel.AutoSize = true;
            testemunhasLabel.Location = new System.Drawing.Point(18, 228);
            testemunhasLabel.Name = "testemunhasLabel";
            testemunhasLabel.Size = new System.Drawing.Size(74, 13);
            testemunhasLabel.TabIndex = 29;
            testemunhasLabel.Text = "Testemunhas:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(313, 176);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 35;
            dataLabel.Text = "Data:";
            // 
            // resultado_FinalLabel
            // 
            resultado_FinalLabel.AutoSize = true;
            resultado_FinalLabel.Location = new System.Drawing.Point(304, 226);
            resultado_FinalLabel.Name = "resultado_FinalLabel";
            resultado_FinalLabel.Size = new System.Drawing.Size(83, 13);
            resultado_FinalLabel.TabIndex = 37;
            resultado_FinalLabel.Text = "Resultado Final:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(18, 161);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(73, 13);
            observacoesLabel.TabIndex = 27;
            observacoesLabel.Text = "Observacoes:";
            // 
            // alunoLabel
            // 
            alunoLabel.AutoSize = true;
            alunoLabel.Location = new System.Drawing.Point(18, 89);
            alunoLabel.Name = "alunoLabel";
            alunoLabel.Size = new System.Drawing.Size(37, 13);
            alunoLabel.TabIndex = 41;
            alunoLabel.Text = "Aluno:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(18, 123);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(54, 13);
            professorLabel.TabIndex = 44;
            professorLabel.Text = "Professor:";
            // 
            // encarregado_EducacaoLabel
            // 
            encarregado_EducacaoLabel.AutoSize = true;
            encarregado_EducacaoLabel.Location = new System.Drawing.Point(313, 89);
            encarregado_EducacaoLabel.Name = "encarregado_EducacaoLabel";
            encarregado_EducacaoLabel.Size = new System.Drawing.Size(84, 13);
            encarregado_EducacaoLabel.TabIndex = 47;
            encarregado_EducacaoLabel.Text = "Enc. Educação:";
            // 
            // diretor_TurmaLabel
            // 
            diretor_TurmaLabel.AutoSize = true;
            diretor_TurmaLabel.Location = new System.Drawing.Point(313, 134);
            diretor_TurmaLabel.Name = "diretor_TurmaLabel";
            diretor_TurmaLabel.Size = new System.Drawing.Size(74, 13);
            diretor_TurmaLabel.TabIndex = 50;
            diretor_TurmaLabel.Text = "Diretor Turma:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(229, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ocorrências";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Escola Profissional Centro Juvenil de Campanhã";
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
            this.tableAdapterManager.Diretor_TurmaTableAdapter = this.diretor_TurmaTableAdapter;
            this.tableAdapterManager.Encarregado_EducacaoTableAdapter = this.encarregado_EducacaoTableAdapter;
            this.tableAdapterManager.OcorrenciaTableAdapter = this.ocorrenciaTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // diretor_TurmaTableAdapter
            // 
            this.diretor_TurmaTableAdapter.ClearBeforeFill = true;
            // 
            // encarregado_EducacaoTableAdapter
            // 
            this.encarregado_EducacaoTableAdapter.ClearBeforeFill = true;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // resultado_FinalTextBox
            // 
            this.resultado_FinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Resultado_Final", true));
            this.resultado_FinalTextBox.Location = new System.Drawing.Point(425, 223);
            this.resultado_FinalTextBox.Name = "resultado_FinalTextBox";
            this.resultado_FinalTextBox.Size = new System.Drawing.Size(150, 20);
            this.resultado_FinalTextBox.TabIndex = 38;
            // 
            // testemunhasTextBox
            // 
            this.testemunhasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Testemunhas", true));
            this.testemunhasTextBox.Location = new System.Drawing.Point(128, 226);
            this.testemunhasTextBox.Multiline = true;
            this.testemunhasTextBox.Name = "testemunhasTextBox";
            this.testemunhasTextBox.Size = new System.Drawing.Size(150, 41);
            this.testemunhasTextBox.TabIndex = 30;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(128, 161);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(150, 48);
            this.observacoesTextBox.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 176);
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
            this.comboBox1.Location = new System.Drawing.Point(128, 86);
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
            this.comboBox2.Location = new System.Drawing.Point(128, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.ValueMember = "ID_Professor";
            // 
            // encarregado_EducacaoBindingSource
            // 
            this.encarregado_EducacaoBindingSource.DataMember = "Encarregado_Educacao";
            this.encarregado_EducacaoBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.encarregado_EducacaoBindingSource;
            this.comboBox3.DisplayMember = "Encarregado_Educacao";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(425, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 48;
            this.comboBox3.ValueMember = "ID_EE";
            // 
            // diretor_TurmaBindingSource
            // 
            this.diretor_TurmaBindingSource.DataMember = "Diretor_Turma";
            this.diretor_TurmaBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.diretor_TurmaBindingSource;
            this.comboBox4.DisplayMember = "Diretor_Turma";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(425, 131);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(150, 21);
            this.comboBox4.TabIndex = 51;
            this.comboBox4.ValueMember = "ID_Diretor_Turma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(500, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(diretor_TurmaLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(encarregado_EducacaoLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(professorLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(alunoLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(testemunhasLabel);
            this.Controls.Add(this.testemunhasTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(resultado_FinalLabel);
            this.Controls.Add(this.resultado_FinalTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encarregado_EducacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diretor_TurmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private Database1DataSetTableAdapters.OcorrenciaTableAdapter ocorrenciaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox resultado_FinalTextBox;
        private System.Windows.Forms.TextBox testemunhasTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private Database1DataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private Database1DataSetTableAdapters.Encarregado_EducacaoTableAdapter encarregado_EducacaoTableAdapter;
        private System.Windows.Forms.BindingSource encarregado_EducacaoBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private Database1DataSetTableAdapters.Diretor_TurmaTableAdapter diretor_TurmaTableAdapter;
        private System.Windows.Forms.BindingSource diretor_TurmaBindingSource;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}