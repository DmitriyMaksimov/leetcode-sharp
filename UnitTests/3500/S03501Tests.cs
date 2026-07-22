using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03501))]
public class S03501Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03501();
        Assert.That(sut.MaxActiveSectionsAfterTrade("01", [[0, 1]]), Is.EqualTo([1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03501();
        Assert.That(sut.MaxActiveSectionsAfterTrade("0100", [[0, 3], [0, 2], [1, 3], [2, 3]]), Is.EqualTo([4, 3, 1, 1]));
    }
}