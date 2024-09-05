namespace CriptografaDados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnCriptografa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtAuxiliar = new System.Windows.Forms.TextBox();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(70, 46);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(250, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // btnCriptografa
            // 
            this.btnCriptografa.Location = new System.Drawing.Point(340, 44);
            this.btnCriptografa.Name = "btnCriptografa";
            this.btnCriptografa.Size = new System.Drawing.Size(102, 23);
            this.btnCriptografa.TabIndex = 1;
            this.btnCriptografa.Text = "Criptografar";
            this.btnCriptografa.UseVisualStyleBackColor = true;
            this.btnCriptografa.Click += new System.EventHandler(this.btnCriptografa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(67, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // txtAuxiliar
            // 
            this.txtAuxiliar.Location = new System.Drawing.Point(70, 90);
            this.txtAuxiliar.Name = "txtAuxiliar";
            this.txtAuxiliar.Size = new System.Drawing.Size(250, 20);
            this.txtAuxiliar.TabIndex = 4;
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(340, 90);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(102, 23);
            this.btnDecriptografar.TabIndex = 5;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecriptografar);
            this.Controls.Add(this.txtAuxiliar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriptografa);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnCriptografa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtAuxiliar;
        private System.Windows.Forms.Button btnDecriptografar;
        private System.Windows.Forms.Label label2;
    }
}

