using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02962Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02962();
        Assert.That(sut.CountSubarrays([1, 3, 2, 3, 3], 2), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02962();
        Assert.That(sut.CountSubarrays([1, 4, 2, 1], 3), Is.EqualTo(0));
    }
}