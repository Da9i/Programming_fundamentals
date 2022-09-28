//calculating the total, highest and lowest sale of salsa in a month.

#include<string>
using namespace std;
int main()
{
	string salsa[5] = { "MILD","MEDIUM","SWEET","HOT","ZESTY"};
	int jars[5], total=0, temp=0;

//number of jars sold of salsa in a month.

	for (int i = 0; i < 5; i++)
	{
		cout << "THE NUMBER OF JARS SOLD OF " << salsa[i] << " SALSA DURING THE PAST MONTH = ";
		cin >> jars[i];
		total += jars[i];
	}
	cout << "\nSALES FOR EACH SALSA TYPE DURING PAST MONTH :\n" << endl;

//number of each salsa sold in a month.

	for (int i = 0; i < 5; i++)
	{
		cout << "TOTAL " << salsa[i] << " SALSA SOLD DURING THE PAST MONTH = " << jars[i] << endl;	
	}

//sorting an array.

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (jars[i] < jars[j])
			{
				temp = jars[i];
				jars[i] = jars[j];
				jars[j] = temp;
			}
		}
	}

//highest, lowest and total sale of salsa in a month.

	cout << "\nHIGHEST SELLING SALSA DURING THE PAST MONTH = " << jars[4] << endl;
	cout << "LOWEST SELLING SALSA DURING THE PAST MONTH = " << jars[0] << endl;
	cout << "\nTOTAL SALES OF SALSA DURING THE PAST MONTH = " << total;
	system("pause>0");
}
