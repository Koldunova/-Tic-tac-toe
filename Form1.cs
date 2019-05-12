using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        int[,] mas = new int[3, 3];
        int flag = 1;
        bool pc_r=false;
        //1- нолик 2-крестик
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Ходит синий (круг)";
            zap();
            textBox2.Text = "Играете с другом";

        }

        void pc()
        {
            if (flag == 2)
            {
                Random r = new Random();
                int x = -1;
                int y = -1;
                int fl = 0;
                while (fl != 1)
                {
                    x = r.Next(0, 3);
                    y = r.Next(0, 3);
                    Console.WriteLine("x= "+ x+"y= "+y);
                    if (mas[x, y] == 0)
                    {
                        fl = 1;
                    }
                    else
                    {

                        fl = 0;
                    }
                }
                if (x == 0)
                {
                    if (y == 0)
                    {
                        pictureBox7.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                    if (y == 1)
                    {
                        pictureBox8.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                    if (y == 2)
                    {
                        pictureBox2.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                }

                if (x == 1)
                {
                    if (y == 0)
                    {
                        pictureBox9.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                    if (y == 1)
                    {
                        pictureBox3.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                    if (y == 2)
                    {
                        pictureBox5.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                }

                if (x == 2)
                {
                    if (y == 0)
                    {
                        pictureBox10.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                    if (y == 1)
                    {
                        pictureBox4.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                    if (y == 2)
                    {
                        pictureBox6.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                        mas[x, y] = 2;
                    }
                }
                flag = 1;
            }
        }

        void zap()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas[i, j] = 0;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (mas[0, 0] != 1 && mas[0, 0] != 2)
            {
                if (flag == 1)
                {
                    pictureBox7.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[0, 0] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox7.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[0, 0] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (mas[0, 1] != 1 && mas[0, 1] != 2)
            {
                if (flag == 1)
                {
                    pictureBox8.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[0, 1] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox8.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[0, 1] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (mas[0, 2] != 1 && mas[0, 2] != 2)
            {
                if (flag == 1)
                {
                    pictureBox2.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[0, 2] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox2.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[0, 2] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (mas[1, 0] != 1 && mas[1, 0] != 2)
            {
                if (flag == 1)
                {
                    pictureBox9.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[1, 0] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox9.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[1, 0] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (mas[1, 1] != 1 && mas[1, 1] != 2)
            {
                if (flag == 1)
                {
                    pictureBox3.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[1, 1] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox3.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[1, 1] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (mas[1, 2] != 1 && mas[1, 2] != 2)
            {
                if (flag == 1)
                {
                    pictureBox5.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[1, 2] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox5.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[1, 2] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (mas[2, 0] != 1 && mas[2, 0] != 2)
            {
                if (flag == 1)
                {
                    pictureBox10.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[2, 0] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox10.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[2, 0] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (mas[2, 1] != 1 && mas[2, 1] != 2)
            {
                if (flag == 1)
                {
                    pictureBox4.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[2, 1] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox4.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[2, 1] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (mas[2, 2] != 1 && mas[2, 2] != 2)
            {
                if (flag == 1)
                {
                    pictureBox6.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\ноль.png");
                    flag = 2;
                    mas[2, 2] = 1;
                    textBox1.Text = "Ходит красный (крестик)";
                }
                else
                {
                    pictureBox6.Load(@"D:\ПРОГРАММИРОВАНИЕ\КРЕСТИКИ НОЛИКИ\крестик.png");
                    flag = 1;
                    mas[2, 2] = 2;
                    textBox1.Text = "Ходит синий (круг)";
                }
            }
            vin();
        }
        //1- нолик 2-крестик

        

        public void vin()
        {
            //горизонтали
            int f = 0;
            
            if (mas[0, 0] == 1 && mas[0, 1] == 1 && mas[0, 2] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }
            if (mas[1, 0] == 1 && mas[1, 1] == 1 && mas[1, 2] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }
            if (mas[2, 0] == 1 && mas[2, 1] == 1 && mas[2, 2] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }
            if (mas[0, 0] == 2 && mas[0, 1] == 2 && mas[0, 2] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            if (mas[1, 0] == 2 && mas[1, 1] == 2 && mas[1, 2] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            if (mas[2, 0] == 2 && mas[2, 1] == 2 && mas[2, 2] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            //вертикали
            if (mas[0, 0] == 1 && mas[1, 0] == 1 && mas[2, 0] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }
            if (mas[0, 1] == 1 && mas[1, 1] == 1 && mas[2, 1] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }
            if (mas[0, 2] == 1 && mas[1, 2] == 1 && mas[2, 2] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }

            if (mas[0, 0] == 2 && mas[1, 0] == 2 && mas[2, 0] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            if (mas[0, 1] == 2 && mas[1, 1] == 2 && mas[2, 1] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            if (mas[0, 2] == 2 && mas[1, 2] == 2 && mas[2, 2] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            //диагонали
            if (mas[0, 2] == 1 && mas[1, 1] == 1 && mas[2, 0] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }
            if (mas[0, 0] == 1 && mas[1, 1] == 1 && mas[2, 2] == 1)
            {
                textBox1.Text = "Победил синий (круг)";
                f = 1;
            }

            if (mas[0, 2] == 2 && mas[1, 1] == 2 && mas[2, 0] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }
            if (mas[0, 0] == 2 && mas[1, 1] == 2 && mas[2, 2] == 2)
            {
                textBox1.Text = "Победил красный (крестик)";
                f = 1;
            }

            int fl = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mas[i, j] != 0)
                    {
                        fl +=1;
                    }
                }
            }
            if (fl == 9)
            {
                textBox1.Text = "Ничья";
            }
            if (f == 1)
            {
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;

            }
            if (pc_r == true && f==0)
            {
                pc();
                textBox1.Text = "Ходит синий (круг)";
                if (mas[0, 0] == 1 && mas[0, 1] == 1 && mas[0, 2] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }
                if (mas[1, 0] == 1 && mas[1, 1] == 1 && mas[1, 2] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }
                if (mas[2, 0] == 1 && mas[2, 1] == 1 && mas[2, 2] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }
                if (mas[0, 0] == 2 && mas[0, 1] == 2 && mas[0, 2] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                if (mas[1, 0] == 2 && mas[1, 1] == 2 && mas[1, 2] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                if (mas[2, 0] == 2 && mas[2, 1] == 2 && mas[2, 2] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                //вертикали
                if (mas[0, 0] == 1 && mas[1, 0] == 1 && mas[2, 0] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }
                if (mas[0, 1] == 1 && mas[1, 1] == 1 && mas[2, 1] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }
                if (mas[0, 2] == 1 && mas[1, 2] == 1 && mas[2, 2] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }

                if (mas[0, 0] == 2 && mas[1, 0] == 2 && mas[2, 0] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                if (mas[0, 1] == 2 && mas[1, 1] == 2 && mas[2, 1] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                if (mas[0, 2] == 2 && mas[1, 2] == 2 && mas[2, 2] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                //диагонали
                if (mas[0, 2] == 1 && mas[1, 1] == 1 && mas[2, 0] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }
                if (mas[0, 0] == 1 && mas[1, 1] == 1 && mas[2, 2] == 1)
                {
                    textBox1.Text = "Победил синий (круг)";
                    f = 1;
                }

                if (mas[0, 2] == 2 && mas[1, 1] == 2 && mas[2, 0] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                if (mas[0, 0] == 2 && mas[1, 1] == 2 && mas[2, 2] == 2)
                {
                    textBox1.Text = "Победил красный (крестик)";
                    f = 1;
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            textBox1.Text = "Ходит синий (круг)";
            zap();
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc_r = !(pc_r);
            flag = 1;
            textBox1.Text = "Ходит синий (круг)";
            zap();
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            if (pc_r == true)
            {
                textBox2.Text = "Вы играете с ПК";
            }
            else
            {
                textBox2.Text = "Играете с другом";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
