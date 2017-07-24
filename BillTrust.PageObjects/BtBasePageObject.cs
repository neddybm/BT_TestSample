using OpenQA.Selenium;
using Golem.WebDriver;

namespace BillTrust.PageObjects
{
    public class BtBasePageObject : BasePageObject
    { 
        // ---top header elements--- //
        private readonly Element _logo = new Element(By.CssSelector(".q_logo>a"));
        private readonly Element _homeLink = new Element(By.XPath("//ul[@class='menu']/li/a[text()='Home']"));
        private readonly Element _careersLink = new Element(By.XPath("//ul[@class='menu']/li/a[text()='Careers']"));
        private readonly Element _aboutUsDD = new Element(By.XPath("//a[contains(.,'About Us ')]"));
        private readonly Element _ourValuesSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Our Values')]"));
        private readonly Element _awardsAndHistorySubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Awards & History')]"));
        private readonly Element _leadershipSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Leadership')]"));
        private readonly Element _boardSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Board of Directors')]"));
        private readonly Element _partnersSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Partners')]"));
        private readonly Element _industriesSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Industries')]"));
        private readonly Element _blogLink = new Element(By.XPath("//ul[@class='menu']/li/a[text()='Blog']"));
        private readonly Element _clientCenterDD = new Element(By.XPath("//a[contains(.,'Client Center ')]"));
        private readonly Element _eInvoiceConnectSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'eInvoice Connect')]"));
        private readonly Element _clientConnectSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Client Connect')]"));
        private readonly Element _invoiceSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Invoice Central')]"));
        private readonly Element _cashAppSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Cash App')]"));
        private readonly Element _knowledgeBaseSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Knowledge Base')]"));
        private readonly Element _trainingSubMenu = new Element(By.XPath("//ul[@class='sub-menu']/li/a[contains(.,'Training')]"));
        private readonly Element _indeedLink = new Element(By.XPath("//div[@class='inner']//a[@href='http://www.linkedin.com/company/99112']")); 
        private readonly Element _twitterLink = new Element(By.XPath("//div[@class='inner']//a[@href='https://twitter.com/Billtrust']"));
        private readonly Element _facebookLink = new Element(By.XPath("//div[@class='inner']//a[@href='https://www.facebook.com/Billtrust-190766524352470']"));
        // ---uber menu elements--- //
        private readonly Element _solutionsLink = new Element(By.XPath("//ul[@id='ubermenu-nav-main-2-top-navigation']/li[1]/a"));
        private readonly Element _iWantToLink = new Element(By.XPath("//ul[@id='ubermenu-nav-main-2-top-navigation']/li[2]/a"));
        private readonly Element _insightsLink = new Element(By.XPath("//ul[@id='ubermenu-nav-main-2-top-navigation']/li[3]/a"));
        private readonly Element _newsEventsLink = new Element(By.XPath("//ul[@id='ubermenu-nav-main-2-top-navigation']/li[4]/a"));
        private readonly Element _clientsHeartUsLink = new Element(By.XPath("//ul[@id='ubermenu-nav-main-2-top-navigation']/li[5]/a"));
        // ---search elements---//
        private readonly Element _magnifyingGlassLink = new Element(By.CssSelector(".search_button.search_covers_header.normal"));
        private readonly Element _searchFld = new Element(By.Name("s"));

        public override void WaitForElements()
        {
            _logo.Verify().Visible();
            _homeLink.Verify().Visible();
            _careersLink.Verify().Visible();
            _aboutUsDD.Verify().Visible();
            _aboutUsDD.MouseOver();
            _ourValuesSubMenu.Verify().Visible();
            _awardsAndHistorySubMenu.Verify().Visible();
            _leadershipSubMenu.Verify().Visible();
            _boardSubMenu.Verify().Visible();
            _partnersSubMenu.Verify().Visible();
            _industriesSubMenu.Verify().Visible();
            _blogLink.Verify().Visible();
            _clientCenterDD.Verify().Visible();
            _clientCenterDD.MouseOver();
            _eInvoiceConnectSubMenu.Verify().Visible();
            _clientConnectSubMenu.Verify().Visible();
            _invoiceSubMenu.Verify().Visible();
            _cashAppSubMenu.Verify().Visible();
            _knowledgeBaseSubMenu.Verify().Visible();
            _trainingSubMenu.Verify().Visible();
            _indeedLink.Verify().Visible();
            _twitterLink.Verify().Visible();
            _facebookLink.Verify().Visible();
            _solutionsLink.Verify().Visible();
            _iWantToLink.Verify().Visible();
            _insightsLink.Verify().Visible();
            _newsEventsLink.Verify().Visible();
            _clientsHeartUsLink.Verify().Visible();
            _magnifyingGlassLink.Verify().Visible();
            _magnifyingGlassLink.MouseOver();
            _searchFld.Verify().Visible();
        }
    }
}
