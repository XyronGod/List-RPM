using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
	class MyList<T>
	{
		public void Add (T value)
		{
		     Node<T> name = new Node<T>();
		     name.value = value;
			 if ( firstElement == null)
			 {
				firstElement = name;
			 }
			 else
			 {
				GetLast().next = name;
			 }
		}
		Node<T> GetLast()
		{
			Node<T> last = firstElement;
			while (last.next != null)
				last = last.next;
			return last;
		}
		Node<T> firstElement;
		public void Print()
		{
			Node<T> last = firstElement;
			while(last != null)
			{
				Console.WriteLine(last.value);
				last = last.next;
			}
		}
	}
	
}
