using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03314Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03314();
        Assert.That(sut.MinBitwiseArray([2, 3, 5, 7]), Is.EqualTo((int[]) [-1, 1, 4, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03314();
        Assert.That(sut.MinBitwiseArray([11, 13, 31]), Is.EqualTo((int[]) [9, 12, 15]));
    }
}
