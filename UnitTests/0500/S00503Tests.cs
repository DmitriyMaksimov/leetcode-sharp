using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00503Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00503();
        sut.NextGreaterElements([1, 2, 1]).Should().Equal(2, -1, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00503();
        sut.NextGreaterElements([1, 2, 3, 4, 3]).Should().Equal(2, 3, 4, -1, 4);
    }
}
