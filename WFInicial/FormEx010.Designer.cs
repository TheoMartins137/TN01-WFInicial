namespace WFInicial
{
    partial class FormEx010
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
            txt_num = new TextBox();
            lbl_num = new Label();
            txt_resultado = new TextBox();
            SuspendLayout();
            // 
            // txt_num
            // 
            txt_num.Location = new Point(95, 39);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(100, 23);
            txt_num.TabIndex = 0;
            txt_num.Leave += txt_num_Leave;
            txt_num.MouseLeave += txt_num_MouseLeave;
            // 
            // lbl_num
            // 
            lbl_num.AutoSize = true;
            lbl_num.Location = new Point(37, 42);
            lbl_num.Name = "lbl_num";
            lbl_num.Size = new Size(52, 15);
            lbl_num.TabIndex = 1;
            lbl_num.Text = "numero:";
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(37, 68);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(158, 248);
            txt_resultado.TabIndex = 2;
            // 
            // FormEx010
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 428);
            Controls.Add(txt_resultado);
            Controls.Add(lbl_num);
            Controls.Add(txt_num);
            Name = "FormEx010";
            Text = "FormEx010";
            Load += FormEx010_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num;
        private Label lbl_num;
        private TextBox txt_resultado;
    }
}