using ChallengeApp;

var employee = new Employee("Franek", "Dzbanek", 45);

employee.AddGrade(9.33);
employee.AddGrade("55");
employee.AddGrade(3);
employee.AddGrade(6);

var statistics1 = employee.GetStatisticsUsingForeach();
var statistics2 = employee.GetStatisticsUsingFor();
var statistics3 = employee.GetStatisticsUsingDoWhile();
var statistics4 = employee.GetStatisticsUsingWhile();

