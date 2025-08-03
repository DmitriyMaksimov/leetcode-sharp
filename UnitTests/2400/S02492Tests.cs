using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02492();
        Assert.That(sut.MinScore(4, [[1, 2, 9], [2, 3, 6], [2, 4, 5], [1, 4, 7]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02492();
        Assert.That(sut.MinScore(4, [[1, 2, 2], [1, 3, 4], [3, 4, 7]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02492();
        Assert.That(sut.MinScore(14, [
            [2, 9, 2308], [2, 5, 2150], [12, 3, 4944], [13, 5, 5462], [2, 10, 2187], [2, 12, 8132], [2, 13, 3666],
            [4, 14, 3019], [2, 4, 6759], [2, 14, 9869], [1, 10, 8147], [3, 4, 7971], [9, 13, 8026], [5, 12, 9982],
            [10, 9, 6459]
        ]), Is.EqualTo(2150));
    }
}