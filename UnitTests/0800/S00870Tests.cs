using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00870Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00870();
        Assert.That(sut.AdvantageCount([2, 7, 11, 15], [1, 10, 4, 11]), Is.EqualTo((int[]) [2, 11, 7, 15]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00870();
        Assert.That(sut.AdvantageCount([12, 24, 8, 32], [13, 25, 32, 11]), Is.EqualTo((int[]) [24, 32, 8, 12]));
    }
}
