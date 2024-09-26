using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00729Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00729.MyCalendar();
        sut.Book(10, 20).Should().BeTrue();
        sut.Book(15, 25).Should().BeFalse();
        sut.Book(20, 30).Should().BeTrue();
    }
}
