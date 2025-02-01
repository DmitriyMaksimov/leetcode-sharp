using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03309Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03309();
        Assert.That(sut.MaxGoodNumber([1, 2, 3]), Is.EqualTo(30));
    }

    [Test]
    public void T2()
    {
        var sut = new S03309();
        Assert.That(sut.MaxGoodNumber([2, 8, 16]), Is.EqualTo(1296));
    }
}
