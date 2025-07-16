using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03080))]
public class S03080Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03080();
        Assert.That(sut.UnmarkedSumArray([1, 2, 2, 1, 2, 3, 1], [[1, 2], [3, 3], [4, 2]]), Is.EqualTo([8, 3, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03080();
        Assert.That(sut.UnmarkedSumArray([1, 4, 2, 3], [[0, 1]]), Is.EqualTo([7]));
    }
}