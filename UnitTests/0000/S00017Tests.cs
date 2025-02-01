using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00017Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00017();
        Assert.That(sut.LetterCombinations("23"), Is.EqualTo((string[]) ["ad","ae","af","bd","be","bf","cd","ce","cf"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00017();
        Assert.That(sut.LetterCombinations(""), Is.Empty);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00017();
        Assert.That(sut.LetterCombinations("2"), Is.EqualTo((string[]) ["a","b","c"]));
    }

}
