using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01611Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01611();
        Assert.That(sut.MinimumOneBitOperations(3), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01611();
        Assert.That(sut.MinimumOneBitOperations(6), Is.EqualTo(4));
    }
}