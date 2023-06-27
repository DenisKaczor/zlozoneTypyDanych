using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
	public enum Płeć
	{
		mężczyzna,
		kobieta
	}

	public struct Student
	{
		public string nazwisko;
		public int Id;
		public double ocena;
		public Płeć płeć;

		public void WypełnijDane()
		{
			Console.Write("Wprowadź nazwisko ucznia: ");
			nazwisko = Console.ReadLine();

			Console.Write("Wprowadź ID ucznia: ");
			int.TryParse(Console.ReadLine(), out Id);

			Console.Write("Wprowadź ocenę ucznia (między 2.0 a 5.0) ");
			double.TryParse(Console.ReadLine(), out ocena);

			if (ocena < 2.0)
				ocena = 2.0;
			else if (ocena > 5.0)
				ocena = 5.0;

			Console.Write("Wprowadź płeć ucznia (0 - mężczyzna, 1 - kobieta): ");
			int wartośćPłeć;
			wartośćPłeć = int.Parse(Console.ReadLine());
			płeć = (Płeć)wartośćPłeć;
		}

		public void WyświetlDane()
		{
			Console.WriteLine("{0} ({1}), ID: {2}, Ocena: {3:F1}", nazwisko, płeć, Id, ocena);
		}
	}

	public class Program
	{
		public static double LiczŚrednią(Student[] students)
		{
			double sum = 0.0;
			foreach (Student student in students)
			{
				sum += student.ocena;
			}
			return sum / students.Length;
		}

		public static void Main()
		{
			Student[] students = new Student[5];

			for (int i = 0; i < students.Length; i++)
			{
				students[i].WypełnijDane();
			}

			Console.WriteLine("Lista studentów:");
			foreach (Student student in students)
			{
				student.WyświetlDane();
			}

			double average = LiczŚrednią(students);
			Console.WriteLine("Średnia ocena: {0:F1}", average);

			Console.ReadKey();
		}
	}
}
