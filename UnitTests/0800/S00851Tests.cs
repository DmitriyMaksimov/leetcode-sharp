using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00851Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00851();
        Assert.That(sut.LoudAndRich([[1, 0], [2, 1], [3, 1], [3, 7], [4, 3], [5, 3], [6, 3]], [3, 2, 5, 4, 6, 1, 7, 0]), Is.EqualTo((int[]) [5, 5, 2, 5, 4, 5, 6, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00851();
        Assert.That(sut.LoudAndRich([], [0]), Is.EqualTo((int[]) [0]));
    }
}
