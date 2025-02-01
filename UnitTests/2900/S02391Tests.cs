using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02391Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02391();
        Assert.That(sut.GarbageCollection(new[] {"G", "P", "GP", "GG"}, new[] {2, 4, 3}), Is.EqualTo(21));
    }

    [Test]
    public void T2()
    {
        var sut = new S02391();
        Assert.That(sut.GarbageCollection(new[] {"MMM", "PGM", "GP"}, new[] {3, 10}), Is.EqualTo(37));
    }
}