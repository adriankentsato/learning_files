#include "fence.h"
#include "sometools.h"
#include <stdio.h>

void DrawFence( HANDLE * console )
{
    char box[80], block[80];
    int i, j;
    block[0] = block[77] = '\xDB';
    for( i = 0, j = 1 ; i < 78 ; i++, j++ )
    {
        if( j == 77 )
            j = 1;
        box[i] = '\xDB';
        block[j] = '\xFF';
    }
    box[78] = 0;
    block[78] = box[78];
    ChangeColor(console, 15);
    SetCurs(2, 2 , console);
    puts(box);
    for( i = 3 ; i < 24 ; i++ )
    {
        SetCurs(2, i , console);
        puts(block);
    }
    SetCurs(2, 24 , console);
    puts(box);
}
