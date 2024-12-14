using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02745Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02745();
        sut.LongestString(2, 5, 1).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S02745();
        sut.LongestString(3, 2, 2).Should().Be(14);
    }
}
