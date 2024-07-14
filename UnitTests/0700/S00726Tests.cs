using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00726Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00726();
        sut.CountOfAtoms("H2O").Should().Be("H2O");
    }

    [Test]
    public void T2()
    {
        var sut = new S00726();
        sut.CountOfAtoms("Mg(OH)2").Should().Be("H2MgO2");
    }

    [Test]
    public void T3()
    {
        var sut = new S00726();
        sut.CountOfAtoms("K4(ON(SO3)2)2").Should().Be("K4N2O14S4");
    }
}