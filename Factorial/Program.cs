using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;//для использования хранилища для польших чисел System.Numerics.BigInteger

namespace Factorial
{
	internal class Program//Алгоритм вычисления факторизацией,разложение факториала на простые множители(10! = 28 * 34 * 52 * 71 = 3 628 800)
						  //1 Выписать подряд все целые числа от двух до n(2, 3, 4, …, n).
						  //2 Пусть переменная i изначально равна двум — первому простому числу.
						  //3 Зачеркнуть в списке числа от 2i до n, считая шагами по i(это будут числа, кратные i: 2i, 3i, 4i, …).
						  //4 Найти первое незачёркнутое число в списке, большее чем i, и присвоить значению переменной i это число.
						  //5 Повторять шаги 3 и 4, пока возможно.
	{
		static BigInteger Factorial(int n)
		{
			if (n < 0)
				return 0;
			if (n == 0)
				return 1;
			if (n == 1 || n == 2)
				return n;
			bool[] flag = new bool[n + 1]; // маркеры для решета Эратосфена
			List<Tuple<int, int>> p = new List<Tuple<int, int>>(); // множители и их показатели степеней
			for (int i = 2; i <= n; ++i)
				if (!flag[i]) // если i - очередное простое число
				{
					// считаем показатель степени в разложении
					int k = n / i;
					int c = 0;
					while (k > 0)
					{
						c += k;
						k /= i;
					}
					// запоминаем множитель и его показатель степени
					p.Add(new Tuple<int, int>(i, c));
					// просеиваем составные числа через решето               
					int j = 2;
					while (i * j <= n)
					{
						flag[i * j] = true;
						++j;
					}
				}
			BigInteger f = 1;
			for (int i = p.Count() - 1; i >= 0; --i)
			{
				f *= BigInteger.Pow(p[i].Item1, p[i].Item2);
				//Console.WriteLine($"{i}!  = {f};");
			}

			return f;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"{n}! = {Factorial(n)}");


			
		}
	}
}
