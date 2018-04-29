using System;

namespace ProgramowanieObiektowe7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Punkt p1 = new Punkt(3,3);
            Kwadrat kwadrat = new Kwadrat("czerwony", p1, 5);
            Console.WriteLine(kwadrat.ToString());
            kwadrat.setColor("zielony");
            Console.WriteLine(kwadrat.ToString());
            Punkt p2 = new Punkt();
            Prostokat prostokat = new Prostokat("zolty", p2, p1);
            Console.WriteLine(prostokat.ToString());
            prostokat.setColor("czarny");
            Console.WriteLine("Kolor: "+prostokat.getColor());
            Punkt p3 = new Punkt(p1);
            p3.x++;
            p3.y *= 2;
            Trojkat trojkat = new Trojkat("bialy", p1, p2, p3);
            Console.WriteLine(trojkat.ToString());
            Punkt p4 = new Punkt();
            p4.x = p3.x + p1.y;
            p4.y = p2.y + 1 + p1.x + p3.y;
            Czworokat czworokat = new Czworokat("fioletowy", p1, p2, p3, p4);
            Console.WriteLine(czworokat.ToString());

        }
    }
    class Figury
    {
        protected string color;
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string set_color)
        {
            this.color = set_color;
        }
        public Figury(string set_color)
        {
            this.color = set_color;
        }

    }
    class Czworokat:Figury
    {
        Punkt p1, p2, p3, p4;
        public Czworokat(string set_color, Punkt point1, Punkt point2, Punkt point3, Punkt point4):base(set_color)
        {
            p1 = new Punkt(point1);
            p2 = new Punkt(point2);
            p3 = new Punkt(point3);
            p4 = new Punkt(point4);
        }
        public override String ToString()
        {

            return "Czworokat\n1: " + p1.ToString() + "\n2: " + p2.ToString() + "\n3: " + p3.ToString() + "\n4: " + p4.ToString()+ "\nkolor: " + color;;
        }
    }
    class Trojkat:Figury
    {
        Punkt p1, p2, p3;
        public Trojkat(string set_color, Punkt point1,Punkt point2, Punkt point3):base(set_color)
        {
            p1 = new Punkt(point1);
            p2 = new Punkt(point2);
            p3 = new Punkt(point3);
        }
        public override String ToString()
        {

            return "Trojkat\n1: " + p1.ToString() + "\n2: " + p2.ToString() + "\n3: " + p3.ToString() + "\nkolor: " + color;
        }
    }
    class Prostokat:Czworokat
    {
        Punkt p1, p2;
        public Prostokat(string set_color, Punkt point1, Punkt point2):base(set_color, new Punkt(point1.x,point1.y), new Punkt(point1.x, point2.y), new Punkt(point2.x, point2.y), new Punkt(point2.x, point2.y))
        {
            p1 = new Punkt(point1);
            p2 = new Punkt(point2);
        }
        public override String ToString()
        {
            Punkt p3 = new Punkt(p1.x, p2.y);
            Punkt p4 = new Punkt(p2.x, p1.y);
            return "Prostokat\n1: " + p1.ToString() + "\n2: " + p2.ToString() + "\n3: " + p3.ToString() + "\n4: " + p4.ToString()+"\nKolor: "+color;
        }
    }
    class Kwadrat:Prostokat
    {
        Punkt p1;
        int dlugosc_boku;
        public Kwadrat(string set_color, Punkt point1, int a):base(set_color,point1,new Punkt(point1.x+a,point1.y+a))
        {
            p1 = new Punkt(point1);
            dlugosc_boku = a;
        }
        public override String ToString()
        {
            Punkt p2 = new Punkt(p1.x, p1.x + dlugosc_boku);
            Punkt p3 = new Punkt(p1.x+dlugosc_boku, p1.y);
            Punkt p4 = new Punkt(p1.x+dlugosc_boku, p1.y+dlugosc_boku);
            return "Kwadrat\n1: " + p1.ToString() + "\n2: " + p2.ToString() + "\n3: " + p3.ToString() + "\n4: " + p4.ToString()+"\nKolor: "+color;
        }
    }
    public class Punkt
    {
        public int x, y;
        public Punkt()
        {
            x = 0;
            y = 0;
        }
        public Punkt(int x_axis_coordinate, int y_axis_coordinate)
        {
            x = x_axis_coordinate;
            y = y_axis_coordinate;
        }
        public Punkt(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
        public override String ToString()
        {
            string tekst = "\nX= " + this.x + "\nY= " + this.y;
            return tekst;
        }
    }
}
