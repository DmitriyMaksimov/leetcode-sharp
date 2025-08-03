using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02542Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02542();
        Assert.That(sut.MaxScore([1, 3, 3, 2], [2, 1, 3, 4], 3), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S02542();
        Assert.That(sut.MaxScore([4, 2, 3, 1, 1], [7, 5, 10, 9, 6], 1), Is.EqualTo(30));
    }
}