using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03309Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03309();
        sut.MaxGoodNumber([1, 2, 3]).Should().Be(30);
    }

    [Test]
    public void T2()
    {
        var sut = new S03309();
        sut.MaxGoodNumber([2, 8, 16]).Should().Be(1296);
    }
}
