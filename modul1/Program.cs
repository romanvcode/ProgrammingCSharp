namespace modul1
{
    /*
     Варіант 1:
    Створіть клас ArrayManipulator, який має методи для роботи з масивами цілих чисел:
    Метод GenerateRandomArray(int length, int min, int max), який створює та повертає новий масив заданої довжини з випадковими числами в діапазоні від min до max.
    Метод FindMax(int[] array), який знаходить та повертає найбільший елемент у масиві.
    Метод SortArray(int[] array), який сортує масив у зростаючому порядку.

    Після створення класу запустіть програму, яка створює масив, знаходить найбільший елемент та сортує масив. Виведіть початковий масив, знайдений максимум та відсортований масив на консоль.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayManipulator.GenerateRandomArray(10, 0, 100);

            Console.WriteLine("Task 1: Random array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nTask 2: Max value:");
            int maxValue = ArrayManipulator.FindMax(array);
            Console.WriteLine(maxValue);

            Console.WriteLine("\nTask 3: Sorted array:");
            ArrayManipulator.SortArray(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        class Bla
        {
            public string Name { set; get; }
        }
    }
}
