using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01443Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01443();
        Assert.That(sut.MinTime(7, [[0, 1], [0, 2], [1, 4], [1, 5], [2, 3], [2, 6]], [false, false, true, false, true, true, false
        ]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01443();
        Assert.That(sut.MinTime(7, [[0, 1], [0, 2], [1, 4], [1, 5], [2, 3], [2, 6]], [false,false,false,false,false,false,false
        ]), Is.EqualTo(0));
    }
}