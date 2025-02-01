using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00127Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00127();
        Assert.That(sut.LadderLength("hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log", "cog"}), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00127();
        Assert.That(sut.LadderLength("hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log"}), Is.EqualTo(0));
    }
}