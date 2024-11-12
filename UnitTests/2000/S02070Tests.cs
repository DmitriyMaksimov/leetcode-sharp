using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02070Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02070();
        sut.MaximumBeauty([[1, 2], [3, 2], [2, 4], [5, 6], [3, 5]], [1, 2, 3, 4, 5, 6]).Should().Equal(2, 4, 5, 5, 6, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02070();
        sut.MaximumBeauty([[1, 2], [1, 2], [1, 3], [1, 4]], [1]).Should().Equal(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02070();
        sut.MaximumBeauty([[10, 1000]], [5]).Should().Equal(0);
    }
}