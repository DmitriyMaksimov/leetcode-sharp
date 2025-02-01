using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01929Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01929();
        Assert.That(sut.GetConcatenation(new[] {1, 2, 1}), Is.EqualTo((int[]) [1, 2, 1, 1, 2, 1]));
    }

    [Test]
    public void Test2()
    {
        var sut = new S01929();
        Assert.That(sut.GetConcatenation(new[] {1, 3, 2, 1}), Is.EqualTo((int[]) [1, 3, 2, 1, 1, 3, 2, 1]));
    }
}