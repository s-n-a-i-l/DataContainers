using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
	internal class Program //решила продублировать все методы, сделав основные приватными, а те что мы можем вызвать соответственно - публичными
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер дерева:");
			int n = Convert.ToInt32(Console.ReadLine());

			Random rand = new Random(0);
			Tree tree = new Tree();
			for (int i = 0; i < n; i++) 
			{
			 tree.Insert(rand.Next(100));
			}

			tree.Erase(20);

			tree.Print();

			Console.WriteLine();
			Console.WriteLine($"Минимальное значение: {tree.MinValue()}");
			Console.WriteLine($"Максимальное значение: {tree.MaxValue()}");
			Console.WriteLine($"Количество элементов дерева: {tree.Count()}");
			Console.WriteLine($"Сумма элементов дерева: {tree.Sum()}");

			UniqueTree u_tree = new UniqueTree();
			for (int i = 0; i < n; i++)
			{
				u_tree.Insert(rand.Next(100));
				
			}

			u_tree.Print();
			Console.WriteLine();
			Console.WriteLine($"Минимальное значение: {u_tree.MinValue()}");
			Console.WriteLine($"Максимальное значение: {u_tree.MaxValue()}");
			Console.WriteLine($"Количество элементов дерева: {u_tree.Count()}");
			Console.WriteLine($"Сумма элементов дерева: {u_tree.Sum()}");
			Console.WriteLine($"Глубина дерева: {u_tree.Depth()}");
			u_tree.Clear();
			//u_tree.Print(); - нет вывода ибо дерево удалено

		}
	}
}
