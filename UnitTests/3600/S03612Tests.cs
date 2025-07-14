using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03612))]
public class S03612Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03612();
        Assert.That(sut.ProcessStr("a#b%*"), Is.EqualTo("ba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03612();
        Assert.That(sut.ProcessStr("z*#"), Is.EqualTo(""));
    }
}