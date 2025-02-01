using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03190();
        Assert.That(sut.MinimumOperations([1, 2, 3, 4]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03190();
        Assert.That(sut.MinimumOperations([3, 6, 9]), Is.EqualTo(0));
    }
}