#include <iostream>
#include <iomanip>
#include <fstream>
#include <cstring>
using namespace std;
class student {
public:
	string name;
	int age;
	char gender;
	float grant;
};
struct building
{
	char name[35];
	char city[20];
	int exams[5];
	char film[20];
	int years;
};
const char* fname1 = "test1.dat";
int main()
{
	/*1.Напишите программу, работающую со всеми четырьмя стандартными объектами iostream.
	int i = 0;
	cout << "Enter a number: ";
	cin >> i;
	cerr << "test for cerr" << endl;//вывод сообщения об ошибке
	clog << "test for clog" << endl;//вывод логов
	/*-----------------------------------------------------------------------------------*/
	/*2.Напишите программу, предлагающую пользователю ввести  с клавиатуры его фамилию, имя и отчество как единое целое, а затем выводящую их на экран.
	string name;
	cout << "Enter your first name and second name like that: MatthewLebedievas \n";
	cin >> name;
	for (int i = 1; i < name.length(); i++)
	{
		if (name[i] >= 'A' && name[i] <= 'Z')
		{
			name.insert(i-1, "_");
		}
	}
	cout << name;
	*/
	/*3.Напишите программу, выполняющую различные вычисления и  выводящую  значений с применение методов форматирования, манипуляторов и флагов объекта cout.
	cout << setiosflags(ios::fixed);
	cout << setprecision(2) << 1000.243 << endl;
	cout << setw(20) << "Hello there.";
	/*4.Используя один из ранее разработанных классов (Worker, Student … ), создайте в программе список объектов путем ввода данных с клавиатуры и рапечатайте его на экране в виде таблицы
	student st1;
	student st2;
	st1.name = "Alex";
	st2.name = "Vlad";

	st1.age = 25;
	st2.age = 21;

	st1.gender = 'f';
	st2.gender = 'm';

	st1.grant = 1600.00;
	st2.grant = 1320.00;
	cout << "Name \t Age \t Gender \t Grant \t\n";
	cout << "---------------------------------------\n";
	cout << st1.name << "\t " << st1.age << "\t " << st1.gender << "\t\t " << st1.grant << "\n";
	cout << st2.name << "\t " << st2.age << "\t " << st2.gender << "\t\t " << st2.grant << "\n";
	*/
	/*5.Напишите программу, предлагающую пользователю ввести его фамилию, имя и отчество , а затем выводящую эти сведения в текстовый файл.
	ofstream f;
	f.open("ld.txt");
	string first_name, second_name;
	cout << "Enter your first name and second name \n";
	cin >> first_name >> second_name;
	f << first_name << " " << second_name;
	f.close();*/
	/*6.Напишите программу в которой ФИО вводятся из текстового файла и затем выводятся на экран.
	string a;
	ifstream f;
	f.open("ld.txt");
	while (!f.eof())
	{
		f >> a;
	}
	cout << a;
	f.close();*/
	/*7.Запись элементов стека в бинарный файл
	building bg1, bg2;
	strcpy_s(bg1.name, "Lenin");
	strcpy_s(bg1.city, "Magadan");
	strcpy_s(bg1.film, "Tarzan");
	bg1.years = 0xaabbccdd;
	strcpy_s(bg2.name, "Mira");
	strcpy_s(bg2.city, "Riga");
	strcpy_s(bg2.film, "Zizi");
	bg2.years = 0x11223344;
	for (int i = 0; i < 5; i++) {
		bg1.exams[i] = i;
		bg2.exams[i] = i * 2;
	}

	ofstream ofs1(fname1, ios::binary | ios::out);
	if (ofs1) {
		ofs1.write((char*)&bg1, sizeof(building));
		ofs1.write((char*)&bg2, sizeof(building));
	}
	else
		cout << "File open error: " << fname1 << endl;*/
}