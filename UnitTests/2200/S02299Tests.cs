using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02299Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02299();
        Assert.That(sut.StrongPasswordCheckerII("IloveLe3tcode!"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02299();
        Assert.That(sut.StrongPasswordCheckerII("Me+You--IsMyDream"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02299();
        Assert.That(sut.StrongPasswordCheckerII("1aB!"), Is.False);
    }
}
