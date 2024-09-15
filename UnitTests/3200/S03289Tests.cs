using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03289Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03289();
        sut.GetSneakyNumbers([0, 1, 1, 0]).Should().BeEquivalentTo([0, 1]);
    }

    [Test]
    public void T2()
    {
        var sut = new S03289();
        sut.GetSneakyNumbers([0, 3, 2, 1, 3, 2]).Should().BeEquivalentTo([2, 3]);
    }

    [Test]
    public void T3()
    {
        var sut = new S03289();
        sut.GetSneakyNumbers([7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2]).Should().BeEquivalentTo([4, 5]);
    }
}
