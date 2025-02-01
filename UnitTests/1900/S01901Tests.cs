using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01901Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01901();
        Assert.That(sut.FindPeakGrid([[1, 4], [3, 2]]), Is.EqualTo((int[]) [0, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01901();
        Assert.That(sut.FindPeakGrid([[10, 20, 15], [21, 30, 14], [7, 16, 32]]), Is.EqualTo((int[]) [1, 1]));
    }
}
