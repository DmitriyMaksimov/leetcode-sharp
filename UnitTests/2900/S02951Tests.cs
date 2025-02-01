using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02951Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02951();
        Assert.That(sut.FindPeaks(new[] {2, 4, 4}), Is.Empty);
    }

    [Test]
    public void T2()
    {
        var sut = new S02951();
        sut.FindPeaks(new[] {1, 4, 3, 8, 5}).Should().Equal(1, 3);
    }
}