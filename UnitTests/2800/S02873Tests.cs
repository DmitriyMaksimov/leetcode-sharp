using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02873Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02873();
        sut.MaximumTripletValue(new[] { 12,6,1,2,7}).Should().Be(77);
    }

    [Test]
    public void T2()
    {
        var sut = new S02873();
        sut.MaximumTripletValue(new[] { 1,10,3,4,19}).Should().Be(133);
    }

    [Test]
    public void T3()
    {
        var sut = new S02873();
        sut.MaximumTripletValue(new[] {1,2,3 }).Should().Be(0);
    }
}