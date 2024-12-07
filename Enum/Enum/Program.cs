//Question 1
enum NgayTrongTuan
{
    ThứHai,
    ThứBa,
    ThứTư,
    ThứNăm,
    ThứSáu,
    ThứBảy,
    ChủNhật,
}

//Question 2
enum EnemyState
{
    Idle,
    Patrol,
    Attack,
}

//Question 3
enum FlightStatus
{
    Ascending, 
    Descending,
    Stationary,
}
//Question 4
enum TitleRank
{
    Beginner,
    Intermidiate,
    Advanced,
}

//Question 5
enum PlayerMovent
{
    Idle,
    Walk,
    Run,
}
//Question 6
enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}
class Program
{
    static void Main()
    {
        Console.WriteLine(NgayTrongTuan.ThứTư);
        Console.WriteLine(DayOfWeek.Monday);


    }
}