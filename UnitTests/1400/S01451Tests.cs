using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01451Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01451();
        Assert.That(sut.ArrangeWords("Leetcode is cool"), Is.EqualTo("Is cool leetcode"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01451();
        Assert.That(sut.ArrangeWords("Keep calm and code on"), Is.EqualTo("On and keep calm code"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01451();
        Assert.That(sut.ArrangeWords("To be or not to be"), Is.EqualTo("To be or to be not"));
    }

    [Test]
    public void T4()
    {
        var sut = new S01451();
        Assert.That(sut.ArrangeWords("You and i"), Is.EqualTo("I you and"));
    }
}
