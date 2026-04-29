using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03225))]
public class S03225Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03225();
        Assert.That(sut.MaximumScore([[0, 0, 0, 0, 0], [0, 0, 3, 0, 0], [0, 1, 0, 0, 0], [5, 0, 0, 3, 0], [0, 0, 0, 0, 2]]), Is.EqualTo(11));
    }

    [Test]
    public void T2()
    {
        var sut = new S03225();
        Assert.That(sut.MaximumScore([[10, 9, 0, 0, 15], [7, 1, 0, 8, 0], [5, 20, 0, 11, 0], [0, 0, 0, 1, 2], [8, 12, 1, 10, 3]]), Is.EqualTo(94));
    }
}