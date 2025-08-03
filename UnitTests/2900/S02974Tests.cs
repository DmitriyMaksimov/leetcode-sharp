using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02974Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02974();
        Assert.That(sut.NumberGame([5, 4, 2, 3]), Is.EqualTo((int[]) [3, 2, 5, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02974();
        Assert.That(sut.NumberGame([2, 5]), Is.EqualTo((int[]) [5, 2]));
    }
}