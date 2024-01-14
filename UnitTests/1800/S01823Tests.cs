using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01823Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01823();
        sut.FindTheWinner(5, 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01823();
        sut.FindTheWinner(6, 5).Should().Be(1);
    }
}