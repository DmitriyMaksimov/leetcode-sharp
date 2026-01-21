using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03315))]
public class S03315Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03315();
        Assert.That(sut.MinBitwiseArray([2, 3, 5, 7]), Is.EqualTo([-1, 1, 4, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03315();
        Assert.That(sut.MinBitwiseArray([11, 13, 31]), Is.EqualTo([9, 12, 15]));
    }
}