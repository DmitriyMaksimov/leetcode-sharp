using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01464Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01464();
        sut.MaxProduct(new[] {3, 4, 5, 2}).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S01464();
        sut.MaxProduct(new[] {1, 5, 4, 5}).Should().Be(16);
    }

    [Test]
    public void T3()
    {
        var sut = new S01464();
        sut.MaxProduct(new[] {3, 7}).Should().Be(12);
    }
}