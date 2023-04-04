using Практика_14;
namespace Форма_Практика_14
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        bool error = false;
        string st_error = "";
        string pusto = "";
        int count_perfomant = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else 
            {
                groupBox1.Visible = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
        }
      
        public bool Proverca(string st)
        {  bool error = false;
            st = st.ToUpper();
            foreach (char c in st)
            {
                if ((c >= 'А') && (c <= 'Я'))
                {
                    error = true;
                }
            else
            {
                //MessageBox.Show("Можно использовать только русские буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                st_error = "Можно использовать только русские буквы\n";
                    error = false;
                    break; 
                }
            }
            
            return error;
        }
        public bool Proverca1(string st)
        {
            bool error = false;
            foreach (char c in st)
            {
                if (char.IsNumber(c))
                {
                    error = true;
                }
            }
            if (error == false)
            {
                st_error += "Количество сезонов должно быть заполнено числом\n";
                //MessageBox.Show("Количество сезонов должно быть заполнено числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return error;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string global_error = "";
            st_error = "";
            pusto = "";
            error = false;
            if (textBox1.Text == String.Empty)
            {
                pusto += "\nЯчейка названия театра пуста";
            }
            if (textBox2.Text == String.Empty)
            {
                pusto += "\nЯчейка сезонов пуста";
            }
            if (textBox3.Text == String.Empty)
            {
                pusto += "\nЯчейка названия спектакля пуста";
            }
            if (textBox4.Text == String.Empty)
            {
                pusto += "\nЯчейка жанра спектакля пуста";
            }
            if (textBox5.Text == String.Empty)
            {
                pusto += "\nЯчейка автора спектакля пуста";
            }
            if (textBox2.Text == String.Empty)
            {
                pusto += "\nЯчейка режисера спектакля пуста";
            }
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            string t5 = textBox5.Text;
            string t6 = textBox6.Text;
            global_error = st_error + pusto;
            if (global_error == "")
            {
                if (Proverca1(t2) && Proverca(t1) && Proverca(t3) && Proverca(t4) && Proverca(t5) && Proverca(t6))
                {
                    string vivod = $"Название спектакля {t3}\n" +
                    $"Жанр спектакля {t4}\n" +
                    $"Автор спектакля {t5}\n" +
                    $"Режисер спектакля {t6}\n" +
                    $"Название театра {t1}\n" +
                    $"Кол-во раз в сезоне {t2}\n";
                    StreamWriter sw = File.AppendText("file1.txt");
                    sw.Write(vivod);
                    sw.Close();
                    MessageBox.Show("Успешно занесено в файл", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show(st_error);
                }
            }
            else
            {
                MessageBox.Show(global_error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string global_error = "";
            st_error = "";
            pusto = "";
            error = false;
            if (textBox11.Text == String.Empty)
            {
                pusto += "\nЯчейка площадки спектакля пуста";
            }
            if (textBox10.Text == String.Empty)
            {
                pusto += "\nЯчейка названия спектакля пуста";
            }
            if (textBox9.Text == String.Empty)
            {
                pusto += "\nЯчейка жанра спектакля пуста";
            }
            if (textBox8.Text == String.Empty)
            {
                pusto += "\nЯчейка автора спектакля пуста";
            }
            if (textBox7.Text == String.Empty)
            {
                pusto += "\nЯчейка режисера спектакля пуста";
            }
            string t11 = textBox11.Text;
            string t10 = textBox10.Text;
            string t9 = textBox9.Text;
            string t8 = textBox8.Text;
            string t7 = textBox7.Text;
            /*error = Proverca(t11);
            error = Proverca(t10);
            error = Proverca(t9);
            error = Proverca(t8);
            error = Proverca(t7);*/
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                st_error += "Дата начала не может быть больше даты конца\n";
            }
            global_error = st_error + pusto;
            if (global_error == "")
            {
                if (Proverca(t11) && Proverca(t10) && Proverca(t9) && Proverca(t8) && Proverca(t7))
                {
                    string vivod = $"Название спектакля {t10}\n" +
                    $"Жанр спектакля {t9}\n" +
                    $"Автор спектакля {t8}\n" +
                    $"Режисер спектакля {t7}\n" +
                    $"Площадка театра {t11}\n" +
                    $"Дата начала {dateTimePicker1.Value}\n" +
                    $"Дата конца {dateTimePicker2.Value}\n";
                    StreamWriter sw = File.AppendText("file2.txt");
                    sw.Write(vivod);
                    sw.Close();
                    MessageBox.Show("Успешно занесено в файл", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(st_error);
                }
            }
            else
            {
                MessageBox.Show(global_error, "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}