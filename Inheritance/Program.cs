﻿using ChildClass;

class Program
{
	static void Main()
	{
		Cat cat = new Cat("Anggi","Pelikan",12, "wanita","keriting");
		Bird bird = new Bird("Anggi","Sabtu","keriting");

		cat.Meow();
		Console.WriteLine(cat);
		bird.Fly();
	}
}