using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02717Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02717();
        Assert.That(sut.SemiOrderedPermutation([2, 1, 4, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02717();
        Assert.That(sut.SemiOrderedPermutation([2, 4, 1, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02717();
        Assert.That(sut.SemiOrderedPermutation([1, 3, 4, 2, 5]), Is.EqualTo(0));
    }
}