using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00967Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00967();
        Assert.That(sut.NumsSameConsecDiff(3, 7), Is.EqualTo((int[]) [181, 292, 707, 818, 929]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00967();
        Assert.That(sut.NumsSameConsecDiff(2, 1), Is.EqualTo((int[]) [12, 10, 23, 21, 34, 32, 45, 43, 56, 54, 67, 65, 78, 76, 89, 87, 98]));
    }
}