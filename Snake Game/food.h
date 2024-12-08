#ifndef FOOD_H_INCLUDED
#define FOOD_H_INCLUDED

#include "snake.h"
#include <windows.h>

struct food{
    int posx, posy;
};


typedef struct food food;
typedef food * fdPtr;

void CreateFood( fdPtr food );
void DisplayFood( fdPtr food, HANDLE * console );
void UpdateFood( HEADPTR hsnake, fdPtr food, int * score );
void Timer( void );
void UpdateTimer( void );

#endif // FOOD_H_INCLUDED
