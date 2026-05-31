using myfirstapplication;
using Myfirstapplication;

//Console.WriteLine("Hello, World!");

// The below statement calls a local function
//single line comment


/*
 Multi-line comment
The below statement is a local function. Local functions
are inside of members and are private by default. This means
they are specific to that member and can only be called
inside that member.
 */

// Lesson Examples
//HouseExample();
// Lesson1Example()
//Lesson2Example();
//Lesson3Example();
Lesson6Exercise();

void Lesson6Exercise()
{
    Exercise6 myExercise6 = new Exercise6(9, "basketball");
    Exercise6.TryOn shoe = myExercise6.DisplayMessage;
    shoe($"I tried on {myExercise6.ShoeType} shoes that are size {myExercise6.ShowSize}");
}

//Lesson 3 Operattors and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    //  myLesson3.BasicCheckedOperator(14);
    //myLesson3.BasicCheckedExample2();
    //Lesson3.BasicUnckeckedExample();
    //myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    //myLesson3.BasicBooleanLogical(true, false);
    //myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    //myLesson3.MyIncrDecrExample();
    // Lesson4Example();
    // int alpha = 2147483647;
    // int total = alpha + 10;
    // Console.WriteLine(total);
    // 2147483639 9
}
// Lesson 4 Control flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    //myLesson4.BasicIfStatement(11);
    //myLesson4.BasicIfElseStatement(12);
    //myLesson4.BasicIfElseChainStatement(10);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(3);
    //myLesson4.BasicWhileStatement();
    //myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    //myLesson4.BasicJumpStatement();
}

// Lesson 5 eperesions & pattern matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();
    // call method of mylesson5
    // myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    // handler("Hello CSharp");

    // func delegate
    Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"func example = {add(23)}");

    // Lambda Expression
    //myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    // switch expression
    string value1 = myLesson5.BasicSwitch("red");
    //  Console.WriteLine(value1);
    string value2 = myLesson5.FavoriteColor("green");
    //Console.WriteLine(value2);

    // relational patern
    // myLesson5.DrinkSize(33);

    // logical paterns
    // myLesson5.TemperatureGuide(48.6);
    // myLesson5.NumberChoice(3);
}
//  Lesson6Examples();
//Lesson7Example();
Lesson8Example();
void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // calculate tempurature
    Console.WriteLine(Lesson8Static.CelciusToFahrenheight(45.6));

    // static methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times");

    // static Lambda
    myLesson8.CalculateHoursV2();
}
//Lesson9Example();
//Lesson10Example();
//HouseUpdated();
//Lesson11Example();
//Lesson12Example();
//CondoExample();
//Lesson13Example();
Lesson14Example();

void Lesson14Example()
{
    Lesson14 myLesson14 = new Lesson14();
    myLesson14.SingleIntArray();
    myLesson14.SingleHouseArray();
    myLesson14.MultiIntArray();
    myLesson14.MultiStringArray();
    myLesson14.JaggedArraySample();
}


void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();
    Console.WriteLine($"Converting feet to inches {total1}");
    Console.WriteLine($"Converting yard to feet {total2}");

    // these are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting Miles to Yards {total3}");

}




void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}

void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();

    Apple myApple = new Apple();
    myApple.EatFruit();
    myFruit.EatFruit(3);
}

void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine (total2);
}
void HouseUpdated()
{
    // calling default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // calling constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // calling constrictor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}
void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();
    // normal property
    myLesson10._FirstName = "Paul";
    Console.WriteLine(myLesson10._FirstName);

    // calling auto property
    //myLesson10.LastName = "Smith"; // only works in lesson10 constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // expression bodied property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // second constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.Zipcode);
}
void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // acess modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
}
void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // readonly struct
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.LastName);

    // struct record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);
}


void Lesson6Examples()
{
    // default constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLesson6.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");


    Console.WriteLine();

    // constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // method parameter modifiers
    int able = 33, beta = 22, charlie;

    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // multi-cast delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;
    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat("Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"my {myLessonHats.HatType} hat");




}




// lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.myStringLength();
    myLesson2.MyEqualsExample("hello world");
    Console.WriteLine(able);
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// This Local Function is for my first exercise lab.
void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day");
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}





