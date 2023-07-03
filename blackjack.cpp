#include <iostream>
#include <random>
#include <vector>
using namespace std;

class Cards
{
public:
    Cards()
    {
    }

    void FirstTwoCards()
    {
        uniform_int_distribution<> rdcard(0, 12);
        uniform_int_distribution<> rdsuit(0, 3);
        for (int i = 0; i < 2; i++)
        {
            cardnow = cards[rdcard(rd)];
            cout << cardnow << " of " << suits[rdsuit(rd)] << endl;
            playercards.push_back(cardnow);
        }
        Sum();
    }
    void Sum()
    {
        playersum = 0;
        for (int i = 0; i < playercards.size(); i++)
        {
            cardnow = playercards[i];
            if (playercards[i] == "2")
                playersum += 2;
            if (playercards[i] == "3")
                playersum += 3;
            if (playercards[i] == "4")
                playersum += 4;
            if (playercards[i] == "5")
                playersum += 5;
            if (playercards[i] == "6")
                playersum += 6;
            if (playercards[i] == "7")
                playersum += 7;
            if (playercards[i] == "8")
                playersum += 8;
            if (playercards[i] == "9")
                playersum += 9;
            if (playercards[i] == "10")
                playersum += 10;
            if (playercards[i] == "jack")
                playersum += 10;
            if (playercards[i] == "queen")
                playersum += 10;
            if (playercards[i] == "king")
                playersum += 10;
            if (playercards[i] == "ace")
            {
                if (playercards.size() == 2)
                    playersum += 11;
                else
                    playersum += 1;
            }
        }
    }
    int Exam()
    {
        if (playersum == 21)
        {

            return 0;
        }
        else if (playersum < 21)
        {
            cout << "You have " << playersum << endl;
            return -1;
        }
        else
        {
            cout << "You have " << playersum << " and you lose" << endl;
            return 1;
        }
    }
    void PlusCard()
    {
        uniform_int_distribution<> rdcard(0, 12);
        uniform_int_distribution<> rdsuit(0, 3);
        cardnow = cards[rdcard(rd)];
        cout << cardnow << " of " << suits[rdsuit(rd)] << endl;
        playercards.push_back(cardnow);
    }

    ~Cards()
    {
    }

private:
    string suits[4] = {"hearts", "clubs", "shades", "diamonds"};
    string cards[13] = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace"};
    vector<string> playercards;
    int playersum = 0;
    random_device rd;
    string cardnow;
    int count = 1;
};

int main()
{
    int result;
    string answer;
    Cards player;
    player.FirstTwoCards();
    while (true)
    {
        player.Sum();
        result = player.Exam();
        if (result == 0)
        {
            cout << "You have 21, you win" << endl;
            break;
        }
        else if (result == -1)
        {
            cout << "Do you need one more card? (yes/no)" << endl;
            cin >> answer;
            if (answer == "yes")
                player.PlusCard();
            else if (answer == "no")
                cout << "Well played" << endl;
        }
        else if (result == 1)
        {
            break;
        }
    }
    cin >> answer;
    return 0;
}