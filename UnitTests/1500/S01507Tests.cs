using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01507Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01507();
        Assert.That(sut.ReformatDate("20th Oct 2052"), Is.EqualTo("2052-10-20"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01507();
        Assert.That(sut.ReformatDate("6th Jun 1933"), Is.EqualTo("1933-06-06"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01507();
        Assert.That(sut.ReformatDate("26th May 1960"), Is.EqualTo("1960-05-26"));
    }
}