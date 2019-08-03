namespace PedraPapelTesoura
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJG = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.ptbJogador = new System.Windows.Forms.PictureBox();
            this.ptbComputador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(58, 292);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(601, 43);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar Novamente";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.Location = new System.Drawing.Point(58, 222);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(75, 23);
            this.btnPedra.TabIndex = 1;
            this.btnPedra.Text = "Pedra";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Location = new System.Drawing.Point(139, 222);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(75, 23);
            this.btnPapel.TabIndex = 2;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.Location = new System.Drawing.Point(220, 222);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(75, 23);
            this.btnTesoura.TabIndex = 3;
            this.btnTesoura.Text = "Tesoura";
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pontos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pontos:";
            // 
            // lblJG
            // 
            this.lblJG.AutoSize = true;
            this.lblJG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJG.Location = new System.Drawing.Point(171, 33);
            this.lblJG.Name = "lblJG";
            this.lblJG.Size = new System.Drawing.Size(29, 31);
            this.lblJG.TabIndex = 9;
            this.lblJG.Text = "0";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.Location = new System.Drawing.Point(624, 33);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(29, 31);
            this.lblPC.TabIndex = 10;
            this.lblPC.Text = "0";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(139, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(427, 33);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbJogador
            // 
            this.ptbJogador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbJogador.Location = new System.Drawing.Point(58, 89);
            this.ptbJogador.Name = "ptbJogador";
            this.ptbJogador.Size = new System.Drawing.Size(142, 89);
            this.ptbJogador.TabIndex = 5;
            this.ptbJogador.TabStop = false;
            // 
            // ptbComputador
            // 
            this.ptbComputador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbComputador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbComputador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbComputador.Location = new System.Drawing.Point(517, 89);
            this.ptbComputador.Name = "ptbComputador";
            this.ptbComputador.Size = new System.Drawing.Size(142, 89);
            this.ptbComputador.TabIndex = 4;
            this.ptbComputador.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 347);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblJG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbJogador);
            this.Controls.Add(this.ptbComputador);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.btnJogar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.PictureBox ptbComputador;
        private System.Windows.Forms.PictureBox ptbJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJG;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblResultado;
    }
}

