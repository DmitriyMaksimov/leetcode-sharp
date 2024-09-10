using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S002895Tests
{
    [Test]
    public void T1()
    {
        var sut = new S002895();
        sut.MinProcessingTime([8, 10], [2, 2, 3, 1, 8, 7, 4, 5]).Should().Be(16);
    }

    [Test]
    public void T2()
    {
        var sut = new S002895();
        sut.MinProcessingTime([10, 20], [2, 3, 1, 2, 5, 8, 4, 3]).Should().Be(23);
    }
}
