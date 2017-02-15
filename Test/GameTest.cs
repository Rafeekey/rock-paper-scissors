using Xunit;
using System;
using System.Collections.Generic;
using RockPaperScissorsApp.Objects;

namespace GameTest
{
  public class GameTest : IDisposable
  {
    [Fact]
    public void IsGame_ShowingPlayerInput_Inputs()
    {
      int player1= 1;
      int player2 = 2;
      List<int> testList = new List<int>();
      testList.Add(player1);
      testList.Add(player2);

      Game newGame = new Game(player1, player2);
      List<int> result= Game.GetMoves();

      Assert.Equal(testList, result);
    }

    [Fact]
    public void IsGame_WhoWins_String()
    {
      int player1= 1;
      int player2 = 3;
      string output = "player 1 wins";

      Game newGame = new Game(player1, player2);
      newGame.PlayGame();
      string result = newGame.GetResult();


      Assert.Equal(output, result);
    }

    public void Dispose()
    {
      Game.DeleteAll();
    }
  }
}