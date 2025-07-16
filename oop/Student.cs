public class Student {
    private string name;
    private int age;
    private string studentId;

    public Student(string name, int age, string studentId) {
        this.name = name;
        this.age = age;
        this.studentId = studentId;
    }

    public string GetName() {
        return name;
    }

    public int GetAge() {
        return age;
    }

    public string GetStudentId() {
        return studentId;
    }

    public void SetName(string name) {
        this.name = name;
    }

    public void SetAge(int age) {
        this.age = age;
    }

    public void SetStudentId(string studentId) {
        this.studentId = studentId;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Name: {name}, Age: {age}, Student ID: {studentId}");
    }
}