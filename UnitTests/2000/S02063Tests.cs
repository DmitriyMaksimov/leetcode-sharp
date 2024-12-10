using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02063Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02063();
        sut.CountVowels("aba").Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02063();
        sut.CountVowels("abc").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02063();
        sut.CountVowels("ltcd").Should().Be(0);
    }
}
