// факториалы 
// 1! = 1; 0! = 1

double Factorial(int n) // т.к. тип Int не смещает такие большие значения, как 30! 
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
// int a = Factorial(3); // 3! 1*2*3=6
// Console.WriteLine(a);
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}