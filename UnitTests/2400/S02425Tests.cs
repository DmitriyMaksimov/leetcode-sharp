using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02425Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02425();
        Assert.That(sut.XorAllNums([2, 1, 3], [10, 2, 5, 0]), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S02425();
        Assert.That(sut.XorAllNums([1, 2], [3, 4]), Is.EqualTo(0));
    }
}
