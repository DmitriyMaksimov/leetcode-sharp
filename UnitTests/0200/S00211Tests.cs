using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00211Tests
{
    [Test]
    public void T1()
    {
        var wordDictionary = new S00211.WordDictionary();
        wordDictionary.AddWord("bad");
        wordDictionary.AddWord("dad");
        wordDictionary.AddWord("mad");
        wordDictionary.Search("pad").Should().BeFalse();
        wordDictionary.Search("bad").Should().BeTrue();
        wordDictionary.Search(".ad").Should().BeTrue();
        wordDictionary.Search("b..").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var wordDictionary = new S00211.WordDictionary();
        wordDictionary.AddWord("a");
        wordDictionary.AddWord("a");
        wordDictionary.Search(".").Should().BeTrue();
        wordDictionary.Search("a").Should().BeTrue();
        wordDictionary.Search("aa").Should().BeFalse();
        wordDictionary.Search("a.").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var wordDictionary = new S00211.WordDictionary();
        wordDictionary.AddWord("at");
        wordDictionary.AddWord("and");
        wordDictionary.AddWord("an");
        wordDictionary.AddWord("add");
        wordDictionary.Search("a").Should().BeFalse();
        wordDictionary.Search(".at").Should().BeFalse();
        wordDictionary.AddWord("bat");
        wordDictionary.Search(".at").Should().BeTrue();
        wordDictionary.Search("an.").Should().BeTrue();
        wordDictionary.Search("a.d.").Should().BeFalse();
        wordDictionary.Search("b.").Should().BeFalse();
        wordDictionary.Search("a.d").Should().BeTrue();
        wordDictionary.Search(".").Should().BeFalse();
    }
}