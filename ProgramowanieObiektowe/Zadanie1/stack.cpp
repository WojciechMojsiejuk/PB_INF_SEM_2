//
//  main.cpp
//  ProgramowanieObiektowe1
//
//  Created by Wojciech Mojsiejuk on 19.02.2018.
//  Copyright © 2018 Wojciech Mojsiejuk. All rights reserved.
//
#include <iostream>
#define STACK_SIZE 10
struct STACK
{
    int number;
    struct STACK *next;
};
//1
STACK* InitStack()
{
    STACK* newstack  = new STACK;
    newstack->next=NULL;
    return newstack;
}
void DestroyStack(STACK** StackToDelete)
{
    STACK *pom;
    while(*StackToDelete!=NULL)
    {
        pom=*StackToDelete;
        *StackToDelete=(*StackToDelete)->next;
        delete pom;
    }
}
STACK* PushStack(STACK* Bottom, int value)
{
    int counter=0;
    while(Bottom->next!=NULL)
    {
        Bottom=Bottom->next;
        counter++;
        if(counter>=STACK_SIZE)
        {
            fprintf(stderr, "Stack size limit. Cannot add another value.\n");
            return Bottom;
        }
    }
    Bottom->next=new STACK;
    Bottom=Bottom->next;
    Bottom->number=value;
    Bottom->next=NULL;
    return Bottom;
}
int PopStack(STACK* Bottom)
{
    int pom;
    STACK *temp;
    while(Bottom->next->next!=NULL)
    {
        Bottom=Bottom->next;
    }
    pom = Bottom->next->number;
    temp = Bottom->next;
    delete temp;
    Bottom->next= NULL;
    return pom;
}
void TopStack(STACK* Bottom)
{
    while(Bottom->next!=NULL)
    {
        Bottom=Bottom->next;
    }
    std::cout<<Bottom->number<<"\n";
}
bool IsEmpty(STACK* Bottom)
{
    if(Bottom==NULL or (Bottom->next==NULL and Bottom->number==0))
        return true;
    return false;
}
bool IsFull(STACK* Bottom)
{
    int counter=0;
    while(Bottom->next!=NULL)
    {
        Bottom=Bottom->next;
        counter++;
        if(counter>=STACK_SIZE)
        {
            return true;
        }
    }
    return false;
}
int main(int argc, const char * argv[]) {
    STACK* init = InitStack();
    init->number=5;
    std::cout << init->number<<"\n";
    //DestroyStack(&init);
    PushStack(init, 6);
    PushStack(init, 7);
    TopStack(init);
    //int wynik = PopStack(init);
    //std::cout << wynik << init->number<<"\n";
    //to fix: delete doesnt work
    return 0;
}
