using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02103Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02103();
        sut.CountPoints("B0B6G0R6R0R6G9").Should().Be(1);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02103();
        sut.CountPoints("B0R0G0R9R0B0G0").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02103();
        sut.CountPoints("G4").Should().Be(0);
    }
}