namespace Sem2Laba3
{
    public class Andriy
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть спосіб заповнення масиву 1 - самостійно | 2 - рандомно ");
            int howToInputArray = int.Parse(Console.ReadLine());

            switch (howToInputArray)
            {
                case 1:
                    int[][] array = Input();
                    AndriyBlock2(ref array);
                    Output(array);
                    break;

                case 2:
                    int[][] array2 = RandomInput();
                    Output(array2);
                    AndriyBlock2(ref array2);
                    Output(array2);
                    break;


            }
        }

        public static int[][] RandomInput()
        {
            Console.WriteLine("Введiть кiлькiсть одновимiрних масивiв");
            int first = int.Parse(Console.ReadLine());

            int[][] array = new int[first][];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введіть кількість елементів в одновимірному масиві ");
                int countOfElements = int.Parse(Console.ReadLine());
                array[i] = new int[countOfElements];

                for (int j = 0; j < array[i].Length; j++)
                {

                    array[i][j] = r.Next(-20, 20);
                }
            }
            return array;
        }

        public static int[][] Input()
        {
            Console.WriteLine("Введiть кiлькiсть одновимiрних масивiв");
            int first = int.Parse(Console.ReadLine());

            int[][] array = new int[first][];

            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("Введiть числа через пробiл");
                string s = Console.ReadLine();
                string[] stringElements = s.Split();
                array[i] = new int[stringElements.Length];

                for (int j = 0; j < stringElements.Length; j++)
                {
                    array[i][j] = int.Parse(stringElements[j]);

                }
            }
            return array;
        }

        public static int[][] AndriyBlock2(ref int[][] array)
        {

            bool isZero;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                isZero = false;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }

                if (!isZero)
                {
                    array[index] = array[i];
                    index++;
                }
            }
            Array.Resize(ref array, index);
            return array;


        }

        public static void Output(int[][] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожнiй");
                return;
            }
            Console.WriteLine("--------------------");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
        }
    }
}
