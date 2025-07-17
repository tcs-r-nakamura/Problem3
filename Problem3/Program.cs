class Program3
{
    /// <summary>
    /// ランダムな数値を表示するメソッド
    /// </summary>
    static void Main()
    {
        /* メソッドでランダムな数値を生成
         * resultに重複しない６個の数値がまとめてある*/
        HashSet<int> result = RandomNumbers(6, 1, 44);

        // 表示するメソッドを呼び出す
        ShowNumbers(result);
    }

    /// <summary>
    /// ランダムな重複しない数値を生成するメソッド
    /// </summary>
    /// <param name="count">6回分</param>
    /// <param name="min">１から</param>
    /// <param name="max">44まで</param>
    /// <returns></returns>
    static HashSet<int> RandomNumbers(int count, int min, int max)
    {//ランダムな数値を生成
        Random ran = new Random();
        return Enumerable.Range(min, max - min)  // min から max-1 までの連番
                           .OrderBy(x => ran.Next()) // ランダムに並び替え
                           .Take(count)               // 上から指定数だけ取る
                           .ToHashSet();                 // リストに変換
    }
    /// <summary>
    /// 数値を表示するメソッド
    /// </summary>
    /// <param name="numbers">ランダムな数値</param>
    static void ShowNumbers(HashSet<int> numbers)
    {
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}