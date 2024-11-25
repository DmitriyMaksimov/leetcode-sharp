using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03015Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03015();
        sut.CountOfPairs(3, 1, 3).Should().Equal(6, 0, 0);
    }

    [Test]
    public void T2()
    {
        var sut = new S03015();
        sut.CountOfPairs(5, 2, 4).Should().Equal(10, 8, 2, 0, 0);
    }

    [Test]
    public void T3()
    {
        var sut = new S03015();
        sut.CountOfPairs(4, 1, 1).Should().Equal(6, 4, 2, 0);
    }
}
