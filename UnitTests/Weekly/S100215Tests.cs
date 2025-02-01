using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S100215Tests
{
    [Test]
    public void T1()
    {
        var sut = new S100215();
        Assert.That(sut.CountKeyChanges("aAbBcC"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S100215();
        Assert.That(sut.CountKeyChanges("AaAaAaaA"), Is.EqualTo(0));
    }
}