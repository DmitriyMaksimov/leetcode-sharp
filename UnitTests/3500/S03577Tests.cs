using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03577))]
public class S03577Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03577();
        Assert.That(sut.CountPermutations([1, 2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03577();
        Assert.That(sut.CountPermutations([3, 3, 3, 4, 4, 4]), Is.Zero);
    }
}