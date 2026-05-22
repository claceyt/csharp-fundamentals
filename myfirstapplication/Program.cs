using Myfirstapplication;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
Lesson3Example();



//Lesson 3 Operattors and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    //myLesson3.BasicCheckedExample2();
    //Lesson3.BasicUnckeckedExample();
    //myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    //myLesson3.BasicBooleanLogical(true, false);
    //myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    //myLesson3.MyIncrDecrExample();
    Lesson4Example();
   // int alpha = 2147483647;
   // int total = alpha + 10;
   // Console.WriteLine(total);
// 2147483639 9
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


        // Lesson 5 eperesions & pattern matching
        void Lesson5Example()
        {
            Lesson5 myLesson5 = new Lesson5();          
                // call method of mylesson5
               // myLesson5.IsOperatorExample(34);

            Lesson5Example.Del handler = myLesson5.DelegateMethod;
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
          string value2 =  myLesson5.FavoriteColor("green");
            //Console.WriteLine(value2);

            // relational patern
            // myLesson5.DrinkSize(33);

            // logical paterns
            myLesson5.TemperatureGuide(48.6);
            myLesson5.NumberChoice(3);
        }
    }
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





