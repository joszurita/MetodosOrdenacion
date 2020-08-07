using System;

namespace HeapSort
{
    class implementacion : IImplementaacion
    {
        public void MostrarArrays(int[] arr, string tipoMuestra)
        {
            if (tipoMuestra.ToLower()=="heapsort")
            {
                heapsort heap = new heapsort();
                int n = arr.Length, i;
                Console.WriteLine("Heap Sort");
                Console.Write("El vector inicial es: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                heap.heapSort(arr, n);
                Console.Write("\nEl vector arreglado es: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.ReadKey();
            }
            else if (tipoMuestra.ToLower() == "binarysort")
            {
                BinaryTree tree = new BinaryTree();
                Node root = new Node();
                int n = arr.Length, i;
                Console.WriteLine("BinaryTree Sort");
                Console.Write("Vector inicial: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.Write("\n\nVector arreglado: ");
                for (i = 0; i < n; i++)
                {
                    tree.Insert(arr[i]);
                }
                tree.DisplayTree();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El segundo parametro no coincide con los algoritmos de ordenamiento almacenados");
                Console.ReadKey();
            }
        }
    }
}
