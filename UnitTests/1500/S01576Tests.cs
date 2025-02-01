using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01576Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01576();
        Assert.That(sut.ModifyString("?zs"), Is.EqualTo("azs"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01576();
        Assert.That(sut.ModifyString("ubv?w"), Is.EqualTo("ubvaw"));
    }
}