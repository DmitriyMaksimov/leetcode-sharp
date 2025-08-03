using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02586Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02586();
        Assert.That(sut.VowelStrings(["are", "amy", "u"], 0, 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02586();
        Assert.That(sut.VowelStrings(["hey", "aeo", "mu", "ooo", "artro"], 1, 4), Is.EqualTo(3));
    }
}