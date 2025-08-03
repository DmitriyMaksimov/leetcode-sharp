using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00661Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00661();
        Assert.That(sut.ImageSmoother([[1, 1, 1], [1, 0, 1], [1, 1, 1]]), Is.EquivalentTo([
            [0, 0, 0], [0, 0, 0], new[] {0, 0, 0}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00661();
        Assert.That(sut.ImageSmoother([[100, 200, 100], [200, 50, 200], [100, 200, 100]]), Is.EquivalentTo([
            [137, 141, 137], [141, 138, 141], new[] {137, 141, 137}
        ]));
    }
}