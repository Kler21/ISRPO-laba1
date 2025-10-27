namespace ЛАба_7
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)//Выпадающий список с единицами измерения
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                Izmerenie.Text = "Напишите какой-нибудь объём";
                Izmerenie.ForeColor = Color.Red;
                textBox2.Text = "";
            }
            else
            {

                if (comboBox1.SelectedIndex == 3)//Перевод в километры
                {
                    if (comboBox2.Text == "ДМ³")
                    {
                        value = Math.Abs(value / 1000000000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "СМ³")
                    {
                        value = Math.Abs(value / 1000000000000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "М³")
                    {
                        value = Math.Abs(value / 1000000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "КМ³")
                    {
                        textBox2.Text = textBox1.Text;
                        Izmerenie.Text = "Перевод в ту же единицу измерения";
                        Izmerenie.ForeColor = Color.Black;
                    }

                }
            }


            if (!double.TryParse(textBox1.Text, out value))
            {
                Izmerenie.Text = "Напишите какой-нибудь объём";
                Izmerenie.ForeColor = Color.Red;
                textBox2.Text = "";
            }
            else
            {

                if (comboBox1.SelectedIndex == 2)//Перевод в децеметры
                {
                    if (comboBox2.Text == "КМ³")
                    {
                        value = Math.Abs(value * 1000000000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "СМ³")
                    {
                        value = Math.Abs(value / 1000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "М³")
                    {
                        value = Math.Abs(value * 1000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "ДМ³")
                    {
                        textBox2.Text = textBox1.Text;
                        Izmerenie.Text = "Перевод в ту же единицу измерения";
                        Izmerenie.ForeColor = Color.Black;
                    }

                }
            }


            if (!double.TryParse(textBox1.Text, out value))
            {
                Izmerenie.Text = "Напишите какой-нибудь объём";
                Izmerenie.ForeColor = Color.Red;
                textBox2.Text = "";
            }
            else
            {

                if (comboBox1.SelectedIndex == 1)//Перевод в сантиметры
                {
                    if (comboBox2.Text == "ДМ³")
                    {
                        value = Math.Abs(value * 1000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "КМ³")
                    {
                        value = Math.Abs(value * 1000000000000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "М³")
                    {
                        value = Math.Abs(value * 1000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "СМ³")
                    {
                        textBox2.Text = textBox1.Text;
                        Izmerenie.Text = "Перевод в ту же единицу измерения";
                        Izmerenie.ForeColor = Color.Black;
                    }

                }
            }



            if (!double.TryParse(textBox1.Text, out value))
            {
                Izmerenie.Text = "Напишите какой-нибудь объём";
                Izmerenie.ForeColor = Color.Red;
                textBox2.Text = "";
            }
            else
            {

                if (comboBox1.SelectedIndex == 0)//Перевод в метры
                {
                    if (comboBox2.Text == "ДМ³")
                    {
                        value = Math.Abs(value / 1000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "СМ³")
                    {
                        value = Math.Abs(value / 1000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "КМ³")
                    {
                        value = Math.Abs(value * 1000000000d);
                        textBox2.Text = value.ToString();

                        Izmerenie.Text = "Перевод успешен";
                        Izmerenie.ForeColor = Color.Black;
                    }
                    else if (comboBox2.Text == "М³")
                    {
                        textBox2.Text = textBox1.Text;
                        Izmerenie.Text = "Перевод в ту же единицу измерения";
                        Izmerenie.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//Разрешение на ввод определённых кнопок в textBox
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) // цифры разрешены
                return;
            if (e.KeyChar == (char)Keys.Back)  // BackSpase разрешён
                return;
            e.KeyChar = '\0';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = '\0';//Всё запрещено
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)//Копирует выделенный текст при нажатии сочетания Ctrl+C из textBox2
        {
            if (e.KeyCode == Keys.C)
            {
                Clipboard.SetText(textBox2.SelectedText);
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)//Запрет на контекстное меню с помощью мыши
        {
            if (e.Button == MouseButtons.Right)
            {
                // Отменяем контекстное меню 
                textBox1.ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)//Запрет на контекстное меню с помощью мыши
        {
            if (e.Button == MouseButtons.Right)
            {
                // Отменяем контекстное меню 
                textBox2.ContextMenuStrip = new ContextMenuStrip();
            }
        }
    }
}
