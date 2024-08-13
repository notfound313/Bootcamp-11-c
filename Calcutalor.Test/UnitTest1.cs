namespace Calcutalor.Test;

public class CalculatorTest
{
	private Calculator _calculator;
	[SetUp]
	public void Setup()
	{
		_calculator = new Calculator();
	}

	[Test]
	public void Add_WhenCalled_ReturnSum()
	{
		//arrange
		int a = 1;
		int b = 2;
		int expected = 3;
		//act
		int actual = _calculator.Add(a, b);
		//assert
		Assert.That(actual, Is.EqualTo(expected));
	}
	[TestCase(1,2,3)]
	[TestCase(9,10,19)]
	public void Add_WhenCalledInt_ReturnSum(int a , int b, int expected)
	{
		//act
		int actual = _calculator.Add(a, b);
		//assert
		Assert.That(actual, Is.EqualTo(expected));
	}
	
	
	[TestCase(9.1f,10.2f,19.3f)]
	public void Add_WhenCalledFloat_ReturnSum(float a , float b, float expected)
	{
		//act
		float actual = _calculator.Add(a, b);
		//assert
		Assert.That(actual, Is.EqualTo(expected));
	}
	
	
	
}