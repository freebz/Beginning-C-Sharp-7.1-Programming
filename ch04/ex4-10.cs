// 예제 4.10 부모 인스턴스를 자식으로 형변환하는 경우

Computer pc = new Computer();
Notebook notebook = (Notebook)pc;   // 명시적 형변환, 컴파일은 가능