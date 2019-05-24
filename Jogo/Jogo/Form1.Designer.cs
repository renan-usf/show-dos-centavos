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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnContinuar = new System.Windows.Forms.Button();
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
            this.lblResposta1.Click += new System.EventHandler(this.lblResposta1_Click);
            // 
            // lblResposta2
            // 
            this.lblResposta2.AutoSize = true;
            this.lblResposta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta2.Location = new System.Drawing.Point(69, 124);
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
            this.lblResposta3.Location = new System.Drawing.Point(69, 174);
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
            this.lblResposta4.Location = new System.Drawing.Point(69, 219);
            this.lblResposta4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta4.Name = "lblResposta4";
            this.lblResposta4.Size = new System.Drawing.Size(123, 29);
            this.lblResposta4.TabIndex = 4;
            this.lblResposta4.Text = "Resposta";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(39, 89);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(39, 134);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(39, 183);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(39, 229);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Red;
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinuar.Location = new System.Drawing.Point(825, 248);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(173, 54);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Confirmar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1011, 315);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnContinuar;
    }
}

