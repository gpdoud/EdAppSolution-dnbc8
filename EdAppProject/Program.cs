using System;

namespace EdAppProject {
    class Program {
        static void Main(string[] args) {

            var accounting = new Major(100, "Accounting", 1000);
            var business = new Major(200, "Business", 1000);
            var engineering = new Major(300, "Engineering", 1200);

            accounting.Print();
            business.Print();
            engineering.Print();

            var chris = new Student(1, "Chris", "List", 1250, 3.2, 100);
            var kim = new Student(2, "Kim", "Kessling", 1175, 3.4, 300);
            var tracy = new Student(3, "Tracy", "Tusky", 1350, 3.5, 200);

            chris.Print();
            kim.Print();
            tracy.Print();

        }
    }
}
