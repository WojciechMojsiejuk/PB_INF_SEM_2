using System;
using System.Collections.Generic;

namespace ProgramowanieObiektowe6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Punkt p1 = new Punkt(0, 0), p2 = new Punkt(1, 1);
            Linia l1 = new Linia(p1, p2), l2 = new Linia(p1, p2);
            l1.przesun(5, 5);
            Console.WriteLine(l1.ToString());
            Console.WriteLine(l2.ToString());
            Punkt p3 = new Punkt(4, 3);


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
        public Punkt(int x_axis_coordinate,int y_axis_coordinate)
        {
            x = x_axis_coordinate;
            y = y_axis_coordinate;
        }
        public Punkt(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
        public void przesun(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
        public String ToString()
        {
            string tekst = "\nX= " + this.x + "\nY= " + this.y;
            return tekst;
        }
    }
    public class Linia
    {
        Punkt punkt1;
        Punkt punkt2;
        public Linia()
        {
            punkt1 = new Punkt();
            punkt2 = new Punkt();
        }
        public Linia(Punkt point1, Punkt point2)
        {
            punkt1 = new Punkt(point1.x, point1.y);
            punkt2 = new Punkt(point2.x,point2.y);
        }
        public Linia(Linia linia)
        {
            this.punkt1 = new Punkt(linia.punkt1.x, linia.punkt1.y);
            this.punkt2 = new Punkt(linia.punkt2.x, linia.punkt2.y);
           
        }
        public void przesun(int dx, int dy)
        {
            punkt1.przesun(dx, dy);
            punkt2.przesun(dx, dy);
        }
        public String ToString()
        {
            string tekst = "\nPunkt 1: " + punkt1.ToString() + "\nPunkt2: "+ punkt2.ToString();
            return tekst;
           
        }

    }
    public class Trojkat
    {
        Linia linia1;
        Linia linia2;
        Linia linia3;

        public Trojkat(Punkt p1, Punkt p2, Punkt p3)
        {
            linia1 = new Linia(p1, p2);
            linia2 = new Linia(p1, p3);
            linia3 = new Linia(p2, p3);
        }
        public void przesun(int dx, int dy)
        {
            linia1.przesun(dx, dy);
            linia2.przesun(dx, dy);
            linia3.przesun(dx, dy);
        }
        public String ToString()
        {
            return "\nLinia 1: "+linia1.ToString()+"\nLinia2: "+linia2.ToString()+"\nLinia3: "+linia3.ToString();
        }
    }
    public class Kwadrat
    {
        Linia linia1;
        Linia linia2;
        Linia linia3;
        Linia linia4;
        public Kwadrat(Punkt p1, Punkt p2, Punkt p3, Punkt p4)
        {
            linia1 = new Linia(p1, p2);
            linia2 = new Linia(p1, p4);
            linia3 = new Linia(p2, p3);
            linia4 = new Linia(p3, p4);
        }
        public void przesun(int dx, int dy)
        {
            linia1.przesun(dx, dy);
            linia2.przesun(dx, dy);
            linia3.przesun(dx, dy);
            linia4.przesun(dx, dy);
        }
        public String ToString()
        {
            return "\nLinia1: "+linia1.ToString()+"\nLinia2: " + linia2.ToString() +"\nLinia3: " + linia3.ToString()+ "\nLinia4: " + linia4.ToString();
        }
    }
    public class Obraz
    {
        List<Trojkat> lista_trojkatow;
        List<Kwadrat> lista_czworokatow;
        public void dodajTrojkat(Punkt p1, Punkt p2, Punkt p3)
        {
            lista_trojkatow.Add(new Trojkat(p1, p2, p3));
        }
        public void dodajKwadrat(Punkt p1, Punkt p2, Punkt p3, Punkt p4)
        {
            lista_czworokatow.Add(new Kwadrat(p1, p2, p3, p4));
        }
    }
}
