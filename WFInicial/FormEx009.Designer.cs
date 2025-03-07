namespace WFInicial
{
    partial class FormEx009
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
            btn_confirmar = new Button();
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            SuspendLayout();
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(33, 80);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(170, 23);
            btn_confirmar.TabIndex = 0;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(33, 30);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(50, 15);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(103, 22);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 2;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(103, 51);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 4;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(33, 59);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha:";
            // 
            // FormEx009
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 137);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_confirmar);
            Name = "FormEx009";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEx009";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirmar;
        private Label lbl_usuario;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
    }
}