using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00287Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00287();
        sut.FindDuplicate(new[] {1, 3, 4, 2, 2}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00287();
        sut.FindDuplicate(new[] {3, 1, 3, 4, 2}).Should().Be(3);
    }
}