using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03345Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03345();
        sut.SmallestNumber(10, 2).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S03345();
        sut.SmallestNumber(15, 3).Should().Be(16);
    }
}
