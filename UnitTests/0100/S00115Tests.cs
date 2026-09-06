using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00115))]
public class S00115Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00115();
        Assert.That(sut.NumDistinct("rabbbit", "rabbit"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00115();
        Assert.That(sut.NumDistinct("babgbag", "bag"), Is.EqualTo(5));
    }
}