namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTests
{
    /*
    [SetUp]
    public void Setup()
    {
    }
    */

    [Test]
    public void AddTest()
    {
        //arrange

        Basket basket = new Basket();
        bool expected = true;

        //act
        bool result = basket.Add("Ham and cheese bagel");

        //assert
        Assert.That(expected == result);
    }
}