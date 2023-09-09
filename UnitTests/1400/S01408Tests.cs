using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01408Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01408();
        sut.StringMatching(new[] {"mass", "as", "hero", "superhero"}).Should().Equal("as", "hero");
    }

    [Test]
    public void T2()
    {
        var sut = new S01408();
        sut.StringMatching(new[] {"leetcode", "et", "code"}).Should().Equal("et", "code");
    }

    [Test]
    public void T3()
    {
        var sut = new S01408();
        sut.StringMatching(new[] {"blue", "green", "bu"}).Should().BeEmpty();
    }
}