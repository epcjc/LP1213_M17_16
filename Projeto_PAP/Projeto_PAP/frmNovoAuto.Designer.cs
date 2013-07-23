namespace Projeto_PAP
{
    partial class frmNovoAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.database1DataSet1 = new Projeto_PAP.Database1DataSet1();
            this.ocorrenciaTestemunhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTestemunhasTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.AlunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.alunoBindingSource;
            this.comboBox1.DisplayMember = "Aluno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Testemunha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 209);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Testemunho:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Medida_DisciplinarTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTestemunhasTableAdapter = this.ocorrenciaTestemunhasTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.database1DataSet1;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // frmNovoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNovoAuto";
            this.Text = "frmNovoAuto";
            this.Load += new System.EventHandler(this.frmNovoAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ocorrenciaTestemunhasBindingSource;
        private Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter ocorrenciaTestemunhasTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSet1TableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource alunoBindingSource;
    }
}