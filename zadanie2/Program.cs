using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
	internal class Program
	{
		struct Student
		{
			string imie;
			string nazwisko;
			int wiek;
			int numer_albumu;
			string kierunek;
		}
		struct Przedmioty
		{
			int id;
			string nazwa;
			int ects;
			string nazwa_wydziału;
		}
		struct nauczyciel_akademicki
		{
			int id;
			string imie;
			string nazwisko;
			int wiek;
			string przedmiot;
			int staz;
			
		}
		static void Main(string[] args)
		{
		}
	}
}
