using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02178Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02178();
        sut.MaximumEvenSplit(12).Should().Equal(2, 4, 6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02178();
        Assert.That(sut.MaximumEvenSplit(7), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S02178();
        sut.MaximumEvenSplit(28).Should().Equal(2, 4, 6, 16);
    }
}
