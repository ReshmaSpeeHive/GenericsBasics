// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
Salaries salaries = new Salaries();
//ArrayList salaryList = salaries.GetSalaries();
List<float> salaryList = salaries.GetSalaries();
float salary = (float)salaryList[1];
salary = salary + (salary * 0.02f);
Console.WriteLine(salary);
Console.ReadKey();
public class Salaries
{

    //ArrayList _salaryList = new ArrayList();
    List<float> _salaryList = new List<float>();
    public Salaries()
    {
        _salaryList.Add(6000.34f);
        _salaryList.Add(56000.34f);
        _salaryList.Add(6550.34f);
        _salaryList.Add(3400.34f);
        _salaryList.Add(3000.34f);

    }
    public List<float> GetSalaries()
    {
        return _salaryList;
    }

}