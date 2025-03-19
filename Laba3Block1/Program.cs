namespace Laba3Block1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Input();
            Output(Block1Var13(ref array));

        }

        public static int[] RandomInput()
        {

            Console.WriteLine("Введiть кiлькiсть елементів у масивi");
            int lenght = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1000, 1000);
            }
            return array;
        }



        public static int[] Input()
        {
            Console.WriteLine("введіть елементи");
            string s = Console.ReadLine();
            string[] sArray = s.Split();
            int[] array = new int[sArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(sArray[i]);
            }

            return array;
        }


        public static int[] Block1Var13(ref int[] array)
        {
            int max = array[0];
            int countOfMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == max) countOfMax++;
            }

            if (max % 2 != 0)
            {
                return array;
            }
            else
            {
                Array.Resize(ref array, array.Length + countOfMax);

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        array[i] = array[i] / 2;
                        array[array.Length - 1] = array[i];

                        for (int j = array.Length - 1; j > i; j--)
                        {
                            int temp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = temp;

                        }
                    }
                }
            }
            return array;
        }

        public static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}




