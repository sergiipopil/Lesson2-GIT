using Lesson2_GIT.Classes;

var sum = new Calculator(2, 3).Sum();
var sub = new Calculator(12, 3).Subtraction();

Console.WriteLine("Start program");
Console.WriteLine("Calculation Example:\n");
Console.WriteLine($"2+3={sum}");
Console.WriteLine($"12-3={sub}");
Console.WriteLine();
Console.WriteLine("End program");