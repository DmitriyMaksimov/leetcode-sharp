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
        Assert.That(wordDictionary.Search("pad"), Is.False);
        Assert.That(wordDictionary.Search("bad"), Is.True);
        Assert.That(wordDictionary.Search(".ad"), Is.True);
        Assert.That(wordDictionary.Search("b.."), Is.True);
    }

    [Test]
    public void T2()
    {
        var wordDictionary = new S00211.WordDictionary();
        wordDictionary.AddWord("a");
        wordDictionary.AddWord("a");
        Assert.That(wordDictionary.Search("."), Is.True);
        Assert.That(wordDictionary.Search("a"), Is.True);
        Assert.That(wordDictionary.Search("aa"), Is.False);
        Assert.That(wordDictionary.Search("a."), Is.False);
    }

    [Test]
    public void T3()
    {
        var wordDictionary = new S00211.WordDictionary();
        wordDictionary.AddWord("at");
        wordDictionary.AddWord("and");
        wordDictionary.AddWord("an");
        wordDictionary.AddWord("add");
        Assert.That(wordDictionary.Search("a"), Is.False);
        Assert.That(wordDictionary.Search(".at"), Is.False);
        wordDictionary.AddWord("bat");
        Assert.That(wordDictionary.Search(".at"), Is.True);
        Assert.That(wordDictionary.Search("an."), Is.True);
        Assert.That(wordDictionary.Search("a.d."), Is.False);
        Assert.That(wordDictionary.Search("b."), Is.False);
        Assert.That(wordDictionary.Search("a.d"), Is.True);
        Assert.That(wordDictionary.Search("."), Is.False);
    }
}
