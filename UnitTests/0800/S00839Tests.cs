using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00839Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00839();
        sut.NumSimilarGroups(new[] {"tars","rats","arts","star"}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00839();
        sut.NumSimilarGroups(new[] {"omv","ovm"}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00839();
        sut.NumSimilarGroups(new[] {"abc","abc"}).Should().Be(1);
    }
}