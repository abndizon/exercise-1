namespace ExerciseOne.Models {
    public class SimCard {
        private string phoneNumber;
        private string network;

        public string PhoneNumber {
            get {
                return this.phoneNumber;
            }
        }

        public SimCard(string phoneNumber, string network) {
            this.phoneNumber = phoneNumber;
            this.network = network;
        }

    }
}