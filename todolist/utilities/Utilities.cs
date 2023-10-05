

using todolist.data;

namespace todolist.utilities
{
    public class Utilities
    {

        public List<String> data;

        public Utilities(List<string> data)
        {
            this.data = data;
        }

        public void removeTodo(int s)
        {
            try
            {
                data.RemoveAt(s - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("DATA NOT FOUND");
            }
        }

        public void editTodo(int i, String s)
        {
            try
            {
                data[i - 1] = s;
            }
            catch (Exception e)
            {
                Console.WriteLine("DATA NOT FOUND");
            }
        }

        public void addTodo(String s)
        {
            if (s == null)
            {
                Console.WriteLine("Iseng ya masukin null?");
            }
            else
            {
                data.Add(s);
            }

        }
    }
}
