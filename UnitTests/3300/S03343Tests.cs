using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03343))]
public class S03343Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03343();
        Assert.That(sut.CountBalancedPermutations("123"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03343();
        Assert.That(sut.CountBalancedPermutations("112"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03343();
        Assert.That(sut.CountBalancedPermutations("12345"), Is.EqualTo(0));
    }
}
