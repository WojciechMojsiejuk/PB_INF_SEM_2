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
            firma.DodajKonto(konto);
            bank.DodajKlienta(firma);

        }
    }

    class Bank
    {
        public List<Klient> lista_klientow;
        public void DodajKlienta(Klient klient)
        {
            lista_klientow.Add(klient);
        }
        public List<Klient> GetKlienci()
        {
            return lista_klientow;
        }
    }
    class Klient
    {
        public List<Konto> lista_kont;
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
        void Wplac(double kwota)
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
        void Wyplac(double kwota)
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
            this.nazwa = "default";
            this.KRS = "default";
            
        }
        public Firma(string nazwafirmy, string numerKRS)
        {
            this.nazwa = nazwafirmy;
            this.KRS = numerKRS;
        }
        protected string KRS;
        protected string nazwa;
    }
    class DuzaFirma:Firma
    {
        public DuzaFirma()
        {
            this.nazwa = "default";
            this.KRS = "default";

        }
        public DuzaFirma(string nazwafirmy, string numerKRS)
        {
            this.nazwa = nazwafirmy;
            this.KRS = numerKRS;
        }
    }
    class Osoba:Klient
    {
        protected string imie;
        protected string nazwisko;
        protected string PESEL;
    }
    class WaznaOsoba:Osoba
    {
        
    }
}
