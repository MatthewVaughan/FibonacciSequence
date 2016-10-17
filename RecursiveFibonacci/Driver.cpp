#include <iostream>
using namespace std;


static double fib(double idx);

int main()
{
	double index;

	cout << "Please enter in the index you would like from the Fibonacci's Sequence: ";

	cin >> index;

	cout << "\n" << "The number at index #" << index << " in Fibonacci's Sequence is " << fib(index) << endl;

	system("PAUSE");
	return 0;
}

double fib(double idx)
{
	if (idx <= 1)
	{ return idx; }
	else
	{ return fib(idx - 1) + fib(idx - 2); }
}