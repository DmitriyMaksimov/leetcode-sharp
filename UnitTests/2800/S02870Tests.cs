using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02870Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02870();
        Assert.That(sut.MinOperations(new[] {2, 3, 3, 2, 2, 4, 2, 3, 4}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02870();
        Assert.That(sut.MinOperations(new[] {2, 1, 2, 2, 3, 3}), Is.EqualTo(-1));
    }
}