using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01420Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01420();
        sut.NumOfArrays(2, 3, 1).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01420();
        sut.NumOfArrays(5, 2, 3).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01420();
        sut.NumOfArrays(9, 1, 1).Should().Be(1);
    }
}