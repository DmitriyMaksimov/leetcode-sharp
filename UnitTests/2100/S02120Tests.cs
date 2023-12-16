using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02120Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02120();
        sut.ExecuteInstructions(3, new[] {0, 1}, "RRDDLU").Should().Equal(1, 5, 4, 3, 1, 0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02120();
        sut.ExecuteInstructions(2, new[] {1, 1}, "LURD").Should().Equal(4, 1, 0, 0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02120();
        sut.ExecuteInstructions(1, new[] {0, 0}, "LRUD").Should().Equal(0, 0, 0, 0);
    }
}