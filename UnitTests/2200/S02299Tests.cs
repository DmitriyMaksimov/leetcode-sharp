using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02299Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02299();
        sut.StrongPasswordCheckerII("IloveLe3tcode!").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02299();
        sut.StrongPasswordCheckerII("Me+You--IsMyDream").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02299();
        sut.StrongPasswordCheckerII("1aB!").Should().BeFalse();
    }
}