using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03222Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03222();
        sut.LosingPlayer(2, 7).Should().Be("Alice");
    }

    [Test]
    public void T2()
    {
        var sut = new S03222();
        sut.LosingPlayer(4, 11).Should().Be("Bob");
    }
}