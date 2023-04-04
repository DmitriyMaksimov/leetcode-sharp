using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02405Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02405();
        sut.PartitionString("abacaba").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02405();
        sut.PartitionString("ssssss").Should().Be(6);
    }
}