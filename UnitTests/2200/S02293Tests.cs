using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02293Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02293();
        Assert.That(sut.MinMaxGame([1, 3, 5, 2, 4, 8, 2, 2]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02293();
        Assert.That(sut.MinMaxGame([3]), Is.EqualTo(3));
    }
}