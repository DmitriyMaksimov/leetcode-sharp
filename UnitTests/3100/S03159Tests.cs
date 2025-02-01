using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03159Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03159();
        Assert.That(sut.OccurrencesOfElement([1, 3, 1, 7], [1, 3, 2, 4], 1), Is.EqualTo((int[]) [0, -1, 2, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03159();
        Assert.That(sut.OccurrencesOfElement([1, 2, 3], [10], 5), Is.EqualTo((int[]) [-1]));
    }
}
