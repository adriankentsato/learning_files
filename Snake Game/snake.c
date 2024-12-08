#include "snake.h"
#include <stdio.h>
#include "sometools.h"
#include <stdlib.h>
#include <conio.h>

void AddBody( HEADPTR head )
{
    snakePtr nwBody = (snakePtr)malloc(sizeof(snake));
    nwBody->prev = head->tail;
    nwBody->next = NULL;
    switch(head->tail->direction)
    {
    case UP:
        nwBody->posx = head->tail->posx;
        nwBody->posy = head->tail->posy+1;
        nwBody->direction = UP;
        break;
    case DOWN:
        nwBody->posx = head->tail->posx;
        nwBody->posy = head->tail->posy-1;
        nwBody->direction = DOWN;
        break;
    case RIGHT:
        nwBody->posx = head->tail->posx-1;
        nwBody->posy = head->tail->posy;
        nwBody->direction = RIGHT;
        break;
    case LEFT:
        nwBody->posx = head->tail->posx+1;
        nwBody->posy = head->tail->posy;
        nwBody->direction = LEFT;
    }
    head->tail->next = nwBody;
    head->tail = nwBody;
}

void DrawSnake( HEADPTR head, HANDLE * console )
{
    snakePtr current;
    current = head->head;
    SetCurs(current->posx, current->posy, console);
    ChangeColor(console, 3);
    printf("\xDB");
    current = current->next;
    while(current != NULL)
    {
        ChangeColor(console, 15);
        SetCurs(current->posx, current->posy, console);
        printf("\xDB");
        current = current->next;
    }
}

void UpdateSnake( HEADPTR head )
{
    snakePtr current = head->tail;
    while(current != NULL)
    {
        switch(current->direction)
        {
        case UP:
            current->posy -= 1;
            break;
        case DOWN:
            current->posy += 1;
            break;
        case LEFT:
            current->posx -= 1;
            break;
        case RIGHT:
            current->posx += 1;
        }
        if(current->prev != NULL)
            current->direction = current->prev->direction;
        current = current->prev;
    }
}

void BoxCollision( HEADPTR hd, HANDLE * console, int score )
{
    if(hd->head->posx == 79 || hd->head->posx == 2 || hd->head->posy == 2 || hd->head->posy == 24)
    {
        system("cls");
        ChangeColor(console, 5);
        SetCurs(40, 12, console);
        printf("Snake Crashed!! Score : %d", score);
        getch();
        exit(1);
    }
}

void SelfCollision( HEADPTR hd, HANDLE * console, int score )
{
    snakePtr current, head;
    current = hd->head->next;
    head = hd->head;
    while(current != NULL)
    {
        if(current->posx == head->posx && current->posy == head->posy)
        {
            system("cls");
            SetCurs(40, 6, console);
            ChangeColor(console, 6);
            printf("Snake collided with itself!! Score : %d", score);
            getch();
            exit(1);
        }
        current = current->next;
    }
}
