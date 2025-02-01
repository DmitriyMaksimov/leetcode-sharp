using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02103Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02103();
        Assert.That(sut.CountPoints("B0B6G0R6R0R6G9"), Is.EqualTo(1));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02103();
        Assert.That(sut.CountPoints("B0R0G0R9R0B0G0"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02103();
        Assert.That(sut.CountPoints("G4"), Is.EqualTo(0));
    }
}