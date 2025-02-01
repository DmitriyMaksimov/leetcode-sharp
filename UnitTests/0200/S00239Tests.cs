using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00239();
        Assert.That(sut.MaxSlidingWindow(new[] {1, 3, -1, -3, 5, 3, 6, 7}, 3), Is.EqualTo((int[]) [3, 3, 5, 5, 6, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00239();
        Assert.That(sut.MaxSlidingWindow(new[] {1}, 1), Is.EqualTo((int[]) [1]));
    }
}