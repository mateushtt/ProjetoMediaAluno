namespace MediaAluno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPesoNota1 = new System.Windows.Forms.ComboBox();
            this.cboPesoNota2 = new System.Windows.Forms.ComboBox();
            this.cboPesoTrabalho = new System.Windows.Forms.ComboBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNotaCorte = new System.Windows.Forms.Label();
            this.lblMediaFinal = new System.Windows.Forms.Label();
            this.lblAproveitamento = new System.Windows.Forms.Label();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.txtAproveitamento = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.numNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaAluno.Properties.Resources.tela_principal;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNota1.Location = new System.Drawing.Point(108, 188);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 26);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNota2.Location = new System.Drawing.Point(238, 188);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 26);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTrabalho.Location = new System.Drawing.Point(370, 188);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(100, 26);
            this.txtTrabalho.TabIndex = 4;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(386, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trabalho";
            // 
            // cboPesoNota1
            // 
            this.cboPesoNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPesoNota1.FormattingEnabled = true;
            this.cboPesoNota1.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoNota1.Location = new System.Drawing.Point(108, 220);
            this.cboPesoNota1.Name = "cboPesoNota1";
            this.cboPesoNota1.Size = new System.Drawing.Size(100, 26);
            this.cboPesoNota1.TabIndex = 1;
            // 
            // cboPesoNota2
            // 
            this.cboPesoNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPesoNota2.FormattingEnabled = true;
            this.cboPesoNota2.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoNota2.Location = new System.Drawing.Point(238, 220);
            this.cboPesoNota2.Name = "cboPesoNota2";
            this.cboPesoNota2.Size = new System.Drawing.Size(100, 26);
            this.cboPesoNota2.TabIndex = 3;
            // 
            // cboPesoTrabalho
            // 
            this.cboPesoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoTrabalho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPesoTrabalho.FormattingEnabled = true;
            this.cboPesoTrabalho.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoTrabalho.Location = new System.Drawing.Point(370, 220);
            this.cboPesoTrabalho.Name = "cboPesoTrabalho";
            this.cboPesoTrabalho.Size = new System.Drawing.Size(100, 26);
            this.cboPesoTrabalho.TabIndex = 5;
            // 
            // txtAulas
            // 
            this.txtAulas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAulas.Location = new System.Drawing.Point(171, 293);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(100, 26);
            this.txtAulas.TabIndex = 6;
            this.txtAulas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAulas.Location = new System.Drawing.Point(64, 297);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(80, 18);
            this.lblAulas.TabIndex = 5;
            this.lblAulas.Text = "Qde Aulas";
            // 
            // txtFaltas
            // 
            this.txtFaltas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFaltas.Location = new System.Drawing.Point(171, 330);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 26);
            this.txtFaltas.TabIndex = 7;
            this.txtFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qde Faltas";
            // 
            // lblNotaCorte
            // 
            this.lblNotaCorte.AutoSize = true;
            this.lblNotaCorte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaCorte.Location = new System.Drawing.Point(364, 293);
            this.lblNotaCorte.Name = "lblNotaCorte";
            this.lblNotaCorte.Size = new System.Drawing.Size(106, 18);
            this.lblNotaCorte.TabIndex = 6;
            this.lblNotaCorte.Text = "Nota de Corte";
            // 
            // lblMediaFinal
            // 
            this.lblMediaFinal.AutoSize = true;
            this.lblMediaFinal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMediaFinal.Location = new System.Drawing.Point(122, 422);
            this.lblMediaFinal.Name = "lblMediaFinal";
            this.lblMediaFinal.Size = new System.Drawing.Size(123, 24);
            this.lblMediaFinal.TabIndex = 7;
            this.lblMediaFinal.Text = "Média Final";
            // 
            // lblAproveitamento
            // 
            this.lblAproveitamento.AutoSize = true;
            this.lblAproveitamento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAproveitamento.Location = new System.Drawing.Point(281, 422);
            this.lblAproveitamento.Name = "lblAproveitamento";
            this.lblAproveitamento.Size = new System.Drawing.Size(172, 24);
            this.lblAproveitamento.TabIndex = 7;
            this.lblAproveitamento.Text = "Aproveitamento";
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMediaFinal.Location = new System.Drawing.Point(133, 466);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(100, 26);
            this.txtMediaFinal.TabIndex = 4;
            this.txtMediaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAproveitamento
            // 
            this.txtAproveitamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAproveitamento.Location = new System.Drawing.Point(317, 466);
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Size = new System.Drawing.Size(100, 26);
            this.txtAproveitamento.TabIndex = 4;
            this.txtAproveitamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(122, 525);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 48);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(315, 525);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 48);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // numNotaCorte
            // 
            this.numNotaCorte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numNotaCorte.Location = new System.Drawing.Point(360, 334);
            this.numNotaCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNotaCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNotaCorte.Name = "numNotaCorte";
            this.numNotaCorte.Size = new System.Drawing.Size(120, 26);
            this.numNotaCorte.TabIndex = 8;
            this.numNotaCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(491, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(18, 45);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 19);
            this.lblSituacao.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecuperacao);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(491, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recuperação";
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecuperacao.Location = new System.Drawing.Point(38, 41);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(100, 26);
            this.txtRecuperacao.TabIndex = 1;
            this.txtRecuperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numNotaCorte);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAproveitamento);
            this.Controls.Add(this.lblMediaFinal);
            this.Controls.Add(this.lblNotaCorte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.txtAproveitamento);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.cboPesoTrabalho);
            this.Controls.Add(this.cboPesoNota2);
            this.Controls.Add(this.cboPesoNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Média Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtTrabalho;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboPesoNota1;
        private ComboBox cboPesoNota2;
        private ComboBox cboPesoTrabalho;
        private TextBox txtAulas;
        private Label lblAulas;
        private TextBox txtFaltas;
        private Label label4;
        private Label lblNotaCorte;
        private Label lblMediaFinal;
        private Label lblAproveitamento;
        private TextBox txtMediaFinal;
        private TextBox txtAproveitamento;
        private Button btnCalcular;
        private Button btnLimpar;
        private NumericUpDown numNotaCorte;
        private GroupBox groupBox1;
        private Label lblSituacao;
        private GroupBox groupBox2;
        private TextBox txtRecuperacao;
    }
}