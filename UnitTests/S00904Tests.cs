using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00904Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00904();
        sut.TotalFruit(new[] {1, 2, 1}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00904();
        sut.TotalFruit(new[] {0, 1, 2, 2}).Should().Be(3);
    }

    [Test]
    public void T4()
    {
        var sut = new S00904();
        sut.TotalFruit(new[] {1, 2, 3, 2, 2}).Should().Be(4);
    }

    [Test]
    public void T5()
    {
        var sut = new S00904();
        sut.TotalFruit(new[] {0, 1, 6, 6, 4, 4, 6}).Should().Be(5);
    }
}