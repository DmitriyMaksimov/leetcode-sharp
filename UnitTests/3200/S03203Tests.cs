using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03203Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03203();
        Assert.That(sut.MinimumDiameterAfterMerge([[0, 1], [0, 2], [0, 3]], [[0, 1]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03203();
        Assert.That(sut.MinimumDiameterAfterMerge([[0, 1], [0, 2], [0, 3], [2, 4], [2, 5], [3, 6], [2, 7]], [[0, 1], [0, 2], [0, 3], [2, 4], [2, 5], [3, 6], [2, 7]]), Is.EqualTo(5));
    }
}
