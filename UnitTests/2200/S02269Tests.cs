using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02269Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02269();
        Assert.That(sut.DivisorSubstrings(240, 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02269();
        Assert.That(sut.DivisorSubstrings(430043, 2), Is.EqualTo(2));
    }
}