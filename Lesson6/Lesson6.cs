using System;
using System.Collections.Generic;

namespace Lesson6
{
    internal class Lesson6
    {
        
        
        public static void Main(string[] args)
        {
            //Посмотрим на еще две полезные фичи при работе с циклами
            //Это инструкции continue и break.
            /*
            Если говорить про теорию то она примерно такая:
            Если в цикле встречается ключевое слово break, программа тут же выходит из цикла, дальнейшие итерации не будут выполняться
            Если в цикле встречается ключевое слово continue, программа тут же выходит из текущей итерации, однако остальные итерации будут выполняться.
            Думаю на примере будет более понятно
            
            */
            
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            /* 
             Будет напечатано:
                1
                2
                3
                4  
            */
            
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            /* 
             Будет напечатано:
                1
                2
                3
                4
                6
                7
                8
                9    
            */
  
            //Одно из заданий было дано уже в прошлом уроке, поэтому в этот раз ограничемся двумя
            
            //Задание 1. Дана строка. Нужно напечатать, является ли она полиндромом. Пока возьмем простые строки, без пробелов. Например
            string s1 = "abccba"; //Полиндром
            string s2 = "abcba"; //Тоже полиндром
            string s3 = "abcdef"; //не полиндром
            string itog1= "";
            string itog2= "";
            string itog3= "";
            

            for (int i=0; i < s1.Length; i++)
                {
                    if (s1[i] != s1[(s1.Length -1) - i])
                    {
                        itog1= "не полиндром";
                        break;
                    }
                    
                    
                    itog1 = "полиндром";
                    

                }
            Console.WriteLine(itog1);
           // Console.ReadLine();





                //Задание 3. Дан массив целых чисел. Длина массива >= 10. Распечатать их в обратном порядке по n чисел в строке. Где n задаваемое число < 10

            //Например вот я создал тестовый массив из 100 чисел
            int[] testArray = GenerateArray(100);
            int n = 3; //пусть пока n будет равно 5
            
            for (int j = testArray.Length - 1; j >= 0; j-=n)
            {
                string s = "";
                for (int k=0; k<n; k++)
                {
                    
                    if ((j - k) < 0)
                    {
                        break;
                    }
                    s+= testArray[j - k] + " ";
                } 
               
               Console.WriteLine(s);
            }
            Console.ReadLine();







        }
        

        private static int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }
        
    }
}