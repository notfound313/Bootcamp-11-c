using ChildClass;

class Program
{
	static void Main()
	{
		Cat cat = new Cat("Anggi","Pelikan",12, "wanita","keriting");
		Bird bird = new Bird("Anggi","Pelikan",12, "wanita","keriting");

		cat.Meow();
		bird.Fly();
	}
}