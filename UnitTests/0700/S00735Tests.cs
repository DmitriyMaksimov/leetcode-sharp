using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00735Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00735();
        Assert.That(sut.AsteroidCollision([5, 10, -5]), Is.EqualTo((int[]) [5, 10]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00735();
        Assert.That(sut.AsteroidCollision([8, -8]), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00735();
        Assert.That(sut.AsteroidCollision([10, 2, -5]), Is.EqualTo((int[]) [10]));
    }
}