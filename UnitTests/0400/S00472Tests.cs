using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00472Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00472();
        sut.FindAllConcatenatedWordsInADict(new[] {"cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat"}).Should()
            .Equal("catsdogcats", "dogcatsdog", "ratcatdogcat");
    }

    [Test]
    public void T2()
    {
        var sut = new S00472();
        sut.FindAllConcatenatedWordsInADict(new[] {"cat","dog","catdog"}).Should().Equal("catdog");
    }
}