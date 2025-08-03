using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02032Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02032();
        Assert.That(sut.TwoOutOfThree([1, 1, 3, 2], [2, 3], [3]), Is.EquivalentTo([3, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02032();
        Assert.That(sut.TwoOutOfThree([3, 1], [2, 3], [1, 2]), Is.EquivalentTo([2, 3, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02032();
        Assert.That(sut.TwoOutOfThree([1, 2, 2], [4, 3, 3], [5]), Is.EquivalentTo(Array.Empty<int>()));
    }
}