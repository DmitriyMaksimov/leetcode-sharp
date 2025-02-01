using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02661Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02661();
        Assert.That(sut.FirstCompleteIndex([1, 3, 4, 2], [[1, 4], [2, 3]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02661();
        Assert.That(sut.FirstCompleteIndex([2, 8, 7, 4, 1, 3, 5, 6, 9], [[3, 2, 5], [1, 4, 6], [8, 7, 9]]), Is.EqualTo(3));
    }
}
