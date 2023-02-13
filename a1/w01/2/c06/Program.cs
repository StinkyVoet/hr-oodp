var grades = new List<double> { 7, 5.5, 3.2, 10, 4.5 };

var passCount = grades.Count(grade => grade >= 5.5);

Console.WriteLine($"{passCount} out of {grades.Count} students passed");