namespace Calculo_PesoIdeial
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnPesoIdeal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSairX = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnGitGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 36);
            this.txtNome.TabIndex = 0;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(332, 240);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(151, 35);
            this.cmbSexo.TabIndex = 1;
            // 
            // btnPesoIdeal
            // 
            this.btnPesoIdeal.BackColor = System.Drawing.Color.Transparent;
            this.btnPesoIdeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesoIdeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesoIdeal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesoIdeal.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesoIdeal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesoIdeal.Location = new System.Drawing.Point(116, 311);
            this.btnPesoIdeal.Name = "btnPesoIdeal";
            this.btnPesoIdeal.Size = new System.Drawing.Size(151, 48);
            this.btnPesoIdeal.TabIndex = 3;
            this.btnPesoIdeal.Text = "Peso Ideal";
            this.btnPesoIdeal.UseVisualStyleBackColor = false;
            this.btnPesoIdeal.Click += new System.EventHandler(this.btnPesoIdeal_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(332, 311);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 48);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(116, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(367, 48);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(111, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(111, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(336, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(227, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = "CALCULE SEU PESO IDEAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSairX
            // 
            this.btnSairX.BackColor = System.Drawing.Color.Transparent;
            this.btnSairX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairX.BackgroundImage")));
            this.btnSairX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSairX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairX.FlatAppearance.BorderSize = 0;
            this.btnSairX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairX.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairX.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSairX.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSairX.Location = new System.Drawing.Point(908, 0);
            this.btnSairX.Name = "btnSairX";
            this.btnSairX.Size = new System.Drawing.Size(41, 41);
            this.btnSairX.TabIndex = 10;
            this.btnSairX.UseVisualStyleBackColor = false;
            this.btnSairX.Click += new System.EventHandler(this.btnSairX_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(116, 241);
            this.txtAltura.Mask = "0.00";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(151, 36);
            this.txtAltura.TabIndex = 13;
            // 
            // btnGitGui
            // 
            this.btnGitGui.BackColor = System.Drawing.Color.Transparent;
            this.btnGitGui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGitGui.BackgroundImage")));
            this.btnGitGui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGitGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGitGui.FlatAppearance.BorderSize = 0;
            this.btnGitGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitGui.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGitGui.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGitGui.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGitGui.Location = new System.Drawing.Point(820, 512);
            this.btnGitGui.Name = "btnGitGui";
            this.btnGitGui.Size = new System.Drawing.Size(129, 43);
            this.btnGitGui.TabIndex = 14;
            this.btnGitGui.UseVisualStyleBackColor = false;
            this.btnGitGui.Click += new System.EventHandler(this.btnGitGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.btnGitGui);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnSairX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesoIdeal);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnPesoIdeal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSairX;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Button btnGitGui;
    }
}

