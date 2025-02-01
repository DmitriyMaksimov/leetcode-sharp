using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02413Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02413();
        Assert.That(sut.SmallestEvenMultiple(5), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S02413();
        Assert.That(sut.SmallestEvenMultiple(6), Is.EqualTo(6));
    }
}