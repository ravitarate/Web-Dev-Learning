#include <iostream>

using namespace std;

int main() {
    char operation;
    double num1, num2;

    cout << "Welcome to the Simple Calculator!" << endl;
    cout << "Enter an operator (+, -, *, /): ";
    cin >> operation;

    cout << "Enter two numbers: ";
    cin >> num1 >> num2;

    switch (operation) {
        case '+':
            cout << num1 << " + " << num2 << " = " << num1 + num2 << endl;
            break;
        case '-':
            cout << num1 << " - " << num2 << " = " << num1 - num2 << endl;
            break;
        case '*':
            cout << num1 << " * " << num2 << " = " << num1 * num2 << endl;
            break;
        case '/':
            // Check if the user is trying to divide by zero
            if (num2 != 0) {
                cout << num1 << " / " << num2 << " = " << num1 / num2 << endl;
            } else {
                cout << "Error! Division by zero is not allowed." << endl;
            }
            break;
        default:
            // If the operator is other than +, -, * or /, error message is shown
            cout << "Error! Invalid operator used." << endl;
            break;
    }

    return 0;
}
