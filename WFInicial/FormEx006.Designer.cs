namespace WFInicial
{
    partial class FormEx006
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
            btn_calcular = new Button();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            txt_valor = new TextBox();
            lbl_hora = new Label();
            txt_hora = new TextBox();
            lbl_valor = new Label();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(143, 172);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(100, 23);
            btn_calcular.TabIndex = 0;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(56, 25);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(81, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Qual o nome?";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(263, 12);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 2;
            txt_nome.TextChanged += textBox1_TextChanged;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(263, 64);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(100, 23);
            txt_valor.TabIndex = 4;
            // 
            // lbl_hora
            // 
            lbl_hora.AutoSize = true;
            lbl_hora.Location = new Point(56, 122);
            lbl_hora.Name = "lbl_hora";
            lbl_hora.Size = new Size(187, 15);
            lbl_hora.TabIndex = 3;
            lbl_hora.Text = "Quantas horas foram trabalhadas?";
            // 
            // txt_hora
            // 
            txt_hora.Location = new Point(263, 114);
            txt_hora.Name = "txt_hora";
            txt_hora.Size = new Size(100, 23);
            txt_hora.TabIndex = 6;
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(56, 72);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(141, 15);
            lbl_valor.TabIndex = 5;
            lbl_valor.Text = "Quantos ganha por hora?";
            // 
            // FormEx006
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(txt_hora);
            Controls.Add(lbl_valor);
            Controls.Add(txt_valor);
            Controls.Add(lbl_hora);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            Controls.Add(btn_calcular);
            Name = "FormEx006";
            Text = "FormEx006";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calcular;
        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_valor;
        private Label lbl_hora;
        private TextBox txt_hora;
        private Label lbl_valor;
    }
}