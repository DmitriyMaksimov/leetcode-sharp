using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01418Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([
            ["David", "3", "Ceviche"], ["Corina", "10", "Beef Burrito"], ["David", "3", "Fried Chicken"],
            ["Carla", "5", "Water"], ["Carla", "5", "Ceviche"], ["Rous", "3", "Ceviche"]
        ]);
        
        Assert.That(displayTable[0], Is.EqualTo((string[]) ["Table", "Beef Burrito", "Ceviche", "Fried Chicken", "Water"]));
        Assert.That(displayTable[1], Is.EqualTo((string[]) ["3", "0", "2", "1", "0"]));
        Assert.That(displayTable[2], Is.EqualTo((string[]) ["5", "0", "1", "0", "1"]));
        Assert.That(displayTable[3], Is.EqualTo((string[]) ["10", "1", "0", "0", "0"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([
            ["James", "12", "Fried Chicken"], ["Ratesh", "12", "Fried Chicken"], ["Amadeus", "12", "Fried Chicken"],
            ["Adam", "1", "Canadian Waffles"], ["Brianna", "1", "Canadian Waffles"]
        ]);

        Assert.That(displayTable[0], Is.EqualTo((string[]) ["Table", "Canadian Waffles", "Fried Chicken"]));
        Assert.That(displayTable[1], Is.EqualTo((string[]) ["1", "2", "0"]));
        Assert.That(displayTable[2], Is.EqualTo((string[]) ["12", "0", "3"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([["Laura", "2", "Bean Burrito"], ["Jhon", "2", "Beef Burrito"], ["Melissa", "2", "Soda"]]);

        Assert.That(displayTable[0], Is.EqualTo((string[]) ["Table", "Bean Burrito", "Beef Burrito", "Soda"]));
        Assert.That(displayTable[1], Is.EqualTo((string[]) ["2", "1", "1", "1"]));
    }

    [Test]
    public void T4()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([["pKKgO","1","qgGxK"],["ZgW","3","XfuBe"]]);

        Assert.That(displayTable[0], Is.EqualTo((string[]) ["Table","XfuBe","qgGxK"]));
        Assert.That(displayTable[1], Is.EqualTo((string[]) ["1","0","1"]));
        Assert.That(displayTable[2], Is.EqualTo((string[]) ["3","1","0"]));
    }
}
