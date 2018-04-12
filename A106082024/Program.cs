using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A106082024
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.ReadLine();
                // 1. 將所有號碼都放入List之中
                List<int> numbers = new List<int>(); 

                for(int i = 1; i<43; i++)
                {
                    numbers.Add(i); 
                }

                Console.ReadLine();
                Random rand = new Random();
                for (int i = 0; i < 10; i++)
                {
                    
                    // 2. 隨機挑選其中一個印出
                    int r = rand.Next(1,numbers.Count);

                    Console.WriteLine(numbersp[r] + "" );
                    
                    // 3. 並從 List 中刪除
                    numbers.RemoveAt(r);
                 }
                   Console.ReadLine();  
            }
        }  
    }
}
