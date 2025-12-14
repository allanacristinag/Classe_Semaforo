namespace Semaforo
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
            this.picrua1 = new System.Windows.Forms.PictureBox();
            this.picrua2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRua1Verde = new System.Windows.Forms.Button();
            this.btnRua1Amarelo = new System.Windows.Forms.Button();
            this.btnRua1Vermelho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picrua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrua2)).BeginInit();
            this.SuspendLayout();
            // 
            // picrua1
            // 
            this.picrua1.Image = global::Semaforo.Properties.Resources.semaforovermelho;
            this.picrua1.Location = new System.Drawing.Point(75, 50);
            this.picrua1.Name = "picrua1";
            this.picrua1.Size = new System.Drawing.Size(272, 254);
            this.picrua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrua1.TabIndex = 0;
            this.picrua1.TabStop = false;
            // 
            // picrua2
            // 
            this.picrua2.BackgroundImage = global::Semaforo.Properties.Resources.semaforovermelho;
            this.picrua2.Image = global::Semaforo.Properties.Resources.semaforovermelho;
            this.picrua2.Location = new System.Drawing.Point(454, 50);
            this.picrua2.Name = "picrua2";
            this.picrua2.Size = new System.Drawing.Size(269, 254);
            this.picrua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrua2.TabIndex = 1;
            this.picrua2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rua 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rua 2";
            // 
            // btnRua1Verde
            // 
            this.btnRua1Verde.Location = new System.Drawing.Point(75, 341);
            this.btnRua1Verde.Name = "btnRua1Verde";
            this.btnRua1Verde.Size = new System.Drawing.Size(75, 23);
            this.btnRua1Verde.TabIndex = 4;
            this.btnRua1Verde.Text = "Verde";
            this.btnRua1Verde.UseVisualStyleBackColor = true;
            this.btnRua1Verde.Click += new System.EventHandler(this.btnRua1Verde_Click);
            // 
            // btnRua1Amarelo
            // 
            this.btnRua1Amarelo.Location = new System.Drawing.Point(176, 341);
            this.btnRua1Amarelo.Name = "btnRua1Amarelo";
            this.btnRua1Amarelo.Size = new System.Drawing.Size(75, 23);
            this.btnRua1Amarelo.TabIndex = 5;
            this.btnRua1Amarelo.Text = "Amarelo";
            this.btnRua1Amarelo.UseVisualStyleBackColor = true;
            this.btnRua1Amarelo.Click += new System.EventHandler(this.btnRua1Amarelo_Click);
            // 
            // btnRua1Vermelho
            // 
            this.btnRua1Vermelho.Location = new System.Drawing.Point(272, 341);
            this.btnRua1Vermelho.Name = "btnRua1Vermelho";
            this.btnRua1Vermelho.Size = new System.Drawing.Size(75, 23);
            this.btnRua1Vermelho.TabIndex = 6;
            this.btnRua1Vermelho.Text = "Vermelho";
            this.btnRua1Vermelho.UseVisualStyleBackColor = true;
            this.btnRua1Vermelho.Click += new System.EventHandler(this.btnRua1Vermelho_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRua1Vermelho);
            this.Controls.Add(this.btnRua1Amarelo);
            this.Controls.Add(this.btnRua1Verde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picrua2);
            this.Controls.Add(this.picrua1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picrua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picrua1;
        private System.Windows.Forms.PictureBox picrua2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRua1Verde;
        private System.Windows.Forms.Button btnRua1Amarelo;
        private System.Windows.Forms.Button btnRua1Vermelho;
    }
}

