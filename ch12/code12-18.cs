// 리터럴에 대한 표현 방법 개선(Literal improvements)

int number1 = 10000000;         // 1천만인지 한눈에 인식이 안 됨
int number2 = 10_000_000;       // 세 자리마다 띄어 한눈에 1천만임을 알 수 있음
int number3 = 1_0_0_0_0_000;    // 잘 쓰진 않겠지만 이런 식으로도 가능


uint hex1 = 0xFFFFFFFF;
uint hex2 = 0xFF_FF_FF_FF;  // 1바이트마다 띄어서 표현
uint hex3 = 0xFFFF_FFFF;    // 2바이트마다 띄어서 표현


// 숫자 4369를 표현한 2진 비트열
uint bin1 = 0b0001000100010001;     // 2진 비트열로 숫자 데이터 정의
uint bin2 = 0b0001_0001_0001_0001;  // 4자리마다 구분자를 사용해 가독성을 높임