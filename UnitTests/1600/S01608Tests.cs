using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01608Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01608();
        sut.SpecialArray(new[] {3, 5}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01608();
        sut.SpecialArray(new[] {0, 0}).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01608();
        sut.SpecialArray(new[] {0, 4, 3, 0, 4}).Should().Be(3);
    }
}