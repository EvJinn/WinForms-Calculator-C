using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N3
{
    public partial class Form1 : Form
    {
        char symb;
        double a, b, j, result;
        int i = 1;
        List<double> digit = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "1"; //Конкатенация 1 с уже имеющимся текстом в текстбоксе
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "2"; //Конкатенация 2 с уже имеющимся текстом в текстбоксе
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "3"; //Конкатенация 3 с уже имеющимся текстом в текстбоксе
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "4"; //Конкатенация 4 с уже имеющимся текстом в текстбоксе
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "5"; //Конкатенация 5 с уже имеющимся текстом в текстбоксе
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "6"; //Конкатенация 6 с уже имеющимся текстом в текстбоксе
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "7"; //Конкатенация 7 с уже имеющимся текстом в текстбоксе
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "8"; //Конкатенация 8 с уже имеющимся текстом в текстбоксе
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "9"; //Конкатенация 9 с уже имеющимся текстом в текстбоксе
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "0"; //Конкатенация 0 с уже имеющимся текстом в текстбоксе
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + ","; //Конкатенация запятой с уже имеющимся текстом в текстбоксе
        }

        private void button_plusminus_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1) symb = 'p'; //Если первое число, то сохраняем символ для обработки после нажатия знака равно, для вывода полученного числа
            string str;
            str = Convert.ToString(resultBox.Text); //Получаем строку из текстбокса
            int n = str.Length;
            if (n != 0) //Проверка на пустоту в текстбоксе, иначе ошибку выдаёт при нажатии кнопки
            {
                j = Convert.ToDouble(resultBox.Text);   //Получаем строку из текстбокса и конвертируем её в double
                j = 0 - j;                              //Отнимаем значение от нуля для получения противоположного знака
                resultBox.Text = j.ToString();          //Записываем результат в текстбокс, конвертируя в строку
                j = 0;                                  //Обнуление переменной на всякий случай
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            symb = '/'; //Символ для обработки нажатия на кнопку равно
            string str;
            str = Convert.ToString(resultBox.Text);  //Получаем строку из текстбокса
            int n = str.Length;
            if (n != 0) //Проверка на пустоту в текстбоксе, иначе ошибку выдаёт при нажатии кнопки
            {
                a = Convert.ToDouble(resultBox.Text); //Получаем из текстбокса строку и конвертируем её в double
                if (i % 2 == 1) //Хитрая система, чтобы можно было считать больше двух действий.
                {
                    resultBox.Text = "";
                    digit.Add(a); //В первый и последующий нечётные разы просто записываем полученное число в список и прибавляем счётчик
                    i++;
                }
                else
                    if (i % 2 == 0) //Во второй и последующие чётные проводим нужную операцию и очищаем вектор, и также прибавляем счётчик.
                    {               //Значения всё равно везде берутся из текстбокса.
                        digit.Add(a);                       //Записываем полученное число в конец вектора
                        result = digit[0] / digit[1];       //Считаем
                        digit.Clear();                      //Очищаем полностью список
                        resultBox.Text = result.ToString(); //Выводим результат в текстбокс 
                        i++;                                //Прибавляем счётчик
                    }   //В +, - и * все действия абсолютно такие же.
            }
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            symb = '*';
            string str;
            str = Convert.ToString(resultBox.Text);
            int n = str.Length;
            if (n != 0)
            {
                a = Convert.ToDouble(resultBox.Text);
                if (i % 2 == 1)
                {
                    resultBox.Text = "";
                    digit.Add(a);
                    i++;
                }
                else
                    if (i % 2 == 0)
                {
                    digit.Add(a);
                    result = digit[0] * digit[1];
                    digit.Clear();
                    resultBox.Text = result.ToString();
                    i++;
                }
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            symb = '-';
            string str;
            str = Convert.ToString(resultBox.Text);
            int n = str.Length;
            if (n != 0)
            {
                a = Convert.ToDouble(resultBox.Text);
                if (i % 2 == 1)
                {
                    resultBox.Text = "";
                    digit.Add(a);
                    i++;
                }
                else
                    if (i % 2 == 0)
                {
                    digit.Add(a);
                    result = digit[0] - digit[1];
                    digit.Clear();
                    resultBox.Text = result.ToString();
                    i++;
                }
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            symb = '+';
            string str;
            str = Convert.ToString(resultBox.Text);
            int n = str.Length;
            if (n != 0)
            {
                a = Convert.ToDouble(resultBox.Text);
                if (i % 2 == 1)
                {
                    resultBox.Text = "";
                    digit.Add(a);
                    i++;
                }
                else
                    if (i % 2 == 0)
                {
                    digit.Add(a);
                    result = digit[0] + digit[1];
                    digit.Clear();
                    resultBox.Text = result.ToString();
                    i++;
                }
            }
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            string str;
            str = Convert.ToString(resultBox.Text); //Получаем строку из текстбокса
            int n = str.Length;
            if (n != 0) //Проверка на пустоту в текстбоксе, иначе ошибку выдаёт при нажатии кнопки
            {
                int k = str.Length - 1;
                string str2;
                str2 = str.Remove(k, 1);
                resultBox.Text = str2;
            }
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            resultBox.Clear(); //Очищаем текстбокс
            a = 0; //Обнуляем все переменные и очищаем список. Счётчик устанавливаем на единицу.
            b = 0;
            digit.Clear();
            i = 1;
            result = 0;
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            string str;
            str = Convert.ToString(resultBox.Text); //Получаем строку из текстбокса
            int n = str.Length;
            if (n != 0) //Проверка на пустоту в текстбоксе, иначе ошибку выдаёт при нажатии кнопки
            {
                if (digit.Count != 0) //Если список не пустой (в нём должен оставаться 1 элемент с числом)
                {
                    b = Convert.ToDouble(resultBox.Text); //Считываем строку, конвертируем её в double
                    if (symb == '/') result = digit[0] / b; //Проверка пришедшего символа операции и её выполнение
                    if (symb == '*') result = digit[0] * b;
                    if (symb == '+') result = digit[0] + b;
                    if (symb == '-') result = digit[0] - b;
                    if (symb == 'p') result = b; //Для операции смены знака просто записываем полученное число ещё раз
                }
                else //Если список оказался пустым
                {
                    b = Convert.ToDouble(resultBox.Text); //Считываем строку, конвертируем её в double
                    result = b; //Записываем число ещё раз
                }
                resultBox.Text = result.ToString(); //Вывод полученного результата в текстбокс
                digit.Clear(); //Очистка списка
                symb = ' '; //Очистка символа операции
                b = 0; //Обнуление переменной
                i = 1; //Установка счётчика на 1
            }
        }
    }
}
