using System.Collections.Generic;

public class Baza
{
	/// <summary>
	/// inicjalizuje baze <see cref="T:Baza"/> class.
    /// </summary>
    /// <param name="data">Jakaś przedziwne dane</param>
	public Baza(Date data)
	{
		
	}

	// oznaczamy metody w klasie bazowej jako funkcje wirtualne, w JAVIE jest to domyslne.
   
    /// <summary>
	/// Zapisuje obiekt w danynym miejscu
    /// </summary>
    /// <param name="o">Podany obiekt</param>
    /// <param name="miejsce">Miejsce do którego ma zostać zapisany obiekt</param>
    public virtual void Zapisz(Obiekt o, string miejsce) 
	{
		
	}
    /// <summary>
    /// Zwraca listę obiektów z miejsca
    /// </summary>
    public List<Obiekt> Czytaj(string miejsce)
	{
		//... dochodzi tutaj do jakiegoś przeszukania bazy, nie interesuje nas to
		List<Obiekt> ObiektyZDanegoMiejsca = new List<Obiekt>();
		return ObiektyZDanegoMiejsca;
	}
    /// <summary>
    /// Usuwa wszystkie obiekty z miejsca
    /// </summary>
    public virtual void Usun(string miejsce)
	{
		
	}

}
public class BazaZTranslacjami : Baza
{
	/* utworzymy tablicę stringów przechowującą informacje o translacji miejsc
	 * tzn. pierwsza kolumna przechowuje informacje nt. miejsceX
	 * druga kolumna przechowuje informacje nt. miejsceY
	 * przykład: string[1,2]
	 * string[,] tablica ={{"Warszawa"},{"Bialystok" }};
	 */
	private string[,] tablicatranslacji;
	public BazaZTranslacjami(Date data, string[,] tablicaTranslacjiMiejsc) : base(data)
	{
		//przekazujemy dane do klasy bazowej i zapisujemy w naszej tablicy wzór translacji
		tablicatranslacji = tablicaTranslacjiMiejsc;
	}
	public override void Zapisz(Obiekt o, string miejsce)
	{
		//metoda będzie sprawdzała czy miejsce należy do tablicy translacji 
		for (int i = 0; i < tablicatranslacji.GetLength(0);i++)
		{
			if(tablicatranslacji[i,0].Equals(miejsce))
			{
				/*znaleziono obiekt w tablicy translacji, 
				 * wywołujemy metodę z klasy bazowej
				 * i przekazujemy jako parametr, 
				 * miejsceY, tzn. drugą kolumnę*/
				base.Zapisz(o, tablicatranslacji[i,1]);
			}
		}
		//nieznaleziono miejsca w tablicy
		base.Zapisz(o, miejsce);
	}
	//nie ma potrzeby deklaracji metody czytaj w tej klasie, bowiem nie uwzglednia ona translacji
	//przechodzimy wiec do usuwania
	public override void Usun(string miejsce)
	{
		//jak w zapisie, ale odwrotnie
        //teraz szukamy miejsca już po translacji
		for (int i = 0; i < tablicatranslacji.GetLength(1); i++)
        {
            if (tablicatranslacji[i, 1].Equals(miejsce))
            {
				/*znaleziono obiekt w tablicy translacji, 
                 * wywołujemy metodę z klasy bazowej
                 * i przekazujemy jako parametr, 
                 * miejsceY, tzn. drugą kolumnę*/
				base.Usun(tablicatranslacji[i, 0]);
            }
        }
        //gdy nie ma translacji 
		base.Usun(miejsce);
	}
}
// klasy ktore powinne pojawic sie w programie
public class Date
{
	//...
}
public class Obiekt
{
	//...
}
