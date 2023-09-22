using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02404Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02404();
        sut.MostFrequentEven(new[] {0, 1, 2, 2, 4, 4, 1}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02404();
        sut.MostFrequentEven(new[] {4, 4, 4, 9, 2, 4}).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02404();
        sut.MostFrequentEven(new[] {29, 47, 21, 41, 13, 37, 25, 7}).Should().Be(-1);
    }
}