namespace ExerciseOne.Models {
    public class App {
        private string name;
        private float size;

        public float Size {
            get {
                return this.size;
            }
        }

        public string Name {
            get {
                return this.name;
            }
        }

        public App (string name, float size) {
            this.name = name;
            this.size = size;
        }
    }
}