using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01925Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01925();
        Assert.That(sut.CountTriples(5), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01925();
        Assert.That(sut.CountTriples(10), Is.EqualTo(4));
    }
}