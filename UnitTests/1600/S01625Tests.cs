using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01625Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01625();
        sut.FindLexSmallestString("5525", 9, 2).Should().Be("2050");
    }

    [Test]
    public void T2()
    {
        var sut = new S01625();
        sut.FindLexSmallestString("74", 5, 1).Should().Be("24");
    }

    [Test]
    public void T3()
    {
        var sut = new S01625();
        sut.FindLexSmallestString("0011", 4, 2).Should().Be("0011");
    }

    [Test]
    public void T4()
    {
        var sut = new S01625();
        sut.FindLexSmallestString("43987654", 7, 3).Should().Be("00553311");
    }
}
