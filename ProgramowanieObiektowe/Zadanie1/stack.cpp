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
struct STACK
{
    int number;
    struct STACK *next;
};
void InitStack()
{
    
    return;
}
bool IsEmpty(STACK* Top)
{
    if(Top==NULL)
        return true;
    return false;
}
bool IsFull(STACK* Top)
{
    //Stack by default won't be full (while using list structure), unless its size would be limited by defined value.
    return false;
}
STACK* PushStack(STACK* Top, int value)
{
    STACK * new_Top = new STACK;
    new_Top->number=value;
    new_Top->next=Top;
    return new_Top;
}
void PopStack(STACK** Top)
{
    if(IsEmpty(*Top)==0)
    {
        STACK *temp = (*Top)->next;
        delete (*Top);
        (*Top) = temp;
    }
    else
    {
        fprintf(stderr, "Cannot delete element, no more elements\n");
    }
}
void DestroyStack(STACK** StackToDelete)
{
    while(*StackToDelete!=NULL)
    {
        PopStack(StackToDelete);
    }
}
void TopStack(STACK* Top)
{
    std::cout<<Top->number<<"\n";
}
int main(int argc, const char * argv[]) {
    STACK* top = NULL;
    int i;
    srand(time(NULL));
    int limit = std::rand()%10;
    int value;
    for(i=0;i<limit;i++)
    {
        value= std::rand()%20;
        top = PushStack(top, value);
        std::cout<<i<<": "<<value<<"\n";
    }
    std::cout<<"Czy stack jest pusty? "<<IsEmpty(top)<<"\n";
    std::cout<<"Czy stack jest pełny? "<<IsFull(top)<<"\n";

    std::cout<<"\nWartosci stosu zdejmowane z gory: \n";
    
    for(i=0;i<limit;i++)
    {
        if(IsEmpty(top)==0)
        {
            TopStack(top);
        }
        PopStack(&top);
        
    }
    DestroyStack(&top);
    return 0;
}
