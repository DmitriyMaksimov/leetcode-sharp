using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03542))]
public class S03542Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03542();
        Assert.That(sut.MinOperations([0, 2]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03542();
        Assert.That(sut.MinOperations([3, 1, 2, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03542();
        Assert.That(sut.MinOperations([1, 2, 1, 2, 1, 2]), Is.EqualTo(4));
    }
}