using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03318Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03318();
        sut.FindXSum([1, 1, 2, 2, 3, 4, 2, 3], 6, 2).Should().Equal(6, 10, 12);
    }

    [Test]
    public void T2()
    {
        var sut = new S03318();
        sut.FindXSum([3, 8, 7, 8, 7, 5], 2, 2).Should().Equal(11, 15, 15, 15, 12);
    }
}
