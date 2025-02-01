using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00728Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00728();
        Assert.That(sut.SelfDividingNumbers(1, 22), Is.EqualTo((int[]) [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00728();
        Assert.That(sut.SelfDividingNumbers(47, 85), Is.EqualTo((int[]) [48, 55, 66, 77]));
    }
}