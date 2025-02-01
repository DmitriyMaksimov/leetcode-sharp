using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01807Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01807();
        Assert.That(sut.Evaluate("(name)is(age)yearsold", [["name", "bob"], ["age", "two"]]), Is.EqualTo("bobistwoyearsold"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01807();
        Assert.That(sut.Evaluate("hi(name)", [["a", "b"]]), Is.EqualTo("hi?"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01807();
        Assert.That(sut.Evaluate("(a)(a)(a)aaa", [["a", "yes"]]), Is.EqualTo("yesyesyesaaa"));
    }
}
