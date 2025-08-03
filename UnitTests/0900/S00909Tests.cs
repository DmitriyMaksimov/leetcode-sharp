using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00909Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00909();
        Assert.That(sut.SnakesAndLadders([
            [-1, -1, -1, -1, -1, -1],
            [-1, -1, -1, -1, -1, -1],
            [-1, -1, -1, -1, -1, -1],
            [-1, 35, -1, -1, 13, -1],
            [-1, -1, -1, -1, -1, -1],
            [-1, 15, -1, -1, -1, -1]
        ]), Is.EqualTo(4));
    }
}