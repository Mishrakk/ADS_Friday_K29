using System;

namespace HeapSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 9, 5, 6, 4, 8, 10 };

            Console.WriteLine("Hello, We are sorting this array: ");
            PrintArray(array);
            Console.WriteLine("After sorting, array looks like this: ");
            Sort(array);
            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));

        }
        public static void Sort(int[] array)
        {
            BuildHeap(array);
            HeapSort(array);
        }
        public static void BuildHeap(int[] array)
        {
            int heapSize = array.Length;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                SiftDown(i, array, heapSize);
            }
        }
        public static void SiftDown(int index, int[] array, int heapSize)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;

            if (leftChildIndex >= heapSize && rightChildIndex >= heapSize)
            {
                return;
            }

            int maxIndex = -1;
            if (leftChildIndex < heapSize)
            {
                maxIndex = leftChildIndex;
            }
            if (maxIndex == -1 || rightChildIndex < heapSize && array[rightChildIndex] > array[leftChildIndex])
            {
                maxIndex = rightChildIndex;
            }

            if (array[index] < array[maxIndex])
            {
                int temp = array[index];
                array[index] = array[maxIndex];
                array[maxIndex] = temp;
                SiftDown(maxIndex, array, heapSize);
            }
        }
        public static void HeapSort(int[] array)
        {
            int heapsize = array.Length;
            while (heapsize > 0)
            {
                int maxElem = HeapPop(array, heapsize);
                heapsize--;
                array[heapsize] = maxElem;
            }
        }
        public static int HeapPop(int[] array, int heapsize)
        {
            int output = array[0];
            array[0] = array[heapsize - 1];
            SiftDown(0, array, heapsize);
            return output;
        }
    }
}