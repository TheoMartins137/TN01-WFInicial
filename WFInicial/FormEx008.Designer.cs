namespace WFInicial
{
    partial class FormEx008
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
            txt_num1 = new TextBox();
            lbl_num1 = new Label();
            lbl_num2 = new Label();
            txt_num2 = new TextBox();
            bpx_operação = new GroupBox();
            rdb_rad = new RadioButton();
            rdb_soma = new RadioButton();
            rdb_pot = new RadioButton();
            rdb_sub = new RadioButton();
            rdb_div = new RadioButton();
            rdb_mult = new RadioButton();
            btn_calcular = new Button();
            bpx_operação.SuspendLayout();
            SuspendLayout();
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(119, 34);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 0;
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(45, 42);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(68, 15);
            lbl_num1.TabIndex = 1;
            lbl_num1.Text = "1° Numero:";
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Location = new Point(45, 117);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(68, 15);
            lbl_num2.TabIndex = 3;
            lbl_num2.Text = "2° Numero:";
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(119, 109);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 2;
            // 
            // bpx_operação
            // 
            bpx_operação.Controls.Add(rdb_rad);
            bpx_operação.Controls.Add(rdb_soma);
            bpx_operação.Controls.Add(rdb_pot);
            bpx_operação.Controls.Add(rdb_sub);
            bpx_operação.Controls.Add(rdb_div);
            bpx_operação.Controls.Add(rdb_mult);
            bpx_operação.Location = new Point(225, 12);
            bpx_operação.Name = "bpx_operação";
            bpx_operação.Size = new Size(108, 192);
            bpx_operação.TabIndex = 4;
            bpx_operação.TabStop = false;
            bpx_operação.Text = "Operação";
            // 
            // rdb_rad
            // 
            rdb_rad.AutoSize = true;
            rdb_rad.Location = new Point(6, 147);
            rdb_rad.Name = "rdb_rad";
            rdb_rad.Size = new Size(82, 19);
            rdb_rad.TabIndex = 10;
            rdb_rad.TabStop = true;
            rdb_rad.Text = "Radiciação";
            rdb_rad.UseVisualStyleBackColor = true;
            // 
            // rdb_soma
            // 
            rdb_soma.AutoSize = true;
            rdb_soma.Location = new Point(6, 22);
            rdb_soma.Name = "rdb_soma";
            rdb_soma.Size = new Size(55, 19);
            rdb_soma.TabIndex = 5;
            rdb_soma.TabStop = true;
            rdb_soma.Text = "Soma";
            rdb_soma.UseVisualStyleBackColor = true;
            // 
            // rdb_pot
            // 
            rdb_pot.AutoSize = true;
            rdb_pot.Location = new Point(6, 122);
            rdb_pot.Name = "rdb_pot";
            rdb_pot.Size = new Size(90, 19);
            rdb_pot.TabIndex = 9;
            rdb_pot.TabStop = true;
            rdb_pot.Text = "Potenciação";
            rdb_pot.UseVisualStyleBackColor = true;
            // 
            // rdb_sub
            // 
            rdb_sub.AutoSize = true;
            rdb_sub.Location = new Point(6, 47);
            rdb_sub.Name = "rdb_sub";
            rdb_sub.Size = new Size(78, 19);
            rdb_sub.TabIndex = 6;
            rdb_sub.TabStop = true;
            rdb_sub.Text = "Subtração";
            rdb_sub.UseVisualStyleBackColor = true;
            // 
            // rdb_div
            // 
            rdb_div.AutoSize = true;
            rdb_div.Location = new Point(6, 97);
            rdb_div.Name = "rdb_div";
            rdb_div.Size = new Size(63, 19);
            rdb_div.TabIndex = 8;
            rdb_div.TabStop = true;
            rdb_div.Text = "Divisão";
            rdb_div.UseVisualStyleBackColor = true;
            // 
            // rdb_mult
            // 
            rdb_mult.AutoSize = true;
            rdb_mult.Location = new Point(6, 72);
            rdb_mult.Name = "rdb_mult";
            rdb_mult.Size = new Size(97, 19);
            rdb_mult.TabIndex = 7;
            rdb_mult.TabStop = true;
            rdb_mult.Text = "Multiplicação";
            rdb_mult.UseVisualStyleBackColor = true;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(45, 210);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(288, 23);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // FormEx008
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 259);
            Controls.Add(btn_calcular);
            Controls.Add(bpx_operação);
            Controls.Add(lbl_num2);
            Controls.Add(txt_num2);
            Controls.Add(lbl_num1);
            Controls.Add(txt_num1);
            Name = "FormEx008";
            Text = "FormsEx008";
            bpx_operação.ResumeLayout(false);
            bpx_operação.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num1;
        private Label lbl_num1;
        private Label lbl_num2;
        private TextBox txt_num2;
        private GroupBox bpx_operação;
        private RadioButton rdb_soma;
        private RadioButton rdb_pot;
        private RadioButton rdb_sub;
        private RadioButton rdb_div;
        private RadioButton rdb_mult;
        private RadioButton rdb_rad;
        private Button btn_calcular;
    }
}