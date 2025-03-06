namespace WFInicial
{
    partial class FormsEX007
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
            lbl_nome = new Label();
            lbl_valor = new Label();
            txt_nome = new TextBox();
            txt_valor = new TextBox();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(102, 82);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(100, 23);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "confirmar";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(23, 27);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(50, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Produto";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(23, 61);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(33, 15);
            lbl_valor.TabIndex = 2;
            lbl_valor.Text = "Valor";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(102, 19);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 3;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(102, 53);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(100, 23);
            txt_valor.TabIndex = 4;
            // 
            // FormsEX007
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 158);
            Controls.Add(txt_valor);
            Controls.Add(txt_nome);
            Controls.Add(lbl_valor);
            Controls.Add(lbl_nome);
            Controls.Add(btn_confirm);
            Name = "FormsEX007";
            Text = "FormsEX007";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirm;
        private Label lbl_nome;
        private Label lbl_valor;
        private TextBox txt_nome;
        private TextBox txt_valor;
    }
}