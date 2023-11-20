using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02391Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02391();
        sut.GarbageCollection(new[] {"G", "P", "GP", "GG"}, new[] {2, 4, 3}).Should().Be(21);
    }

    [Test]
    public void T2()
    {
        var sut = new S02391();
        sut.GarbageCollection(new[] {"MMM", "PGM", "GP"}, new[] {3, 10}).Should().Be(37);
    }
}