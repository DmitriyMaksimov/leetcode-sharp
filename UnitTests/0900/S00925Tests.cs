using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00925Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00925();
        Assert.That(sut.IsLongPressedName("alex", "aaleex"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00925();
        Assert.That(sut.IsLongPressedName("saeed", "ssaaedd"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00925();
        Assert.That(sut.IsLongPressedName("alex", "aaleexa"), Is.False);
    }
}
