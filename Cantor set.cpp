/*Канторово множество*/
#include <iostream>
using namespace std;

// create a void function to calculate whether this point is in
void CantorSet(float a, float b, int n)
{
    long float dot = a / b;
    long double edge1, edge2;
    edge1 = 0.33333333333333333f; // edge1 = 1/3
    edge2 = 0.66666666666666666f; // edge2 = 2/3
    float num = 9;
    int count = 1;

    if (dot < 0 || dot > 1)
    { // if a/b is out of Cantor set
        cout << "Dot with coordinates " << a << "/" << b << " is OUT of the Cantor's set!" << endl;
    }
    else
    { // if a/b is in Cantor set
        if (dot == 0 || dot == 1 || dot == edge1 || dot == edge2)
        { // if a/b is on any EDGE
            cout << "Dot with coordinates " << a << "/" << b << " is IN the Cantor's set!" << endl;
        }
        else if (dot > edge1 && dot < edge2)
        { // if a/b is in {1/3;2/3}
            cout << "Dot with coordinates " << a << "/" << b << " is OUT of the Cantor's set!" << endl;
        }
        else
        {
            if (dot < edge1)
            { // if a/b is in {0; 1/3}
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        cout << "Dot with coordinates " << a << "/" << b << " is IN the Cantor's set!" << endl;
                        break;
                    }
                    for (float j = 1 / num; j <= edge1; j = j + 1 / num)
                    {
                        if (count == 3)
                        {
                            count = 1;
                        }
                        if (dot < j)
                        {
                            if (count % 2 == 0)
                            {
                                cout << "Dot with coordinates " << a << "/" << b << " is OUT of the Cantor's set!" << endl;
                                break;
                            }
                        }
                        else
                        {
                            count = count + 1;
                        }
                    }
                    if (count == 2)
                        break;
                    num = num * 3;
                }
            }
            else
            { // if a/b is in {2/3;1}
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        cout << "Dot with coordinates " << a << "/" << b << " is IN the Cantor's set!" << endl;
                        break;
                    }
                    for (float j = 1; j > edge2; j = j - 1 / num)
                    {
                        if (count == 3)
                            count = 1;
                        if (dot <= j)
                        {
                            if (count % 2 == 0)
                            {
                                if (count % 2 == 0)
                                {
                                    cout << "Dot with coordinates " << a << "/" << b << " is OUT of the Cantor's set!" << endl;
                                    break;
                                }
                            }
                        }
                        else
                            count++;
                    }
                    num = num * 3;
                }
            }
        }
    }
}

int main()
{
    float a, b;
    int n;
    cout << "Input a >= 0 (1st coordinate): " << endl;
    cin >> a;
    cout << "Input b > 1 (2nd coordinate): " << endl;
    cin >> b;
    cout << "Input n (level): " << endl;
    cin >> n;
    CantorSet(a, b, n);

    return 0;
}
