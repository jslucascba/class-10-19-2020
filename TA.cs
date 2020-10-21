namespace class10_19_2020
{
    public class TA
    {
        private string name;
        private int year;
        private static int count;
        
        public TA() {

        }
        public TA(string name, int year) {
            this.name = name;
            this.year = year;
        }
        public void SetName(string value) {
            name = value;
        }

        public string GetName() {
            return name;
        }

        public void SetYear(int value) {
            year = value;
        }

        public int GetYear() {
            return year;
        }

        public static int GetCount() {
            return count;
        }

        public static void SetCount(int value) {
            count = value;
        }

        public static void IncCount() {
            count++;
        }

        public override string ToString() {
            return name + " " + year;
        }
    }
}