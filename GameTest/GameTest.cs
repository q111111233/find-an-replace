using Xunit;

namespace FindAndReplace
{
  public class GameTests
  {
    [Fact]
    public void Replace_Rockpaper_Rock_scissors__scissorspaper()
    {
      Game g = new Game("Rock paper", "Rock", "scissors");
      Assert.Equal("scissors paper", g.Replace());
    }
    [Fact]
    public void Replace_Rockpaper_rock_scissors__scissorspaper()
    {
      Game g = new Game("Rock paper", "rock", "scissors");
      Assert.Equal("scissors paper", g.Replace());
    }
    [Fact]
    public void Replace_RockNoSpacepaper_rock_scissors__scissorspaper()
    {
      Game g = new Game("Rockpaper", "rock", "scissors");
      Assert.Equal("scissorspaper", g.Replace());
    }
    [Fact]
    public void ReplaceWholeWord_RockNoSpacepaper_rock_scissors__Rockpaper()
    {
      Game g = new Game("Rockpaper", "rock", "scissors");
      Assert.Equal("Rockpaper", g.ReplaceWholeWord());
    }
    [Fact]
    public void ReplaceWholeWord_Rockpaper_rock_scissors__scissorspaper()
    {
      Game g = new Game("Rock paper", "rock", "scissors");
      Assert.Equal("scissors paper", g.ReplaceWholeWord());
    }
    [Fact]
    public void ReplaceWholeWord_Rockpaperrock_rock_scissors__scissorspaperscissors()
    {
      Game g = new Game("Rock paper rock paper Rock", "rock", "scissors");
      Assert.Equal("scissors paper scissors paper scissors", g.ReplaceWholeWord());
    }
    [Fact]
    public void ReplaceWholeWord_nospaces_same()
    {
      Game g = new Game("RockpaperrockpaperRock", "rock", "scissors");
      Assert.Equal("RockpaperrockpaperRock", g.ReplaceWholeWord());
    }
  }
}
