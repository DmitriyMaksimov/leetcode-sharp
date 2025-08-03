using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01637Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01637();
        Assert.That(sut.MaxWidthOfVerticalArea([[8, 7], [9, 9], [7, 4], [9, 7]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01637();
        Assert.That(sut.MaxWidthOfVerticalArea([
            [3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8, 8]
        ]), Is.EqualTo(3));
    }
}