namespace WFInicial
{
    partial class FormEx003
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
            lbl_text1 = new Label();
            lbl_text2 = new Label();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(144, 91);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(75, 23);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "Confirmar";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbl_text1
            // 
            lbl_text1.AutoSize = true;
            lbl_text1.Location = new Point(25, 30);
            lbl_text1.Name = "lbl_text1";
            lbl_text1.Size = new Size(100, 15);
            lbl_text1.TabIndex = 1;
            lbl_text1.Text = "Primeiro número:";
            // 
            // lbl_text2
            // 
            lbl_text2.AutoSize = true;
            lbl_text2.Location = new Point(25, 65);
            lbl_text2.Name = "lbl_text2";
            lbl_text2.Size = new Size(102, 15);
            lbl_text2.TabIndex = 2;
            lbl_text2.Text = "Segundo número:";
            lbl_text2.Click += label2_Click;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(131, 22);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(131, 62);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 4;
            txt_num2.TextChanged += textBox2_TextChanged;
            // 
            // FormEx003
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 144);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(lbl_text2);
            Controls.Add(lbl_text1);
            Controls.Add(btn_confirm);
            Name = "FormEx003";
            Text = "FormEx003";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirm;
        private Label lbl_text1;
        private Label lbl_text2;
        private TextBox txt_num1;
        private TextBox txt_num2;
    }
}