#ifndef SNAKE_H_INCLUDED
#define SNAKE_H_INCLUDED

#include <windows.h>

enum Direction{UP = 1, DOWN, LEFT, RIGHT};
typedef enum Direction Direction;

struct snake{
    struct snake * prev;
    int posx;
    int posy;
    Direction direction;
    struct snake * next;
};

typedef struct{
    struct snake * head;
    int lenght;
    struct snake * tail;
}HEAD;

typedef struct snake snake;
typedef snake * snakePtr;
typedef HEAD * HEADPTR;

void AddBody( HEADPTR head );
void DrawSnake( HEADPTR head, HANDLE * console );
void UpdateSnake( HEADPTR head );
void BoxCollision( HEADPTR hd, HANDLE * console, int score );
void SelfCollision( HEADPTR hd, HANDLE * console, int score );

#endif // SNAKE_H_INCLUDED
