using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00763Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00763();
        Assert.That(sut.PartitionLabels("ababcbacadefegdehijhklij"), Is.EqualTo((int[]) [9, 7, 8]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00763();
        Assert.That(sut.PartitionLabels("eccbbbbdec"), Is.EqualTo((int[]) [10]));
    }
}