using Microsoft.Playwright;
using Xunit;

namespace WebAutomation_Project.Functions;

public class WebAutomation_Project_Functions
{
    private IPage _page;
    public WebAutomation_Project_Functions(IPage page) => _page = page;


    public async Task<IPage> NavigateToURL()
    {
        await _page.GotoAsync("http://www.way2automation.com/angularjs-protractor/webtables/");
        Assert.Equal("Protractor practice website - WebTables", await _page.TitleAsync());

        return _page;
    }


    public async Task<IPage>VerifyHomePageElements()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);
        
        await page_Elements.header_table.IsVisibleAsync();
        await page_Elements.search_input.IsVisibleAsync();   
        await page_Elements.add_button.IsVisibleAsync();

        return _page; 
    }

    public async Task<IPage> ClickAddUser()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.add_button.IsVisibleAsync();
        await page_Elements.add_button.ClickAsync();
        await page_Elements.firstname_input.IsVisibleAsync();

        return _page;
    }

    public async Task<IPage> SetNames(string firstname, string lastname)
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.firstname_input.IsVisibleAsync();
        await page_Elements.firstname_input.FillAsync(firstname);
        await page_Elements.lastname_input.FillAsync(lastname);

        return _page;
    }

    public async Task<IPage> SetLoginDetails(string username, string password)
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.username_input.IsVisibleAsync();
        await page_Elements.username_input.FillAsync(username);
        await page_Elements.password_input.FillAsync(password);

        return _page;
    }

    public async Task<IPage> SetCompanyAAA()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.company_aaa_radio.IsVisibleAsync();
        await page_Elements.company_aaa_radio.ClickAsync();

        return _page;
    }

    public async Task<IPage> SetCompanyBBB()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.company_bbb_radio.IsVisibleAsync();
        await page_Elements.company_bbb_radio.ClickAsync();

        return _page;
    }


    public async Task<IPage> SetRole(string value)
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.duty_dropdown.IsVisibleAsync();
        await page_Elements.duty_dropdown.SelectOptionAsync(new[] { value });

        return _page;
    }

    public async Task<IPage> SetContactDetails(string email, string cell)
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.email_input.IsVisibleAsync();
        await page_Elements.email_input.FillAsync(email);
        await page_Elements.cell_input.FillAsync(cell);

        return _page;
    }

    public async Task<IPage> ClickSaveButton()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.save_button.IsVisibleAsync();
        await page_Elements.save_button.ClickAsync();

        return _page;
    }

    public async Task<IPage> SearchInput(string value)
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.search_input.ClickAsync();
        await page_Elements.search_input.FillAsync(value);

        return _page;
    }

    public async Task<IPage> VerifyNoMatchingUserFound()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        await page_Elements.search_input.IsVisibleAsync();
        await page_Elements.delete_icon.IsHiddenAsync();

        return _page;
    }

    public async Task<IPage> DeleteUser()
    {
        var page_Elements = new WebAutomation_Project.pages.elements_page(_page);

        if (await page_Elements.delete_icon.IsVisibleAsync())
        {
            await page_Elements.delete_icon.ClickAsync();
            await page_Elements.delete_confirmation_modal.IsVisibleAsync();
            await page_Elements.delete_confirmation_ok.ClickAsync();

        }
        else
        {
            Console.WriteLine("User does not exist");

        }

        return _page;
    }

    public async Task<IPage> CloseBrowser()
    {
        await _page.CloseAsync();

        return _page;
    }
}


