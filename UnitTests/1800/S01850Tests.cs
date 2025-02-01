using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01850Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01850();
        Assert.That(sut.GetMinSwaps("5489355142", 4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01850();
        Assert.That(sut.GetMinSwaps("11112", 4), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01850();
        Assert.That(sut.GetMinSwaps("00123", 1), Is.EqualTo(1));
    }
}