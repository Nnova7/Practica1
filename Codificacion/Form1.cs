namespace Codificacion
{
    public partial class Form1 : Form
    {
        private int[] LeerBits()
        {
            // Si usas TextBoxes
            return new int[]
            {
         int.Parse(textBox1.Text),
         int.Parse(textBox2.Text),
         int.Parse(textBox3.Text),
         int.Parse(textBox4.Text),
         int.Parse(textBox5.Text),
         int.Parse(textBox6.Text),
         int.Parse(textBox7.Text),
         int.Parse(textBox8.Text),
         int.Parse(textBox9.Text),
         int.Parse(textBox10.Text)
            };
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox1.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox2.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void cmbCodificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodificacion.SelectedItem != null)
                textBox11.Text = cmbCodificacion.SelectedItem.ToString();

            var bits = LeerBits();
            switch (cmbCodificacion.SelectedItem.ToString())
            {
                case "No retorno a cero-nivel (NRZ-L)":
                    DibujarNRZ_L(bits);
                    break;
                case "No retorno a cero Invertido (NRZ-I)":
                    DibujarNRZ_I(bits);
                    break;
                case "Bipolar AMI":
                    DibujarBipolarAMI(bits);
                    break;
                case "Pseudoterminario":
                    //DibujarPseudoterminario(bits);
                    break;
                case "Manchester":
                    //DibujarManchester(bits);
                    break;
                case "Código diferencial":
                    //DibujarCodigoDiferencial(bits);
                    break;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox3.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox4.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox5.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox6.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox7.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox8.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox9.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo si el TextBox está vacío y la tecla es '0' o '1'
            if ((e.KeyChar == '0' || e.KeyChar == '1') && textBox10.Text.Length == 0)
            {
                e.Handled = false; // Aceptar
            }
            else if (char.IsControl(e.KeyChar)) // Permitir borrar (Backspace, Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquear todo lo demás
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox de bits (1 al 10)
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            // Limpiar TextBox11
            textBox11.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DibujarNRZ_L(int[] bits)
        {
            Graphics lienzo = panelGrafica.CreateGraphics();
            lienzo.Clear(Color.White);

            Pen lapiz = new Pen(Color.Black, 2);
            Font fuente = new Font("Arial", 16, FontStyle.Bold);
            Brush pincel = Brushes.Black;

            int anchoCel = 100;
            int altUno = 80;
            int altCel = 200;
            int margenSup = 40;

            // calcular el ancho total del gráfico para centrarlo en el panel
            int anchoTot = bits.Length * anchoCel;
            int centro = panelGrafica.Width / 2;
            int xIni = centro - (anchoTot / 2);

            int x = xIni;
            // dibujar las etiquetas 1 y 0 al lado izquierdo
            lienzo.DrawString("1", fuente, pincel, xIni - 30, altUno - 10);
            lienzo.DrawString("0", fuente, pincel, xIni - 30, altCel - 10);
            for (int i = 0; i < bits.Length; i++)
            {
                int y = bits[i] == 1 ? altUno : altCel;
                // dibujar el valor del bit arriba de la celda
                string bitTxt = bits[i].ToString();
                SizeF tamTxt = lienzo.MeasureString(bitTxt, fuente);
                float txtX = x + (anchoCel / 2) - (tamTxt.Width / 2);
                lienzo.DrawString(bitTxt, fuente, pincel, txtX, margenSup);
                // dibujar línea horizontal que representa el nivel
                lienzo.DrawLine(lapiz, x, y, x + anchoCel, y);
                // si cambia el nivel respecto al bit anterior, dibujar línea vertical
                if (i > 0 && bits[i] != bits[i - 1])
                {
                    int yAnt = bits[i - 1] == 1 ? altUno : altCel;
                    lienzo.DrawLine(lapiz, x, yAnt, x, y);
                }
                // dibujar línea vertical de la cuadrícula
                lienzo.DrawLine(Pens.LightGray, x, altUno - 40, x, altCel + 40);
                // dibujar líneas horizontales de la cuadrícula
                lienzo.DrawLine(Pens.LightGray, x, altUno, x + anchoCel, altUno);
                lienzo.DrawLine(Pens.LightGray, x, altCel, x + anchoCel, altCel);
                x += anchoCel;
            }

            // dibujar la última línea vertical de la cuadrícula
            lienzo.DrawLine(Pens.LightGray, x, altUno - 40, x, altCel + 40);
        }


        private void DibujarNRZ_I(int[] bits)
        {
            Graphics lienzo = panelGrafica.CreateGraphics();
            lienzo.Clear(Color.White);

            Pen lapiz = new Pen(Color.Black, 2);
            Font fuente = new Font("Arial", 16, FontStyle.Bold);
            Brush pincel = Brushes.Black;

            int anchoCel = 100;
            int altUno = 80;
            int altCel = 200;
            int margenSup = 40;

            int anchoTot = bits.Length * anchoCel;
            int centro = panelGrafica.Width / 2;
            int xIni = centro - (anchoTot / 2);
            int x = xIni;

            // nivel actual, comienza en bajo (altCel)
            int yAct = altCel;

            // etiquetas al lado izquierdo
            lienzo.DrawString("1", fuente, pincel, xIni - 30, altUno - 10);
            lienzo.DrawString("0", fuente, pincel, xIni - 30, altCel - 10);

            for (int i = 0; i < bits.Length; i++)
            {
                // invertir nivel si el bit es 1
                if (bits[i] == 1)
                {
                    yAct = yAct == altUno ? altCel : altUno;
                }

                // texto del bit arriba
                string bitTxt = bits[i].ToString();
                SizeF tamTxt = lienzo.MeasureString(bitTxt, fuente);
                float txtX = x + (anchoCel / 2) - (tamTxt.Width / 2);
                lienzo.DrawString(bitTxt, fuente, pincel, txtX, margenSup);

                // línea horizontal
                lienzo.DrawLine(lapiz, x, yAct, x + anchoCel, yAct);

                // si no es el primer bit y el nivel cambió, dibujar línea vertical
                if (i > 0 && bits[i] == 1)
                {
                    int yAnt = yAct == altUno ? altCel : altUno;
                    lienzo.DrawLine(lapiz, x, yAnt, x, yAct);
                }

                // cuadrícula vertical
                lienzo.DrawLine(Pens.LightGray, x, altUno - 40, x, altCel + 40);
                // cuadrícula horizontal
                lienzo.DrawLine(Pens.LightGray, x, altUno, x + anchoCel, altUno);
                lienzo.DrawLine(Pens.LightGray, x, altCel, x + anchoCel, altCel);

                x += anchoCel;
            }

            // última línea de cuadrícula vertical
            lienzo.DrawLine(Pens.LightGray, x, altUno - 40, x, altCel + 40);
        }

        private void DibujarBipolarAMI(int[] bits)
        {
            Graphics lienzo = panelGrafica.CreateGraphics();
            lienzo.Clear(Color.White);

            Pen lapiz = new Pen(Color.Black, 2);
            Font fuente = new Font("Arial", 16, FontStyle.Bold);
            Brush pincel = Brushes.Black;

            int anchoCel = 100;
            int altPos = 80;
            int altCero = 140;
            int altNeg = 200;
            int margenSup = 40;

            int anchoTot = bits.Length * anchoCel;
            int centro = panelGrafica.Width / 2;
            int xIni = centro - (anchoTot / 2);
            int x = xIni;

            bool nivelPositivo = true;

            lienzo.DrawString("+1", fuente, pincel, xIni - 38, altPos - 10);
            lienzo.DrawString("0", fuente, pincel, xIni - 30, altCero - 10);
            lienzo.DrawString("-1", fuente, pincel, xIni - 30, altNeg - 10);

            int yAnt = altCero; // empieza desde nivel cero

            for (int i = 0; i < bits.Length; i++)
            {
                int y = altCero;

                if (bits[i] == 1)
                {
                    if (nivelPositivo)
                    {
                        y = altPos;
                    }
                    else
                    {
                        y = altNeg;
                    }

                    nivelPositivo = !nivelPositivo;
                }

                // dibujar bit
                string bitTxt = bits[i].ToString();
                SizeF tamTxt = lienzo.MeasureString(bitTxt, fuente);
                float txtX = x + (anchoCel / 2) - (tamTxt.Width / 2);
                lienzo.DrawString(bitTxt, fuente, pincel, txtX, margenSup);

                // línea horizontal
                lienzo.DrawLine(lapiz, x, y, x + anchoCel, y);

                // línea vertical si cambia de nivel
                if (i > 0 && yAnt != y)
                {
                    lienzo.DrawLine(lapiz, x, yAnt, x, y);
                }

                // cuadrícula
                lienzo.DrawLine(Pens.LightGray, x, altPos - 40, x, altNeg + 40);
                lienzo.DrawLine(Pens.LightGray, x, altPos, x + anchoCel, altPos);
                lienzo.DrawLine(Pens.LightGray, x, altCero, x + anchoCel, altCero);
                lienzo.DrawLine(Pens.LightGray, x, altNeg, x + anchoCel, altNeg);

                yAnt = y;
                x += anchoCel;
            }

            lienzo.DrawLine(Pens.LightGray, x, altPos - 40, x, altNeg + 40);
        }

    }
}
