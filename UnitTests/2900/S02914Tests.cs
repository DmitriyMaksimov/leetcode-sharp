using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02914Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02914();
        sut.MinChanges("1001").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02914();
        sut.MinChanges("10").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02914();
        sut.MinChanges("0000").Should().Be(0);
    }
}
