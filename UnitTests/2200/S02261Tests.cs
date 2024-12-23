using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02261Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02261();
        sut.CountDistinct([2, 3, 3, 2, 2], 2, 2).Should().Be(11);
    }

    [Test]
    public void T2()
    {
        var sut = new S02261();
        sut.CountDistinct([1, 2, 3, 4], 4, 1).Should().Be(10);
    }
}
