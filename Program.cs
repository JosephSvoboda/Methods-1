

using Methods;



Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine($"hello {name}.");

Console.WriteLine("What is your favorite color?");
var color = Console.ReadLine();
Console.WriteLine("That's my favorite color as well!");

Console.WriteLine("What is your favorite animal?");
var animal = Console.ReadLine();
Console.WriteLine($"I always found {animal} to be fascinating.");

Console.WriteLine($"Last question {name}, what is your favorite band?");
var band = Console.ReadLine();
Console.WriteLine($"I've heard a lot about {band} but i never listened to them.");

Console.WriteLine($"So {name} your favorite color is {color}, your favorite animal is {animal} and your favorite band is {band}");



var numbers = Calc.Add(2, 4);
Console.WriteLine(numbers);

var numbers3 = Calc.Add3(2, 4, 6);
Console.WriteLine(numbers3);

var numbers5 = Calc.Add5(1, 1, 1, 1, 1);
Console.WriteLine(numbers5);


