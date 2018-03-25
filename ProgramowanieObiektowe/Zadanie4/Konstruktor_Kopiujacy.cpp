#include <iostream>
using namespace std;
#define STACK_SIZE 10
class Stos
{
    int * tab;
    int n=0;
    int stack_size;
    public:
    Stos();
    Stos(int stack_size);
    ~Stos();
    Stos(Stos &s);
    void push(int value);
    int top();
    bool empty();
    bool full();
    void pop();
};


Stos::Stos()
{
    cout<<"\nUruchomiono konstruktor domyślny\n";
    stack_size=10;
    this->tab  = new int[stack_size];
}
Stos::Stos(int number)
{
    cout<<"\nUruchomiono konstruktor z parametrem\n";
    stack_size=number;
    this->tab = new int[stack_size];
}
Stos::Stos(Stos &s)
{
     cout<<"\nUruchomiono konstruktor kopiujacy\n";
    stack_size=s.stack_size;
    n=s.n;
    this->tab = new int[stack_size];
    for(int i=0;i<n;i++)
    {
        tab[i]=s.tab[i];
    }
}

Stos::~Stos()
{
    cout<<"\nUruchomiono destruktor\n";
    if(!empty())
    {
        delete [] this->tab;
    }
}
void Stos::push(int value)
{
    if(!full())
    {
        this->tab[n]=value;
        n++;
    }
}
int Stos::top()
{
    return this->tab[n-1];
}
void Stos::pop()
{
    n--;
}
bool Stos::empty()
{
    if(n==0)
        return true;
    return false;
}
bool Stos::full()
{
    if(this->n==this->stack_size)
        return true;
    return false;
}
void dodaj(Stos s, int a) {
    s.push(a);
}
int main() {
    Stos s;
    s.push(0);
    dodaj(s, 1);
    dodaj(s, 2);
    while (!s.empty()) {
        cout <<
        s.top();
        s.pop();
    }
}
