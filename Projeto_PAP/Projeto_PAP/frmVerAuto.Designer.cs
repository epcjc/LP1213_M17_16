namespace Projeto_PAP
{
    partial class frmVerAuto
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
            this.label2 = new System.Windows.Forms.Label();
            this.database1DataSet1 = new Projeto_PAP.Database1DataSet1();
            this.ocorrenciaTestemunhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTestemunhasTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager();
            this.nome_testemunhaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.testemunhoTextBox = new System.Windows.Forms.TextBox();
            this.data_testemunhoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Testemunha:";
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
            this.tableAdapterManager.AlunoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Medida_DisciplinarTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTestemunhasTableAdapter = this.ocorrenciaTestemunhasTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nome_testemunhaTextBox
            // 
            this.nome_testemunhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaTestemunhasBindingSource, "nome_testemunha", true));
            this.nome_testemunhaTextBox.Location = new System.Drawing.Point(91, 74);
            this.nome_testemunhaTextBox.Name = "nome_testemunhaTextBox";
            this.nome_testemunhaTextBox.Size = new System.Drawing.Size(120, 20);
            this.nome_testemunhaTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Testemunho:";
            // 
            // testemunhoTextBox
            // 
            this.testemunhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaTestemunhasBindingSource, "testemunho", true));
            this.testemunhoTextBox.Location = new System.Drawing.Point(18, 142);
            this.testemunhoTextBox.Multiline = true;
            this.testemunhoTextBox.Name = "testemunhoTextBox";
            this.testemunhoTextBox.Size = new System.Drawing.Size(400, 206);
            this.testemunhoTextBox.TabIndex = 11;
            // 
            // data_testemunhoDateTimePicker
            // 
            this.data_testemunhoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ocorrenciaTestemunhasBindingSource, "data_testemunho", true));
            this.data_testemunhoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_testemunhoDateTimePicker.Location = new System.Drawing.Point(91, 31);
            this.data_testemunhoDateTimePicker.Name = "data_testemunhoDateTimePicker";
            this.data_testemunhoDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.data_testemunhoDateTimePicker.TabIndex = 12;
            // 
            // frmVerAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 411);
            this.Controls.Add(this.data_testemunhoDateTimePicker);
            this.Controls.Add(this.testemunhoTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_testemunhaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVerAuto";
            this.Text = "Ver Auto";
            this.Load += new System.EventHandler(this.frmVerAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaTestemunhasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ocorrenciaTestemunhasBindingSource;
        private Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter ocorrenciaTestemunhasTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nome_testemunhaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox testemunhoTextBox;
        private System.Windows.Forms.DateTimePicker data_testemunhoDateTimePicker;
    }
}