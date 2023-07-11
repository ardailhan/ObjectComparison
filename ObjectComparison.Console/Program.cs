


//Comparison - Sorting


string a = "arda";
string b = "ilhan";

var result = string.Compare(a, b);

// result == 1 -> a is greater than b
// result == -1 -> b is greater than a
// result == 0 -> a and b are equal

var names = new List<Employee>();

names.Add(new Employee(1, "Arda"));
names.Add(new Employee(4, "Rustu"));
names.Add(new Employee(2, "Hazar"));
names.Add(new Employee(3, "Ege"));
names.Add(new Employee(5, "Hakan"));
names.Add(new Employee(6, "İlhan"));


//names.Sort(new NameBaseComparer());
names.Sort(new IdBaseComparer());


//***Linq ile sıralama***
//names.OrderBy(x => x.Id);
//Print(names.OrderBy(x => x.Id));

Print(names);

Console.ReadLine();


void Print(IEnumerable<Employee> names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}


class NameBaseComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x.FullName.CompareTo(y.FullName);
    }
}

class IdBaseComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x.Id.CompareTo(y.Id);
    }
}


class BaseEmployee
{
    public int Id { get; set; }
    public string FullName { get; set; }

}

class Accountant : BaseEmployee
{

}

class Employee : BaseEmployee
{
    

    public Employee(int ıd, string fullName)
    {
        Id = ıd;
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
    }

    public override string ToString()
    {
        return $"{Id} - {FullName}";
    }

    
}