using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00857Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00857();
        Assert.That(sut.MincostToHireWorkers([10, 20, 5], [70, 50, 30], 2), Is.EqualTo(105).Within(0.0001));
    }

    [Test]
    public void T2()
    {
        var sut = new S00857();
        Assert.That(sut.MincostToHireWorkers([3, 1, 10, 10, 1], [4, 8, 2, 2, 7], 3), Is.EqualTo(30.66667).Within(0.0001));
    }

    [Test]
    public void T3()
    {
        var sut = new S00857();
        Assert.That(sut.MincostToHireWorkers([4,4,4,5], [13,12,13,12], 2), Is.EqualTo(26).Within(0.0001));
    }
}