namespace BarbieriBankGroup
{
    partial class Deposito
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboIndice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoSaldoAtual = new System.Windows.Forms.TextBox();
            this.textoValorOperacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Barbieri Bank Group";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoValorOperacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textoSaldoAtual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboIndice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botaoDepositar);
            this.groupBox1.Controls.Add(this.botaoCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 287);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depósito:";
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(144, 215);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(104, 33);
            this.botaoDepositar.TabIndex = 7;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(297, 215);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(104, 33);
            this.botaoCancelar.TabIndex = 6;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Depósito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecione a Conta:";
            // 
            // comboIndice
            // 
            this.comboIndice.FormattingEnabled = true;
            this.comboIndice.Location = new System.Drawing.Point(182, 48);
            this.comboIndice.Name = "comboIndice";
            this.comboIndice.Size = new System.Drawing.Size(219, 28);
            this.comboIndice.TabIndex = 9;
            this.comboIndice.SelectedIndexChanged += new System.EventHandler(this.comboIndice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saldo Atual:";
            // 
            // textoSaldoAtual
            // 
            this.textoSaldoAtual.Location = new System.Drawing.Point(182, 98);
            this.textoSaldoAtual.Name = "textoSaldoAtual";
            this.textoSaldoAtual.Size = new System.Drawing.Size(219, 26);
            this.textoSaldoAtual.TabIndex = 11;
            // 
            // textoValorOperacao
            // 
            this.textoValorOperacao.Location = new System.Drawing.Point(182, 150);
            this.textoValorOperacao.Name = "textoValorOperacao";
            this.textoValorOperacao.Size = new System.Drawing.Size(219, 26);
            this.textoValorOperacao.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor Depósito:";
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoValorOperacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoSaldoAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboIndice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Label label1;
    }
}