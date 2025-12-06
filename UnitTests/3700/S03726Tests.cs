using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03726))]
public class S03726Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03726();
        Assert.That(sut.RemoveZeros(1020030), Is.EqualTo(123));
    }

    [Test]
    public void T2()
    {
        var sut = new S03726();
        Assert.That(sut.RemoveZeros(1), Is.EqualTo(1));
    }
}