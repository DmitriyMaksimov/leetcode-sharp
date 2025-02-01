using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02785Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02785();
        Assert.That(sut.SortVowels("lEetcOde"), Is.EqualTo("lEOtcede"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02785();
        Assert.That(sut.SortVowels("lYmpH"), Is.EqualTo("lYmpH"));
    }

}