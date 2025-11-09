using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03688))]
public class S03688Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03688();
        Assert.That(sut.EvenNumberBitwiseORs([1, 2, 3, 4, 5, 6]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03688();
        Assert.That(sut.EvenNumberBitwiseORs([7, 9, 11]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03688();
        Assert.That(sut.EvenNumberBitwiseORs([1, 8, 16]), Is.EqualTo(24));
    }
}