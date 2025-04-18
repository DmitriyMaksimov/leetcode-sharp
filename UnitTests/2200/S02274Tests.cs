using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02274Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02274();
        Assert.That(sut.MaxConsecutive(2, 9, [4, 6]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02274();
        Assert.That(sut.MaxConsecutive(6, 8, [7, 6, 8]), Is.EqualTo(0));
    }
}
