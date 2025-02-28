namespace WFInicial
{
    partial class FormEx002
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
            lbl_diasemana = new Label();
            txt_diaSemana = new TextBox();
            btn_escolher = new Button();
            SuspendLayout();
            // 
            // lbl_diasemana
            // 
            lbl_diasemana.AutoSize = true;
            lbl_diasemana.Location = new Point(82, 47);
            lbl_diasemana.Name = "lbl_diasemana";
            lbl_diasemana.Size = new Size(88, 15);
            lbl_diasemana.TabIndex = 0;
            lbl_diasemana.Text = "Dia da Semana:";
            lbl_diasemana.Click += label1_Click;
            // 
            // txt_diaSemana
            // 
            txt_diaSemana.Location = new Point(176, 43);
            txt_diaSemana.Name = "txt_diaSemana";
            txt_diaSemana.Size = new Size(96, 23);
            txt_diaSemana.TabIndex = 1;
            // 
            // btn_escolher
            // 
            btn_escolher.Location = new Point(278, 43);
            btn_escolher.Name = "btn_escolher";
            btn_escolher.Size = new Size(75, 23);
            btn_escolher.TabIndex = 2;
            btn_escolher.Text = "Confirmar";
            btn_escolher.UseVisualStyleBackColor = true;
            btn_escolher.Click += btn_escolher_Click;
            // 
            // FormEx002
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 167);
            Controls.Add(btn_escolher);
            Controls.Add(txt_diaSemana);
            Controls.Add(lbl_diasemana);
            Name = "FormEx002";
            Text = "FormEx002";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_diasemana;
        private TextBox txt_diaSemana;
        private Button btn_escolher;
    }
}