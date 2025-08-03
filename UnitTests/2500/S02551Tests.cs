using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02551Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02551();
        Assert.That(sut.PutMarbles([1, 3, 5, 1], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02551();
        Assert.That(sut.PutMarbles([1, 3], 2), Is.EqualTo(0));
    }
}