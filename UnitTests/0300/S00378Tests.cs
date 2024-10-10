using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00378Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00378();
        sut.KthSmallest([[1, 5, 9], [10, 11, 13], [12, 13, 15]], 8).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S00378();
        sut.KthSmallest([[-5]], 1).Should().Be(-5);
    }
}
