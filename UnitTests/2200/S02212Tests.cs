using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02212Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02212();
        Assert.That(sut.MaximumBobPoints(9, [1, 1, 0, 1, 0, 0, 2, 1, 0, 1, 2, 0]), Is.EqualTo([0, 0, 0, 0, 1, 1, 0, 0, 1, 2, 3, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02212();
        Assert.That(sut.MaximumBobPoints(3, [0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2]), Is.EqualTo([0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0]));
    }
}
