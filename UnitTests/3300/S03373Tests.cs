using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03373))]
public class S03373Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03373();
        Assert.That(sut.MaxTargetNodes([[0, 1], [0, 2], [2, 3], [2, 4]], [[0, 1], [0, 2], [0, 3], [2, 7], [1, 4], [4, 5], [4, 6]]), Is.EqualTo([8, 7, 7, 8, 8]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03373();
        Assert.That(sut.MaxTargetNodes([[0, 1], [0, 2], [0, 3], [0, 4]], [[0, 1], [1, 2], [2, 3]]), Is.EqualTo([3, 6, 6, 6, 6]));
    }
}
