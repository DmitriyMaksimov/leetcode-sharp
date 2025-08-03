using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00598Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00598();
        Assert.That(sut.MaxCount(3, 3, [[2, 2], [3, 3]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00598();
        Assert.That(sut.MaxCount(3, 3,
        [
            [2, 2], [3, 3], [3, 3], [2, 2], [3, 3], [3, 3], [3, 3],
            [2, 2], [3, 3], [3, 3], [3, 3]
        ]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00598();
        Assert.That(sut.MaxCount(3, 3, []), Is.EqualTo(9));
    }
}