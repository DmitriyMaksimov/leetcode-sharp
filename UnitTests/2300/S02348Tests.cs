using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02348Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02348();
        Assert.That(sut.ZeroFilledSubarray(new[] {1, 3, 0, 0, 2, 0, 0, 4}), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02348();
        Assert.That(sut.ZeroFilledSubarray(new[] {0, 0, 0, 2, 0, 0}), Is.EqualTo(9));
    }

    [Test]
    public void T3()
    {
        var sut = new S02348();
        Assert.That(sut.ZeroFilledSubarray(new[] {2, 10, 2019}), Is.EqualTo(0));
    }
}