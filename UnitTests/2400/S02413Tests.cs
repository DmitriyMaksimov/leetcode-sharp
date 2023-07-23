using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02413Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02413();
        sut.SmallestEvenMultiple(5).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S02413();
        sut.SmallestEvenMultiple(6).Should().Be(6);
    }
}