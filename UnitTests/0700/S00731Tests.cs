using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00731Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00731.MyCalendarTwo();
        sut.Book(10, 20).Should().BeTrue();
        sut.Book(50, 60).Should().BeTrue();
        sut.Book(10, 40).Should().BeTrue();
        sut.Book(5, 15).Should().BeFalse();
        sut.Book(5, 10).Should().BeTrue();
        sut.Book(25, 55).Should().BeTrue();
    }
}
