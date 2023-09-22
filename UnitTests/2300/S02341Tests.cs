using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02341Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02341();
        sut.NumberOfPairs(new[] {1, 3, 2, 1, 3, 2, 2}).Should().Equal(3, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02341();
        sut.NumberOfPairs(new[] {1, 1}).Should().Equal(1, 0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02341();
        sut.NumberOfPairs(new[] {0}).Should().Equal(0, 1);
    }
}