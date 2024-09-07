using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01387Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01387();
        sut.GetKth(12, 15, 2).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S01387();
        sut.GetKth(7, 11, 4).Should().Be(7);
    }
}
