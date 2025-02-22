using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01410Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01410();
        Assert.That(sut.EntityParser("&amp; is an HTML entity but &ambassador; is not."), Is.EqualTo("& is an HTML entity but &ambassador; is not."));
    }

    [Test]
    public void T2()
    {
        var sut = new S01410();
        Assert.That(sut.EntityParser("and I quote: &quot;...&quot;"), Is.EqualTo("and I quote: \"...\""));
    }
}
