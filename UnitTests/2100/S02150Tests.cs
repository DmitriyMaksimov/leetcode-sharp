using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02150Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02150();
        sut.FindLonely([10, 6, 5, 8]).Should().Equal(10, 8);
    }

    [Test]
    public void T2()
    {
        var sut = new S02150();
        sut.FindLonely([1, 3, 5, 3]).Should().Equal(1, 5);
    }
}
