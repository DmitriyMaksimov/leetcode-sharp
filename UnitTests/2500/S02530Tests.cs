using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02530Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02530();
        Assert.That(sut.MaxKelements([10, 10, 10, 10, 10], 5), Is.EqualTo(50));
    }

    [Test]
    public void T2()
    {
        var sut = new S02530();
        Assert.That(sut.MaxKelements([1, 10, 3, 3, 3], 3), Is.EqualTo(17));
    }
}
