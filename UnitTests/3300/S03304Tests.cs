using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03304Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03304();
        Assert.That(sut.KthCharacter(5), Is.EqualTo('b'));
    }

    [Test]
    public void T2()
    {
        var sut = new S03304();
        Assert.That(sut.KthCharacter(10), Is.EqualTo('c'));
    }
}