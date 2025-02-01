using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02116Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02116();
        Assert.That(sut.CanBeValid("))()))", "010100"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02116();
        Assert.That(sut.CanBeValid("()()", "0000"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02116();
        Assert.That(sut.CanBeValid(")", "0"), Is.False);
    }
}
