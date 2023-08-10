using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00763Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00763();
        sut.PartitionLabels("ababcbacadefegdehijhklij").Should().Equal(9, 7, 8);
    }

    [Test]
    public void T2()
    {
        var sut = new S00763();
        sut.PartitionLabels("eccbbbbdec").Should().Equal(10);
    }
}