using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01268Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01268();
        sut.SuggestedProducts(new[] {"mobile", "mouse", "moneypot", "monitor", "mousepad"}, "mouse").Should()
            .BeEquivalentTo(new[]
            {
                new[] {"mobile", "moneypot", "monitor"},
                new[] {"mobile", "moneypot", "monitor"},
                new[] {"mouse", "mousepad"},
                new[] {"mouse", "mousepad"},
                new[] {"mouse", "mousepad"}
            });
    }

    [Test]
    public void T2()
    {
        var sut = new S01268();
        sut.SuggestedProducts(new[] {"havana"}, "havana").Should()
            .BeEquivalentTo(new[]
            {
                new[] {"havana"},
                new[] {"havana"},
                new[] {"havana"},
                new[] {"havana"},
                new[] {"havana"},
                new[] {"havana"},
            });
    }
}