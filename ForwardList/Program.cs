using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
	internal class Program
	{
		static readonly string delimiter = "\n----------------------------------------------\n";
		static void Main(string[] args)
		{
			ForwardList list1 = new ForwardList() { 3, 5, 8, 13, 21 };//если добавить конструктор в класс ForwardList
			list1.Print();

			List list3 = new List() { 3, 6, 8, 7, 0, 11 };//если добавить конструктор в класс ForwardList
			list3.Print();

			Console.WriteLine(delimiter);
			Console.Write("Введите размер списка:");
			int n = Convert.ToInt32(Console.ReadLine());

			Random random = new Random(0);

			ForwardList list = new ForwardList();
			for (int i = 0; i < n; i++)
			{
				list.PushFront(random.Next(100));
				//list.PushBack(random.Next(100));

			}

            Console.WriteLine("Лист до модификаций:");
			foreach (int value in list)
			{
				Console.WriteLine(value);
			}
			
			list.PopFront();
			list.PopBack();
			list.PushBack(234);

			Console.WriteLine("Лист после модификаций:");
			list.Print();
			Console.WriteLine(delimiter);



			Console.Write("Введите размер второго списка:");
			int f = Convert.ToInt32(Console.ReadLine());

			List list2 = new List();
			for (int i = 0; i < f; i++)
			{
				list2.PushFront(random.Next(100));
				//list.PushBack(random.Next(100));

			}
			Console.WriteLine("Лист до модификаций:");
			foreach (int value in list2)
			{
				Console.WriteLine(value);
			}

			list2.PopFront();
			list2.PopBack();
			list2.PushBack(96);
			list2.PushFront(11);

			Console.WriteLine("Лист после модификаций:");
			list2.Print();
			Console.WriteLine(delimiter);

			//list.PopFront();
			//list.PopBack();	
			//list.PushBack(234);
			//list.Print();
			/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//   repeat:
			//Console.Write("Введите индекс добавляемого элемента:");
			//int index = Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите значение добавляемого элемента:");
			//int value = Convert.ToInt32(Console.ReadLine());

			//try
			//{
			//	list.Insert(value, index);
			//}
			//catch (Exception ex)
			//{ 
			//    Console.WriteLine(ex.Message);
			//	goto repeat;
			//}
			//list.Print();

			

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



		}
	}
}
