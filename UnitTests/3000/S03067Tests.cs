using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03067Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03067();
        sut.CountPairsOfConnectableServers([[0, 1, 1], [1, 2, 5], [2, 3, 13], [3, 4, 9], [4, 5, 2]], 1).Should().Equal(0, 4, 6, 6, 4, 0);
    }

    [Test]
    public void T2()
    {
        var sut = new S03067();
        sut.CountPairsOfConnectableServers([[0, 6, 3], [6, 5, 3], [0, 3, 1], [3, 2, 7], [3, 1, 6], [3, 4, 2]], 3).Should().Equal(2, 0, 0, 0, 0, 0, 2);
    }
}
