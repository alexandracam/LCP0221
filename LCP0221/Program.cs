// MIS 3013 001
// Feb, 20 2024
// Alexandra Camarena
// 113568154

Console.WriteLine("Exam 1 Practice II");

string mesStr;

mesStr = "Please input the number of cogs in Order 1: ";
Console.Write(mesStr);

string ncogsStr;
ncogsStr = Console.ReadLine();
int nCogsInt;
nCogsInt = Convert.ToInt32(ncogsStr);

mesStr = "Please input the number of gears in Order 1: ";
Console.Write(mesStr);

string ngearsStr;
ngearsStr = Console.ReadLine();
int ngearsInt;
ngearsInt = Convert.ToInt32(ngearsStr);

double subtotal;
subtotal = 60.00 * nCogsInt + 200 * ngearsInt;

if (subtotal < 1000)
{
    mesStr = string.Format($"Subtotal is: {subtotal:C2}, and is below {1000:C2}");
}
else if (subtotal <= 2000)// we do not need to write subtotal >= 1000
{
    mesStr = string.Format($"Subtotal is {subtotal:C2}, and is between {1000:C2} and {2000:C2}");
}
else
{
    mesStr = string.Format($"Subtotal is {subtotal:C2} and is above {2000:C2} ");
}

Console.WriteLine(mesStr);