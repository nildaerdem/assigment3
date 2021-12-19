int a, b, c, e;

Console.Write("Enter a number:");
a = Convert.ToInt32(Console.ReadLine());

for (b = 2; b <= a; b++)
{
	e = 2;
	c = 1;
	while (e < b)
	{
		if (b % e == 0)
		{
			c = 0;
			break;
		}
		e++;
	}
	if (c == 1)
	{
		Console.WriteLine("Number is prime:" + b);
	}
}

	
