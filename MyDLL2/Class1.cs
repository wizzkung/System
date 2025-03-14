namespace MyDLL2
{
    public class SuperClass
    {
        public void think4()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int highest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > highest)
                {
                    highest = arr[i];
                }
            }
            Console.WriteLine(highest);

        }

        public void think3()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int lowest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                }
            }
            Console.WriteLine(lowest);
        }

        public void think2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum / arr.Length);
        }

        public void think(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine( num + " is: " + fact);
        }

        public void think5(int num)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
