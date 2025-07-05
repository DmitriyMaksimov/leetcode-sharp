using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03307))]
public class S03307Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03307();
        Assert.That(sut.KthCharacter(5, [0, 0, 0]), Is.EqualTo('a'));
    }

    [Test]
    public void T2()
    {
        var sut = new S03307();
        Assert.That(sut.KthCharacter(10, [0, 1, 0, 1]), Is.EqualTo('b'));
    }
}