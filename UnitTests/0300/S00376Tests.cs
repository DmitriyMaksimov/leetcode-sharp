using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00376Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00376();
        sut.WiggleMaxLength(new[] {1, 7, 4, 9, 2, 5}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00376();
        sut.WiggleMaxLength(new[] {1, 17, 5, 10, 13, 15, 10, 5, 16, 8}).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S00376();
        sut.WiggleMaxLength(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}).Should().Be(2);
    }
}