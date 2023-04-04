namespace votacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranco = new System.Windows.Forms.TextBox();
            this.txtNulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBranco = new System.Windows.Forms.Label();
            this.lblNulo = new System.Windows.Forms.Label();
            this.lblValidos = new System.Windows.Forms.Label();
            this.btlCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votos em branco:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBranco
            // 
            this.txtBranco.Location = new System.Drawing.Point(114, 93);
            this.txtBranco.Name = "txtBranco";
            this.txtBranco.Size = new System.Drawing.Size(100, 23);
            this.txtBranco.TabIndex = 1;
            // 
            // txtNulo
            // 
            this.txtNulo.Location = new System.Drawing.Point(114, 139);
            this.txtNulo.Name = "txtNulo";
            this.txtNulo.Size = new System.Drawing.Size(100, 23);
            this.txtNulo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Votos em nulo:";
            // 
            // txtValidos
            // 
            this.txtValidos.Location = new System.Drawing.Point(114, 181);
            this.txtValidos.Name = "txtValidos";
            this.txtValidos.Size = new System.Drawing.Size(100, 23);
            this.txtValidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Votos válidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Porcentagem de votos em branco:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Porcentagem de votos nulos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Porcentagem de votos válidos: ";
            // 
            // lblBranco
            // 
            this.lblBranco.AutoSize = true;
            this.lblBranco.Location = new System.Drawing.Point(430, 101);
            this.lblBranco.Name = "lblBranco";
            this.lblBranco.Size = new System.Drawing.Size(0, 15);
            this.lblBranco.TabIndex = 6;
            // 
            // lblNulo
            // 
            this.lblNulo.AutoSize = true;
            this.lblNulo.Location = new System.Drawing.Point(430, 147);
            this.lblNulo.Name = "lblNulo";
            this.lblNulo.Size = new System.Drawing.Size(0, 15);
            this.lblNulo.TabIndex = 7;
            this.lblNulo.Click += new System.EventHandler(this.lblPorcenulo_Click);
            // 
            // lblValidos
            // 
            this.lblValidos.AutoSize = true;
            this.lblValidos.Location = new System.Drawing.Point(430, 189);
            this.lblValidos.Name = "lblValidos";
            this.lblValidos.Size = new System.Drawing.Size(0, 15);
            this.lblValidos.TabIndex = 8;
            // 
            // btlCalcular
            // 
            this.btlCalcular.Location = new System.Drawing.Point(139, 224);
            this.btlCalcular.Name = "btlCalcular";
            this.btlCalcular.Size = new System.Drawing.Size(75, 23);
            this.btlCalcular.TabIndex = 9;
            this.btlCalcular.Text = "Calcular";
            this.btlCalcular.UseVisualStyleBackColor = true;
            this.btlCalcular.Click += new System.EventHandler(this.btlCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total de votos:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(114, 25);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlCalcular);
            this.Controls.Add(this.lblValidos);
            this.Controls.Add(this.lblNulo);
            this.Controls.Add(this.lblBranco);
            this.Controls.Add(this.txtValidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBranco);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBranco;
        private TextBox txtNulo;
        private Label label2;
        private TextBox txtValidos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblBranco;
        private Label lblNulo;
        private Label lblValidos;
        private Button btlCalcular;
        private Label label7;
        private TextBox txtTotal;
    }
}