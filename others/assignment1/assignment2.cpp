#include <bits/stdc++.h>
using namespace std;

struct Forward
{
    char name[50];
    int goals[3];
    int totalGoals = 0;
};

struct Goalkeeper
{
    char name[50];
    int saves[3];
    int totalSaves = 0;
};

struct Referee
{
    char name[50];
    int wDecs[3];
    int totalwDecs = 0;
};

int main()
{
    int f, g, r;

    cout << "Enter number of forwards: ";
    cin >> f;
    cin.ignore();
    vector<Forward> forwards(f);
    for (int i = 0; i < f; i++)
    {
        cout << "Enter name of forward " << i + 1 << ": ";
        cin >> forwards[i].name;
        cout << "Enter goals scored by forward " << i + 1 << ": ";
        for (int j = 0; j < 3; j++)
        {
            cin >> forwards[i].goals[j];
            forwards[i].totalGoals += forwards[i].goals[j];
        }
        cin.ignore();
    }

    sort(forwards.begin(), forwards.end(), [](const Forward &a, const Forward &b) {
        return a.totalGoals > b.totalGoals;
    });

    cout << "==========================\n";
    cout << "\nForward Rankings:\n";
    cout << "Rank\t | Name\t\t|Match1|Match2|Match3|Total Goals\n";
    cout << "--------------------------------------------------------\n";
    for (int i = 0; i < f; i++)
    {
        cout << i + 1 << "\t | " << forwards[i].name << "\t| ";
        for (int j = 0; j < 3; j++)
        {
            cout << forwards[i].goals[j] << " | ";
        }
        cout << forwards[i].totalGoals << endl;
    }
    cout << "==========================\n";

    cout << "Enter number of goalkeepers: ";
    cin >> g;
    cin.ignore();
    vector<Goalkeeper> goalkeepers(g);
    for (int i = 0; i < g; i++)
    {
        cout << "Enter name of goalkeeper " << i + 1 << ": ";
        cin >> goalkeepers[i].name;
        cout << "Enter saves made by goalkeeper " << i + 1 << ": ";
        for (int j = 0; j < 3; j++)
        {
            cin >> goalkeepers[i].saves[j];
            goalkeepers[i].totalSaves += goalkeepers[i].saves[j];
        }
        cin.ignore();
    }

    sort(goalkeepers.begin(), goalkeepers.end(), [](const Goalkeeper &a, const Goalkeeper &b) {
        return a.totalSaves > b.totalSaves;
    });

    cout << "==========================\n";
    cout << "\nGoalkeeper Rankings:\n";
    cout << "Rank\t | Name\t\t|Match1|Match2|Match3|Total Saves\n";
    cout << "--------------------------------------------------------\n";
    for (int i = 0; i < g; i++)
    {
        cout << i + 1 << "\t | " << goalkeepers[i].name << "\t| ";
        for (int j = 0; j < 3; j++)
        {
            cout << goalkeepers[i].saves[j] << " | ";
        }
        cout << goalkeepers[i].totalSaves << endl;
    }
    cout << "==========================\n";

    cout << "Enter number of referees: ";
    cin >> r;
    cin.ignore();
    vector<Referee> referees(r);
    for (int i = 0; i < r; i++)
    {
        cout << "Enter name of referee " << i + 1 << ": ";
        cin >> referees[i].name;
        cout << "Enter wrong decisions made by referee " << i + 1 << ": ";
        for (int j = 0; j < 3; j++)
        {
            cin >> referees[i].wDecs[j];
            referees[i].totalwDecs += referees[i].wDecs[j];
        }
        cin.ignore();
    }

    sort(referees.begin(), referees.end(), [](const Referee &a, const Referee &b) {
        return a.totalwDecs > b.totalwDecs;
    });

    cout << "==========================\n";
    cout << "\nReferee Rankings:\n";
    cout << "Rank\t | Name\t\t|Match1|Match2|Match3|Total Wrong Decisions\n";
    cout << "--------------------------------------------------------\n";
    for (int i = 0; i < r; i++)
    {
        cout << i + 1 << "\t | " << referees[i].name << "\t| ";
        for (int j = 0; j < 3; j++)
        {
            cout << referees[i].wDecs[j] << " | ";
        }
        cout << referees[i].totalwDecs << endl;
    }
    cout << "==========================\n";

    return 0;
}