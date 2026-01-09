using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03798))]
public class S03798Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03798();
        Assert.That(sut.LargestEven("1112"), Is.EqualTo("1112"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03798();
        Assert.That(sut.LargestEven("221"), Is.EqualTo("22"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03798();
        Assert.That(sut.LargestEven("1"), Is.EqualTo(""));
    }
}