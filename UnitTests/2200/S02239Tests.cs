using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02239();
        Assert.That(sut.FindClosestNumber([-4, -2, 1, 4, 8]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02239();
        Assert.That(sut.FindClosestNumber([2, -1, 1]), Is.EqualTo(1));
    }
}