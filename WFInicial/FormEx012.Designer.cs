namespace WFInicial
{
    partial class FormEx012
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
            lbl_num = new Label();
            txt_num = new TextBox();
            btn_confirmar = new Button();
            lbl_cont = new Label();
            lbl_numeros = new Label();
            lbl_par = new Label();
            lbl_impar = new Label();
            SuspendLayout();
            // 
            // lbl_num
            // 
            lbl_num.AutoSize = true;
            lbl_num.Location = new Point(51, 20);
            lbl_num.Name = "lbl_num";
            lbl_num.Size = new Size(51, 15);
            lbl_num.TabIndex = 0;
            lbl_num.Text = "Número";
            // 
            // txt_num
            // 
            txt_num.Location = new Point(108, 12);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(104, 23);
            txt_num.TabIndex = 1;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(51, 41);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(180, 23);
            btn_confirmar.TabIndex = 3;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // lbl_cont
            // 
            lbl_cont.AutoSize = true;
            lbl_cont.Location = new Point(218, 15);
            lbl_cont.Name = "lbl_cont";
            lbl_cont.Size = new Size(13, 15);
            lbl_cont.TabIndex = 4;
            lbl_cont.Text = "0";
            lbl_cont.Click += lbl_cont_Click;
            // 
            // lbl_numeros
            // 
            lbl_numeros.BorderStyle = BorderStyle.Fixed3D;
            lbl_numeros.Location = new Point(51, 67);
            lbl_numeros.Name = "lbl_numeros";
            lbl_numeros.Size = new Size(180, 23);
            lbl_numeros.TabIndex = 5;
            lbl_numeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_par
            // 
            lbl_par.BorderStyle = BorderStyle.Fixed3D;
            lbl_par.Location = new Point(51, 102);
            lbl_par.Name = "lbl_par";
            lbl_par.Size = new Size(180, 23);
            lbl_par.TabIndex = 6;
            lbl_par.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_impar
            // 
            lbl_impar.BorderStyle = BorderStyle.Fixed3D;
            lbl_impar.Location = new Point(51, 136);
            lbl_impar.Name = "lbl_impar";
            lbl_impar.Size = new Size(180, 23);
            lbl_impar.TabIndex = 7;
            // 
            // FormEx012
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 187);
            Controls.Add(lbl_impar);
            Controls.Add(lbl_par);
            Controls.Add(lbl_numeros);
            Controls.Add(lbl_cont);
            Controls.Add(btn_confirmar);
            Controls.Add(txt_num);
            Controls.Add(lbl_num);
            Name = "FormEx012";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEx012";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_num;
        private TextBox txt_num;
        private Button btn_confirmar;
        private Label lbl_cont;
        private Label lbl_numeros;
        private Label lbl_par;
        private Label lbl_impar;
    }
}