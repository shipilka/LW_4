
//    static int FindLocalMaximum(int[] arr)
//    {
//        int n = arr.Length;
//        if (arr == null || n <= 1)
//        {
//            return -1;
//        }

//        for (int i = 1; i < n - 1; i++)
//        {
//            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
//            {
//                return i;
//            }
//        }

//        if (arr[0] > arr[1])
//        {
//            return 0;
//        }

//        if (arr[n - 1] > arr[n - 2])
//        {
//            return n - 1;
//        }

//        return -1;
//    }

//int[] arr1 = { 1, 3, 7, 5, 8 };
//int index1 = FindLocalMaximum(arr1);
//Console.WriteLine($"Для массива: {string.Join(", ", arr1)},  локальный максимум на позиции {index1}");

//int[] arr2 = { 5, 19, 7, 5, 20 };
//int index2 = FindLocalMaximum(arr2);
//Console.WriteLine($"Для массива: {string.Join(", ", arr2)},  локальный максимум на позиции {index2}");