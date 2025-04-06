using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03484Tests
{
    [Test]
    public void T1()
    {
        var spreadsheet = new S03484.Spreadsheet(3);
        Assert.That(spreadsheet.GetValue("=5+7"), Is.EqualTo(12)); // returns 12 (5+7)
        spreadsheet.SetCell("A1", 10); // sets A1 to 10
        Assert.That(spreadsheet.GetValue("=A1+6"), Is.EqualTo(16)); // returns 16 (10+6)
        spreadsheet.SetCell("B2", 15); // sets B2 to 15
        Assert.That(spreadsheet.GetValue("=A1+B2"), Is.EqualTo(25)); // returns 25 (10+15)
        spreadsheet.ResetCell("A1"); // resets A1 to 0
        Assert.That(spreadsheet.GetValue("=A1+B2"), Is.EqualTo(15)); // returns 15 (0+15)
    }
}
