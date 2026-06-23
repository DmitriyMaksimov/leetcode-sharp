using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03699))]
public class S03699Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03699();
        Assert.That(sut.ZigZagArrays(3, 4, 5), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03699();
        Assert.That(sut.ZigZagArrays(3, 1, 3), Is.EqualTo(10));
    }
}