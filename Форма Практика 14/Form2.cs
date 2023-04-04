using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_Практика_14
{
    public partial class Form2 : Form
    {

        public string[,] DataPerfomanse1(string[,] data1, int i)
        {
            StreamReader sr = File.OpenText("file1.txt");
            while (!sr.EndOfStream)
            {
                for (int j = 0; j < 6; j++)
                {
                    data1[i, j] = sr.ReadLine();
                }
                i++;
            }
            sr.Close();
            return data1;
        }
        public int CountPerfomanse1()
        {
            StreamReader sr = File.OpenText("file1.txt");
            int count = 0;
            while (!sr.EndOfStream)
            {
                string check = sr.ReadLine();
                if (check == null) break;
                else count++;
            }
            sr.Close();
            return count / 6;
        }
        public string[,] DataPerfomanse2(string[,] data2, int i)
        {
            StreamReader sr = File.OpenText("file2.txt");
            while (!sr.EndOfStream)
            {
                for (int j = 0; j < 7; j++)
                {
                    data2[i, j] = sr.ReadLine();
                }
                i++;
            }
            sr.Close();
            return data2;
        }
        public int CountPerfomanse2()
        {
            StreamReader sr = File.OpenText("file2.txt");
            int count = 0;
            while (!sr.EndOfStream)
            {
                string check = sr.ReadLine();
                if (check == null) break;
                else count++;
            }
            sr.Close();
            return count / 7;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("Название спектакля", "Название спектакля");
            dataGridView1.Columns.Add("Жанр спектакля", "Жанр спектакля");
            dataGridView1.Columns.Add("Автор спектакля", "Автор спектакля");
            dataGridView1.Columns.Add("Режисер спектакля", "Режисер спектакля");
            dataGridView1.Columns.Add("Название театра", "Название театра");
            dataGridView1.Columns.Add("Кол-во раз в сезоне", "Кол-во раз в сезоне");
            dataGridView1.Columns["Название спектакля"].Width = 200;
            dataGridView1.Columns["Жанр спектакля"].Width = 200;
            dataGridView1.Columns["Автор спектакля"].Width = 200;
            dataGridView1.Columns["Режисер спектакля"].Width = 200;
            dataGridView1.Columns["Название театра"].Width = 200;
            dataGridView1.Columns["Кол-во раз в сезоне"].Width = 200;
            count_perfomant = CountPerfomanse1();
            string[,] data_perfomant = new string[count_perfomant, 6];
            data_perfomant = DataPerfomanse1(data_perfomant, 0);
            dataGridView1.RowCount = data_perfomant.GetLength(0);
            dataGridView1.ColumnCount = data_perfomant.GetLength(1);
            for (int i = 0; i < data_perfomant.GetLength(0); i++)
            {
                for (int j = 0; j < data_perfomant.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = data_perfomant[i, j];
                }
            }
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Columns.Add("Название спектакля", "Название спектакля");
            dataGridView2.Columns.Add("Жанр спектакля", "Жанр спектакля");
            dataGridView2.Columns.Add("Автор спектакля", "Автор спектакля");
            dataGridView2.Columns.Add("Режисер спектакля", "Режисер спектакля");
            dataGridView2.Columns.Add("Дата начала гастролей", "Дата начала гастролей");
            dataGridView2.Columns.Add("Конца начала гастролей", "Конца начала гастролей");
            dataGridView2.Columns.Add("Площадка гастролей", "Площадка гастролей");
            dataGridView2.Columns["Название спектакля"].Width = 200;
            dataGridView2.Columns["Жанр спектакля"].Width = 200;
            dataGridView2.Columns["Автор спектакля"].Width = 200;
            dataGridView2.Columns["Режисер спектакля"].Width = 200;
            dataGridView2.Columns["Дата начала гастролей"].Width = 200;
            dataGridView2.Columns["Конца начала гастролей"].Width = 200;
            dataGridView2.Columns["Площадка гастролей"].Width = 200;
            data_perfomant = new string[count_perfomant, 7];
            count_perfomant = CountPerfomanse2();
            data_perfomant = new string[count_perfomant, 7];
            data_perfomant = DataPerfomanse2(data_perfomant, 0);
            dataGridView2.RowCount = data_perfomant.GetLength(0);
            dataGridView2.ColumnCount = data_perfomant.GetLength(1);
            for (int i = 0; i < data_perfomant.GetLength(0); i++)
            {
                for (int j = 0; j < data_perfomant.GetLength(1); j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = data_perfomant[i, j];
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectRow = dataGridView1.SelectedRows[0].DataBoundItem as TextBox;
            textBox1.Text = selectRow.Name;
            textBox2.Text = selectRow.Genre;
            textBox3.Text = selectRow.Autor;
            textBox4.Text = selectRow.Director;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            dataGridView1.Refresh();
            //int selecttedRow = dataGridView1.SelectedCells[0].RowIndex;
            //dataGridView1.Rows.RemoveAt(selecttedRow);
            //count_perfomant = CountPerfomanse();
            //string[,] data = new string[count_perfomant, 6];
            //data = DataPerfomanse(data, 0);
            //string[,] new_data = new string[data.GetLength(0) - 1, data.GetLength(1)];
            //int j = 0;
            //for (int i = 0; i < data.GetLength(0); i++)
            //{
            //    if (1 != selecttedRow)
            //    {
            //        for (int h = 0; h < data.GetLength(1); h++)
            //        {
            //            new_data[i, h] = data[i, h];
            //        }
            //        j++;
            //    }
            //}
            //data = new_data;
            //StreamWriter sw = File.AppendText("file1.txt");
            //File.WriteAllText("fale1.txt", "");
            //for (int i = 0; i < new_data.GetLength(0); i++)
            //{
            //    for (int h = 0; h < new_data.GetLength(1); h++)
            //    {
            //        sw.WriteLine(new_data[i, h]);
            //    }
            //}
        }

        int count_perfomant = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            int index = dataGridView1.CurrentCell.RowIndex;
            count_perfomant = CountPerfomanse1();
            string[,] data = new string[count_perfomant, 6];
            textBox1.Text = data[index, 0];
            textBox2.Text = data[index, 1];
            textBox3.Text = data[index, 2];
            textBox4.Text = data[index, 3];
            textBox5.Text = data[index, 4];
            textBox6.Text = data[index, 5];
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
