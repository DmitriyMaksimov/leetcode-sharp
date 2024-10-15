using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01738Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01738();
        sut.KthLargestValue([[5, 2], [1, 6]], 1).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S01738();
        sut.KthLargestValue([[5, 2], [1, 6]], 2).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01738();
        sut.KthLargestValue([[5, 2], [1, 6]], 3).Should().Be(4);
    }
}
