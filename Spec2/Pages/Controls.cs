namespace Spec2.Pages
{
    public  class Controls :BasePage
    {

        
        private static HomePage _homePage;
        private static DestinationsPage _destinationsPage;
        private static HolidayCollectionsPage _holidayCollectionsPage;
        private static BlogPage _blogPage;
        private static ContactUsPage _contactUsPage;

        public HomePage HomePage
        {
            get { return new HomePage(); }
        }

        public DestinationsPage DestinationsPage
        {
            get { return new DestinationsPage(); }
        }
        public HolidayCollectionsPage HolidayCollectionsPage
        {
            get { return new HolidayCollectionsPage(); }
        }

        public BlogPage BlogPage
        {
            get { return new BlogPage(); }
        }
        public ContactUsPage ContactUsPage
        {
            get { return new ContactUsPage(); }
        }

















    }
}
