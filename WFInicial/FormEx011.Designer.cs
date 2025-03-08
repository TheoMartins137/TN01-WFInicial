namespace WFInicial
{
    partial class FormEx011
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
            txt_salario = new TextBox();
            lbl_salario = new Label();
            btn_confirmar = new Button();
            txt_resultado = new RichTextBox();
            SuspendLayout();
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(95, 23);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(100, 23);
            txt_salario.TabIndex = 0;
            // 
            // lbl_salario
            // 
            lbl_salario.AutoSize = true;
            lbl_salario.Location = new Point(44, 26);
            lbl_salario.Name = "lbl_salario";
            lbl_salario.Size = new Size(45, 15);
            lbl_salario.TabIndex = 1;
            lbl_salario.Text = "Salário:";
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(44, 52);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(151, 23);
            btn_confirmar.TabIndex = 2;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(44, 81);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(151, 174);
            txt_resultado.TabIndex = 3;
            txt_resultado.Text = "";
            // 
            // FormEx011
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 368);
            Controls.Add(txt_resultado);
            Controls.Add(btn_confirmar);
            Controls.Add(lbl_salario);
            Controls.Add(txt_salario);
            Name = "FormEx011";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEx011";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_salario;
        private Label lbl_salario;
        private Button btn_confirmar;
        private RichTextBox txt_resultado;
    }
}