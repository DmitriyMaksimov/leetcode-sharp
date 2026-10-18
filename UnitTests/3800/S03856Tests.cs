using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03856))]
public class S03856Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03856();
        Assert.That(sut.TrimTrailingVowels("idea"), Is.EqualTo("id"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03856();
        Assert.That(sut.TrimTrailingVowels("day"), Is.EqualTo("day"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03856();
        Assert.That(sut.TrimTrailingVowels("aeiou"), Is.EqualTo(""));
    }
}