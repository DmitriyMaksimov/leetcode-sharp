using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01122Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01122();
        Assert.That(sut.RelativeSortArray([2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19], [2, 1, 4, 3, 9, 6]), Is.EqualTo((int[]) [2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01122();
        Assert.That(sut.RelativeSortArray([28, 6, 22, 8, 44, 17], [22, 28, 8, 6]), Is.EqualTo((int[]) [22, 28, 8, 6, 17, 44]));
    }
}