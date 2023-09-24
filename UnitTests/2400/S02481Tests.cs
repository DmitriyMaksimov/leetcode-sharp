using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02481Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02481();
        sut.NumberOfCuts(4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02481();
        sut.NumberOfCuts(3).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02481();
        sut.NumberOfCuts(8).Should().Be(4);
    }

    [Test]
    public void T4()
    {
        var sut = new S02481();
        sut.NumberOfCuts(1).Should().Be(0);
    }

    [Test]
    public void T5()
    {
        var sut = new S02481();
        sut.NumberOfCuts(6).Should().Be(3);
    }
}