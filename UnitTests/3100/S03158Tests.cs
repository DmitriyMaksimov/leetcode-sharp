using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03158Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03158();
        sut.DuplicateNumbersXOR([1, 2, 1, 3]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03158();
        sut.DuplicateNumbersXOR([1, 2, 3]).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S03158();
        sut.DuplicateNumbersXOR([1, 2, 2, 1]).Should().Be(3);
    }
}