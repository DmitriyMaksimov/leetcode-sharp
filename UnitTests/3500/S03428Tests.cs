using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03428))]
public class S03428Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03428();
        Assert.That(sut.BaseUnitConversions([[0, 1, 2], [1, 2, 3]]), Is.EqualTo([1, 2, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03428();
        Assert.That(sut.BaseUnitConversions([[0, 1, 2], [0, 2, 3], [1, 3, 4], [1, 4, 5], [2, 5, 2], [4, 6, 3], [5, 7, 4]]), Is.EqualTo([1, 2, 3, 8, 10, 6, 30, 24]));
    }
}
