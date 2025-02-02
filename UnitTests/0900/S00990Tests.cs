using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00990Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00990();
        Assert.That(sut.EquationsPossible(["a==b", "b!=a"]), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00990();
        Assert.That(sut.EquationsPossible(["b==a", "a==b"]), Is.True);
    }
}
