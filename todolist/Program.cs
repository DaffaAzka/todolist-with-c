using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<String> data = new List<string>();
        static void Main(string[] args)
        {
            while (true)
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
                    addTodo(s);
                    Console.WriteLine("=======================");
                } else if (input == "e")
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("Edit TODOLIST");
                    try
                    {
                        int i = Int32.Parse(Console.ReadLine());
                        String s = Console.ReadLine();
                        editTodo(i, s);
                    } catch (Exception e)
                    {
                        Console.WriteLine("ERROR! TRY AGAIN!");
                    }
                    Console.WriteLine("=======================");
                } else if (input == "d") {
                    Console.WriteLine("=======================");
                    Console.WriteLine("Delete TODOLIST");
                    try
                    {
                        int i = Int32.Parse(Console.ReadLine());
                        deleteTodo(i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR! TRY AGAIN!");
                    }
                    Console.WriteLine("=======================");
                } else {
                    break;
                }
            }
        }

        static void showTodo()
        {
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + data[i]);
            }
        }

        static void addTodo(String s)
        {
            data.Add(s);
        }

        static void editTodo(int i, String s)
        {
            try
            {
                data[i - 1] = s;
            } catch (Exception e)
            {
                Console.WriteLine("Data NOT FOUND!");
            }
        }

        static void deleteTodo(int i)
        {
            try
            {
                data.RemoveAt(i - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Data NOT FOUND!");
            }
        }
    }
}
