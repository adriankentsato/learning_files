#ifndef SOMETOOLS_H_INCLUDED
#define SOMETOOLS_H_INCLUDED

#include <windows.h>

void InitConsole( HANDLE * console );
void SetCurs( unsigned x, unsigned y, HANDLE * console );
void ChangeColor( HANDLE * console, int color );

#endif // SOMETOOLS_H_INCLUDED
