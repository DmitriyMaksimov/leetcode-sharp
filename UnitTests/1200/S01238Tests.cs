using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01238Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01238();
        Assert.That(sut.CircularPermutation(2, 3), Is.EqualTo((int[]) [3, 2, 0, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01238();
        Assert.That(sut.CircularPermutation(3, 2), Is.EqualTo((int[]) [2, 6, 7, 5, 4, 0, 1, 3]));
    }
}
