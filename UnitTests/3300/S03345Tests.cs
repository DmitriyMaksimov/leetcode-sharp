using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03345Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03345();
        Assert.That(sut.SmallestNumber(10, 2), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S03345();
        Assert.That(sut.SmallestNumber(15, 3), Is.EqualTo(16));
    }
}
