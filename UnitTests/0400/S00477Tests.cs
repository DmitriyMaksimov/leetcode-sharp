using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00477Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00477();
        sut.TotalHammingDistance([4, 14, 2]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00477();
        sut.TotalHammingDistance([4, 14, 4]).Should().Be(4);
    }
}
