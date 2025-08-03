using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01002Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01002();
        Assert.That(sut.CommonChars(["bella", "label", "roller"]), Is.EqualTo((string[]) ["e", "l", "l"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01002();
        Assert.That(sut.CommonChars(["cool", "lock", "cook"]), Is.EqualTo((string[]) ["c", "o"]));
    }
}
