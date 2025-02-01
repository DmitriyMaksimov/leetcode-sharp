using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00413Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00413();
        Assert.That(sut.NumberOfArithmeticSlices(new[] {1, 2, 3, 4}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00413();
        Assert.That(sut.NumberOfArithmeticSlices(new[] {1}), Is.EqualTo(0));
    }
}