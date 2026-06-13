using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03838))]
public class S03838Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03838();
        Assert.That(sut.MapWordWeights(["abcd", "def", "xyz"], [5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2]), Is.EqualTo("rij"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03838();
        Assert.That(sut.MapWordWeights(["a", "b", "c"], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]), Is.EqualTo("yyy"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03838();
        Assert.That(sut.MapWordWeights(["abcd"], [7, 5, 3, 4, 3, 5, 4, 9, 4, 2, 2, 7, 10, 2, 5, 10, 6, 1, 2, 2, 4, 1, 3, 4, 4, 5]), Is.EqualTo("g"));
    }
}