using System;
using System.Collections.Generic;

class Program3
{
    static void Main()
    {
        /* メソッドでランダムな数値を生成
         * resultに重複しない６個の数値がまとめてある*/
        HashSet<int> result = RandomNumbers(6, 1, 44);

        // 表示するメソッドを呼び出す
        ShowNumbers(result);
    }

    // ランダムな重複しない数値を生成するメソッド
    static HashSet<int> RandomNumbers(int count, int min, int max)
    {//ランダムな数値を生成
        Random ran = new Random();
        //重複しない数字
        HashSet<int> result = new HashSet<int>();

        while (result.Count < count)
        {
            // 1～43
            int randomNumber = ran.Next(min, max);
            // HashSetで重複防止
            result.Add(randomNumber); 
        }

        return result;
    }

    // 数値を表示するメソッド
    static void ShowNumbers(HashSet<int> numbers)
    {
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}