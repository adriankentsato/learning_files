#include "food.h"
#include "snake.h"
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include "sometools.h"

int timer = 100;

void DisplayFood( fdPtr food, HANDLE * console )
{
    SetCurs(food->posx, food->posy, console);
    ChangeColor(console, 12);
    printf("\xDB");
}
void UpdateFood( HEADPTR hsnake, fdPtr food, int * score )
{
    if(hsnake->head->posx == food->posx && hsnake->head->posy == food->posy)
    {
        food->posx = (rand() % 74) + 3;
        food->posy = (rand() % 19) + 3;
        *score += 1;
        UpdateTimer();
        AddBody(hsnake);
    }
}
void CreateFood( fdPtr food )
{
    food->posx = (rand() % 74) + 3;
    food->posy = (rand() % 19) + 3;
}
void UpdateTimer( void )
{
    timer -= 5;
}
void Timer( void )
{
    Sleep(timer);
}
