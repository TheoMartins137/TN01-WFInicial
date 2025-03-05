namespace WFInicial
{
    partial class FormEx007
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
            txt_nome = new TextBox();
            txt_valor = new TextBox();
            lbl_valor = new Label();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(141, 151);
            btn_confirm.Margin = new Padding(3, 4, 3, 4);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(114, 31);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "confirmar";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(64, 59);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(62, 20);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Produto";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(141, 99);
            txt_nome.Margin = new Padding(3, 4, 3, 4);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(114, 27);
            txt_nome.TabIndex = 2;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(141, 55);
            txt_valor.Margin = new Padding(3, 4, 3, 4);
            txt_valor.Multiline = true;
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(114, 27);
            txt_valor.TabIndex = 3;
            txt_valor.TextChanged += txt_valor_TextChanged;
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(64, 103);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(43, 20);
            lbl_valor.TabIndex = 4;
            lbl_valor.Text = "Valor";
            // 
            // FormEx007
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 364);
            Controls.Add(lbl_valor);
            Controls.Add(txt_valor);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(btn_confirm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEx007";
            Text = "FormEx007";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirm;
        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_valor;
        private Label lbl_valor;
    }
}