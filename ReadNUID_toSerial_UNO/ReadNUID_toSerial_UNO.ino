/*
based on Uno sample, tp ini hanya kirim HEX via Serial saja
Using OPEN Smart NFC Shield on RC522 chip
 * Typical pin layout used:
 * -----------------------------------------------------------------------------------------
 *             MFRC522      Arduino       Arduino   Arduino    Arduino          Arduino
 *             Reader/PCD   Uno/101       Mega      Nano v3    Leonardo/Micro   Pro Micro
 * Signal      Pin          Pin           Pin       Pin        Pin              Pin
 * -----------------------------------------------------------------------------------------
 * RST/Reset   RST          9             5         D9         RESET/ICSP-5     RST
 * SPI SS      SDA(SS)      10            53        D10        10               10
 * SPI MOSI    MOSI         11 / ICSP-4   51        D11        ICSP-4           16
 * SPI MISO    MISO         12 / ICSP-1   50        D12        ICSP-1           14
 * SPI SCK     SCK          13 / ICSP-3   52        D13        ICSP-3           15
 */

#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9
//BUZZER
const int buzzer = 8;//8 yg dipake
 
MFRC522 rfid(SS_PIN, RST_PIN); // Instance of the class

MFRC522::MIFARE_Key key; 

// Init array that will store new NUID 
byte nuidPICC[4];

void setup() { 
  Serial.begin(9600);
  SPI.begin(); // Init SPI bus
  rfid.PCD_Init(); // Init MFRC522 

  //SEt BUZZER sebagai output
  pinMode(buzzer, OUTPUT);
  
  bunyi(2000,1); 
}
 
void loop() {

  // Reset the loop if no new card present on the sensor/reader. This saves the entire process when idle.
  if ( ! rfid.PICC_IsNewCardPresent())
    return;

  // Verify if the NUID has been readed
  if ( ! rfid.PICC_ReadCardSerial())
    return;

  //Serial.print(F("PICC type: "));
  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
  //Serial.println(rfid.PICC_GetTypeName(piccType));

  // Check is the PICC of Classic MIFARE type
  /* //jangan dibatasi dia bisa bacanya apa
  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&  
    piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
    piccType != MFRC522::PICC_TYPE_MIFARE_4K) {
    Serial.println(F("XXXXXXXX"));
    return;
  }
  */

  if (rfid.uid.uidByte[0] != nuidPICC[0] || 
    rfid.uid.uidByte[1] != nuidPICC[1] || 
    rfid.uid.uidByte[2] != nuidPICC[2] || 
    rfid.uid.uidByte[3] != nuidPICC[3] ) {
    //Serial.println(F("A new card has been detected."));

    // Store NUID into nuidPICC array
    for (byte i = 0; i < 4; i++) {
      nuidPICC[i] = rfid.uid.uidByte[i];
    }

   bunyi(1000,1); 
   Serial.println(convertToHex(rfid.uid.uidByte, rfid.uid.size));
  }
  else{
    //Serial.println(F("--------"));
   bunyi(4000,3); 
   }

  // Halt PICC
  rfid.PICC_HaltA();

  // Stop encryption on PCD
  rfid.PCD_StopCrypto1();
  
}

String convertToHex(byte *buffer, byte bufferSize){
  String uidStringHexTemp;
  //Serial.print("Convert To Hex UID : ");
  for (byte i = 0; i < rfid.uid.size; i++) {
        //Serial.print(rfid.uid.uidByte[i] < 0x10 ? " 0" : " ");
        if(rfid.uid.uidByte[i] < 0x10){
          uidStringHexTemp = uidStringHexTemp + " 0";
        }else{
          uidStringHexTemp = uidStringHexTemp + " ";
        }
          //DEBUG
          //Serial.print(rfid.uid.uidByte[i], HEX);
          uidStringHexTemp = uidStringHexTemp + String(rfid.uid.uidByte[i],HEX);
       }
       //Serial.println("");
      return uidStringHexTemp;
}
void bunyi(int freq,int jumlah){
  for(int i=0;i<jumlah;i++){
    tone(buzzer, freq); 
     delay(100);        
     noTone(buzzer);
  }     
}
