//BinaryTree
//#define TREE_1
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{

	internal class Program //решила продублировать все методы, сделав основные приватными, а те что мы можем вызвать соответственно - публичными(обертка)
	{
		static void Main(string[] args)
		{
#if tREE_1
			Console.Write("Введите размер дерева:");
			int n = Convert.ToInt32(Console.ReadLine());

			Random rand = new Random(0);
			Tree tree = new Tree();
			for (int i = 0; i < n; i++)
			{
				tree.Insert(rand.Next(100));
			}

			//tree.Erase(20);

			//tree.Print();

			Console.WriteLine();
			TreePefrormance<int>.Measure("Минимальное значение:", tree.MinValue);
			TreePefrormance<int>.Measure("Максимальное значение:", tree.MaxValue);
			TreePefrormance<int>.Measure("Количество элементов дерева:", tree.Count);
			TreePefrormance<int>.Measure("Сумма элементов дерева:", tree.Sum);
			TreePefrormance<double>.Measure("Среднее арифметическое:", tree.Avg);

			//Console.WriteLine($"Минимальное значение: {tree.MinValue()}");
			//Console.WriteLine($"Максимальное значение: {tree.MaxValue()}");
			//Console.WriteLine($"Количество элементов дерева: {tree.Count()}");
			//Console.WriteLine($"Сумма элементов дерева: {tree.Sum()}");

			UniqueTree u_tree = new UniqueTree();
			for (int i = 0; i < n; i++)
			{
				u_tree.Insert(rand.Next(100));

			}

			//u_tree.Print();
			Console.WriteLine();
			Console.WriteLine($"Минимальное значение: {u_tree.MinValue()}");
			Console.WriteLine($"Максимальное значение: {u_tree.MaxValue()}");
			Console.WriteLine($"Количество элементов дерева: {u_tree.Count()}");
			Console.WriteLine($"Сумма элементов дерева: {u_tree.Sum()}");
			Console.WriteLine($"Глубина дерева: {u_tree.Depth()}");
			u_tree.Clear();
			//u_tree.Print(); - нет вывода ибо дерево удалено  
#endif
			//Tree tree = new Tree() {50, 25, 75,16,32,70,80 };
			Tree tree = new Tree();
			tree.Insert(50);
			tree.Insert(25);
			tree.Insert(75);
			tree.Insert(16);
			tree.Insert(32);
			tree.Insert(70);
			tree.Insert(80);
			//Console.WriteLine(tree.Depth());
			tree.Print();
			Console.WriteLine("\n---------------------------------------\n");

			//tree.DepthPrint(2);
			tree.Balance();
			
			tree.TreePrint();
		}
		public void MeasurePerformance(DateTime start,DateTime stop) 
		{
		 
		}
	}
}
