using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03046Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03046();
        Assert.That(sut.IsPossibleToSplit([1, 1, 2, 2, 3, 4]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03046();
        Assert.That(sut.IsPossibleToSplit([1, 1, 1, 1]), Is.False);
    }
}
