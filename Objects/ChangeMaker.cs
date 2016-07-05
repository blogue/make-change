using System.Collections.Generic;

namespace ChangeMaker.Objects
{
  public class Coins
  {
    private static List<int> _coins = new List<int> {25, 10, 5, 1};
    private static List<int> _change = new List<int> {0, 0, 0, 0};

    public static List<int> MakeChange(int num)
    {
      for (int i = 0; i < _coins.Count; i++)
      {
        while(num >= _coins[i])
        {
          _change[i]++;
          num -= _coins[i];
        }
      }
      return _change;
    }
    public static void DeleteAll()
    {
      _change.Clear();
    }
  }
}
