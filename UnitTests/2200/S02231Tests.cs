using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02231Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02231();
        Assert.That(sut.LargestInteger(1234), Is.EqualTo(3412));
    }

    [Test]
    public void T2()
    {
        var sut = new S02231();
        Assert.That(sut.LargestInteger(65875), Is.EqualTo(87655));
    }
}