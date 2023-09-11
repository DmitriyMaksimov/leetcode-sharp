using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01652Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01652();
        sut.Decrypt(new[] {5, 7, 1, 4}, 3).Should().Equal(12, 10, 16, 13);
    }

    [Test]
    public void T2()
    {
        var sut = new S01652();
        sut.Decrypt(new[] {1, 2, 3, 4}, 0).Should().Equal(0, 0, 0, 0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01652();
        sut.Decrypt(new[] {2, 4, 9, 3}, -2).Should().Equal(12, 5, 6, 13);
    }
}