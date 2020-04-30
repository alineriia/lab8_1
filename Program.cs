using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написати статичний метод ChangeMatrix, що виконує вказані дії над елементами матриці дійсних чисел
(матрицю заповнити рандомно або з файла!! в Main()).
Формальні параметри : матриця дійсних чисел, задана дія – об'єкт Action/Func.
Використовуючи написаний метод:
 вивести матрицю на екран;
 вивести на екран позитивні (>=0) елементи матриці;
 збільшити в три рази всі позитивні елементи матриці.
Після виклику останньої дії – вивести змінену матрицю на екран
static void MethodAct(int[,] arr, Action<int> act);
static void MethodFunc(int[,] arr, Func<int, int> act)
static void Show(int num)
static void ShowPositive(int num)
static int Mult3(int num)
static void Main(string[] args)
*/
namespace lab8_1
{
    class Program
    {
        static void MethodAct(int[,] arr, Action<int> act)
        {
            if (arr == null)
            {
                Console.WriteLine("Your matrix is empty");
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        act(arr[i, j]);
                }
            }
        }
        public static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            if (arr == null)
            {
                Console.WriteLine("Your matrix is empty");
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        act(arr[i, j]);
                }
            }
        }
        public static void Main()
        {
            int[,] Matrix = new int[3, 2];
            Random rnd = new Random();
            for (int i = 0; i != Matrix.GetLength(0); i++)
                for (int j = 0; j != Matrix.GetLength(1); j++)
                    Matrix[i, j] = rnd.Next(-50,50);
            Console.WriteLine("\nMATRIX:");
            MethodAct(Matrix, Show); 
            Console.WriteLine("\nPOSITIVE ELEMENTS:");
            MethodAct(Matrix, ShowPositive);
            Console.WriteLine("\n3*MATRIX:");
            MethodFunc(Matrix, Mult3);
            //MethodAct(Matrix, Show);
            Console.ReadKey();

        }
        static void Show(int num)
        {
           Console.Write(num+ " " );
            
        }
        static void ShowPositive(int num)
        {
            if (num >= 0)
                Console.Write(String.Format("{0} ", num));
        }
        static int Mult3(int num)
        {
            if (num >= 0)
            {
                Console.Write(String.Format("{0} ", 3*num));
                return 3*num;
            }
            else
            {
                Console.Write(String.Format("{0} ", num));
                return num;
            }
        }
       
    }
}
