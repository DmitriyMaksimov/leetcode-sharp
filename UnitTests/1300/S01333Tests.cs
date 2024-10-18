using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01333Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01333();
        sut.FilterRestaurants([[1, 4, 1, 40, 10], [2, 8, 0, 50, 5], [3, 8, 1, 30, 4], [4, 10, 0, 10, 3], [5, 1, 1, 15, 1]], 1, 50, 10).Should().Equal(3, 1, 5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01333();
        sut.FilterRestaurants([[1, 4, 1, 40, 10], [2, 8, 0, 50, 5], [3, 8, 1, 30, 4], [4, 10, 0, 10, 3], [5, 1, 1, 15, 1]], 0, 50, 10).Should().Equal(4, 3, 2, 1, 5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01333();
        sut.FilterRestaurants([[1, 4, 1, 40, 10], [2, 8, 0, 50, 5], [3, 8, 1, 30, 4], [4, 10, 0, 10, 3], [5, 1, 1, 15, 1]], 0, 30, 3).Should().Equal(4, 5);
    }
}
