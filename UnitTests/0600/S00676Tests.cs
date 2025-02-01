using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00676Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00676.MagicDictionary();
        sut.BuildDict(["hello", "leetcode"]);
        Assert.That(sut.Search("hello"), Is.False);
        Assert.That(sut.Search("hhllo"), Is.True);
        Assert.That(sut.Search("hell"), Is.False);
        Assert.That(sut.Search("leetcoded"), Is.False);
    }
}
