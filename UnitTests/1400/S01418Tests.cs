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
        
        displayTable[0].Should().Equal(["Table", "Beef Burrito", "Ceviche", "Fried Chicken", "Water"]);
        displayTable[1].Should().Equal(["3", "0", "2", "1", "0"]);
        displayTable[2].Should().Equal(["5", "0", "1", "0", "1"]);
        displayTable[3].Should().Equal(["10", "1", "0", "0", "0"]);
    }

    [Test]
    public void T2()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([
            ["James", "12", "Fried Chicken"], ["Ratesh", "12", "Fried Chicken"], ["Amadeus", "12", "Fried Chicken"],
            ["Adam", "1", "Canadian Waffles"], ["Brianna", "1", "Canadian Waffles"]
        ]);

        displayTable[0].Should().Equal(["Table", "Canadian Waffles", "Fried Chicken"]);
        displayTable[1].Should().Equal(["1", "2", "0"]);
        displayTable[2].Should().Equal(["12", "0", "3"]);
    }

    [Test]
    public void T3()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([["Laura", "2", "Bean Burrito"], ["Jhon", "2", "Beef Burrito"], ["Melissa", "2", "Soda"]]);

        displayTable[0].Should().Equal(["Table", "Bean Burrito", "Beef Burrito", "Soda"]);
        displayTable[1].Should().Equal(["2", "1", "1", "1"]);
    }

    [Test]
    public void T4()
    {
        var sut = new S01418();
        var displayTable = sut.DisplayTable([["pKKgO","1","qgGxK"],["ZgW","3","XfuBe"]]);

        displayTable[0].Should().Equal(["Table","XfuBe","qgGxK"]);
        displayTable[1].Should().Equal(["1","0","1"]);
        displayTable[2].Should().Equal(["3","1","0"]);
    }
}