using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03347))]
public class S03347Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03347();
        Assert.That(sut.MaxFrequency([1, 4, 5], 1, 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03347();
        Assert.That(sut.MaxFrequency([5, 11, 20, 20], 5, 1), Is.EqualTo(2));
    }
}