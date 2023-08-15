using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00127Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00127();
        sut.LadderLength("hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log", "cog"}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00127();
        sut.LadderLength("hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log"}).Should().Be(0);
    }
}