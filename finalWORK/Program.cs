using System;
using static System.Console;
Clear();

string[] array = EnteredArray();
string[] result = FindLessFour(array, 4);



string[] EnteredArray() {
    Write("Введите строки через пробел: ");
    return ReadLine().Split(" ");
}
string[] FindLessFour(string[] input, int n) {
    string[] output = new string[CountLessFour(input, n)];

    for(int i = 0, a = 0; i < input.Length; i++) {
        if(input[i].Length = n) {
            output[a] = input[i];
            a++;
        }
    }

    return output;
}
