using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03448))]
public class S03448Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03448();
        Assert.That(sut.MinSensors(5, 5, 1), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03448();
        Assert.That(sut.MinSensors(2, 2, 2), Is.EqualTo(1));
    }
}