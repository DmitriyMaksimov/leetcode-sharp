using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03302))]
public class S03302Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03302();
        Assert.That(sut.ValidSequence("vbcca", "abc"), Is.EqualTo([0, 1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03302();
        Assert.That(sut.ValidSequence("bacdc", "abc"), Is.EqualTo([1, 2, 4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03302();
        Assert.That(sut.ValidSequence("aaaaaa", "aaabc"), Is.Empty);
    }

    [Test]
    public void T4()
    {
        var sut = new S03302();
        Assert.That(sut.ValidSequence("abc", "ab"), Is.EqualTo([0, 1]));
    }
}