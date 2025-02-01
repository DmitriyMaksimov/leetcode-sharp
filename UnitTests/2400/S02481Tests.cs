using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02481Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02481();
        Assert.That(sut.NumberOfCuts(4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02481();
        Assert.That(sut.NumberOfCuts(3), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02481();
        Assert.That(sut.NumberOfCuts(8), Is.EqualTo(4));
    }

    [Test]
    public void T4()
    {
        var sut = new S02481();
        Assert.That(sut.NumberOfCuts(1), Is.EqualTo(0));
    }

    [Test]
    public void T5()
    {
        var sut = new S02481();
        Assert.That(sut.NumberOfCuts(6), Is.EqualTo(3));
    }
}