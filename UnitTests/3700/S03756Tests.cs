using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03756))]
public class S03756Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03756();
        Assert.That(sut.SumAndMultiply("10203004", [[0, 7], [1, 3], [4, 6]]), Is.EqualTo([12340, 4, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03756();
        Assert.That(sut.SumAndMultiply("1000", [[0, 3], [1, 1]]), Is.EqualTo([1, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03756();
        Assert.That(sut.SumAndMultiply("9876543210", [[0, 9]]), Is.EqualTo([444444137]));
    }
}