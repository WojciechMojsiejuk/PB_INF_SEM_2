using System;
using System.Collections.Generic;

namespace ProgramowanieObiektowePrzygotowanieDoEgzaminu
{
	public class Kolejka_Lilo//zad PO9.jpg
	{
		private int?[] kolejka;
		public Kolejka_Lilo(int max_size)
		{
			kolejka = new int?[max_size];         
		}
        public void Wstaw_Element(int nowyelement)
		{
			if(kolejka[kolejka.Length-1]!=null)
			{
				throw new Exception("Kolejka jest pełna");
			}
			for (int i = kolejka.Length - 1; i > 0;i--)
			{
				kolejka[i] = kolejka[i - 1];
			}
			kolejka[0] = nowyelement;
		}
        public int? ZwrocOstatni()
		{
			if(CzyPusta())
			{
				throw new Exception("Kolejka jest pusta");
			}
			int i;
			for (i = 0; i <= kolejka.Length - 1;i++)
			{
				if (i == kolejka.Length - 1) break;
				if (kolejka[i + 1] == null) break;
			}
			int? temp = kolejka[i];
			kolejka[i] = null;
			return temp;
   		}
        public bool CzyPusta()
		{
			return (kolejka[0] == null);
		}
	}
	//Zadanie P07.jpg
    public class Kalkulator
	{
		virtual public double Log10(double arg)
		{
			if (arg <= 0)
				throw new ArithmeticException("Argument logarytmu musi byc dodatni");
			return Math.Log10(arg);
		}
        virtual public double Potega(double x, double y)
		{
			if(x==0.0 && y==0.0)
			{
				throw new ArithmeticException("0 do potegi zerowej, symbol nieoznaczony");
			}
			return Math.Pow(x, y);
		}
        virtual public void Posprzataj()
		{
			GC.Collect();
		}
	}
	public class KalkulatorZPamiecia : Kalkulator
	{  
		Operacja[] historia;
		public KalkulatorZPamiecia()
		{
			historia = new Operacja[10];
		}
        override public double Log10(double arg)
		{
			double poszukiwany = PrzeszukajHistorie(new Logarytm10("logarytm", arg));
            if (!Double.IsNaN(poszukiwany))
            {
				Console.WriteLine("Znaleziono w pamieci");
                return poszukiwany;
            }
			try
			{
				double result = base.Log10(arg);
				Logarytm10 logarytm10 = new Logarytm10("logarytm", arg, result);
				Wstaw_Element(logarytm10);
				return result;
			}
            catch(ArithmeticException ae)
			{
				Console.WriteLine(ae.Message);
				return Double.NaN;
			}
		}
		public override double Potega(double x, double y)
		{
			double poszukiwany = PrzeszukajHistorie(new Potega("potega", x, y));
			if(!Double.IsNaN(poszukiwany))
			{
				Console.WriteLine("Znaleziono w pamieci");
				return poszukiwany;
			}		
			try
			{
				double result = base.Potega(x, y);
				Potega potega = new Potega("potega", x, y, result);
				Wstaw_Element(potega);
				return result;
			}
			catch(ArithmeticException ae)
			{
				Console.WriteLine(ae.Message);
                return Double.NaN;
			}

		}
		public void Wstaw_Element(Operacja operacja)
        {
			
			for (int i = historia.Length - 1; i > 0; i--)
            {
                historia[i] = historia[i - 1];
            }
			historia[0] = operacja;
        }
		public double PrzeszukajHistorie(Operacja operacja)
		{
			if (historia[0] != null)
			{
				if (operacja is Logarytm10)
                {
                    foreach (Logarytm10 poprzedniaoperacja in historia)
                    {
                        if (((Logarytm10)poprzedniaoperacja).ARGUMENT.Equals(((Logarytm10)operacja).ARGUMENT))
                        {
                            return poprzedniaoperacja.WYNIKOPERACJI;
                        }
                    }
                }
                if (operacja is Potega)
                {
                    foreach (Potega poprzedniaoperacja in historia)
                    {
							if(poprzedniaoperacja.X.Equals(((ProgramowanieObiektowePrzygotowanieDoEgzaminu.Potega)operacja).X) && poprzedniaoperacja.Y.Equals(((ProgramowanieObiektowePrzygotowanieDoEgzaminu.Potega)operacja).Y))
                                return poprzedniaoperacja.WYNIKOPERACJI;                  
                    }
                }
			}
			return double.NaN;

		}
        
	}
    public class Operacja
	{
		private string nazwaOperacji;
		public string NAZWAOPERACJI
		{
			get => nazwaOperacji;
			set => nazwaOperacji = value;
		}

		private double wynikOperacji;
        public double WYNIKOPERACJI
		{
			get => wynikOperacji;
			set => wynikOperacji = value;
		}
		public Operacja(string _nazwa,double _wynik)
		{
			nazwaOperacji = _nazwa;
			wynikOperacji = _wynik;
		}
	}
	public class Logarytm10:Operacja
	{
		private double argument;
        public double ARGUMENT
		{
			get => argument;
			set => argument = value;
		}
		public Logarytm10(string _nazwa, double _argument, double _wynik=Double.NaN):base(_nazwa,_wynik)
		{
			argument = _argument;
		}
	}
	public class Potega:Operacja
	{
		private double x;
		private double y;

		public double X
        {
            get => x;
            set => x = value;
        }
		public double Y
        {
            get => y;
            set => y = value;
        }
		public Potega(string _nazwa, double _x,double _y, double _wynik=Double.NaN):base(_nazwa, _wynik)
		{
			x = _x;
			y = _y;
		}
	}

    class MainClass
    {
        public static void Main(string[] args)
        {
			//Zadanie P09.jpg
			Kolejka_Lilo kolejka = new Kolejka_Lilo(3);
			try
			{
				kolejka.ZwrocOstatni();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			for (int i = 0; i <= 2; i++) 
			{
				kolejka.Wstaw_Element(i);
			}
			for (int i = 0; i <= 2; i++)
            {
				Console.WriteLine(kolejka.ZwrocOstatni());
            }
			try
            {
				for (int i = 0; i <= 4; i++)
                {
					kolejka.Wstaw_Element(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
			//Zadanie P07.jpg
			KalkulatorZPamiecia kalkulator = new KalkulatorZPamiecia();
			Console.WriteLine(kalkulator.Log10(10));
			Console.WriteLine(kalkulator.Log10(10));
			Console.WriteLine(kalkulator.Potega(2,2));
			Console.WriteLine(kalkulator.Potega(2,2));

        }
    }
}
