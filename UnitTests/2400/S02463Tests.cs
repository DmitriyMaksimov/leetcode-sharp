using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02463Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02463();
        Assert.That(sut.MinimumTotalDistance([0, 4, 6], [[2, 2], [6, 2]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02463();
        Assert.That(sut.MinimumTotalDistance([1, -1], [[-2, 1], [2, 1]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02463();
        Assert.That(sut.MinimumTotalDistance(
        [
            -333539942, 359275673, 89966494, 949684497, -733065249, 241002388, 325009248, 403868412, -390719486, -670541382, 563735045, 119743141, 323190444, 534058139, -684109467,
            425503766, 761908175
        ], [[-590277115, 0], [-80676932, 3], [396659814, 0], [480747884, 9], [118956496, 10]]), Is.EqualTo(4412966458));
    }
}
