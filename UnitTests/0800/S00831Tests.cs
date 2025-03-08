using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00831Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00831();
        Assert.That(sut.MaskPII("LeetCode@LeetCode.com"), Is.EqualTo("l*****e@leetcode.com"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00831();
        Assert.That(sut.MaskPII("AB@qq.com"), Is.EqualTo("a*****b@qq.com"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00831();
        Assert.That(sut.MaskPII("1(234)567-890"), Is.EqualTo("***-***-7890"));
    }
}
