using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01362Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01362();
        sut.ClosestDivisors(8).Should().Equal(3, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01362();
        sut.ClosestDivisors(123).Should().Equal(5, 25);
    }

    [Test]
    public void T3()
    {
        var sut = new S01362();
        sut.ClosestDivisors(999).Should().Equal(25, 40);
    }
}
