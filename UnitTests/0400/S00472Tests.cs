using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00472Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00472();
        Assert.That(sut.FindAllConcatenatedWordsInADict(new[] {"cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat"}), Is.EqualTo((string[]) ["catsdogcats", "dogcatsdog", "ratcatdogcat"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00472();
        Assert.That(sut.FindAllConcatenatedWordsInADict(new[] {"cat","dog","catdog"}), Is.EqualTo((string[]) ["catdog"]));
    }
}
