namespace ExerciseOne.Models {
    public class MobilePhone {
        private string brand;
        private string color;
        private string model;
        private SimCard simCard;

        public MobilePhone(string brand, string color, string model, SimCard simCard) {
            this.brand = brand;
            this.color = color;
            this.model = model;
            this.simCard = simCard;
        }

        public string GetPhoneNumber() {
            return simCard.PhoneNumber;
        }

        public void SwapSimCard(SimCard simCard) {
            this.simCard = simCard;
        }

        public void Call(string phoneNumber) {
            Console.WriteLine($"Calling {phoneNumber} from number {GetPhoneNumber()}.");
        }

        public void Call(MobilePhone mobilePhone) {
            Console.WriteLine($"Calling {mobilePhone.GetPhoneNumber()} from number {GetPhoneNumber()}.");
        }
    }
}