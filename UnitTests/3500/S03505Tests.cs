using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03505))]
public class S03505Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03505();
        Assert.That(sut.MinOperations([5, -2, 1, 3, 7, 3, 6, 4, -1], 3, 2), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S03505();
        Assert.That(sut.MinOperations([9, -2, -2, -2, 1, 5], 2, 2), Is.EqualTo(3));
    }
}