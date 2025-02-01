using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03100Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03100();
        Assert.That(sut.MaxBottlesDrunk(13, 6), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S03100();
        Assert.That(sut.MaxBottlesDrunk(10, 3), Is.EqualTo(13));
    }
}
