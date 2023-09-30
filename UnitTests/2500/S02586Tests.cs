using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02586Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02586();
        sut.VowelStrings(new[] {"are", "amy", "u"}, 0, 2).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02586();
        sut.VowelStrings(new[] {"hey", "aeo", "mu", "ooo", "artro"}, 1, 4).Should().Be(3);
    }
}