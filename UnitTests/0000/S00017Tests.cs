using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00017Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00017();
        sut.LetterCombinations("23").Should().Equal("ad","ae","af","bd","be","bf","cd","ce","cf");
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
        sut.LetterCombinations("2").Should().Equal("a","b","c");
    }

}
