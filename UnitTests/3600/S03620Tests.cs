using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03620))]
public class S03620Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03620();
        Assert.That(sut.FindMaxPathScore([[0, 1, 5], [1, 3, 10], [0, 2, 3], [2, 3, 4]], [true, true, true, true], 10), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03620();
        Assert.That(sut.FindMaxPathScore([[0, 1, 7], [1, 4, 5], [0, 2, 6], [2, 3, 6], [3, 4, 2], [2, 4, 6]], [true, true, true, false, true], 12), Is.EqualTo(6));
    }
}