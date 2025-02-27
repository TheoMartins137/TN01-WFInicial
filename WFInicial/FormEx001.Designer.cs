namespace WFInicial
{
    partial class FormEx001
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
            lbl_nome1 = new Label();
            txt_nota1 = new TextBox();
            btn_calcular = new Button();
            lbl_nota2 = new Label();
            txt_nota2 = new TextBox();
            SuspendLayout();
            // 
            // lbl_nome1
            // 
            lbl_nome1.AutoSize = true;
            lbl_nome1.Location = new Point(291, 58);
            lbl_nome1.Name = "lbl_nome1";
            lbl_nome1.Size = new Size(43, 15);
            lbl_nome1.TabIndex = 0;
            lbl_nome1.Text = "nota 1:";
            lbl_nome1.Click += label1_Click;
            // 
            // txt_nota1
            // 
            txt_nota1.Location = new Point(340, 54);
            txt_nota1.Name = "txt_nota1";
            txt_nota1.Size = new Size(100, 23);
            txt_nota1.TabIndex = 1;
            txt_nota1.TextChanged += textBox1_TextChanged;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(340, 114);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(100, 23);
            btn_calcular.TabIndex = 2;
            btn_calcular.Text = "Calcular!";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lbl_nota2
            // 
            lbl_nota2.AutoSize = true;
            lbl_nota2.Location = new Point(291, 88);
            lbl_nota2.Name = "lbl_nota2";
            lbl_nota2.Size = new Size(43, 15);
            lbl_nota2.TabIndex = 3;
            lbl_nota2.Text = "nota 2:";
            lbl_nota2.Click += txt_nota2_Click;
            // 
            // txt_nota2
            // 
            txt_nota2.Location = new Point(340, 85);
            txt_nota2.Name = "txt_nota2";
            txt_nota2.Size = new Size(100, 23);
            txt_nota2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 260);
            Controls.Add(txt_nota2);
            Controls.Add(lbl_nota2);
            Controls.Add(btn_calcular);
            Controls.Add(txt_nota1);
            Controls.Add(lbl_nome1);
            Name = "Form1";
            Text = "Calculo de Média";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome1;
        private TextBox txt_nota1;
        private Button btn_calcular;
        private Label lbl_nota2;
        private TextBox txt_nota2;
    }
}
