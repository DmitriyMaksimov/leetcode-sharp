using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01175Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01175();
        sut.NumPrimeArrangements(5).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S01175();
        sut.NumPrimeArrangements(100).Should().Be(682289015);
    }
}