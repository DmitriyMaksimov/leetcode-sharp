using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03502Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03502();
        Assert.That(sut.MinCosts([5, 3, 4, 1, 3, 2]), Is.EqualTo([5, 3, 3, 1, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03502();
        Assert.That(sut.MinCosts([1, 2, 4, 6, 7]), Is.EqualTo([1, 1, 1, 1, 1]));
    }
}
