using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01702))]
public class S01702Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01702();
        Assert.That(sut.MaximumBinaryString("000110"), Is.EqualTo("111011"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01702();
        Assert.That(sut.MaximumBinaryString("01"), Is.EqualTo("01"));
    }
}