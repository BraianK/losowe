// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <conio.h>
#define _USE_MATH_DEFINES
#include <math.h>
#include <iostream>
using namespace std;



int main()
{
	float liczba_godz, s, brutto, netto;
	char kat;
	cout << "Program obliczający tygodniowe zarobki brutto i netto pracownika\n\nPodaj kategorie zaszeregowania: ";
	cin >> kat;
	cout << "Podaj liczbę przepracowanych godzin: ";
	cin >> liczba_godz;

	if (kat == "A" || kat == "a") {
		s = 15;
	}
	else if (kat == "B" || kat == "b") {
		s = 25;
	}
	else if (kat == "C" || kat == "c") {
		s = 30;
	}
	else if (kat == "D" || kat == "d") {
		s = 35;
	}
	else {
		cout << "Podano zła kategorie zaszeregowania. Spróbuj ponownie";
	}

	if (liczba_godz > 40) {
		netto = (liczba_godz - 40)*s * 2;
	}

	if (netto <= 700) {
		brutto = netto - 0.15*netto;
	}
	else if (netto <= 1200 && netto >= 701) {
		brutto = netto - 0.2*netto;
	}
	else if (netto > 1200) {
		brutto = netto - 0.25*netto;
	}

	cout << "Zarobeki pracownika wynoszą: \nNetto:" << netto << "\nBrutto: " << brutto;
	getch();
	return 0;
}