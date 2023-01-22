using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00131Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00131();
        sut.Partition("aab").Should().BeEquivalentTo(new[] {new[] {"a", "a", "b"}, new[] {"aa", "b"}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00131();
        sut.Partition("a").Should().BeEquivalentTo(new[] {new[] {"a"}});
    }

    [Test]
    public void T3()
    {
        var sut = new S00131();
        sut.Partition("bb").Should().BeEquivalentTo(new[] {new[] {"bb"}, new []{"b", "b"}});
    }
}