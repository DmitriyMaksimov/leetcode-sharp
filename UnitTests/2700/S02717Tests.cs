using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02717Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02717();
        sut.SemiOrderedPermutation(new[] {2, 1, 4, 3}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02717();
        sut.SemiOrderedPermutation(new[] {2, 4, 1, 3}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02717();
        sut.SemiOrderedPermutation(new[] {1, 3, 4, 2, 5}).Should().Be(0);
    }
}