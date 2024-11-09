using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01690Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01690();
        sut.StoneGameVII([5, 3, 1, 4, 2]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01690();
        sut.StoneGameVII([7, 90, 5, 1, 100, 10, 10, 2]).Should().Be(122);
    }
}