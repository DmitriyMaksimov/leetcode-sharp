using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00169Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00169();
        sut.MajorityElement(new[] {3, 2, 3}).Should().Be(3);
    }

    [Test]
    public void Test2()
    {
        var sut = new S00169();
        sut.MajorityElement(new[] {2, 2, 1, 1, 1, 2, 2}).Should().Be(2);
    }

    [Test]
    public void Test3()
    {
        var sut = new S00169();
        sut.MajorityElement(new[] {1}).Should().Be(1);
    }

    [Test]
    public void Test4()
    {
        var sut = new S00169();
        sut.MajorityElement(new[] {3, 3, 4}).Should().Be(3);
    }

    [Test]
    public void Test5()
    {
        var sut = new S00169();
        sut.MajorityElement(new[] {-1, 1, 1, 1, 2, 1}).Should().Be(1);
    }
}