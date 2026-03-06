using System.Data;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali number");
            Console.WriteLine("1. Where");
            Console.WriteLine("2. ");
            Console.WriteLine("3. Select");
            Console.WriteLine("4. Skip, SkipWhile");
            Console.WriteLine("5. TakeWhile");
            Console.WriteLine("6. ");
            Console.WriteLine("7. Avarage, Count, Sum, Max, Min");
            Console.WriteLine("8. ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Where();
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        public static void Where()
        {
            var where = ClientData.client
                .Where(x => x.City =);

            foreach (var item in where)
            {
                Console.WriteLine(item.City);
            }
        }
    }
}