using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01408Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01408();
        Assert.That(sut.StringMatching(new[] {"mass", "as", "hero", "superhero"}), Is.EqualTo((string[]) ["as", "hero"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01408();
        Assert.That(sut.StringMatching(new[] {"leetcode", "et", "code"}), Is.EqualTo((string[]) ["et", "code"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01408();
        Assert.That(sut.StringMatching(new[] {"blue", "green", "bu"}), Is.Empty);
    }
}
