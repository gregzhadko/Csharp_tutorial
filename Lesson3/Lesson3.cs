﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            //Сегодня изучим циклы. Но для начала еще один интересный момент с операциями

            int value = 10;
            value += 1; //кое-что подобное уже было, к существующему значению прибавляем число. Но конекретно в случае с 1 есть еще более короткая запись:
            value++; //эта запись эквивалента строчке выше. А еще можно написать так
            ++value; //в данном случае и эта строчка тоже эквивалента. Есть одно различие, но об этом мы поговорим позже.
            //это называется оператор инкремента. Также есть оператор декремента, работает также
            value--;

            //чему равно value?

            //В мирской суматохе, на прошлом уроке мы обсудили все операторы сравнения кроме одного тоже важного.
            //Как проверить что два значения не равны? Необходимо использовать оператор !=

            if(5 != 6)
            {
                Console.WriteLine("Достаточно очевидно что 5 не равно 6");
            }

            //Или же так:

            int a = 1;
            int b = 2;
            if(a != b)
            {
                Console.WriteLine("Ты не поверишь, но 1 не равно 2, что за глупые проверки?");
            }


            //А теперь короли сегодняшнего бала: циклы.
            //В общем, цикл это набор операций который повторяется некоторое количество раз

            //Самый простой из них это цикл while

            int i = 0;
            while (i < 5) //Условие которое проверятся каждый раз перед началом выполнения операция внутри цикла. Также как и с циклом if внутри скобок может быть только true или false
            {             //Внутри фигурных скобок - операции для выполнения.
                Console.WriteLine(i);
                i++;    //о, наш новый друг, оператор инкремента.
            }
            //как можно догадаться программа будет выводить на экран число лежащее i, пока оно не будет равно 5
            //еще есть очень близкий к циклу while цикл do while

            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            //В целом работает также, единственное отличие в том что операции в скобках выполнятся хотя бы один раз
            //Наверное, бывает полезным, но я никогда не пользовался, мне кажется бесполезной, в целом, штукой.


            //Задание 1:
            //Пользователь вводит любое число больше 0
            //Программа выводит все числа от этого числа до 0
            //Console.WriteLine("vvedite CHISLO bolse nylya");
            //String X = Console.ReadLine();
            //int chislo = Convert.ToInt32(X);

            //while (chislo > 0)
            //{
            //    Console.WriteLine(chislo);
            //    chislo--;
            //}
            //Console.ReadLine();

            //Задание 2:
            //Пользователь вводит любое число больше 1
            //Программа выводит сумму всех чисел от 1 до этого числа

            //Console.WriteLine("vvedite CHISLO bolse 1");
            //String X = Console.ReadLine();
            //int chislo = Convert.ToInt32(X);
            //int sum = 0;

            //while (chislo > 0)
            //{
            //    sum = sum + chislo;
            //    chislo--;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //Задание 3:
            //Написать программу которая спрашивает имя пользователя до тех пор пока он не введет Аня.
            //Если имя пользователя неверно просить пользователя ввести имя еще раз.
            //Если имя правильно то возрадоваться и сказать спасибо Богу программированию

            //Console.WriteLine("vvedite imya");
            //string name = Console.ReadLine();
            
            ////if (name == "Anya")
            ////{
               
            ////}
            ////else
            ////{
            //    while (name != "Anya")
            //    {
            //        Console.WriteLine("vvedite imya");
            //        name = Console.ReadLine();
            //        //Console.ReadLine();
                    
            //    }
            //Console.WriteLine("thak you puuuuups!");
            //Console.ReadLine();






            //Вопрос с *
            //Допускается ли написать так? и если да то что будет происходить во время выолнения команды

            
           /* bool testValue = true;
            while (testValue)
            {
                Console.WriteLine("Происходит чёрте что!");
            }
            */

           
            string name = "";
            while (name != "Anya")
            {
                Console.WriteLine("Vvedite imya pani: ");
                name = Console.ReadLine();
            }

            
            string name2 = "";
            while (name2 != "Grisha")
            {
                Console.WriteLine("vvedite imya pana");
                name2 = Console.ReadLine();
            }

            Console.WriteLine("super parochka");        
            Console.ReadLine();


            //Еще одно задание
            //Пользователь вводит число х. Программа выводит число из последовательности фибоначи которое в этой последовательности имеет номер х.
            //Например если последовательность 1 1 2 3 5 8 13 а пользователь ввел 4, то должно вывести 3.
        }
    }
}
