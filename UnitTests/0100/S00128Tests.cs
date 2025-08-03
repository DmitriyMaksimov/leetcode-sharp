using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00128Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00128();
        Assert.That(sut.LongestConsecutive([100, 4, 200, 1, 3, 2]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00128();
        Assert.That(sut.LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]), Is.EqualTo(9));
    }
}