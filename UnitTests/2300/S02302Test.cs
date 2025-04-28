using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02302))]
public class S02302Test
{
    [Test]
    public void T1()
    {
        var sut = new S02302();
        Assert.That(sut.CountSubarrays([2, 1, 4, 3, 5], 10), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02302();
        Assert.That(sut.CountSubarrays([1, 1, 1], 5), Is.EqualTo(5));
    }
}
