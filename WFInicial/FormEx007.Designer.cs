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
            btn_confirm.Location = new Point(123, 113);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(100, 23);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "confirmar";
            btn_confirm.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(56, 44);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(50, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Produto";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(123, 74);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 2;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(123, 41);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(100, 23);
            txt_valor.TabIndex = 3;
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(56, 77);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(33, 15);
            lbl_valor.TabIndex = 4;
            lbl_valor.Text = "Valor";
            // 
            // FormEx007
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 273);
            Controls.Add(lbl_valor);
            Controls.Add(txt_valor);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(btn_confirm);
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