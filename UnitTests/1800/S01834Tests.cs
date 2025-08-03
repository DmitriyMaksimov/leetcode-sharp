using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01834Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01834();
        Assert.That(sut.GetOrder([[1, 2], [2, 4], [3, 2], [4, 1]]), Is.EqualTo((int[]) [0, 2, 3, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01834();
        Assert.That(sut.GetOrder([[7, 10], [7, 12], [7, 5], [7, 4], [7, 2]]), Is.EqualTo((int[]) [4, 3, 2, 0, 1]));
    }
}