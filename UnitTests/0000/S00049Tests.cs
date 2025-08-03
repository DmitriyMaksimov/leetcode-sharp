using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00049Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00049();
        Assert.That(sut.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]), Is.EquivalentTo([
            ["bat"],
            ["tan", "nat"],
            new List<string> {"eat", "tea", "ate"}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00049();
        Assert.That(sut.GroupAnagrams([""]), Is.EquivalentTo([new List<string> {""}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00049();
        Assert.That(sut.GroupAnagrams(["a"]), Is.EquivalentTo([new List<string> {"a"}]));
    }
}
