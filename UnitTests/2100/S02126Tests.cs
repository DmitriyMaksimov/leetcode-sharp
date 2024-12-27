using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02126Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02126();
        sut.AsteroidsDestroyed(10, [3, 9, 19, 5, 21]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02126();
        sut.AsteroidsDestroyed(5, [4, 9, 23, 4]).Should().BeFalse();
    }
}
