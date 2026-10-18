using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03917))]
public class S03917Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03917();
        Assert.That(sut.CountOppositeParity([1, 2, 3, 4]), Is.EqualTo([2, 1, 1, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03917();
        Assert.That(sut.CountOppositeParity([1]), Is.EqualTo([0]));
    }
}