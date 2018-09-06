namespace BarbieriBankGroup
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoExtrato = new System.Windows.Forms.Button();
            this.botaoCadastroConta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem Vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barbieri Bank Group";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.botaoDeposito);
            this.groupBox1.Controls.Add(this.botaoExtrato);
            this.groupBox1.Controls.Add(this.botaoCadastroConta);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha uma opção";
            // 
            // botaoSaque
            // 
            this.botaoSaque.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSaque.Location = new System.Drawing.Point(6, 193);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(298, 48);
            this.botaoSaque.TabIndex = 3;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeposito.Location = new System.Drawing.Point(6, 139);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(298, 48);
            this.botaoDeposito.TabIndex = 2;
            this.botaoDeposito.Text = "Depósito";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoExtrato
            // 
            this.botaoExtrato.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExtrato.Location = new System.Drawing.Point(6, 85);
            this.botaoExtrato.Name = "botaoExtrato";
            this.botaoExtrato.Size = new System.Drawing.Size(298, 48);
            this.botaoExtrato.TabIndex = 1;
            this.botaoExtrato.Text = "Extrato";
            this.botaoExtrato.UseVisualStyleBackColor = true;
            // 
            // botaoCadastroConta
            // 
            this.botaoCadastroConta.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroConta.Location = new System.Drawing.Point(7, 31);
            this.botaoCadastroConta.Name = "botaoCadastroConta";
            this.botaoCadastroConta.Size = new System.Drawing.Size(298, 48);
            this.botaoCadastroConta.TabIndex = 0;
            this.botaoCadastroConta.Text = "Cadastrar Conta";
            this.botaoCadastroConta.UseVisualStyleBackColor = true;
            this.botaoCadastroConta.Click += new System.EventHandler(this.botaoCadastroConta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoExtrato;
        private System.Windows.Forms.Button botaoCadastroConta;
    }
}

