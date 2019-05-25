namespace Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblResposta1 = new System.Windows.Forms.Label();
            this.lblResposta2 = new System.Windows.Forms.Label();
            this.lblResposta3 = new System.Windows.Forms.Label();
            this.lblResposta4 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnunciado.Location = new System.Drawing.Point(35, 34);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(326, 31);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Mas ué tá funcionando!!";
            // 
            // lblResposta1
            // 
            this.lblResposta1.AutoSize = true;
            this.lblResposta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResposta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta1.Location = new System.Drawing.Point(67, 79);
            this.lblResposta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta1.Name = "lblResposta1";
            this.lblResposta1.Size = new System.Drawing.Size(125, 31);
            this.lblResposta1.TabIndex = 1;
            this.lblResposta1.Text = "Resposta";
            // 
            // lblResposta2
            // 
            this.lblResposta2.AutoSize = true;
            this.lblResposta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta2.Location = new System.Drawing.Point(67, 130);
            this.lblResposta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta2.Name = "lblResposta2";
            this.lblResposta2.Size = new System.Drawing.Size(123, 29);
            this.lblResposta2.TabIndex = 2;
            this.lblResposta2.Text = "Resposta";
            // 
            // lblResposta3
            // 
            this.lblResposta3.AutoSize = true;
            this.lblResposta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta3.Location = new System.Drawing.Point(67, 180);
            this.lblResposta3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta3.Name = "lblResposta3";
            this.lblResposta3.Size = new System.Drawing.Size(123, 29);
            this.lblResposta3.TabIndex = 3;
            this.lblResposta3.Text = "Resposta";
            // 
            // lblResposta4
            // 
            this.lblResposta4.AutoSize = true;
            this.lblResposta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta4.Location = new System.Drawing.Point(67, 226);
            this.lblResposta4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta4.Name = "lblResposta4";
            this.lblResposta4.Size = new System.Drawing.Size(123, 29);
            this.lblResposta4.TabIndex = 4;
            this.lblResposta4.Text = "Resposta";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(31, 86);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(29, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(31, 130);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(29, 23);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(31, 180);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(29, 23);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(31, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(29, 23);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1011, 315);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblResposta4);
            this.Controls.Add(this.lblResposta3);
            this.Controls.Add(this.lblResposta2);
            this.Controls.Add(this.lblResposta1);
            this.Controls.Add(this.lblEnunciado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblResposta1;
        private System.Windows.Forms.Label lblResposta2;
        private System.Windows.Forms.Label lblResposta3;
        private System.Windows.Forms.Label lblResposta4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

