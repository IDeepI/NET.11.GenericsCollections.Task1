using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET._11.GenericsCollections.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целочисленный массив
            var numericData = new int[]{ 8, 3, 10, 1, 6, 4, 7 };

            var numericBinaryTree = new BinaryTree<int>( numericData );

            // Добавляем еще числа
            numericBinaryTree.Add(14);
            numericBinaryTree.Add(16);
            numericBinaryTree.Add(null);

            Console.WriteLine(new string('-', 40));
            numericBinaryTree.PrintTree();
            Console.WriteLine(new string('-', 40));

            // Тесты студентов
            var studentsBinaryTree = new BinaryTree<StudentOnTest>();
            studentsBinaryTree.Add(new StudentOnTest() { Name = "Володя", Assessment = 53, TestDate = DateTime.Now, TestName = "ЕГЭ"});
            studentsBinaryTree.Add(new StudentOnTest() { Name = "Саша", Assessment = 67, TestDate = DateTime.Now, TestName = "ЕГЭ"});
            studentsBinaryTree.Add(new StudentOnTest() { Name = "Маша", Assessment = 22, TestDate = DateTime.Now, TestName = "ЕГЭ"});
            studentsBinaryTree.Add(new StudentOnTest() { Name = "Юля", Assessment = 85, TestDate = DateTime.Now, TestName = "ЕГЭ"});

            Console.WriteLine(new string('-', 40));
            studentsBinaryTree.PrintTree();
            Console.WriteLine(new string('-', 40));


            // Строки в список
            string rawdata = "ECTM.S1AG1210,2007.03,925.1,F,Dollars,6,Electronic Card Transactions(ANZSIC06) - ECT,Private - Values - Electronic card transactions  A / S / T by industry, Actual, Supermarket and grocery stores";
            var stringData = new List<string>();
            stringData = rawdata.Split(',').ToList();
            // Дерево строк
            var stringBinaryTree = new BinaryTree<string>(stringData);
            // Вывод в обратном порядке
            Console.WriteLine(new string('-', 40));
            foreach (var item in stringBinaryTree.GetReverseEnumerator())
            {
                Console.WriteLine($" {item} ");
            }
            Console.WriteLine(new string('-', 40));

            Console.ReadLine();
        }
    }
}
