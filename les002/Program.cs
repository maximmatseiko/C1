// / код который принимает на вход три числа ина выходе показывает последнюю цифру этого числа
Console.WriteLine("Введите трехзначное число");
int NumA = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(NumA);
Console.WriteLine("последняя цифра этого числа :" + Number[2]);
