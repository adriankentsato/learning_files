#line 1 "C:/Dev/Frequency/main.c"
void frequencyGenerator();
void frequencyMeter();

unsigned int getTMR0();
void setTMR0(unsigned int val);

void main() {

ADCON1 = 15;
CMCON = 7;

TRISA = 16;
TRISB = 128;
TRISC = 0;
TRISD = 0;
TRISE = 0;

LATA = 0;
LATB = 0;
LATC = 0;
LATD = 0;
LATE = 0;

NOT_RBPU_bit = 1;

while(1) {
if(RB7_bit) {
frequencyGenerator();
} else {
frequencyMeter();
}
}


}

void frequencyGenerator() {
}


void frequencyMeter() {
unsigned int x = 0;
float y = 0.0f;
unsigned int z = 0;
char txt[15];
T0CON = 0x80;
while(RA4_bit);
while(!RA4_bit);
setTMR0(0);
while(RA4_bit);
while(!RA4_bit);
x = getTMR0();
TMR0ON_bit = 0;
y = (float)x / 6.0f;
y = y * 0.000001f;
y = 1.0f / y;

FloatToStr(y, txt);


LATD = txt[0] - 0x30;
}

unsigned int getTMR0() {
unsigned int x = TMR0L;
return x | TMR0H << 8;
}

void setTMR0(unsigned int val) {
TMR0H = val >> 8;
TMR0L = val;
}
