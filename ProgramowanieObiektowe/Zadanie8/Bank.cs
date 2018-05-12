using System;
using System.Collections.Generic;

namespace ProgramowanieObiektowe8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Firma firma = new Firma();
            Bank bank = new Bank();
            Konto konto = new Konto("1");
            konto.SALDO = 1000;
            konto.Wyplac(100);
            firma.DodajKonto(konto);
            Konto konto2 = new Konto("2");
            konto2.SALDO = 1500;
            konto2.Wplac(200);
            firma.DodajKonto(konto2);
            DuzaFirma duzaFirma = new DuzaFirma("Powazne korpo", "123456789");
            Konto konto3 = new Konto("3");
            konto3.SALDO = 10000;
            duzaFirma.DodajKonto(konto3);
            Konto konto4 = new Konto("4");
            konto4.SALDO = 15000;
            duzaFirma.DodajKonto(konto4);
            Konto konto5 = new Konto("5");
            konto5.SALDO = 12000;
            duzaFirma.DodajKonto(konto5);
            Osoba osoba1 = new Osoba();
            Konto konto6 = new Konto("6");
            konto6.SALDO = 500;
            osoba1.DodajKonto(konto6);
            Osoba osoba2 = new Osoba("Jan", "Kowalski", "12345");
            Konto konto7 = new Konto("7");
            konto7.SALDO = 1500;
            osoba2.DodajKonto(konto7);
            Osoba osoba3 = new Osoba("Piotr","Nowak","666");
            Konto konto8 = new Konto("8");
            konto8.SALDO = 2340;
            konto8.Wyplac(-60);
            osoba3.DodajKonto(konto8);
            WaznaOsoba wazna1 = new WaznaOsoba();
            Konto konto9 = new Konto("9");
            konto9.SALDO = 30000;
            wazna1.DodajKonto(konto9);
            WaznaOsoba wazna2 = new WaznaOsoba("Karol", "Wojtyla", "2137");
            Konto konto10 = new Konto("10");
            konto10.SALDO = 0;
            konto10.Wplac(-10);
            wazna2.DodajKonto(konto10);
            bank.DodajKlienta(firma);
            bank.DodajKlienta(duzaFirma);
            bank.DodajKlienta(osoba1);
            bank.DodajKlienta(osoba2);
            bank.DodajKlienta(osoba3);
            bank.DodajKlienta(wazna1);
            bank.DodajKlienta(wazna2);
			System.Console.WriteLine("Lista wszystkich klientow");
			List<Klient> lista_klientow = bank.GetKlienci();
            foreach(Klient klient in lista_klientow)
			{
				List<Konto> lista_kont = klient.GetKonta();
				foreach(Konto konta in lista_kont)
				{
					System.Console.WriteLine(konta.NR + " " + konta.SALDO);
				}
			}
			System.Console.WriteLine("Lista wszystkich firm");
			double suma=0.0;
			foreach (Klient klient in lista_klientow)
            {
				if(klient is Firma || klient is DuzaFirma)
				{
					List<Konto> lista_kont = klient.GetKonta();
                    foreach (Konto konta in lista_kont)
                    {
                        System.Console.WriteLine(konta.NR + " " + konta.SALDO);
						suma += konta.SALDO;
                    }
				} 
            }
			System.Console.WriteLine("Laczne srodki wszystkich firm= "+suma);
			System.Console.WriteLine("Lista wszystkich osob fizycznych");
            suma = 0.0;
            foreach (Klient klient in lista_klientow)
            {
				if (klient is Osoba || klient is WaznaOsoba)
                {
                    List<Konto> lista_kont = klient.GetKonta();
                    foreach (Konto konta in lista_kont)
                    {
                        System.Console.WriteLine(konta.NR + " " + konta.SALDO);
                        suma += konta.SALDO;
                    }
                }
            }
            System.Console.WriteLine("Laczne srodki wszystkich osob= " + suma);
			System.Console.WriteLine("Lista duzych firm i waznych osob");
            suma = 0.0;
            foreach (Klient klient in lista_klientow)
            {
				if (klient is DuzaFirma || klient is WaznaOsoba)
                {
                    List<Konto> lista_kont = klient.GetKonta();
                    foreach (Konto konta in lista_kont)
                    {
                        System.Console.WriteLine(konta.NR + " " + konta.SALDO);
                        suma += konta.SALDO;
                    }
                }
            }
            System.Console.WriteLine("Laczne srodki wszystkich waznych osob i duzych firm= " + suma);
			System.Console.WriteLine("Lista zwyklych osob");
            suma = 0.0;
            foreach (Klient klient in lista_klientow)
            {
                if (klient is Osoba)
                {
                    List<Konto> lista_kont = klient.GetKonta();
                    foreach (Konto konta in lista_kont)
                    {
                        System.Console.WriteLine(konta.NR + " " + konta.SALDO);
                        suma += konta.SALDO;
                    }
                }
            }
            System.Console.WriteLine("Laczne srodki niewaznych osob= " + suma);
        }
    }

    class Bank
    {
        public List<Klient> lista_klientow;
        public Bank()
        {
            lista_klientow = new List<Klient>();
        }
        public void DodajKlienta(Klient klient)
        {
            lista_klientow.Add(klient);
        }
        public List<Klient> GetKlienci()
        {
            return lista_klientow;
        }
    }
    abstract class Klient
    {
        public List<Konto> lista_kont;
        public Klient()
        {
            lista_kont = new List<Konto>();
        }
        public void DodajKonto(Konto konto)
        {
            lista_kont.Add(konto);
        }
        public List<Konto> GetKonta()
        {
            return lista_kont;
        }
    }
    class Konto
    {
        private string nr;
        private double saldo;
        public Konto(string nr)
        {
            this.nr = nr;
        }
        public double SALDO
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string NR
        {
            get { return nr; }
        }
        public void Wplac(double kwota)
        {
            if (kwota > 0)
            {
                saldo = saldo + kwota;
            }
            else
            {
                System.Console.WriteLine("Nasz bank nie przyjmuje minus pieniedzy");
            }
        }
        public void Wyplac(double kwota)
        {
            if (kwota > 0)
            {
                saldo = saldo - kwota;
            }
            else
            {
                System.Console.WriteLine("Lol nie mozna wyplacic ujemnej kwoty. Co za nia kupisz, minus chleb?");
            }
        }

    }
    class Firma:Klient
    {
        public Firma()
        {
            nazwa = "default";
            KRS = "default";
            
        }
        public Firma(string nazwafirmy, string numerKRS)
        {
            nazwa = nazwafirmy;
            KRS = numerKRS;
        }
        protected string KRS;
        protected string nazwa;
    }
    class DuzaFirma:Firma
    {
        public DuzaFirma():base()
        {
        }
        public DuzaFirma(string nazwafirmy, string numerKRS):base(nazwafirmy,numerKRS)
        {
        }
    }
    class Osoba:Klient
    {
        protected string imie;
        protected string nazwisko;
        protected string PESEL;
        public Osoba()
        {
            imie = "default";
            nazwisko = "default";
            PESEL = "default";
        }
        public Osoba(string _imie, string _nazwisko, string _PESEL)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            PESEL = _PESEL;
        }
    }
    class WaznaOsoba : Osoba
    {
        public WaznaOsoba() : base()
        {
        }
        public WaznaOsoba(string _imie, string _nazwisko, string _PESEL) : base(_imie, _nazwisko, _PESEL)
        {
        }
    }
}
