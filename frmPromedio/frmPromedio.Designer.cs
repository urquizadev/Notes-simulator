namespace frmPromedio
{
    partial class frmPromedio
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
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtCond = new TextBox();
            label6 = new Label();
            txtProm = new TextBox();
            label5 = new Label();
            txtNot4 = new TextBox();
            label4 = new Label();
            txtNot2 = new TextBox();
            label3 = new Label();
            txtNot3 = new TextBox();
            label1 = new Label();
            txtNot1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(325, 319);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(69, 29);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(180, 319);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(69, 29);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(21, 319);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(69, 29);
            btnCalcular.TabIndex = 28;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCond
            // 
            txtCond.Location = new Point(117, 249);
            txtCond.Name = "txtCond";
            txtCond.Size = new Size(215, 23);
            txtCond.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 252);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 26;
            label6.Text = "Condicion:";
            // 
            // txtProm
            // 
            txtProm.Location = new Point(117, 202);
            txtProm.Name = "txtProm";
            txtProm.Size = new Size(100, 23);
            txtProm.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 205);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 24;
            label5.Text = "Promedio:";
            // 
            // txtNot4
            // 
            txtNot4.Location = new Point(117, 158);
            txtNot4.Name = "txtNot4";
            txtNot4.Size = new Size(100, 23);
            txtNot4.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 161);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 22;
            label4.Text = "Nota 4:";
            // 
            // txtNot2
            // 
            txtNot2.Location = new Point(117, 61);
            txtNot2.Name = "txtNot2";
            txtNot2.Size = new Size(100, 23);
            txtNot2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 64);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 20;
            label3.Text = "Nota 2:";
            // 
            // txtNot3
            // 
            txtNot3.Location = new Point(117, 108);
            txtNot3.Name = "txtNot3";
            txtNot3.Size = new Size(100, 23);
            txtNot3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 111);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 18;
            label1.Text = "Nota 3:";
            // 
            // txtNot1
            // 
            txtNot1.Location = new Point(117, 20);
            txtNot1.Name = "txtNot1";
            txtNot1.Size = new Size(100, 23);
            txtNot1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 16;
            label2.Text = "Nota 1:";
            // 
            // frmPromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 372);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtCond);
            Controls.Add(label6);
            Controls.Add(txtProm);
            Controls.Add(label5);
            Controls.Add(txtNot4);
            Controls.Add(label4);
            Controls.Add(txtNot2);
            Controls.Add(label3);
            Controls.Add(txtNot3);
            Controls.Add(label1);
            Controls.Add(txtNot1);
            Controls.Add(label2);
            Name = "frmPromedio";
            Text = "frmPromedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtCond;
        private Label label6;
        private TextBox txtProm;
        private Label label5;
        private TextBox txtNot4;
        private Label label4;
        private TextBox txtNot2;
        private Label label3;
        private TextBox txtNot3;
        private Label label1;
        private TextBox txtNot1;
        private Label label2;
    }
}