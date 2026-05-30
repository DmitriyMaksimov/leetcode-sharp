using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03161))]
public class S03161Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03161();
        Assert.That(sut.GetResults([[1, 2], [2, 3, 3], [2, 3, 1], [2, 2, 2]]), Is.EqualTo([false, true, true]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03161();
        Assert.That(sut.GetResults([[1, 7], [2, 7, 6], [1, 2], [2, 7, 5], [2, 7, 6]]), Is.EqualTo([true, true, false]));
    }
}