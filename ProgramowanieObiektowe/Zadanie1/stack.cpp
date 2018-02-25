//
//  main.cpp
//  ProgramowanieObiektowe1
//
//  Created by Wojciech Mojsiejuk on 19.02.2018.
//  Copyright © 2018 Wojciech Mojsiejuk. All rights reserved.
//
#include <iostream>
#include <cstdlib>
#include <ctime>
#define STACK_SIZE 5
struct STACK
{
    int number;
    struct STACK *next;
};
STACK* InitStack()
{
    STACK* newstack  = new STACK;
    newstack->next=NULL;
    return newstack;
}
bool IsEmpty(STACK* Bottom)
{
    //Condition checks whether stack was not initialized or was initialized but did not receive any value - by default it gets 0
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
            return NULL;
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
    if(IsEmpty(Bottom)==1)
    {
        fprintf(stderr, "Stack is empty, cannot pop object\n");
        return -1;
    }
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
int main(int argc, const char * argv[]) {
    STACK* init = InitStack();
    std::cout<<"Czy stack jest pusty? "<<IsEmpty(init)<<"\n";
    int i,j;
    srand(time(NULL));
    int limit = std::rand()%10;
    int value;
    for(i=0;i<limit;i++)
    {
        value= std::rand()%20;
        if(PushStack(init, value)==NULL)
        {
            break;
        }
        std::cout<<i<<": "<<value<<"\n";
    }
    std::cout<<"Czy stack jest pusty? "<<IsEmpty(init)<<"\n";
    std::cout<<"Czy stack jest pełny? "<<IsFull(init)<<"\n";
    std::cout<<"\nTop element: ";
    TopStack(init);
    std::cout<<"\nWartosci stosu zdejmowane z gory: \n";
    
    for(j=0;j<i;j++)
    {
        std::cout<<PopStack(init)<<"\n";
    }
    DestroyStack(&init);
    return 0;
}
