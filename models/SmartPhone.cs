namespace ExerciseOne.Models {
    public class SmartPhone : MobilePhone {
        private string browser;
        private List<App> applications;

        public List<App> Applications {
            get {
                return this.applications;
            }
        }

        public SmartPhone (string brand, string color, string model, SimCard simCard, string browser) 
            : base(brand, color, model, simCard) 
        {
            this.browser = browser;
            applications = new List<App>();
        }

        public void CallFromBrowser(string phoneNumber) {
            Console.WriteLine($"Calling from {this.browser}");
            base.Call(phoneNumber);
        }

        public void CallFromBrowser(MobilePhone mobilePhone) {
            Console.WriteLine($"Calling from {this.browser}");
            base.Call(mobilePhone);
        }

        public void AddApplication(App app) {
            applications.Add(app);
        }

        public int GetTotalSize() {
            return applications.Count;
        }
    }
}