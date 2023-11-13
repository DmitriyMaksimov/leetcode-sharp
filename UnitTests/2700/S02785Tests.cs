using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02785Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02785();
        sut.SortVowels("lEetcOde").Should().Be("lEOtcede");
    }

    [Test]
    public void T2()
    {
        var sut = new S02785();
        sut.SortVowels("lYmpH").Should().Be("lYmpH");
    }

}