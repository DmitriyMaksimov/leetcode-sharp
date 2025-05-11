using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02918))]
public class S02918Test
{
    [Test]
    public void T1()
    {
        var sut = new S02918();
        Assert.That(sut.MinSum([3, 2, 0, 1, 0], [6, 5, 0]), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S02918();
        Assert.That(sut.MinSum([2, 0, 2, 0], [1, 4]), Is.EqualTo(-1));
    }
}
