using Moq;

namespace SimpleGame.Test;

public class SimpleGameTest 
{
	private GameController _gameController;
	private  Mock<IPlayer> _player1;
	private  Mock<IPlayer> _player2;
	
	
	[SetUp]
	public void Setup()
	{
		_player1 = new();
		_player1.Setup(p => p.GetName()).Returns("Player1");
		_player2 = new();
		_player2.Setup(p => p.GetName()).Returns("Player2");
		_gameController = new GameController(_player1.Object, _player2.Object);
	}
	
	[Test]
	public void TotalPlayer_WhenCalled_Return2()
	{
		//act
		int actual = _gameController.TotalPlayer();
		//assert
		Assert.That(actual, Is.EqualTo(2));
	}
	[Test]
	public void AddPlayer_WhenCalled_ReturnTrue()
	{
		//arrange
		Mock<IPlayer> player3 = new();
		player3.Setup(p => p.GetName()).Returns("Player3");
		int expected = 3;
		//act
		bool actual = _gameController.AddPlayer(player3.Object);
		//assert
		Assert.That(actual, Is.EqualTo(true));
		Assert.That(_gameController.TotalPlayer(), Is.EqualTo(expected));
	}
	[Test]
	public void AddPlayer_WhenCalled_ReturnFalse()
	{
		//act
		bool actual = _gameController.AddPlayer(_player1.Object);
		
		//assert
		Assert.That(actual, Is.EqualTo(false));
	}
	[Test]
	public void Remove_WhenCalled_ReturnTrue()
	{
		//act
		bool actual = _gameController.Remove(_player1.Object);
		int expected = 1;
		//assert
		Assert.That(actual, Is.EqualTo(true));
		Assert.That(_gameController.TotalPlayer(), Is.EqualTo(expected));
	}
	[Test]
	public void Remove_WhenCalled_ReturnFalse()
	{
		//act
		bool actual = _gameController.Remove(_player1.Object);		
		actual = _gameController.Remove(_player1.Object);		
		//assert
		Assert.That(actual, Is.EqualTo(false));
	}
	[Test]
	public void CheckPlayersName_WhenCalled_ReturnPlayer1()
	{
		//act
		string actual = _gameController.CheckPlayersName(0);
		//assert
		Assert.That(actual, Is.EqualTo("Player1"));
	}
	
	
}