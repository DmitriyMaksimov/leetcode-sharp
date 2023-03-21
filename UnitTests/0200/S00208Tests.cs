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
        trie.Search("apple").Should().BeTrue();
        trie.Search("app").Should().BeFalse();
        trie.StartsWith("app").Should().BeTrue();
        trie.Insert("app");
        trie.Search("app").Should().BeTrue();
    }
}