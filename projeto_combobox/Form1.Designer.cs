namespace projeto_combobox
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.LightSalmon;
            this.txtTexto.Location = new System.Drawing.Point(238, 31);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(270, 20);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(254, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inserir no Combo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(388, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ordenar o Combo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboLista
            // 
            this.cboLista.BackColor = System.Drawing.Color.LightSalmon;
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(238, 142);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(270, 21);
            this.cboLista.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Location = new System.Drawing.Point(318, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remover do Combo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Location = new System.Drawing.Point(307, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Exibir dados do combo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.Color.LightSalmon;
            this.txtIndice.Location = new System.Drawing.Point(238, 314);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(270, 20);
            this.txtIndice.TabIndex = 6;
            // 
            // txtConteudo
            // 
            this.txtConteudo.BackColor = System.Drawing.Color.LightSalmon;
            this.txtConteudo.Location = new System.Drawing.Point(238, 353);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(270, 20);
            this.txtConteudo.TabIndex = 7;
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(182, 31);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(33, 13);
            this.lbltxt.TabIndex = 8;
            this.lbltxt.Text = "texto:";
            this.lbltxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(185, 142);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(25, 13);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "lista";
            this.lblLista.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Indice do Combo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Texto do Combo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade de Itens:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(276, 239);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(13, 13);
            this.lblQtde.TabIndex = 13;
            this.lblQtde.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtde;
    }
}

