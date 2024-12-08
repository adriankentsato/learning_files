#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include "sometools.h"
#include "fence.h"
#include "snake.h"
#include "food.h"

void Input( HEADPTR hdptr );

HANDLE console;

int score = 0;

int main ( void )
{
    HEAD snkbody;
    food mefood;
    snakePtr body = (snakePtr)malloc(sizeof(snake));
    body->next = body->prev = NULL;
    body->posx = 40;
    body->posy = 12;
    body->direction = UP;
    snkbody.head = snkbody.tail = body;
    snkbody.lenght = 1;
    system("title Kent Adrian Sato's Snake Game");
    InitConsole( &console );
    CreateFood(&mefood);
    AddBody(&snkbody);
    AddBody(&snkbody);
    AddBody(&snkbody);
    while(1)
    {
        system("cls");
        DrawFence(&console);
        Input(&snkbody);
        UpdateSnake(&snkbody);
        BoxCollision(&snkbody, &console, score);
        SelfCollision(&snkbody, &console, score);
        UpdateFood(&snkbody, &mefood, &score);
        DisplayFood(&mefood, &console);
        DrawSnake(&snkbody, &console);
        Timer();
    }
    return 0;
}

void Input( HEADPTR hdptr )
{
    int key = 0;
    if(_kbhit())
        key = getch();
    switch(key)
    {
    case 'w':
        if(hdptr->head->direction == RIGHT || hdptr->head->direction == LEFT)
        hdptr->head->direction = UP;
        break;
    case 's':
        if(hdptr->head->direction == RIGHT || hdptr->head->direction == LEFT)
        hdptr->head->direction = DOWN;
        break;
    case 'a':
        if(hdptr->head->direction == UP || hdptr->head->direction == DOWN)
        hdptr->head->direction = LEFT;
        break;
    case 'd':
        if(hdptr->head->direction == UP || hdptr->head->direction == DOWN)
        hdptr->head->direction = RIGHT;
        break;
    }
}
