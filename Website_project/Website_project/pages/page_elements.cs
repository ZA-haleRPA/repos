using Microsoft.Playwright;

namespace WebAutomation_Project.pages
{
    public class elements_page
    {
    private IPage _page;
    public elements_page(IPage page) => _page = page;
    public ILocator header_table => _page.Locator("tr[class='smart-table-header-row']");
    public ILocator search_input => _page.GetByPlaceholder("Search");
    public ILocator add_button => _page.Locator("button[type='add']");
    public ILocator delete_icon => _page.Locator("button[ng-click='delUser()']");
    public ILocator firstname_input => _page.Locator("input[name=\"FirstName\"]");
    public ILocator lastname_input => _page.Locator("input[name=\"LastName\"]");
    public ILocator username_input => _page.Locator("input[name=\"UserName\"]");
    public ILocator password_input => _page.Locator("input[name=\"Password\"]");
    public ILocator company_aaa_radio => _page.GetByLabel("Company AAA");
    public ILocator company_bbb_radio => _page.GetByLabel("Company BBB");
    public ILocator duty_dropdown => _page.GetByRole(AriaRole.Combobox);
    public ILocator email_input => _page.Locator("input[name=\"Email\"]");
    public ILocator cell_input => _page.Locator("input[name=\"Mobilephone\"]");
    public ILocator save_button => _page.GetByRole(AriaRole.Button, new() { Name = "Save" });
    public ILocator delete_confirmation_modal => _page.GetByRole(AriaRole.Heading, new() { Name = "Confirmation Dialog" });
    public ILocator delete_confirmation_ok => _page.GetByRole(AriaRole.Button, new () { Name = "OK" });

    }
}
