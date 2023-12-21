job x = new job("Гунствин А.В.", "Директор", 2005, 56500);
job y = new job("Пипичан А.С.", "Нач.отдела", 20010, 50000);
job z = new job("Бозорова М.А.", "Зам.нач", 2016, 35500);
job[] mass = new job[] { x, y, z };
for (int i = 0; i < 3; i++)
{
    if (mass[i].salary > 40000)
    {
        Console.WriteLine(mass[i].FIO);
    }
}
for (int i = 0; i < 3; i++)
{
    if (mass[i].job_title == "Директор")
    {
        Console.WriteLine(mass[i].FIO);
    }
}
class job
{
    public string FIO;
    public string job_title;
    public int age;
    public int salary;
    public job(string fIO, string job_title, int age, int salary)
    {
        FIO = fIO;
        this.job_title = job_title;
        this.age = age;
        this.salary = salary;
    }
}