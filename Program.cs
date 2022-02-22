using System.Collections;
namespace arrayList1
{
    class Program
    {

        public static void Printout(IEnumerable tarylst)
        {
            int n = 1;
            foreach (Object obj in tarylst)
            {
                Console.WriteLine("第{0}個元素資料內容：{1}", n, obj);
                n++;
            }
        }

        static void Main(string[] args)
        {
            ArrayList arylst = new ArrayList();
            arylst.Add("Alice");
            arylst.Add("Bob");
            arylst.Add(168);
            arylst.Add(true);

            //或者可以寫成下面的語法
            //ArrayList arylst = new ArrayList {"Alice", "Bob", 168, true};
            
            //新增多個資料於結尾處
            arylst.AddRange(new string[] { "David", "Eric" });

            //新增資料於指定索引
            arylst.Insert(2, "Jack");

            //新增資料於結尾處
            arylst.Add("Ford");
            
            Console.WriteLine("\n目前 arylst 可存放元素總容量：{0}", arylst.Count);

            int n = 1;
            foreach (object s in arylst)
            {
                Console.WriteLine("第 {0}個元素資料容量：{1}", n, s);
                n++;
            }

            //移除指定元素
            arylst.Remove("Ford");

            //移除指定索引的元素
            arylst.RemoveAt(2);

            //移除區間索引的元素，以下為索引2取後3(包含索引2在內)
            arylst.RemoveRange(2, 3);

            Console.WriteLine("\n目前 arylist 可存放元素總容量：{0}", arylst.Capacity);
            Console.WriteLine("目前 arylist 內所有元素共計：{0}", arylst.Count);
            Printout(arylst);

            //移除陣列串列所有元素
            arylst.Clear();

            Console.WriteLine("\n目前 arylist 可存放元素總容量：{0}", arylst.Capacity);
            Console.WriteLine("已移除 arylist 內所有元素,目前元素共計：{0}", arylst.Count);

            Console.Read();
        }
    }
}