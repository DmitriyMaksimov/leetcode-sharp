using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02672Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02672();
        Assert.That(sut.ColorTheArray(4, [[0, 2], [1, 2], [3, 1], [1, 1], [2, 1]]), Is.EqualTo((int[]) [0, 1, 1, 0, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02672();
        Assert.That(sut.ColorTheArray(1, [[0, 100000]]), Is.EqualTo((int[]) [0]));
    }
}
