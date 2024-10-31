using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03070Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03070();
        sut.CountSubmatrices([[7, 6, 3], [6, 6, 1]], 18).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03070();
        sut.CountSubmatrices([[7, 2, 9], [1, 5, 0], [2, 6, 6]], 20).Should().Be(6);
    }
}
