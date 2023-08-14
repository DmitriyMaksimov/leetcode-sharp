using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00433();
        sut.MinMutation("AACCGGTT", "AACCGGTA", new[] {"AACCGGTA"}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00433();
        sut.MinMutation("AACCGGTT", "AAACGGTA", new[] {"AACCGGTA", "AACCGCTA", "AAACGGTA"}).Should().Be(2);
    }
}