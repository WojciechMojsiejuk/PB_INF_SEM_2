//
//  main.cpp
//  ProgramowanieObiektowe2
//
//  Created by Wojciech Mojsiejuk on 05.03.2018.
//  Copyright © 2018 Wojciech Mojsiejuk. All rights reserved.
//

#include <iostream>
#include <fstream>
#include <string>
using namespace std;
int main(int argc, const char * argv[]) {

    string nazwa, nazwa1, nazwa2;
    string imie;
    string nazwisko;
    int wiek;
    float skutecznosc;
    ifstream plik;
    ofstream plik_wynik;
    cout<<"Podaj nazwe pliku"<<endl;
    cin>>nazwa;
    nazwa1=nazwa+".txt";
    nazwa2=nazwa+".max.txt";
    plik.open( nazwa1 );
    plik_wynik.open(nazwa2);
    if(!plik.is_open())
        cout<<"Blad otwarcia pliku";
    float max_skutecznosc = -1;
    cout<<"Wszystkie osoby w pliku"<<endl;
    while(!plik.eof())
    {
        plik>>imie;
        plik>>nazwisko;
        plik>>wiek;
        plik>>skutecznosc;
        if(skutecznosc>max_skutecznosc)
            max_skutecznosc=skutecznosc;
        cout<<imie<<" "<<nazwisko<<" "<<wiek<<" "<<skutecznosc<<endl;
    }
    plik.close();
    plik.open( nazwa1 );
    cout<<"Osoba spelniajaca warunki"<<endl;
    if(!plik.is_open())
        cout<<"Blad otwarcia pliku";
while(!plik.eof())
    {
        plik>>imie;
        plik>>nazwisko;
        plik>>wiek;
        plik>>skutecznosc;
        if(skutecznosc==max_skutecznosc and  imie.length()>=3 and nazwisko.substr(nazwisko.length()-3,3) == "ski")
        {
            plik_wynik<<imie[0];
            for(int i=0;i<imie.length()-4;i++)
                plik_wynik<<'*';
            plik_wynik<<imie[0];
            plik_wynik<<imie.substr(imie.length()-3,3)<<" "<<nazwisko[0];
            for(int i=0;i<nazwisko.length()-4;i++)
                plik_wynik<<'*';
            plik_wynik<<nazwisko.substr(nazwisko.length()-3,3)<<" "<<wiek<<endl;
        }
    }
    plik_wynik.close();
    
    return 0;
}
