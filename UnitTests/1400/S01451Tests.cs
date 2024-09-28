using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01451Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01451();
        sut.ArrangeWords("Leetcode is cool").Should().Be("Is cool leetcode");
    }

    [Test]
    public void T2()
    {
        var sut = new S01451();
        sut.ArrangeWords("Keep calm and code on").Should().Be("On and keep calm code");
    }

    [Test]
    public void T3()
    {
        var sut = new S01451();
        sut.ArrangeWords("To be or not to be").Should().Be("To be or to be not");
    }

    [Test]
    public void T4()
    {
        var sut = new S01451();
        sut.ArrangeWords("You and i").Should().Be("I you and");
    }
}
