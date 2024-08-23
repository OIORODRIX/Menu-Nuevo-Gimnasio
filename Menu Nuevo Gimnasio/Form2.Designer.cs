namespace Menu_Nuevo_Gimnasio
{
    partial class Form2
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(507, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 42);
            label1.TabIndex = 0;
            label1.Text = "Tabla De Ejercicios";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuText;
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "o Pectoral. Press banca plano. 1 serie de calentamiento y 3 series de trabajo. Repeticiones: 14, 12, 10. ", "o Pres banca inclinado. Idem banco plano. ", "o Aberturas con mancuerna y banco plano. 1 serie de calentamiento y 3 de trabajo. Repeticiones: 14, 12, 10 ", "o Aberturas con mancuerna y banco inclinado. Idem aberturas inclinadas. ", "o Hombro. Elevaciones laterales. 1 series de calentamiento y 4 series de trabajo. Repeticiones: 14, 12, 10, 8 ", "o Tríceps. Extensión de tríceps en polea. 3 series de trabajo. Repeticiones: 16, 14, 12" });
            comboBox1.Location = new Point(55, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(374, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Entrenamiento de pectoral, hombro y tríceps";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.MenuText;
            comboBox2.ForeColor = SystemColors.Window;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "o Espalda. Empujes en polea alta. 1 serie de calentamiento y 4 series de trabajo. Repeticiones: 14, 12, 10, 8 ", "o Empujes en polea baja. Idem ", "o Hiperextensiones. 1 serie de calentamiento y 4 series de trabajo. Repeticiones: 10, 10, 10, 10 ", "o Hombro. Press en multipower. 1 serie de calentamiento y 4 series de tabajo. Repeticiones: 14, 12, 10, 8 ", "o Elevaciones frontales. 3 series de trabajo. 14, 12, 10 ", "o Bíceps. Curl en barra. 4 series de trabajo. Repeticiones: 14, 12, 10, 8 ", "o Curl de martillo con mancuerna. 3 series de trabajo. Repeticiones: 12, 10, 8 " });
            comboBox2.Location = new Point(55, 221);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(374, 23);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "Entrenamiento de espalda, hombro (pres) y bíceps";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.MenuText;
            comboBox3.ForeColor = SystemColors.Window;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "o Cuádriceps. Sentadilla. 1 serie de calentamiento y 4 de trabajo. Repeticiones: 16, 14, 12, 10. o Extensiones. 4 series de trabajo. Repeticiones: 10, 10, 10, 10 ", "o Femoral. Curl de femoral en banco. 1 serie de calentamiento y 4 de trabajo. Repeticiones: 14, 12, 10, 8 ", "o Gemelo. Elevaciones de pie. 1 serie de calentamiento y 4 de trabajo. Repeticiones: 16, 14, 12, 10. " });
            comboBox3.Location = new Point(55, 345);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(374, 23);
            comboBox3.TabIndex = 5;
            comboBox3.Text = "Entrenamiento de pierna ";
            // 
            // button1
            // 
            button1.Location = new Point(1043, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1012, 86);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 8;
            label2.Text = "Entrenamiento Pilates";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1349, 621);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Label label2;
    }
}