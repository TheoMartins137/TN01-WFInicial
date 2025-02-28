namespace WFInicial
{
    partial class FormEx005
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
            btn_confirm = new Button();
            lbl_num1 = new Label();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            lbl_num2 = new Label();
            txt_num3 = new TextBox();
            lbl_num3 = new Label();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(140, 129);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(100, 23);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "Confirmar";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(65, 28);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(68, 15);
            lbl_num1.TabIndex = 1;
            lbl_num1.Text = "1° Número:";
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(140, 25);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 2;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(140, 54);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 4;
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Location = new Point(65, 57);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(65, 15);
            lbl_num2.TabIndex = 3;
            lbl_num2.Text = "2° Número";
            // 
            // txt_num3
            // 
            txt_num3.Location = new Point(140, 83);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(100, 23);
            txt_num3.TabIndex = 6;
            // 
            // lbl_num3
            // 
            lbl_num3.AutoSize = true;
            lbl_num3.Location = new Point(65, 86);
            lbl_num3.Name = "lbl_num3";
            lbl_num3.Size = new Size(68, 15);
            lbl_num3.TabIndex = 5;
            lbl_num3.Text = "3° Numero:";
            // 
            // FormEx005
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(txt_num3);
            Controls.Add(lbl_num3);
            Controls.Add(txt_num2);
            Controls.Add(lbl_num2);
            Controls.Add(txt_num1);
            Controls.Add(lbl_num1);
            Controls.Add(btn_confirm);
            Name = "FormEx005";
            Text = "FormEx005";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirm;
        private Label lbl_num1;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private Label lbl_num2;
        private TextBox txt_num3;
        private Label lbl_num3;
    }
}