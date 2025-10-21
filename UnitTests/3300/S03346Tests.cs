using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03346))]
public class S03346Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03346();
        Assert.That(sut.MaxFrequency([1, 4, 5], 1, 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03346();
        Assert.That(sut.MaxFrequency([5, 11, 20, 20], 5, 1), Is.EqualTo(2));
    }
}