using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00726Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00726();
        Assert.That(sut.CountOfAtoms("H2O"), Is.EqualTo("H2O"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00726();
        Assert.That(sut.CountOfAtoms("Mg(OH)2"), Is.EqualTo("H2MgO2"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00726();
        Assert.That(sut.CountOfAtoms("K4(ON(SO3)2)2"), Is.EqualTo("K4N2O14S4"));
    }
}