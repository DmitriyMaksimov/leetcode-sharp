using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00229Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00229();
        sut.MajorityElement(new[] {3, 2, 3}).Should().Equal(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00229();
        sut.MajorityElement(new[] {1}).Should().Equal(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00229();
        sut.MajorityElement(new[] {1, 2}).Should().Equal(1, 2);
    }
}