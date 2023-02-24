namespace Componentes
{
    partial class calcularPontos
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
            this.rb_a = new System.Windows.Forms.RadioButton();
            this.rb_B = new System.Windows.Forms.RadioButton();
            this.rb_C = new System.Windows.Forms.RadioButton();
            this.tb_pontos = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_a
            // 
            this.rb_a.AutoSize = true;
            this.rb_a.Location = new System.Drawing.Point(208, 36);
            this.rb_a.Name = "rb_a";
            this.rb_a.Size = new System.Drawing.Size(81, 17);
            this.rb_a.TabIndex = 0;
            this.rb_a.TabStop = true;
            this.rb_a.Text = "Instalador A";
            this.rb_a.UseVisualStyleBackColor = true;
            this.rb_a.CheckedChanged += new System.EventHandler(this.rb_a_CheckedChanged);
            // 
            // rb_B
            // 
            this.rb_B.AutoSize = true;
            this.rb_B.Location = new System.Drawing.Point(208, 75);
            this.rb_B.Name = "rb_B";
            this.rb_B.Size = new System.Drawing.Size(81, 17);
            this.rb_B.TabIndex = 1;
            this.rb_B.TabStop = true;
            this.rb_B.Text = "Instalador B";
            this.rb_B.UseVisualStyleBackColor = true;
            this.rb_B.CheckedChanged += new System.EventHandler(this.rb_B_CheckedChanged);
            // 
            // rb_C
            // 
            this.rb_C.AutoSize = true;
            this.rb_C.Location = new System.Drawing.Point(208, 112);
            this.rb_C.Name = "rb_C";
            this.rb_C.Size = new System.Drawing.Size(81, 17);
            this.rb_C.TabIndex = 2;
            this.rb_C.TabStop = true;
            this.rb_C.Text = "Instalador C";
            this.rb_C.UseVisualStyleBackColor = true;
            this.rb_C.CheckedChanged += new System.EventHandler(this.rb_C_CheckedChanged);
            // 
            // tb_pontos
            // 
            this.tb_pontos.Location = new System.Drawing.Point(13, 35);
            this.tb_pontos.Name = "tb_pontos";
            this.tb_pontos.Size = new System.Drawing.Size(172, 20);
            this.tb_pontos.TabIndex = 3;
            this.tb_pontos.TextChanged += new System.EventHandler(this.tb_pontos_TextChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 85);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(171, 53);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite sua Pontuação ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marque sua Categoria";
            // 
            // calcularPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tb_pontos);
            this.Controls.Add(this.rb_C);
            this.Controls.Add(this.rb_B);
            this.Controls.Add(this.rb_a);
            this.MaximizeBox = false;
            this.Name = "calcularPontos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Pontuação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_a;
        private System.Windows.Forms.RadioButton rb_B;
        private System.Windows.Forms.RadioButton rb_C;
        private System.Windows.Forms.TextBox tb_pontos;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}