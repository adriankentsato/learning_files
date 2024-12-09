
_main:

;main.c,7 :: 		void main() {
;main.c,9 :: 		ADCON1 = 15;
	MOVLW       15
	MOVWF       ADCON1+0 
;main.c,10 :: 		CMCON = 7;
	MOVLW       7
	MOVWF       CMCON+0 
;main.c,12 :: 		TRISA = 16;
	MOVLW       16
	MOVWF       TRISA+0 
;main.c,13 :: 		TRISB = 128;
	MOVLW       128
	MOVWF       TRISB+0 
;main.c,14 :: 		TRISC = 0;
	CLRF        TRISC+0 
;main.c,15 :: 		TRISD = 0;
	CLRF        TRISD+0 
;main.c,16 :: 		TRISE = 0;
	CLRF        TRISE+0 
;main.c,18 :: 		LATA = 0;
	CLRF        LATA+0 
;main.c,19 :: 		LATB = 0;
	CLRF        LATB+0 
;main.c,20 :: 		LATC = 0;
	CLRF        LATC+0 
;main.c,21 :: 		LATD = 0;
	CLRF        LATD+0 
;main.c,22 :: 		LATE = 0;
	CLRF        LATE+0 
;main.c,24 :: 		NOT_RBPU_bit = 1;
	BSF         NOT_RBPU_bit+0, BitPos(NOT_RBPU_bit+0) 
;main.c,26 :: 		while(1) {
L_main0:
;main.c,27 :: 		if(RB7_bit) {
	BTFSS       RB7_bit+0, BitPos(RB7_bit+0) 
	GOTO        L_main2
;main.c,28 :: 		frequencyGenerator();
	CALL        _frequencyGenerator+0, 0
;main.c,29 :: 		} else {
	GOTO        L_main3
L_main2:
;main.c,30 :: 		frequencyMeter();
	CALL        _frequencyMeter+0, 0
;main.c,31 :: 		}
L_main3:
;main.c,32 :: 		}
	GOTO        L_main0
;main.c,35 :: 		}
L_end_main:
	GOTO        $+0
; end of _main

_frequencyGenerator:

;main.c,37 :: 		void frequencyGenerator() {
;main.c,38 :: 		}
L_end_frequencyGenerator:
	RETURN      0
; end of _frequencyGenerator

_frequencyMeter:

;main.c,41 :: 		void frequencyMeter() {
;main.c,42 :: 		unsigned int x = 0;
;main.c,43 :: 		float y = 0.0f;
;main.c,44 :: 		unsigned int z = 0;
;main.c,46 :: 		T0CON = 0x80;
	MOVLW       128
	MOVWF       T0CON+0 
;main.c,47 :: 		while(RA4_bit);
L_frequencyMeter4:
	BTFSS       RA4_bit+0, BitPos(RA4_bit+0) 
	GOTO        L_frequencyMeter5
	GOTO        L_frequencyMeter4
L_frequencyMeter5:
;main.c,48 :: 		while(!RA4_bit);
L_frequencyMeter6:
	BTFSC       RA4_bit+0, BitPos(RA4_bit+0) 
	GOTO        L_frequencyMeter7
	GOTO        L_frequencyMeter6
L_frequencyMeter7:
;main.c,49 :: 		setTMR0(0);
	CLRF        FARG_setTMR0_val+0 
	CLRF        FARG_setTMR0_val+1 
	CALL        _setTMR0+0, 0
;main.c,50 :: 		while(RA4_bit);
L_frequencyMeter8:
	BTFSS       RA4_bit+0, BitPos(RA4_bit+0) 
	GOTO        L_frequencyMeter9
	GOTO        L_frequencyMeter8
L_frequencyMeter9:
;main.c,51 :: 		while(!RA4_bit);
L_frequencyMeter10:
	BTFSC       RA4_bit+0, BitPos(RA4_bit+0) 
	GOTO        L_frequencyMeter11
	GOTO        L_frequencyMeter10
L_frequencyMeter11:
;main.c,52 :: 		x = getTMR0();
	CALL        _getTMR0+0, 0
;main.c,53 :: 		TMR0ON_bit = 0;
	BCF         TMR0ON_bit+0, BitPos(TMR0ON_bit+0) 
;main.c,54 :: 		y = (float)x / 6.0f;
	CALL        _word2double+0, 0
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       64
	MOVWF       R6 
	MOVLW       129
	MOVWF       R7 
	CALL        _Div_32x32_FP+0, 0
;main.c,55 :: 		y = y * 0.000001f;
	MOVLW       189
	MOVWF       R4 
	MOVLW       55
	MOVWF       R5 
	MOVLW       6
	MOVWF       R6 
	MOVLW       107
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
;main.c,56 :: 		y = 1.0f / y;
	MOVF        R0, 0 
	MOVWF       R4 
	MOVF        R1, 0 
	MOVWF       R5 
	MOVF        R2, 0 
	MOVWF       R6 
	MOVF        R3, 0 
	MOVWF       R7 
	MOVLW       0
	MOVWF       R0 
	MOVLW       0
	MOVWF       R1 
	MOVLW       0
	MOVWF       R2 
	MOVLW       127
	MOVWF       R3 
	CALL        _Div_32x32_FP+0, 0
;main.c,58 :: 		FloatToStr(y, txt);
	MOVF        R0, 0 
	MOVWF       FARG_FloatToStr_fnum+0 
	MOVF        R1, 0 
	MOVWF       FARG_FloatToStr_fnum+1 
	MOVF        R2, 0 
	MOVWF       FARG_FloatToStr_fnum+2 
	MOVF        R3, 0 
	MOVWF       FARG_FloatToStr_fnum+3 
	MOVLW       frequencyMeter_txt_L0+0
	MOVWF       FARG_FloatToStr_str+0 
	MOVLW       hi_addr(frequencyMeter_txt_L0+0)
	MOVWF       FARG_FloatToStr_str+1 
	CALL        _FloatToStr+0, 0
;main.c,61 :: 		LATD = txt[0] - 0x30;
	MOVLW       48
	SUBWF       frequencyMeter_txt_L0+0, 0 
	MOVWF       LATD+0 
;main.c,62 :: 		}
L_end_frequencyMeter:
	RETURN      0
; end of _frequencyMeter

_getTMR0:

;main.c,64 :: 		unsigned int getTMR0() {
;main.c,65 :: 		unsigned int x = TMR0L;
	MOVF        TMR0L+0, 0 
	MOVWF       R3 
	MOVLW       0
	MOVWF       R4 
;main.c,66 :: 		return x | TMR0H << 8;
	MOVF        TMR0H+0, 0 
	MOVWF       R1 
	CLRF        R0 
	MOVF        R3, 0 
	IORWF       R0, 1 
	MOVF        R4, 0 
	IORWF       R1, 1 
;main.c,67 :: 		}
L_end_getTMR0:
	RETURN      0
; end of _getTMR0

_setTMR0:

;main.c,69 :: 		void setTMR0(unsigned int val) {
;main.c,70 :: 		TMR0H = val >> 8;
	MOVF        FARG_setTMR0_val+1, 0 
	MOVWF       R0 
	CLRF        R1 
	MOVF        R0, 0 
	MOVWF       TMR0H+0 
;main.c,71 :: 		TMR0L = val;
	MOVF        FARG_setTMR0_val+0, 0 
	MOVWF       TMR0L+0 
;main.c,72 :: 		}
L_end_setTMR0:
	RETURN      0
; end of _setTMR0
