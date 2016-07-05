using Xunit;
using ChangeMaker.Objects;
using System.Collections.Generic;
using System;

namespace ChangeMaker
{
  public class ChangeMakerTest : IDisposable
  {
    [Fact]
    public void ChangeMaker_Test()
    {
      List<int> newTest = new List<int> {3, 1, 0, 1};
      List<int> changeResult = Coins.MakeChange(86);
      Assert.Equal(newTest, changeResult);
    }
    public void Dispose()
    {
      Coins.DeleteAll();
    }
  }
}
