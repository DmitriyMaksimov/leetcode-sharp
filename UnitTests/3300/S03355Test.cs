using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03355))]
public class S03355Test
{
    [Test]
    public void T1()
    {
        var sut = new S03355();
        Assert.That(sut.IsZeroArray([1, 0, 1], [[0, 2]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03355();
        Assert.That(sut.IsZeroArray([4, 3, 2, 1], [[1, 3], [0, 2]]), Is.False);
    }
}
