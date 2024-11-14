

using Assignment4;

string filePath = "Data.txt";

string[] lines = File.ReadAllLines(filePath);


using TrainingDbContext trainingDbContext = new TrainingDbContext();



   foreach (string line in lines)
   {

    string[] parts = line.Split(' ');
     

    string name = parts[0];
    int age = int.Parse(parts[1]);
    double cgpa = double.Parse(parts[2]);

    Student student = new Student();
    student.Name = name;
    student.Age = age;
    student.CGPA = cgpa;

    trainingDbContext.Students.Add(student);

   }

trainingDbContext.SaveChanges();



