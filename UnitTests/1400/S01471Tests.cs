using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01471Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01471();
        sut.GetStrongest([1, 2, 3, 4, 5], 2).Should().Equal(5, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01471();
        sut.GetStrongest([1, 1, 3, 5, 5], 2).Should().Equal(5, 5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01471();
        sut.GetStrongest([6, 7, 11, 7, 6, 8], 5).Should().Equal(11, 8, 6, 6, 7);
    }
}
