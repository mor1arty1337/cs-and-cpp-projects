#include <iostream>
#include <fstream>
#include <string>
using namespace std;

bool IsRegistered()
{
    string username, password, un, pw;
    cout << "Enter username: " << endl;
    cin >> username;
    cout << "Enter password: " << endl;
    cin >> password;
    ifstream read("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + username + ".txt");
    getline(read, un);
    getline(read, pw);
    if (un == username && pw == password)
        return true;
    else
        return false;
}

int main()
{
    int choise;
    string username, password;
    cout << "Enter 1 to register" << endl;
    cout << "Enter 2 to login" << endl;
    cout << "Your choise:";
    cin >> choise;
    if (choise == 1)
    {
        cout << "Create username:" << endl;
        cin >> username;
        cout << "Create password:" << endl;
        cin >> password;
        ofstream file;
        file.open("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + username + ".txt");
        file << username << endl;
        file << password << endl;
        file.close();
        cout << "You successfully registered" << endl;
    }
    else if (choise == 2)
    {
        bool status = IsRegistered();
        if (status == false)
        {
            cout << "False login" << endl;
            system("PAUSE");
            return 0;
        }
        else
        {
            cout << "You successfully logged in" << endl;
            system("PAUSE");
            return 1;
        }
    }
}
