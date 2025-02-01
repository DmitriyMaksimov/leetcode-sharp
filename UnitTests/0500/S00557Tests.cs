using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00557Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00557();
        Assert.That(sut.ReverseWords("Let's take LeetCode contest"), Is.EqualTo("s'teL ekat edoCteeL tsetnoc"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00557();
        Assert.That(sut.ReverseWords("God Ding"), Is.EqualTo("doG gniD"));
    }
}