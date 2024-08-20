namespace Mestre_Mandou
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
            this.components = new System.ComponentModel.Container();
            this.btFacil = new System.Windows.Forms.Button();
            this.ptbAmarelo = new System.Windows.Forms.PictureBox();
            this.ptbAzul = new System.Windows.Forms.PictureBox();
            this.ptbPiscaVerde = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ptbPiscaVermelho = new System.Windows.Forms.PictureBox();
            this.ptbPiscaAmarelo = new System.Windows.Forms.PictureBox();
            this.ptbVeremelho = new System.Windows.Forms.PictureBox();
            this.ptbVerde = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.ptbPiscaAzul = new System.Windows.Forms.PictureBox();
            this.btMedio = new System.Windows.Forms.Button();
            this.btDificil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVeremelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaAzul)).BeginInit();
            this.SuspendLayout();
            // 
            // btFacil
            // 
            this.btFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacil.Location = new System.Drawing.Point(12, 190);
            this.btFacil.Name = "btFacil";
            this.btFacil.Size = new System.Drawing.Size(195, 38);
            this.btFacil.TabIndex = 4;
            this.btFacil.Text = "Fácil";
            this.btFacil.UseVisualStyleBackColor = true;
            this.btFacil.Click += new System.EventHandler(this.btFacil_Click);
            // 
            // ptbAmarelo
            // 
            this.ptbAmarelo.Image = global::Mestre_Mandou.Properties.Resources.amarelo;
            this.ptbAmarelo.Location = new System.Drawing.Point(303, 190);
            this.ptbAmarelo.Name = "ptbAmarelo";
            this.ptbAmarelo.Size = new System.Drawing.Size(150, 150);
            this.ptbAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAmarelo.TabIndex = 5;
            this.ptbAmarelo.TabStop = false;
            this.ptbAmarelo.Click += new System.EventHandler(this.ptbAmarelo_Click);
            // 
            // ptbAzul
            // 
            this.ptbAzul.Image = global::Mestre_Mandou.Properties.Resources.azul;
            this.ptbAzul.Location = new System.Drawing.Point(449, 190);
            this.ptbAzul.Name = "ptbAzul";
            this.ptbAzul.Size = new System.Drawing.Size(150, 150);
            this.ptbAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAzul.TabIndex = 6;
            this.ptbAzul.TabStop = false;
            this.ptbAzul.Click += new System.EventHandler(this.ptbAzul_Click);
            // 
            // ptbPiscaVerde
            // 
            this.ptbPiscaVerde.Image = global::Mestre_Mandou.Properties.Resources.verde_aceso;
            this.ptbPiscaVerde.Location = new System.Drawing.Point(303, 337);
            this.ptbPiscaVerde.Name = "ptbPiscaVerde";
            this.ptbPiscaVerde.Size = new System.Drawing.Size(150, 150);
            this.ptbPiscaVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPiscaVerde.TabIndex = 7;
            this.ptbPiscaVerde.TabStop = false;
            this.ptbPiscaVerde.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escolha uma dificuldade e aperte para começar!";
            // 
            // ptbPiscaVermelho
            // 
            this.ptbPiscaVermelho.Image = global::Mestre_Mandou.Properties.Resources.vermelho_aceso;
            this.ptbPiscaVermelho.Location = new System.Drawing.Point(449, 337);
            this.ptbPiscaVermelho.Name = "ptbPiscaVermelho";
            this.ptbPiscaVermelho.Size = new System.Drawing.Size(150, 150);
            this.ptbPiscaVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPiscaVermelho.TabIndex = 10;
            this.ptbPiscaVermelho.TabStop = false;
            this.ptbPiscaVermelho.Visible = false;
            // 
            // ptbPiscaAmarelo
            // 
            this.ptbPiscaAmarelo.Image = global::Mestre_Mandou.Properties.Resources.amarelo_aceso;
            this.ptbPiscaAmarelo.Location = new System.Drawing.Point(303, 190);
            this.ptbPiscaAmarelo.Name = "ptbPiscaAmarelo";
            this.ptbPiscaAmarelo.Size = new System.Drawing.Size(150, 150);
            this.ptbPiscaAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPiscaAmarelo.TabIndex = 11;
            this.ptbPiscaAmarelo.TabStop = false;
            this.ptbPiscaAmarelo.Visible = false;
            // 
            // ptbVeremelho
            // 
            this.ptbVeremelho.Image = global::Mestre_Mandou.Properties.Resources.vermelho;
            this.ptbVeremelho.Location = new System.Drawing.Point(449, 337);
            this.ptbVeremelho.Name = "ptbVeremelho";
            this.ptbVeremelho.Size = new System.Drawing.Size(150, 150);
            this.ptbVeremelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVeremelho.TabIndex = 12;
            this.ptbVeremelho.TabStop = false;
            this.ptbVeremelho.Click += new System.EventHandler(this.ptbVeremelho_Click);
            // 
            // ptbVerde
            // 
            this.ptbVerde.Image = global::Mestre_Mandou.Properties.Resources.verde;
            this.ptbVerde.Location = new System.Drawing.Point(303, 337);
            this.ptbVerde.Name = "ptbVerde";
            this.ptbVerde.Size = new System.Drawing.Size(150, 150);
            this.ptbVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVerde.TabIndex = 13;
            this.ptbVerde.TabStop = false;
            this.ptbVerde.Click += new System.EventHandler(this.ptbVerde_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(12, 409);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(195, 38);
            this.btStart.TabIndex = 14;
            this.btStart.Text = "Start!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // ptbPiscaAzul
            // 
            this.ptbPiscaAzul.Image = global::Mestre_Mandou.Properties.Resources.azul_aceso;
            this.ptbPiscaAzul.Location = new System.Drawing.Point(449, 190);
            this.ptbPiscaAzul.Name = "ptbPiscaAzul";
            this.ptbPiscaAzul.Size = new System.Drawing.Size(150, 150);
            this.ptbPiscaAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPiscaAzul.TabIndex = 8;
            this.ptbPiscaAzul.TabStop = false;
            this.ptbPiscaAzul.Visible = false;
            // 
            // btMedio
            // 
            this.btMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedio.Location = new System.Drawing.Point(12, 262);
            this.btMedio.Name = "btMedio";
            this.btMedio.Size = new System.Drawing.Size(195, 38);
            this.btMedio.TabIndex = 15;
            this.btMedio.Text = "Médio";
            this.btMedio.UseVisualStyleBackColor = true;
            this.btMedio.Click += new System.EventHandler(this.btMedio_Click);
            // 
            // btDificil
            // 
            this.btDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDificil.Location = new System.Drawing.Point(12, 337);
            this.btDificil.Name = "btDificil";
            this.btDificil.Size = new System.Drawing.Size(195, 38);
            this.btDificil.TabIndex = 16;
            this.btDificil.Text = "Difícil ";
            this.btDificil.UseVisualStyleBackColor = true;
            this.btDificil.Click += new System.EventHandler(this.btDificil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 562);
            this.Controls.Add(this.btDificil);
            this.Controls.Add(this.btMedio);
            this.Controls.Add(this.ptbPiscaAmarelo);
            this.Controls.Add(this.ptbPiscaAzul);
            this.Controls.Add(this.ptbPiscaVermelho);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.ptbVeremelho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbPiscaVerde);
            this.Controls.Add(this.ptbAzul);
            this.Controls.Add(this.ptbAmarelo);
            this.Controls.Add(this.btFacil);
            this.Controls.Add(this.ptbVerde);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVeremelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPiscaAzul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFacil;
        private System.Windows.Forms.PictureBox ptbAmarelo;
        private System.Windows.Forms.PictureBox ptbAzul;
        private System.Windows.Forms.PictureBox ptbPiscaVerde;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbPiscaVermelho;
        private System.Windows.Forms.PictureBox ptbPiscaAmarelo;
        private System.Windows.Forms.PictureBox ptbVeremelho;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.PictureBox ptbVerde;
        private System.Windows.Forms.PictureBox ptbPiscaAzul;
        private System.Windows.Forms.Button btMedio;
        private System.Windows.Forms.Button btDificil;
    }
}

