using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01991Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01991();
        sut.FindMiddleIndex(new[] {2, 3, -1, 8, 4}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01991();
        sut.FindMiddleIndex(new[] {1, -1, 4}).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01991();
        sut.FindMiddleIndex(new[] {2, 5}).Should().Be(-1);
    }
}