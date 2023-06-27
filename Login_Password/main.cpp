#include <iostream>
#include <fstream>
#include <string>
#include <cstdio>
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

void DeleteAccount()
{
    string username, password, un, pw;
    cout << "Enter username: " << endl;
    cin >> username;
    cout << "Enter password: " << endl;
    cin >> password;
    ifstream read("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + username + ".txt");
    getline(read, un);
    getline(read, pw);
    read.close();
    if (un == username && pw == password)
    {
        string path = "d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + username + ".txt";
        remove(path.c_str());
        cout << path << endl;
        cout << "This account has been successfully deleted" << endl;
    }
    else
        cout << "You wrote something wrong" << endl;
}

void PasswordChange()
{
    cout << "To confirm changes enter your data again" << endl;
    string username, oldpassword, newpassword, un, pw;
    cout << "Confirm username" << endl;
    cin >> username;
    cout << "Confirm password" << endl;
    cin >> oldpassword;
    ifstream read("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + username + ".txt");
    getline(read, un);
    getline(read, pw);
    read.close();
    if (un == username && pw == oldpassword)
    {
        cout << "Enter your new password" << endl;
        cin >> newpassword;
        ofstream file;
        file.open("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + username + ".txt");
        file.clear();
        file << username << endl;
        file << newpassword << endl;
        file.close();
        cout << "New password set" << endl;
    }
    else
        cout << "Something went wrong" << endl;
}

void UsernameChange()
{
    cout << "To confirm changes enter your data again" << endl;
    string oldusername, newusername, password, un, pw;
    cout << "Confirm username" << endl;
    cin >> oldusername;
    cout << "Confirm password" << endl;
    cin >> password;
    ifstream read("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + oldusername + ".txt");
    getline(read, un);
    getline(read, pw);
    read.close();
    if (un == oldusername && pw == password)
    {
        cout << "Enter your new password" << endl;
        cin >> newusername;
        string path = "d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + oldusername + ".txt";
        remove(path.c_str());
        ofstream file;
        file.open("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + newusername + ".txt");
        file << newusername << endl;
        file << password << endl;
        cout << "New username set" << endl;
    }
    else
        cout << "Something went wrong" << endl;
}

void ChangAll()
{
    cout << "To confirm changes enter your data again" << endl;
    string oldusername, newusername, oldpassword, newpassword, un, pw;
    cout << "Confirm username" << endl;
    cin >> oldusername;
    cout << "Confirm password" << endl;
    cin >> oldpassword;
    ifstream read("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + oldusername + ".txt");
    getline(read, un);
    getline(read, pw);
    read.close();
    if (un == oldusername && pw == oldpassword)
    {
        cout << "Enter your new username" << endl;
        cin >> newusername;
        cout << "Enter your new password" << endl;
        cin >> newpassword;
        string path = "d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + oldusername + ".txt";
        remove(path.c_str());
        ofstream file;
        file.open("d:\\Coding\\C++\\Login_Password\\AllUsers\\User_" + newusername + ".txt");
        file << newusername << endl;
        file << newpassword << endl;
        cout << "Data changed" << endl;
    }
    else
    {
        cout << "Something went wrong" << endl;
    }
}

int main()
{
    int choise;
    bool loggedin;
    string username, password;
    cout << "Enter 1 to register" << endl;
    cout << "Enter 2 to login" << endl;
    cout << "Enter 3 to delete account" << endl;
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
        }
        else
        {
            cout << "You successfully logged in" << endl;
            loggedin = true;
        }
    }
    else if (choise == 3)
        DeleteAccount();
    if (loggedin == true)
    {
        printf("Enter 1 to change your password\n");
        printf("Enter 2 to change your username\n");
        printf("Enter 3 to change your username and password\n");
        cin >> choise;
        if (choise == 1)
        {
            PasswordChange();
        }
        else if (choise == 2)
        {
            UsernameChange();
        }
        else if (choise == 3)
        {
            ChangAll();
        }
    }
    return 1;
}
