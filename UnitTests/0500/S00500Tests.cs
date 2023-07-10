using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00500Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00500();
        sut.FindWords(new[] {"Hello", "Alaska", "Dad", "Peace"}).Should().Equal("Alaska", "Dad");
    }

    [Test]
    public void T2()
    {
        var sut = new S00500();
        sut.FindWords(new[] {"omk"}).Should().Equal();
    }

    [Test]
    public void T3()
    {
        var sut = new S00500();
        sut.FindWords(new[] {"adsdf", "sfd"}).Should().Equal("adsdf", "sfd");
    }

    [Test]
    public void T4()
    {
        var sut = new S00500();
        sut.FindWords(new[] {"a", "b"}).Should().Equal("a", "b");
    }

    [Test]
    public void T5()
    {
        var sut = new S00500();
        sut.FindWords(new[] {"qz", "wq", "asdddafadsfa", "adfadfadfdassfawde"}).Should().Equal("wq", "asdddafadsfa");
    }
}