using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DexitovyTypyXD;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DexituvList<int>         list   = new DexituvList<int>();
            DexituvHodTamCokolivList aList  = new DexituvHodTamCokolivList();
            DexituvZasobnik<int>     stack  = new DexituvZasobnik<int>();
            DexitovaFronta<int>      fronta = new DexitovaFronta<int>();

            stack.Push(5);   
            int neco = stack.Pop();
            stack.Push(neco);
            neco = stack.Peek();

            fronta.Enqueue(5);
            fronta.Enqueue(6);
            fronta.Enqueue(7);
            int jej = fronta.Dequeue();
            jej = fronta.Dequeue();

            list.Add(5);
            aList.Add(5);

            foreach (int num in list)
                Console.WriteLine(num);

            Console.ReadKey(true);

            Stack<Stack<Stack<Stack<Stack<int>>>>> stackovic = new Stack<Stack<Stack<Stack<Stack<int>>>>>();
            //stackovic.Push(new Stack<Stack<Stack<Stack<int>>>>(new Stack<Stack<Stack<int>>>(new Stack<Stack<int>>(new Stack<int>( )))));

            //IndexOf(item)
            //Insert(index, item)
            //Reverse()
            //Sort()
            //Remove(item)
            //RemoveAt(index)
            //Clear()
        }
    }
}
