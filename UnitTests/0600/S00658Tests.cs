using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00658))]
public class S00658Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00658();
        Assert.That(sut.FindClosestElements([1, 2, 3, 4, 5], 4, 3), Is.EqualTo([1, 2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00658();
        Assert.That(sut.FindClosestElements([1, 1, 2, 3, 4, 5], 4, -1), Is.EqualTo([1, 1, 2, 3]));
    }
}
