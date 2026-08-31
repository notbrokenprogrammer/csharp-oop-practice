class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int DepartmentId { get; set; }
    public decimal Salary { get; set; }
}

class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public decimal Budget { get; set; }
}

class EmployeeProject
{
    public int EmployeeId { get; set; }
    public int ProjectId { get; set; }
}