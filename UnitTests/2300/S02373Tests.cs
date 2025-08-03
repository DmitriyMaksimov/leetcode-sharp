using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02373Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02373();
        var result = sut.LargestLocal([[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]]);
        Assert.That(result[0], Is.EqualTo((int[]) [9, 9]));
        Assert.That(result[1], Is.EqualTo((int[]) [8, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02373();
        var result = sut.LargestLocal([
            [1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 2, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]
        ]);
        Assert.That(result[0], Is.EqualTo((int[]) [2, 2, 2]));
        Assert.That(result[1], Is.EqualTo((int[]) [2, 2, 2]));
        Assert.That(result[2], Is.EqualTo((int[]) [2, 2, 2]));
    }
}