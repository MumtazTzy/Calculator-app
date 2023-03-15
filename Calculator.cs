class Calculator
// mumtaz 22.11.5065
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Comsole.Writeline("Hasil penambahan: {0} + {1} = {2}", a, b, penambahan(a, b));
		Comsole.Writeline("Hasil pengurangan: {0} - {1} = {2}", a, b, pengurangan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	static int penabahan(int a, int b)
	{
		return a+b;
	}
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
	
}