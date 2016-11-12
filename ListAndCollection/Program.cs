using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<T>
            #region MyRegion
            //List<string> strlist = new List<string>();
            //strlist.Capacity = 5; //Глубина списка без изменения размера
            //strlist.Add("C#"); //добавление елемента в конец списка
            //strlist.Add("the");
            //strlist.Add("best");
            //strlist.Add("from");
            //strlist.Add("language");
            //Console.WriteLine(strlist[0]); //обращение к елементу по индексу
            //Console.WriteLine("-----------------base list------------");
            //Console.ForegroundColor = ConsoleColor.Red;

            //foreach (var item in strlist) //"проход" по всем елементам списка

            //{
            //    Console.WriteLine(item);
            //}

            //List<string> sublist = new List<string>(2); //задание размера списка через конструктор
            //sublist.Add("some");
            //sublist.Add("string");
            //strlist.AddRange(sublist); //добавление доп. списка в конец основного
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("-------------------AddRange--------------");
            //foreach (var item in strlist)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("capacity list = {0}", strlist.Count); // текущий размер списка

            //string[] stringfromlist = new string[2];
            //sublist.CopyTo(stringfromlist);
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("--------------------CopyTo-------------");
            //foreach (var value in stringfromlist)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("------------SORT--------------------");
            //strlist.Sort();
            //foreach (var value in strlist)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("-------------REVERSE------------------");
            //strlist.Reverse();
            //foreach (var value in strlist)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("--------------CLEAR-------------------");
            //sublist.Clear();

            //Console.WriteLine(sublist.Count);
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("--------------AsReadOnly---------------");
            //IList<string> readonlylist = strlist.AsReadOnly();
            //try
            //{

            //    readonlylist[2] = "hello";
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //foreach (var item in readonlylist)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("--------------Containce-----------------");
            //Console.WriteLine("Element hello containce - {0}", strlist.Contains("hello"));
            //Console.WriteLine("Element string containce - {0}", strlist.Contains("string"));
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("----------------Find--------------------");
            //strlist.Add("string");
            //foreach (var item in strlist) //"проход" по всем елементам списка

            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("позиция первого вхождения = {0}", strlist.FindIndex(x=>x.Contains("string")));
            //Console.WriteLine("-----------------BinarySearch-------------");
            //Console.WriteLine("Поиск {0}" , strlist.BinarySearch("string"));
            #endregion

            #region LinkType
            List<ListSS> lss = new List<ListSS>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            lss.Add(new ListSS("Petrov", 23));
            lss.Add(new ListSS("Sidorov", 44));
            lss.Add(new ListSS("Ivanov", 99));


            //foreach (var item in lss)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine("---------------BinarySearch------------------");
            //ListSS ils = new ListSS();
            //Console.WriteLine("find index = {0}", lss.BinarySearch(new ListSS("Ivanov", 99), ils));
            //Console.WriteLine("--------------sort link types---------------");
            //lss.Sort();
            //foreach (var item in lss)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("----------------equals-----------------------");
            //Console.WriteLine(lss[0].Equals(lss[1]));
            //Console.WriteLine(lss[0].Equals(lss[0]));


            #endregion
            #endregion

            #region ArrayList
            //ArrayList arr_list = new ArrayList();
            //arr_list.Add("144");
            //arr_list.Add("C#");
            //arr_list.Add("3.14");
            //string[] arr_str = new string[arr_list.Count];
            //arr_str = (String[])arr_list.ToArray(typeof(string));
            //foreach (var item in arr_str)
            //{
            //    Console.WriteLine(item);
            //}

            //arr_list.AddRange(lss);
            //int i = 0;
            //foreach (var item in arr_list)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(arr_list[i].GetType());
            //    i++;
            //}


            #endregion

            #region Dictionary<TKey, TValue>
            Dictionary<int, string> mydict = new Dictionary<int, string>();
            mydict.Add(1, "C#");
            mydict.Add(2, "best");
            mydict.Add(3, "in ");
            mydict.Add(4, "world");

            foreach (var item in mydict)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("Key 2 is - > {0}", mydict.ContainsKey(2));
            Console.WriteLine("Value \" in \" is - > {0}", mydict.ContainsValue("in"));
            

            #endregion

            Console.ReadKey();
        }
    }
}
