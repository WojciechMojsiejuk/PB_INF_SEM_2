#include <iostream>
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
void DestroyStack(STACK* StackToDelete)
{
    STACK* temp;
    while(StackToDelete->next!=NULL)
    {
        temp = StackToDelete;
        while(temp->next!=NULL)
        {
            temp=temp->next;
        }
        delete temp;
    }
    delete StackToDelete;
}
STACK* PushStack(STACK* Bottom, int value)
{
    while(Bottom->next!=NULL)
    {
        Bottom=Bottom->next;
    }
    Bottom->number=value;
    return Bottom;
}
int main(int argc, const char * argv[]) {
    STACK* init = InitStack();
    init->number=5;
    std::cout << init->number<<"\n";
    delete init;
    //DestroyStack(init);
    std::cout << init->number<<"\n";
    //to fix: delete doesnt work
    return 0;
}
