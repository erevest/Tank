using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1111
{
  public partial class Form1 : Form
  {
    int dvig;
    public Form1()
    {
      InitializeComponent();
      dvig = 0;
    }

        private void button1_Click(object sender, EventArgs e)
        {
        // Объявляем объект "g" класса Graphics и предоставляем
        // ему возможность рисования на pictureBox1:
        Graphics g = pictureBox1.CreateGraphics();
        g.Clear(Color.DarkOrange);
        // Создаем объекты-кисти для закрашивания фигур
        SolidBrush myCorp = new SolidBrush(Color.Black);
        SolidBrush myTrum = new SolidBrush(Color.DarkGreen);
        SolidBrush myTrub = new SolidBrush(Color.ForestGreen);
        SolidBrush mySeа = new SolidBrush(Color.LawnGreen);
        //Выбираем перо myPen желтого цвета толщиной в 2 пикселя:
        Pen myWind = new Pen(Color.White, 2);
        // Закрашиваем фигуры
        g.FillRectangle(myTrub, 100+dvig, 215, 200, 40); // 1 труба (прямоугольник)
        g.FillRectangle(myTrub, 380, 175, 75, 75);
        g.FillRectangle(myTrub, 50 + dvig, 200, 50, 75);// 2 труба (прямоугольник)
        g.FillPolygon(myCorp, new Point[]      // корпус (трапеция)
          {
    new Point(100,300),new Point(700,300),
    new Point(700,300),new Point(600,400),
    new Point(600,400),new Point(200,400),
    new Point(200,400),new Point(100,300)
          }
        );
        g.FillRectangle(myTrum, 250, 200, 350, 100); // палуба (прямоугольник)
                                                     // Море - 12 секторов-полуокружностей
        int x = 50;
        int Radius = 50;
        while (x <= pictureBox1.Width - Radius)
        {
          g.FillPie(mySeа, 0 + x, 386, 50, 50, 0, -180);
          x += 50;
        }
      dvig--;
        // Иллюминаторы 
        for (int y = 200; y <= 550; y += 80)
        {
          g.DrawEllipse(myWind, y, 340, 50, 50); // 6 окружностей
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
