using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01104Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01104();
        sut.PathInZigZagTree(14).Should().Equal(1,3,4,14);
    }

    [Test]
    public void T2()
    {
        var sut = new S01104();
        sut.PathInZigZagTree(26).Should().Equal(1,2,6,10,26);
    }
}