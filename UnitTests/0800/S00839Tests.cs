using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00839Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00839();
        Assert.That(sut.NumSimilarGroups(new[] {"tars","rats","arts","star"}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00839();
        Assert.That(sut.NumSimilarGroups(new[] {"omv","ovm"}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00839();
        Assert.That(sut.NumSimilarGroups(new[] {"abc","abc"}), Is.EqualTo(1));
    }
}