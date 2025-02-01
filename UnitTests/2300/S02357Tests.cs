using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02357Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02357();
        Assert.That(sut.MinimumOperations(new[] {1, 5, 0, 3, 5}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02357();
        Assert.That(sut.MinimumOperations(new[] {0}), Is.EqualTo(0));
    }
}