using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03234))]
public class S03234Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03234();
        Assert.That(sut.NumberOfSubstrings("00011"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03234();
        Assert.That(sut.NumberOfSubstrings("101101"), Is.EqualTo(16));
    }
}