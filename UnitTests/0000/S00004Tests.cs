using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00004Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00004();
        Assert.That(sut.FindMedianSortedArrays([1, 2], [2]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00004();
        Assert.That(sut.FindMedianSortedArrays([1, 2], [3, 4]), Is.EqualTo(2.5));
    }
}