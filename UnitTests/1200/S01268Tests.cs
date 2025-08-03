using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01268Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01268();
        Assert.That(sut.SuggestedProducts(["mobile", "mouse", "moneypot", "monitor", "mousepad"], "mouse"), Is.EquivalentTo(
        [
            ["mobile", "moneypot", "monitor"],
            ["mobile", "moneypot", "monitor"],
            ["mouse", "mousepad"],
            ["mouse", "mousepad"],
            new[] {"mouse", "mousepad"}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01268();
        Assert.That(sut.SuggestedProducts(["havana"], "havana"), Is.EquivalentTo([
            ["havana"],
            ["havana"],
            ["havana"],
            ["havana"],
            ["havana"],
            new[] {"havana"}
        ]));
    }
}