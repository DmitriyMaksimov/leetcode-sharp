using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02765Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02765();
        sut.AlternatingSubarray(new[] {2, 3, 4, 3, 4}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02765();
        sut.AlternatingSubarray(new[] {4, 5, 6}).Should().Be(2);
    }
}