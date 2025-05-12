namespace Codificacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox13 = new TextBox();
            buttonBorrar = new Button();
            buttonSalir = new Button();
            cmbCodificacion = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            panelGrafica = new Panel();
            textBox11 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 31);
            textBox1.TabIndex = 17;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox13.Location = new Point(424, 47);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(439, 48);
            textBox13.TabIndex = 12;
            textBox13.Text = "INGRESA LOS VALORES";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(51, 658);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(269, 55);
            buttonBorrar.TabIndex = 14;
            buttonBorrar.Text = "BORRAR";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(932, 658);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(269, 55);
            buttonSalir.TabIndex = 15;
            buttonSalir.Text = "SALIR";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // cmbCodificacion
            // 
            cmbCodificacion.FormattingEnabled = true;
            cmbCodificacion.Items.AddRange(new object[] { "No retorno a cero-nivel (NRZ-L)", "No retorno a cero Invertido (NRZ-I)", "Bipolar AMI", "Pseudoternario", "Manchester", "Código diferencial" });
            cmbCodificacion.Location = new Point(492, 670);
            cmbCodificacion.Name = "cmbCodificacion";
            cmbCodificacion.Size = new Size(233, 33);
            cmbCodificacion.TabIndex = 16;
            cmbCodificacion.Text = "Elegir...";
            cmbCodificacion.SelectedIndexChanged += cmbCodificacion_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 31);
            textBox2.TabIndex = 18;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 31);
            textBox3.TabIndex = 19;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(424, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(85, 31);
            textBox4.TabIndex = 20;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(536, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(85, 31);
            textBox5.TabIndex = 21;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(650, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(85, 31);
            textBox6.TabIndex = 22;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(765, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(85, 31);
            textBox7.TabIndex = 23;
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.KeyPress += textBox7_KeyPress;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(874, 131);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(85, 31);
            textBox8.TabIndex = 24;
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.KeyPress += textBox8_KeyPress;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(985, 131);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(85, 31);
            textBox9.TabIndex = 25;
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.KeyPress += textBox9_KeyPress;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1090, 131);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(85, 31);
            textBox10.TabIndex = 26;
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.KeyPress += textBox10_KeyPress;
            // 
            // panelGrafica
            // 
            panelGrafica.Location = new Point(97, 254);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Size = new Size(1078, 374);
            panelGrafica.TabIndex = 13;
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(437, 201);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(413, 31);
            textBox11.TabIndex = 27;
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.WordWrap = false;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 811);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(cmbCodificacion);
            Controls.Add(buttonSalir);
            Controls.Add(buttonBorrar);
            Controls.Add(panelGrafica);
            Controls.Add(textBox13);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox13;
        private Button buttonBorrar;
        private Button buttonSalir;
        private ComboBox cmbCodificacion;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Panel panelGrafica;
        private TextBox textBox11;
    }
}
