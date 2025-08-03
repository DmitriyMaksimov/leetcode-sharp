using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02389Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02389();
        Assert.That(sut.AnswerQueries([4, 5, 2, 1], [3, 10, 21]), Is.EqualTo((int[]) [2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02389();
        Assert.That(sut.AnswerQueries([2, 3, 4, 5], [1]), Is.EqualTo((int[]) [0]));
    }
}