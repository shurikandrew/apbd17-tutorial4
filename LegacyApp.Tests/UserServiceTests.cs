namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnFalseWhenFirstNameIsEmpty()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            null,
            "Smith",
            "smith@gmail.pl",
            DateTime.Parse("2000-01-01"),
            3
            );
        //Assert
        Assert.False(result);
    }
    
    [Fact]
    public void AddUser_ThrowsExceptionWhenClientDoesNotExist()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        Action action = () => userService.AddUser(
            "John",
            "Smith",
            "smith@gmail.pl",
            DateTime.Parse("2000-01-01"),
            100
        );
        //Assert
        Assert.Throws<ArgumentException>(action);
    }

    [Fact]
    public void AddUser_ReturnsFalseWhenMissingAtSignAndDotInEmail()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "John",
            "Smith",
            "smithgmailpl",
            DateTime.Parse("2000-01-01"),
            3
        );
        //Assert
        Assert.False(result);
    }
    [Fact]
    public void AddUser_ReturnsFalseWhenYoungerThen21YearsOld()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "John",
            "Smith",
            "smith@gmail.pl",
            DateTime.Parse("2020-01-01"),
            3
        );
        //Assert
        Assert.False(result);
    }

    [Fact]
    public void AddUser_ReturnsTrueWhenVeryImportantClient()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "John",
            "Malewski",
            "malewski@gmail.pl",
            DateTime.Parse("2000-01-01"),
            2
        );
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void AddUser_ReturnsTrueWhenImportantClient()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "John",
            "Smith",
            "smith@gmail.pl",
            DateTime.Parse("2000-01-01"),
            3
        );
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AddUser_ReturnsTrueWhenNormalClient()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "John",
            "Kwiatkowski",
            "kwiatkowski@wp.pl",
            DateTime.Parse("2000-01-01"),
            5
        );
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        var result = userService.AddUser(
            "John",
            "Kowalski",
            "kowalski@wp.pl",
            DateTime.Parse("2000-01-01"),
            1
        );
        //Assert
        Assert.False(result);
    }

    [Fact]
    public void AddUser_ThrowsExceptionWhenUserDoesNotExist()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        Action action = () => userService.AddUser(
            "John",
            "Someone",
            "smith@gmail.pl",
            DateTime.Parse("2000-01-01"),
            3
        );
        //Assert
        Assert.Throws<ArgumentException>(action);
    }
    
    [Fact]
    public void AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser()
    {
        //Arrange
        var userService = new UserService();
        
        //Act
        Action action = () => userService.AddUser(
            "John",
            "Andrzejewicz",
            "andrzejewicz@wp.pl",
            DateTime.Parse("2000-01-01"),
            6
        );
        //Assert
        Assert.Throws<ArgumentException>(action);
    }
}