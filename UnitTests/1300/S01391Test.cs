using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01391))]
public class S01391Test
{
    [Test]
    public void T1()
    {
        var sut = new S01391();
        Assert.That(sut.HasValidPath([[2, 4, 3], [6, 5, 2]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01391();
        Assert.That(sut.HasValidPath([[1, 2, 1], [1, 2, 1]]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01391();
        Assert.That(sut.HasValidPath([[1, 1, 2]]), Is.False);
    }
}
