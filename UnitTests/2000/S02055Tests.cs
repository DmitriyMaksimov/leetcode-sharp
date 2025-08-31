using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02055))]
public class S02055Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02055();
        Assert.That(sut.PlatesBetweenCandles("**|**|***|", [[2, 5], [5, 9]]), Is.EqualTo([2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02055();
        Assert.That(sut.PlatesBetweenCandles("***|**|*****|**||**|*", [[1, 17], [4, 5], [14, 17], [5, 11], [15, 16]]), Is.EqualTo([9, 0, 0, 0, 0]));
    }
}