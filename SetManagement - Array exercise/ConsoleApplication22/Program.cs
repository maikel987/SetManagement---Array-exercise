using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)  // AJOUTER TOUS LES CONTROLE DE FORME "é(è@"
        {
            //-Create 2 sets by drawing 12 random numbers in the range of 
            //0…1000 for each set, and display the sets contents.
            Random Ran = new Random();
            int[] firstArr = new int[12];
            int[] secondArr = new int[12];
            int longuer = 1001; 

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = Ran.Next(longuer);
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = Ran.Next(longuer);
            }

            Set set1 = new Set(firstArr);
            Set set2 = new Set(secondArr);            

            Console.Write("first Set: \t\t");
            Console.WriteLine(set1.ToString());
            Console.Write("Second Set: \t\t");
            Console.WriteLine(set2.ToString());

            //- Perform intersection and union of the two sets and display the received sets.
            Set tempSet = new Set();
            tempSet.Union(set1);
            Console.Write("After Intersec: \t");
            tempSet.Intersect(set2);
            Console.WriteLine(tempSet.ToString());

            Set tempSet2 = new Set();
            tempSet2.Union(set1);
            Console.Write("After Union: \t\t");
            tempSet2.Union(set2);
            Console.WriteLine(tempSet2.ToString());

            //- Get from the user 3 numbers and create a 
            //third set.Check whether this set is a sub-set 
            //of one of the sets and display the result.
            Console.WriteLine();
            Console.WriteLine("Enter 3 numbers to Check whether this set is a sub-set of one of the sets.");
            int[] tempArr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int temp;
                bool isWrong = !int.TryParse(Console.ReadLine(), out temp);
                if (temp < 0 || temp > 1000|| isWrong)
                {
                    Console.WriteLine("Wrong Value");
                    i--;
                }
                else
                {
                    tempArr[i] = temp;
                }
            }
            Set set3 = new Set(tempArr);
            Console.WriteLine(set3.ToString());
            Console.WriteLine("Is the 3rd Set is a Sub-Set of 1st Set: {0}",set1.Subset(set3));
            Console.WriteLine("Is the 3rd Set is a Sub-Set of 2nd Set: {0}", set2.Subset(set3));

            //- Get from the user a number and check whether it is a member of each set and display the result.
            Console.WriteLine();
            Console.WriteLine("Enter a number to check whether it is a member of each set");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Wrong Value");
            }
            Console.WriteLine("Is the number par of 1st Set: {0}",set1.IsMember(num));
            Console.WriteLine("Is the number par of 2nd Set: {0}", set2.IsMember(num));

            //- Get from the user a number and insert it to each set, then display them after the addition.
            Console.WriteLine();
            Console.WriteLine("Enter a number to insert it to each set.");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Wrong Value");
            }
            set1.Insert(number);
            set2.Insert(number);
            Console.WriteLine("after adding {0}, 1st Set is: {1}", number,set1.ToString());
            Console.WriteLine("after adding {0}, 2nd Set is: {1}",number, set2.ToString());

            //- Get from the user another number, delete it from the two sets and display them after the deletion.
            Console.WriteLine();
            Console.WriteLine("Enter another number to delete from the two sets.");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Wrong Value");
            }
            set1.Delete(num2);
            set2.Delete(num2);
            Console.WriteLine("after deleting {0}, 1st Set is: {1}", num2, set1.ToString());
            Console.WriteLine("after deleting {0}, 2nd Set is: {1}", num2, set2.ToString());

        }
    }
}
