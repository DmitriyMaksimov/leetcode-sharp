using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01104Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01104();
        Assert.That(sut.PathInZigZagTree(14), Is.EqualTo((int[]) [1,3,4,14]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01104();
        Assert.That(sut.PathInZigZagTree(26), Is.EqualTo((int[]) [1,2,6,10,26]));
    }
}