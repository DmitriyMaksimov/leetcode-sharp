using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03174Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03174();
        Assert.That(sut.ClearDigits("abc"), Is.EqualTo("abc"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03174();
        Assert.That(sut.ClearDigits("cb34"), Is.EqualTo(""));
    }
}