using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00525Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00525();
        sut.FindMaxLength([0, 1]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00525();
        sut.FindMaxLength([0, 1, 0]).Should().Be(2);
    }
}