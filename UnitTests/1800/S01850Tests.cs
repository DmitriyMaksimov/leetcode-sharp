using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01850Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01850();
        sut.GetMinSwaps("5489355142", 4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01850();
        sut.GetMinSwaps("11112", 4).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S01850();
        sut.GetMinSwaps("00123", 1).Should().Be(1);
    }
}