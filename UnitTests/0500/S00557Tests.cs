using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00557Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00557();
        sut.ReverseWords("Let's take LeetCode contest").Should().Be("s'teL ekat edoCteeL tsetnoc");
    }

    [Test]
    public void T2()
    {
        var sut = new S00557();
        sut.ReverseWords("God Ding").Should().Be("doG gniD");
    }
}