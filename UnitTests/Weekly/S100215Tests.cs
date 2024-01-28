using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S100215Tests
{
    [Test]
    public void T1()
    {
        var sut = new S100215();
        sut.CountKeyChanges("aAbBcC").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S100215();
        sut.CountKeyChanges("AaAaAaaA").Should().Be(0);
    }
}