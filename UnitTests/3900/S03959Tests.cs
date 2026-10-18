using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03959))]
public class S03959Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03959();
        Assert.That(sut.CheckGoodInteger(1000), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S03959();
        Assert.That(sut.CheckGoodInteger(19), Is.True);
    }
}