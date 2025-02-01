using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01813Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01813();
        Assert.That(sut.AreSentencesSimilar("My name is Haley", "My Haley"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01813();
        Assert.That(sut.AreSentencesSimilar("of", "A lot of words"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01813();
        Assert.That(sut.AreSentencesSimilar("Eating right now", "Eating"), Is.True);
    }
}
