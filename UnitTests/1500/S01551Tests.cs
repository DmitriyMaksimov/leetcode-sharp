using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01551Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01551();
        sut.MinOperations(3).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01551();
        sut.MinOperations(6).Should().Be(9);
    }
}