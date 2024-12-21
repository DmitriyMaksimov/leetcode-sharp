using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02872Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02872();
        sut.MaxKDivisibleComponents(5, [[0, 2], [1, 2], [1, 3], [2, 4]], [1, 8, 1, 4, 4], 6).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02872();
        sut.MaxKDivisibleComponents(7, [[0, 1], [0, 2], [1, 3], [1, 4], [2, 5], [2, 6]], [3, 0, 6, 1, 5, 2, 1], 3).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02872();
        sut.MaxKDivisibleComponents(7, [[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]], [1000000000,1000000000,1000000000,1000000000,1000000000,1000000000,1000000000], 7).Should().Be(1);
    }
}
