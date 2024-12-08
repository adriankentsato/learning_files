#include "sometools.h"
#include <stdlib.h>

void InitConsole( HANDLE * console )
{
    COORD consize = { 80, 25 };
    *console = CreateFile("CONOUT$", GENERIC_WRITE | GENERIC_READ,
                           FILE_SHARE_READ | FILE_SHARE_WRITE, 0L,
                           OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0L);
    SetConsoleScreenBufferSize(*console, consize);
    SetConsoleTextAttribute(*console, (WORD)((0 << 4) | 15));
}

void SetCurs( unsigned x, unsigned y, HANDLE * console )
{
    COORD curpos = { x - 1, y - 1 };
    SetConsoleCursorPosition(*console, curpos);
}

void ChangeColor( HANDLE * console, int color )
{
    SetConsoleTextAttribute( *console, (WORD)((0 << 4) | color));
}
