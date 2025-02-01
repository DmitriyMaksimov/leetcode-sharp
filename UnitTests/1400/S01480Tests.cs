using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01480Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01480();
        Assert.That(sut.RunningSum(new[] {1, 2, 3, 4}), Is.EqualTo((int[]) [1, 3, 6, 10]));
    }

    [Test]
    public void Test2()
    {
        var sut = new S01480();
        Assert.That(sut.RunningSum(new[] {1, 1, 1, 1, 1}), Is.EqualTo((int[]) [1, 2, 3, 4, 5]));
    }

    [Test]
    public void Test3()
    {
        var sut = new S01480();
        Assert.That(sut.RunningSum(new[] {3, 1, 2, 10, 1}), Is.EqualTo((int[]) [3, 4, 6, 16, 17]));
    }
}