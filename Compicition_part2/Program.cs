
using ComponentHP;
using ProdukSmartPhone;

class Program
{
	static void Main()
	{
		CPU  intel = new CPU(2, "v3","intel");
		Screen gorila = new Screen(12, "Gorila");
		
		CPU  amd = new CPU(2, "v3","AMD");
		Screen gajah = new Screen(12, "Gajah");
		SmartPhone phone = new SmartPhone(amd,gorila);
		
		phone.Start();
	}
}
 