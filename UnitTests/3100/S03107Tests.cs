using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03107))]
public class S03107Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03107();
        Assert.That(sut.MinOperationsToMakeMedianK([2, 5, 6, 8, 5], 4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03107();
        Assert.That(sut.MinOperationsToMakeMedianK([2, 5, 6, 8, 5], 7), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03107();
        Assert.That(sut.MinOperationsToMakeMedianK([1, 2, 3, 4, 5, 6], 4), Is.EqualTo(0));
    }
}