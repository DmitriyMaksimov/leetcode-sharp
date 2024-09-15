using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01807Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01807();
        sut.Evaluate("(name)is(age)yearsold", [["name", "bob"], ["age", "two"]]).Should().Be("bobistwoyearsold");
    }

    [Test]
    public void T2()
    {
        var sut = new S01807();
        sut.Evaluate("hi(name)", [["a", "b"]]).Should().Be("hi?");
    }

    [Test]
    public void T3()
    {
        var sut = new S01807();
        sut.Evaluate("(a)(a)(a)aaa", [["a", "yes"]]).Should().Be("yesyesyesaaa");
    }
}
