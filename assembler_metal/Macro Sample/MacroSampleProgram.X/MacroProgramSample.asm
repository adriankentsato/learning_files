#include "p16f84a.inc"

; CONFIG
; __config 0xFFF1
 __CONFIG _FOSC_XT & _WDTE_OFF & _PWRTE_ON & _CP_OFF
 
 CBLOCK 0x0c
    COUNT
    ENDC
 
 ORG 0x0000 ;reset vector
 
 goto START
 
 ORG 0x0004 ;interrupt vector

START

    BCF STATUS, RP0 ;BANK 0
    CLRF PORTB
    CLRF PORTA
    
    BSF STATUS, RP0 ;BANK1
    BCF OPTION_REG, NOT_RBPU ;WEAK PULL-UP
    
    MOVLW 0x00
    MOVWF TRISB
    MOVLW 0x00
    MOVWF TRISA
    
    MOVLW 0x07 ;00000111
    MOVWF OPTION_REG ;Counter mode, falling edge, prescaler set to maximum
    
    BCF STATUS, RP0 ;BANK 0
    
    MOVLW 0x0F ;0000 1111
    MOVWF COUNT
    
MAIN BCF PORTB, 0
    MOVF TMR0, 0
    SUBLW .255
    BTFSS STATUS, Z
    GOTO MAIN ; keep looping until timer reaches 255
    DECFSZ COUNT,1 ;if set, decrement COUNT
    GOTO MAIN ;if count is not yet zero, repeat the loop

MAIN2 BSF PORTB,0 ;if count reaches zero, set PORTB.0
    MOVF TMR0,0 ;repeat process to delay turn off
    SUBLW .255
    BTFSS STATUS, Z
    GOTO MAIN2

    DECFSZ COUNT,1
    GOTO MAIN2
    GOTO MAIN
   
    ;GOTO $                          ; loop forever

    END