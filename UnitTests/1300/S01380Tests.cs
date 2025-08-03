using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01380Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01380();
        Assert.That(sut.LuckyNumbers([[3, 7, 8], [9, 11, 13], [15, 16, 17]]), Is.EqualTo((int[]) [15]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01380();
        Assert.That(sut.LuckyNumbers([[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]]), Is.EqualTo((int[]) [12]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01380();
        Assert.That(sut.LuckyNumbers([[7, 8], [1, 2]]), Is.EqualTo((int[]) [7]));
    }
}