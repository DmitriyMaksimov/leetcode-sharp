using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00208Tests
{
    [Test]
    public void T1()
    {
        var trie = new S00208.Trie();
        trie.Insert("apple");
        Assert.That(trie.Search("apple"), Is.True);
        Assert.That(trie.Search("app"), Is.False);
        Assert.That(trie.StartsWith("app"), Is.True);
        trie.Insert("app");
        Assert.That(trie.Search("app"), Is.True);
    }
}
