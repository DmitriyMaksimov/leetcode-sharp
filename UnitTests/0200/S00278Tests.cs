using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00278Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00278(4);
        sut.FirstBadVersion(5).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00278(1);
        sut.FirstBadVersion(1).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00278(2);
        sut.FirstBadVersion(3).Should().Be(2);
    }
    
    [Test]
    public void T4()
    {
        var sut = new S00278(1702766719);
        sut.FirstBadVersion(2126753390).Should().Be(1702766719);
    }
}