using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00974Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00974();
        Assert.That(sut.SubarraysDivByK(new[] {4, 5, 0, -2, -3, 1}, 5), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S00974();
        Assert.That(sut.SubarraysDivByK(new[] {5}, 9), Is.EqualTo(0));
    }
}