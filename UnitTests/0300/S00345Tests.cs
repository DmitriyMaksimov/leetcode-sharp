using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00345Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00345();
        Assert.That(sut.ReverseVowels("hello"), Is.EqualTo("holle"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00345();
        Assert.That(sut.ReverseVowels("leetcode"), Is.EqualTo("leotcede"));
    }
}