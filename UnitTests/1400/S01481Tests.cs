using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01481Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01481();
        sut.FindLeastNumOfUniqueInts([5, 5, 4], 1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01481();
        sut.FindLeastNumOfUniqueInts([4, 3, 1, 1, 3, 3, 2], 3).Should().Be(2);
    }
}