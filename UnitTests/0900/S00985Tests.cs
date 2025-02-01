using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00985Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00985();
        Assert.That(sut.SumEvenAfterQueries([1, 2, 3, 4], [[1, 0], [-3, 1], [-4, 0], [2, 3]]), Is.EqualTo((int[]) [8, 6, 2, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00985();
        Assert.That(sut.SumEvenAfterQueries([1], [[4, 0]]), Is.EqualTo((int[]) [0]));
    }
}
