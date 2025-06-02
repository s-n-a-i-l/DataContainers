using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForwardList
{
	internal class ForwardList : IEnumerable<int>
	{

		private Element Head {  get; set; }
		public int Lenght { get; private set; }

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
		public ForwardList() 
		{
			Head = null;
			Console.WriteLine($"LConstructor:\t{GetHashCode()}");
		}

		~ForwardList() 
		{
			Head = null;
			Lenght = 0;
			Console.WriteLine($"LDestructor:\t{GetHashCode()}");

		}

		public void Clear()//Замена деструктору
		{
			Lenght = 0;
			Head = null;
		}

		public void PushFront(int Data)
		{
			////создать новый элемент
			//Element New = new Element(Data);//указатель

			////Пристыковываем новый элемент к началу списка
			//New.pNext = Head;

			////смещаем голову на новый элемент
			//Head = New;

			Head = new Element(Data, Head);
			Lenght++;
		}

		public void Insert(int Data,int Index) 
		{
			//ПРОВЕРЯЕМ ВЫХОД ЗА ПРЕДЕЛЫ
			if(Index > Lenght || Index < 0) 
			{
				//Console.WriteLine($"Error:выход за пределы списка.");
				//return;
				throw new IndexOutOfRangeException($"Error:выход за пределы списка.");
			}
			if (Index == 0)
			{
				PushFront(Data);
				return;
			}
		 //доходим до нужного эл-та
		      Element Temp = Head;
			for (int i = 0; i < Index - 1; i++) 
			{
				Temp = Temp.pNext;
			}
			//+ el in list
			Temp.pNext = new Element(Data, Temp.pNext);
			Lenght++;
		}

		public void PushBack(int Data)
		{
			//проверка на наличие элементов в списке
			if (Head == null) 
			{ 
				PushFront(Data);
				return;
			}

		 //Доходим до конца списка
		    Element Temp = Head;
			while (Temp.pNext != null) 
			{ 
				if (Temp.pNext == null) break;
				Temp = Temp.pNext; 
			} 
			
			//Element New = new Element(Data);
			//Temp.pNext = New;

			Temp.pNext = new Element(Data);
			Lenght++;
		}

		public void Print()
		{
			for (Element Temp = Head; Temp != null; Temp = Temp.pNext)
			{
				Console.WriteLine($"{Temp.Data}\t");
				Console.WriteLine();
				
			}
			Console.WriteLine($"Количество элементов в списке: {Lenght}");
		}
		//Remove


		public void PopFront() 
		{
			if (Head != null)
			{
				Head = Head.pNext;// исключаем элемент из списка он будет удален гербейдж коллектором+
			}
			Lenght--;
		}

		public void PopBack()
		{
			if(Head == null || Head.pNext == null) 
			{
				PopFront();
				return; 
			}

			Element Temp = Head;
			while (Temp.pNext.pNext != null) Temp = Temp.pNext;
			Temp.pNext = null;
			Lenght--;
		}

		

	}
}
