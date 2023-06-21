using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01304Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01304();
        var sumZero = sut.SumZero(5);
        sumZero.Should().HaveCount(5);
        sumZero.Should().OnlyHaveUniqueItems();
        sumZero.Sum().Should().Be(0);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01304();
        var sumZero = sut.SumZero(3);
        sumZero.Should().HaveCount(3);
        sumZero.Should().OnlyHaveUniqueItems();
        sumZero.Sum().Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01304();
        var sumZero = sut.SumZero(1);
        sumZero.Should().HaveCount(1);
        sumZero.Should().OnlyHaveUniqueItems();
        sumZero.Sum().Should().Be(0);
    }
}