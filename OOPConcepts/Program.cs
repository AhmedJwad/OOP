

using OOP.Logic;

try
{
	var date1 = new Date { Year =2025, Month = 5, Day = 50 };
	Console.WriteLine(date1);
}
catch (Exception Ex)
{

	Console.WriteLine(Ex.Message);
}