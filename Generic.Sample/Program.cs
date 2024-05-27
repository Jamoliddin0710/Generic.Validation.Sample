using Generic.Sample;
using Library.TimeExtensions;
using ValidatorLibrary;

var date = DateTime.Now;

var payment = new Payment()
{
    Id = 1,
    RecievedDateTime = date.LastDayOfMonth(),
};

/*var error = ValidationHelper.ValidateEntity(payment);

foreach (var item in error.Errors)
{
    Console.WriteLine(item.ErrorMessage);
}*/
var student = new Student()
{
    Id = 1,
    FullName = "Test",
    GPA = 10,
    MarriedStatus = "sbduibuisd"
};

var error = ValidationHelper.ValidateEntity(student);

foreach (var item in error.Errors)
{
    Console.WriteLine(item.ErrorMessage);
}