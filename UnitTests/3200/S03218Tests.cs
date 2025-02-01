using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03218Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03218();
        Assert.That(sut.MinimumCost(3, 2, [1, 3], [5]), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S03218();
        Assert.That(sut.MinimumCost(2, 2, [7], [4]), Is.EqualTo(15));
    }
}
