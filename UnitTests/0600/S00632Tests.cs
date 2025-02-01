using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00632Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00632();
        Assert.That(sut.SmallestRange([[4, 10, 15, 24, 26], [0, 9, 12, 20], [5, 18, 22, 30]]), Is.EqualTo((int[]) [20, 24]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00632();
        Assert.That(sut.SmallestRange([[1, 2, 3], [1, 2, 3], [1, 2, 3]]), Is.EqualTo((int[]) [1, 1]));
    }
}
