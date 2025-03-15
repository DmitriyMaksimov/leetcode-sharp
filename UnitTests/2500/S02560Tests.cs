using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02560Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02560();
        Assert.That(sut.MinCapability([2, 3, 5, 9], 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02560();
        Assert.That(sut.MinCapability([2, 7, 9, 3, 1], 2), Is.EqualTo(2));
    }
}
