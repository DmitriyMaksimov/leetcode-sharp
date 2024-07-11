using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01190();
        sut.ReverseParentheses("(abcd)").Should().Be("dcba");
    }

    [Test]
    public void T2()
    {
        var sut = new S01190();
        sut.ReverseParentheses("(u(love)i)").Should().Be("iloveu");
    }

    [Test]
    public void T3()
    {
        var sut = new S01190();
        sut.ReverseParentheses("(ed(et(oc))el)").Should().Be("leetcode");
    }
}