using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01913Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01913();
        Assert.That(sut.MaxProductDifference([5,6,2,7,4]), Is.EqualTo(34));
    }

    [Test]
    public void T2()
    {
        var sut = new S01913();
        Assert.That(sut.MaxProductDifference([4,2,5,9,7,4,8]), Is.EqualTo(64));
    }
}