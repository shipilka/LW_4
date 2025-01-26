//    static List<int> GetChange(int sum, int[] coins)
//    {
//        coins = coins.OrderByDescending(c => c).ToArray();
//        List<int> change = new List<int>();
//        int remaining = sum;

//        foreach (int coin in coins)
//        {
//            while (remaining >= coin)
//            {
//                change.Add(coin);
//                remaining -= coin;
//            }
//        }
//        if (remaining > 0) return null;
//        return change;
//    }

//int amount = 27;
//int[] coins = { 10, 5, 2, 1 };

//List<int> change = GetChange(amount, coins);
//if (change != null)
//{
//    Console.WriteLine($"Сдача для суммы {amount}: {string.Join(", ", change)}");
//}
//else
//{
//    Console.WriteLine($"Сдача для суммы {amount} не найдена.");
//}


//int amount2 = 6;
//int[] coins2 = { 1, 3, 4 };
//List<int> change2 = GetChange(amount2, coins2);
//if (change2 != null)
//{
//    //for (int i = 0; i < coins2.Length; i++)
//    //{
//    //    Console.Write($"{coins2[i]}\t");
//    //}

//    Console.WriteLine($"Сдача для суммы {amount2}: {string.Join(", ", change2)}");
//}
//else
//{
//    Console.WriteLine($"Сдача для суммы {amount2} не найдена.");
//}