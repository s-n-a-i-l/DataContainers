using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
	internal class Tree
	{
		public Element Root { get; protected set; }
		public Tree()
		{
			Root = null;
			Console.WriteLine($"TConstructor{GetHashCode()}");
		}

		~Tree()
		{
			Console.WriteLine($"TDestructor{GetHashCode()}");
		}
		public void Insert(int data)//удалось убрать элемент из агрумента
		{
			if (Root == null)
				Root = new Element(data);
			else
				Insert(data, Root); // приватный рекурсивный
		}
		private void Insert(int Data, Element Root)
		{
			if (this.Root == null) this.Root = new Element(Data);

			if (Root == null) return;
			if (Data < Root.Data)
			{
				if (Root.pLeft == null) Root.pLeft = new Element(Data);
				else Insert(Data, Root.pLeft);
			}
			else
			{
				if (Root.pRight == null) Root.pRight = new Element(Data);
				else Insert(Data, Root.pRight);
			}
		}
		public int MinValue()
		{
			return MinValue(Root);
		}
		private int MinValue(Element Root)
		{
			if (Root == null) return 0;
			return Root.pLeft == null ? Root.Data : MinValue(Root.pLeft);
			//if (Root.pLeft == null) return Root.Data;
			//else return MinValue(Root.pLeft);
		}

		public int MaxValue()
		{
			return MaxValue(Root);
		}

		private int MaxValue(Element Root)
		{
			if (Root == null) return 0;
			else return Root.pRight == null ? Root.Data : MaxValue(Root.pRight);
		}

		public int Count()
		{
			return Count(Root);
		}
		private int Count(Element Root) 
		{
		  return Root == null ?0: Count(Root.pLeft) + Count(Root.pRight) + 1;
		}
		public int Sum()
		{
			return Sum(Root);
		}

		private int Sum(Element Root) 
		{
		 return Root == null?0:Sum(Root.pLeft) + Sum(Root.pRight) + Root.Data;
		}

		public void Print()
		{
			Print(Root);
			Console.WriteLine(); 
		}
		private void Print(Element Root)
		{

			if (Root == null) return;
			Print(Root.pLeft);
			Console.Write(Root.Data + "\t");
			Print(Root.pRight);
		}

		public void Clear() 
		{
			Root = null;
			Console.WriteLine($"Tree has been delete.{GetHashCode()}");
		}

		public void Erase(int value)
		{
			Root = Erase(Root, value);
		}

		private Element Erase(Element node, int value)
		{
			if (node == null) return null;

			if (value < node.Data)
				node.pLeft = Erase(node.pLeft, value);
			else if (value > node.Data)
				node.pRight = Erase(node.pRight, value);
			else
			{
				
				if (node.pLeft == null && node.pRight == null)
					return null;

				if (node.pLeft == null)
					return node.pRight;

				if (node.pRight == null)
					return node.pLeft;

				
				int minValue = MinValue(node.pRight);
				node.Data = minValue;
				node.pRight = Erase(node.pRight, minValue);
			}
			return node;
		}

		public int Depth()
		{
			return Depth(Root);
		}

		private int Depth(Element node)
		{
			if (node == null) return 0;

			int leftDepth = Depth(node.pLeft);
			int rightDepth = Depth(node.pRight);

			return Math.Max(leftDepth, rightDepth) + 1;
		}

	}
}
