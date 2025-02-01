using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01396Tests
{
    [Test]
    public void T1()
    {
        var undergroundSystem = new S01396.UndergroundSystem();
        undergroundSystem.CheckIn(45, "Leyton", 3);
        undergroundSystem.CheckIn(32, "Paradise", 8);
        undergroundSystem.CheckIn(27, "Leyton", 10);
        undergroundSystem.CheckOut(45, "Waterloo", 15);  // Customer 45 "Leyton" -> "Waterloo" in 15-3 = 12
        undergroundSystem.CheckOut(27, "Waterloo", 20);  // Customer 27 "Leyton" -> "Waterloo" in 20-10 = 10
        undergroundSystem.CheckOut(32, "Cambridge", 22); // Customer 32 "Paradise" -> "Cambridge" in 22-8 = 14
        Assert.That(undergroundSystem.GetAverageTime("Paradise", "Cambridge"), Is.EqualTo(14)); // return 14.00000. One trip "Paradise" -> "Cambridge", (14) / 1 = 14
        Assert.That(undergroundSystem.GetAverageTime("Leyton", "Waterloo"), Is.EqualTo(11));    // return 11.00000. Two trips "Leyton" -> "Waterloo", (10 + 12) / 2 = 11
        undergroundSystem.CheckIn(10, "Leyton", 24);
        Assert.That(undergroundSystem.GetAverageTime("Leyton", "Waterloo"), Is.EqualTo(11));    // return 11.00000
        undergroundSystem.CheckOut(10, "Waterloo", 38);  // Customer 10 "Leyton" -> "Waterloo" in 38-24 = 14
        Assert.That(undergroundSystem.GetAverageTime("Leyton", "Waterloo"), Is.EqualTo(12));    // return 12.00000. Three trips "Leyton" -> "Waterloo", (10 + 12 + 14) / 3 = 12
    }
}