using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02439Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02439();
        Assert.That(sut.MinimizeArrayValue([3,7,1,6]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02439();
        Assert.That(sut.MinimizeArrayValue([10,1]), Is.EqualTo(10));
    }
}