using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03211Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03211();
        sut.ValidStrings(3).Should().BeEquivalentTo(["010", "011", "101", "110", "111"]);
    }

    [Test]
    public void T2()
    {
        var sut = new S03211();
        sut.ValidStrings(1).Should().BeEquivalentTo(["0", "1"]);
    }

    [Test]
    public void T3()
    {
        var sut = new S03211();
        sut.ValidStrings(18).Should().HaveCount(6765);
    }
}
