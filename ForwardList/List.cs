using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForwardList
{
	internal class List : IEnumerable<int>
	{
		private Element Head;
		private Element Tail;
		public int Length { get; private set; }

		public void Add(int data)
		{
			PushBack(data); // добавляет в конец при инициализации: {1, 2, 3}
		}

		public IEnumerator<int> GetEnumerator()
		{
			Element current = Head;
			while (current != null)
			{
				yield return current.Data;
				current = current.pNext;
			}
		}
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		public List()
		{
			Head = null;
			Tail = null;
			Length = 0;
			Console.WriteLine($"LConstructor:\t{GetHashCode()}");
		}

		public void Clear()
		{
			Head = null;
			Tail = null;
			Length = 0;
		}
		~List()
		{
			Clear();
			Console.WriteLine($"LDestructor:\t{GetHashCode()}");
		}

		public void PushFront(int data)
		{
			Element newElement = new Element(data);
			Element Temp = Head;
		    newElement.pNext = Temp;
			Head = newElement;
			if (Length == 0)
				Tail = Head;
			else
				Temp.pRev = newElement;

			Length++;
		}
		public void PushBack(int data)
		{
			Element newElement = new Element(data, null, Tail);
			if (Tail != null)
				Tail.pNext = newElement;
			else
				Tail = newElement;

			Tail = newElement;
			Length++;
		}

		public void Insert(int data, int index)
		{
			if (index < 0 || index > Length)
				throw new IndexOutOfRangeException("Выход за пределы списка");

			if (index == 0)
			{
				PushFront(data);
				return;
			}
			if (index == Length)
			{
				PushBack(data);
				return;
			}

			Element current = Head;
			for (int i = 0; i < index - 1; i++)
				current = current.pNext;

			Element newNode = new Element(data, current.pNext, current);
			current.pNext.pRev = newNode;
			current.pNext = newNode;
			Length++;
		}

		public void PopFront()
		{
			if (Head == null) return;

			Head = Head.pNext;
			if (Head != null)
				Head.pRev = null;
			else
				Tail = null;

			Length--;
		}

		public void PopBack()
		{
			if (Tail == null) return;

			Tail = Tail.pRev;
			if (Tail != null)
				Tail.pNext = null;
			else
				Head = null;

			Length--;
		}

		public void Print()
		{
			Element current = Head;
			while (current != null)
			{
				Console.Write($"{current.Data} ");
				current = current.pNext;
			}
			Console.WriteLine($"\nКоличество элементов: {Length}");
		}
	}
}
