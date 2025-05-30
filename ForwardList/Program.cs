using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер списка:");
			int n = Convert.ToInt32(Console.ReadLine());

			Random random = new Random(0);

			ForwardList list = new ForwardList();
			for (int i = 0; i < n; i++) 
			{
				list.PushFront(random.Next(100));
				//list.PushBack(random.Next(100));

			}
			//list.PopFront();
			//list.PopBack();	
			//list.PushBack(234);
			list.Print();

		    repeat:
			Console.Write("Введите индекс добавляемого элемента:");
			int index = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите значение добавляемого элемента:");
			int value = Convert.ToInt32(Console.ReadLine());
			
			try
			{
				list.Insert(value, index);
			}
			catch (Exception ex)
			{ 
			    Console.WriteLine(ex.Message);
				goto repeat;
			}
			list.Print();
		}
	}
}
