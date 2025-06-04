
using System.Runtime.InteropServices;

OperatorExamples();

void OperatorExamples()
{
    // this statement declares a variable and sets it to 3
    int width = 3;

    // the ++ operator increments a variable  (adds 1 to it)
    width++;

    // Delcare two more int variables to hold numbers and
    // use the + and * operators to add and multiply values
    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);

    while (area < 50)
    {
        height++;
        area = width * height;
    }
    do
    {
        width--;
        area = width * height;
    } while (area > 25);

    // the next two statements declare starting variables
    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result);

    // a boolean variable is either true or false
    bool truthValue = true;
    Console.WriteLine(truthValue);
}