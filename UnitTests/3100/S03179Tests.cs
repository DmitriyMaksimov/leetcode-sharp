using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03179Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03179();
        sut.ValueAfterKSeconds(4, 5).Should().Be(56);
    }

    [Test]
    public void T2()
    {
        var sut = new S03179();
        sut.ValueAfterKSeconds(5, 3).Should().Be(35);
    }
}
