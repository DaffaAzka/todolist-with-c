using System;
using System.Collections;
using System.Numerics;
using todolist.data;
using todolist.utilities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static Utilities util = new Utilities(Database.data);
    

        static void Main(string[] args)
        {
            while(true)
            {

                Console.WriteLine("TODO LIST WITH C#");
                showTodo();
                Console.WriteLine("=======================");
                Console.WriteLine("a. add Todo");
                Console.WriteLine("e. edit Todo");
                Console.WriteLine("d. delete Todo");
                Console.WriteLine("else?. Exit");
                Console.WriteLine("=======================");

                String input = Console.ReadLine();

                if (input == "a")
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("ADD TODOLIST");
                    String s = Console.ReadLine();
                    util.addTodo(s);
                    Console.WriteLine("=======================");
                }
                else if (input == "e")
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("Edit TODOLIST");

                    try
                    {
                        int i = Int32.Parse(Console.ReadLine());
                        String s = Console.ReadLine();
                        util.editTodo(i, s);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR! TRY AGAIN!");
                    }

                    Console.WriteLine("=======================");
                }
                else if (input == "d")
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("Delete TODOLIST");
                    try
                    {
                        int i = Int32.Parse(Console.ReadLine());
                        util.removeTodo(i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR! TRY AGAIN!");
                    }
                    Console.WriteLine("=======================");
                }
                else
                {
                    break;
                }
            }
        }

        static void showTodo()
        {
            for (int i = 0; i < util.data.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + util.data[i]);
            }
        }

        

        

    }
}
