//  Copyright © 2018 Paweł Bąk.
//
#include <iostream>
#include <ctime>

struct stos
{
	int liczba;
	stos* nast;
};
typedef stos* Adres;

Adres init();
void destroy(Adres&);
void push(int, Adres&);
void pop(Adres&);
int top(Adres);
int empty(Adres);
int full();

int main()
{
	srand((unsigned)time(NULL));
	Adres nowy = init();
	int liczba = rand() % 100;
	for(int i = 0; i < liczba; i++)
	{
		push(rand() % 1000, nowy);
	}
	while (!empty(nowy))
	{
		std::cout << top(nowy) << '\n';
		pop(nowy);
	}
	std::cin.get();
	return 0;
}

Adres init()
{
	return nullptr;
}

void destroy(Adres &pm)
{
	if (pm)
	{
		destroy(pm->nast);
		delete pm;
		pm = nullptr;
	}
}

void push(int n, Adres &pm)
{
	Adres nowy = new stos;
	nowy->liczba = n;
	nowy->nast = pm;
	pm = nowy;
}

void pop(Adres &pm)
{
	Adres pom = pm->nast;
	delete pm;
	pm = pom;
}

int top(Adres pm)
{
	return pm->liczba;
}

int empty(Adres pm)
{
	return ((pm) ? 0 : 1);
}

int full()
{
	return 0;
}
