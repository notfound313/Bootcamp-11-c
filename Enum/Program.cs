class Program
{
	static void Main()
	{
		DaysOfWeek day = DaysOfWeek.Sun;
		Console.WriteLine(day);
		int idx = (int) DaysOfWeek.Sun;
		Console.WriteLine(idx);
		
		string otherDay =  DaysOfWeek.Thur.ToString();
		Console.WriteLine(otherDay);
	}
	
}

enum DaysOfWeek
{
	Sun=1,
	Mon,
	Tue,
	Thur,
	Fri,
	Sat,
	
}
enum MonthsOfYear
{
	Jan=1,
	Feb,
	Mey,
	Jun,
	Jul,
	Aug,
	Sep,
	Oct,
	Nov,
	Dec,
	
}
enum PieceOfType
{
	Rook,
	Bishop,
	King,
	Queen,
	Knight,
	Pawn,
}
