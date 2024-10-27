using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01760Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01760();
        sut.MinimumSize([9], 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01760();
        sut.MinimumSize([2, 4, 8, 2], 4).Should().Be(2);
    }
}
