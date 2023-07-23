using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00735Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00735();
        sut.AsteroidCollision(new[] {5, 10, -5}).Should().Equal(5, 10);
    }

    [Test]
    public void T2()
    {
        var sut = new S00735();
        sut.AsteroidCollision(new[] {8, -8}).Should().Equal();
    }

    [Test]
    public void T3()
    {
        var sut = new S00735();
        sut.AsteroidCollision(new[] {10, 2, -5}).Should().Equal(10);
    }
}