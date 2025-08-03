using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00905Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00905();
        Assert.That(sut.SortArrayByParity([3, 1, 2, 4]), Is.EqualTo((int[]) [2, 4, 1, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00905();
        Assert.That(sut.SortArrayByParity([0]), Is.EqualTo((int[]) [0]));
    }
}