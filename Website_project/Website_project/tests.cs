using Microsoft.Playwright;
using Xunit;
using WebAutomation_Project.Functions;

namespace PlaywrightTests;

public class Playwright_Tests
{
    [Fact]
    public async Task AddAdminUser()
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var page = await browser.NewPageAsync();

        var func = new WebAutomation_Project_Functions(page);

        await func.NavigateToURL();
        await func.VerifyHomePageElements();

        await func.ClickAddUser();
        await func.SetNames("FName1","LName1");
        await func.SetLoginDetails("User1", "Pass1");
        await func.SetCompanyAAA();
        await func.SetRole("2");
        await func.SetContactDetails("admin@mail.com","082555");
        await func.ClickSaveButton();
        await func.SearchInput("User1");
        await func.DeleteUser();
        await func.SearchInput("User1");
        await func.VerifyNoMatchingUserFound();
        await func.CloseBrowser();
    }

    [Fact]
    public async Task AddCustomerUser()
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var page = await browser.NewPageAsync();

        var func = new WebAutomation_Project_Functions(page);

        await func.NavigateToURL();
        await func.VerifyHomePageElements();

        await func.ClickAddUser();
        await func.SetNames("FName2", "LName2");
        await func.SetLoginDetails("User2", "Pass2");
        await func.SetCompanyBBB();
        await func.SetRole("1");
        await func.SetContactDetails("cusomter@mail.com", "0824444");
        await func.ClickSaveButton();
        await func.SearchInput("User2");
        await func.DeleteUser();
        await func.SearchInput("User2");
        await func.VerifyNoMatchingUserFound();
        await func.CloseBrowser();
    }
}