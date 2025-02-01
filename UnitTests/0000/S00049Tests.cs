using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00049Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00049();
        Assert.That(sut.GroupAnagrams(new[] {"eat", "tea", "tan", "ate", "nat", "bat"}), Is.EquivalentTo(new[]
        {
            new List<string> {"bat"},
            new List<string> {"tan", "nat"},
            new List<string> {"eat", "tea", "ate"}
        }));
    }

    [Test]
    public void T2()
    {
        var sut = new S00049();
        Assert.That(sut.GroupAnagrams(new[] {""}), Is.EquivalentTo(new[] {new List<string> {""}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00049();
        Assert.That(sut.GroupAnagrams(new[] {"a"}), Is.EquivalentTo(new[] {new List<string> {"a"}}));
    }
}
