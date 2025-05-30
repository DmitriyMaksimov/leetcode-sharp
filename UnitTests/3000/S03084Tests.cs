using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03084))]
public class S03084Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03084();
        Assert.That(sut.CountSubstrings("abada", 'a'), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03084();
        Assert.That(sut.CountSubstrings("zzz", 'z'), Is.EqualTo(6));
    }
}
