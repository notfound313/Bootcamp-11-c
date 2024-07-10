namespace ProdukSmartPhone;

using ComponentHP;


public class SmartPhone
{
	public CPU cPU;
	public Screen screen;

	public SmartPhone(CPU cPU, Screen screen)
	{
		this.cPU = cPU;
		this.screen = screen;
	}

	public void Start()
	{
		cPU.PowerOn();
	}
}
