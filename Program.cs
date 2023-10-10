using Lesson2_GIT.Classes;

global::System.Console.WriteLine();
var sum = new Calculator(2, 3).Sum();
var sub = new Calculator(12, 3).Subtraction();
global::System.Console.WriteLine();
Console.WriteLine($"2+3={sum}");
Console.WriteLine($"12-3={sub}");