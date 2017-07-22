﻿using System;
using System.Collections.Generic;

namespace Lesson5
{
    internal class Lesson5
    {
        public static void Main(string[] args)
        {
            //Сегодня поговорим о массивах
            //Но сначала немного дополнительной информации которая может быть полезной
            //Во многих языках программирования есть оператор %
            //Он возвращает остаток от деления одного числа от другого. Например

            int a = 10 % 2; // в а лежит 0
            a = 10 % 3; // в а лежит 1
            
            //Вопрос: что лежит в а теперь:
            a = 100 % 50;
            
            //а теперь?
            a = 1090 % 100;

            
            /*Также есть так называемые логические операторы, пока что остановимся на трёх &&, || и !
                && - это логическое и 
                || - логическое или
                ! - отрицание.
                Вообще бывает всего три вида операторов: унарный, бинарный и тернарный
                унарный работает только с одной переменной, бинарный с двумя, тернарый (существую только один такой) с тремя.
                Все! Остальные операторы - это их комбинации
                Как не сложно догадаться && и || это бинарные операторы, а ! - унарный.            
                Используются они так (сразу вспоминаем мат. логику и говорим чему равно b после каждой строчки):
            */

            int r = 1 + 2;
            bool y = true;
            bool x = false;
            bool b = true && false;
            b = b || true;
            b = !b;
            b = b && false;
            
            //Если теперь понятно что такое унарные и бинарные операторы (тернарные пока оставим), то назови унарные и бинарные операторы которые мы уже изучали до этого.
            
            //Ну все, хватит детских шалостей, пора переходить к действительно важным вещам: что лучше бигли или пастушьи колли?
            //На самом деле переходим к массивам.
            //Массив это всего лишь набор данных определенного типа, например так объявляется массив длинной 10 типа int
            int[] array = new int[10];
            
            //Внутри этого массива будет лежать 10 int'ов. При подобной инициализации массива, каждый его элемент будет инициализирован значением по-умолчанию.
            //Например для int значение по умолчанию это 0.
            //Задание 1. Т.к. при программировании часто необходимо гуглить незнакомые вещи, тебе необходимо найти значения по умолчанию для других известных тебе типов данных.
            //Если какие-то из значений непонятны, их тоже необходимо разобрать и если неясно - спросить.
            
            //Поехали работать с массивами дальше
            //Помимо уже упомянутого способа объявления массива есть и другие, например
            int[] array1 = new[] {10, 20, 1};
            //Так мы инициализировали массив с тремя элементами, которые явно указаны.
            //Для того чтобы взять элемент массива по его индексу нужно написать так:
            int item = array1[1]; 
            //в item будет лежать 20. Неопытный студент может спросить почему же 20, а не 10. Все дело в том что индексация в массиве идет с нуля. (Отсюда и все шуточки)
            
            //Вопрос:
            //можем ли мы так написать:
            //int item1 = array1[3];

            //Еще один способ инициализации массива
            int[] array3 = {10, 20, 1};

            //можно объявить массив любого типа данных, например
            bool[] array4 = {true, false, true};
            double[] array5 = {1.1, 2, 2.6};
            string[] array6 = {"aaa", "bbb", "ccc"};

            //А вот для типа данных лучше использова8ть обычный string, пока что просто воспринимать его как супер-пупер массив
            string str = "Test";
            char cr = str[1]; //в cr будет лежать e
            
            //чтобы изменить элемент в массиве по индексу нужно написать так:
            array[1] = 100;//второй элемент массива будет равен 100.
            //Со string такой фокус не сработает

            //Переходим к заданиям. Для всех заданий будем использовать один массив, который нельзя изменять (однако я изменю его когда буду проверять задание):
            int[] arrayForTests = {9, 1, 2, 5, 3, 4, 8, 0, 7, 6};
            //В этом массиве 10 элементов, однако тебе не надо каждый раз считать кол-во элеменов, для этого можно воспользовать такой функцией:
            int size = arrayForTests.Length; // в size будет лежать 10

            //Задание 2
            //Вывести элементы из массива которые одновременно делятся и на 2 и на 3 без остатка 

            int[] array7 = new[] {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            for (int i = 0; i <= 13; i++)
            {
                if ((array7[i] % 2 == 0) && (array7[i] % 3 == 0))
                { 
                    Console.WriteLine(array7[i] );
                }
                
            }
            //Console.ReadLine();
            
            //Задание 3
            //Вывести все элементы которые делятся на 2, но кроме тех которые делятся на 4.
            for (int j = 0; j <= 13; j++)
            {
                if ((array7[j] % 2 == 0) && (array7[j] % 4 != 0))
                { 
                    Console.WriteLine(array7[j]);
                }
            }
            //Console.ReadLine();
            
            //Задание 4
            //Написать программу которая выводит на экран два столбика: первый - массив как он есть, второй - массив в обратном порядке
            //Т.е. вывод будет такой
            /*
                9 6
                1 7
                2 0
                5 8
                3 4
                4 3
                8 5
                0 2
                7 1
                6 9
            */
            int[] array8 = new[] {9, 1, 2, 5, 3, 4, 8, 0, 7, 6, 10, 11, 14, 15, 20};
            int size2 = array8.Length;
            for (int k = 0; k < size2; k++)
            {

               
                    Console.WriteLine(array8[k] + " " + array8[(size2-1) -k]);
                
            }

            //Console.ReadLine();
            //Задание 4.
            //Дан массив. Вывести на экран максимальное значение в массиве и его индекс. И минимальное значение и его индекс
            //Кто сделает это за один цикл, тот молодец
            int[] array9 = new[] {2, 3, 6, 5, 8, 9, 21, 4, 1, 13, 15};
            int size3 = array9.Length;
            int max = array9[0];
            int min = array9[0];
            int t = 0;
            int w = 0;
            for (int q = 0; q < size3; q++)
                {
                    if (array9[q] > max)
                    {
                        max = array9[q];
                        t = q;
                    }
                    
                    if (array9[q]<min)
                    {
                        min = array9[q];
                        w= q;
                    }
                    
                }
            
            
            
            Console.WriteLine("max = " + max + " индекс = "+ t);
            Console.WriteLine("min = " + min +" индекс = "+ w);

            Console.ReadLine();

        }
    }
}