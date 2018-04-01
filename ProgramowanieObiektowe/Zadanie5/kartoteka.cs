using System;
using System.Collections.Generic;
namespace ProgramowanieObiektowe5
{
    using impl;
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            int i=1;
            int index;
            string name, surname;
            Kartoteka k1 = new Kartoteka();
            Osoba o1 = new Osoba();
            while(i!=0)
            {
                Console.WriteLine("\nWybierz opcje!");
                Console.WriteLine("1.Dodaj");
                Console.WriteLine("2.Usun");
                Console.WriteLine("3.Rozmiar");
                Console.WriteLine("4.CzyZawiera");
                Console.WriteLine("5.Pobierz");
                Console.WriteLine("0.Zamknij program");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Podaj imie: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        surname = Console.ReadLine();
                        o1 = new Osoba(name, surname);
                        k1.dodaj(o1);
                        break;
                    case 2:
                        Console.WriteLine("Podaj imie: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        surname = Console.ReadLine();
                        o1 = new Osoba(name, surname);
                        if(k1.czyZawiera(o1))
                            k1.usun(o1);
                        break;
                    case 3:
                        Console.WriteLine("Rozmiar kartoteki wynosi: ");
                        Console.Write(k1.rozmiar());
                        break;
                    case 4:
                        Console.WriteLine("Podaj imie: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        surname = Console.ReadLine();
                        o1 = new Osoba(name, surname);
                        Console.Write(k1.czyZawiera(o1));
                        break;
                    case 5:
                        Console.WriteLine("Podaj index: ");
                        index = int.Parse(Console.ReadLine());
                        o1= k1.pobierz(index);
                        Console.Write(o1.getImie());
                        Console.Write(o1.getNazwisko());

                        break;
                    default:
                        Console.WriteLine("Nie prawidlowe dane");
                        break;
                }
            }


        }
    }
  
    class Osoba
    {
        private string imie;
        private string nazwisko;
        public Osoba()
        {
        }
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public string getImie()
        {
            return imie;
        }
        public string getNazwisko()
        {
            return nazwisko;
        }
    }
    namespace mockup
    {
        class Kartoteka
        {
            public void dodaj(Osoba osoba)
            {
                
            }
            public void usun(Osoba osoba)
            {

            }
            public int rozmiar()
            {
                return 1;
            }
            public Boolean czyZawiera(Osoba osoba)
            {
                return true;
            }
            public Osoba pobierz (int index)
            {
                return new Osoba("Gall", "Anonim");
            }

        }
    }
    namespace impl
    {
        class Kartoteka
        {
            private List<Osoba> kartoteka;
            public Kartoteka()
            {
                kartoteka = new List<Osoba>();
            }
            public void dodaj(Osoba osoba)
            {
                kartoteka.Add(osoba);
            }
            public void usun(Osoba osoba)
            {
                string szukanaimie, szukananazwisko, podanaimie, podananazwisko;
                foreach (Osoba szukana in kartoteka)
                {
                    szukanaimie = szukana.getImie();
                    szukananazwisko = szukana.getNazwisko();
                    podanaimie = osoba.getImie();
                    podananazwisko = osoba.getNazwisko();
                    if (szukanaimie == podanaimie && szukananazwisko == podananazwisko)
                    {
                        kartoteka.Remove(szukana);
                        break;
                    }
                        
                }
            }
            public int rozmiar()
            {
                return kartoteka.Count;
            }
            public Boolean czyZawiera(Osoba osoba)
            {
                string szukanaimie, szukananazwisko, podanaimie, podananazwisko;
                foreach(Osoba szukana in kartoteka)
                {
                    szukanaimie = szukana.getImie();
                    szukananazwisko = szukana.getNazwisko();
                    podanaimie = osoba.getImie();
                    podananazwisko = osoba.getNazwisko();
                    if (szukanaimie == podanaimie && szukananazwisko == podananazwisko)
                        return true;
                }
                return false;
            }
            public Osoba pobierz(int index)
            {
                return kartoteka[index];
            }
        }
    }
}
