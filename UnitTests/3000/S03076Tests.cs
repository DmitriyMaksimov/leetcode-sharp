using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03076))]
public class S03076Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03076();
        Assert.That(sut.ShortestSubstrings(["cab", "ad", "bad", "c"]), Is.EqualTo(["ab", "", "ba", ""]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03076();
        Assert.That(sut.ShortestSubstrings(["abc", "bcd", "abcd"]), Is.EqualTo(["", "", "abcd"]));
    }
}