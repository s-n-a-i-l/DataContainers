using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForwardList
{
	internal class Element
	{

		public int Data { get; set; }
		public Element pNext { get; set; }
		public Element pRev { get; set; }

		//public Element(int Data, Element pNext = null, Element Next = null) 
		//{
		//    this.Data = Data;
		//	this.pNext = pNext;
		//	this.Next = Next;
		//	Console.WriteLine($"EConstructor:\t{GetHashCode()}");
		//}


		public Element(int Data, Element pNext = null, Element pRev = null)
		{
			this.Data = Data;
			this.pNext = pNext;
			this.pRev = pRev;

			Console.WriteLine($"EConstructor:\t{GetHashCode()}");
		}

		~Element()
		{
			Console.WriteLine($"EDestructor:\t{GetHashCode()}");
		}
	}
}
