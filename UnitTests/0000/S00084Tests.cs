using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00084Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00084();
        Assert.That(sut.LargestRectangleArea([2, 1, 5, 6, 2, 3]), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S00084();
        Assert.That(sut.LargestRectangleArea([2, 4]), Is.EqualTo(4));
    }
}