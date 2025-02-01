using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01190();
        Assert.That(sut.ReverseParentheses("(abcd)"), Is.EqualTo("dcba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01190();
        Assert.That(sut.ReverseParentheses("(u(love)i)"), Is.EqualTo("iloveu"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01190();
        Assert.That(sut.ReverseParentheses("(ed(et(oc))el)"), Is.EqualTo("leetcode"));
    }
}