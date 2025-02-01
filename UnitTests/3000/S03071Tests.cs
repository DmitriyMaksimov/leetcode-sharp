using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03071Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03071();
        Assert.That(sut.MinimumOperationsToWriteY([[1, 2, 2], [1, 1, 0], [0, 1, 0]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03071();
        Assert.That(sut.MinimumOperationsToWriteY([[0, 1, 0, 1, 0], [2, 1, 0, 1, 2], [2, 2, 2, 0, 1], [2, 2, 2, 2, 2], [2, 1, 2, 2, 2]]), Is.EqualTo(12));
    }
}
