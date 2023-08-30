using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00496Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00496();
        sut.NextGreaterElement(new[] {4, 1, 2}, new[] {1, 3, 4, 2}).Should().Equal(-1, 3, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00496();
        sut.NextGreaterElement(new[] {2, 4}, new[] {1, 2, 3, 4}).Should().Equal(3, -1);
    }
}