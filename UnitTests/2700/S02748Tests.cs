using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02748Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02748();
        sut.CountBeautifulPairs(new[] {2, 5, 1, 4}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02748();
        sut.CountBeautifulPairs(new[] {11, 21, 12}).Should().Be(2);
    }
}