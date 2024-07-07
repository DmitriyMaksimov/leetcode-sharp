using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03151Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03151();
        sut.IsArraySpecial([1]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03151();
        sut.IsArraySpecial([2, 1, 4]).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S03151();
        sut.IsArraySpecial([4, 3, 1, 6]).Should().BeFalse();
    }
}