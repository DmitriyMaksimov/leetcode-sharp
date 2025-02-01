using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03152Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03152();
        Assert.That(sut.IsArraySpecial([3, 4, 1, 2, 6], [[0, 4]]), Is.EqualTo((bool[]) [false]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03152();
        Assert.That(sut.IsArraySpecial([4, 3, 1, 6], [[0, 2], [2, 3]]), Is.EqualTo((bool[]) [false, true]));
    }
}
