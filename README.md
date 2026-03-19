# (c#코딩) 에코 메신저

##개요 
-c# 프로그래밍 학습
-설명 : 사용자의 키보드에 입력한 정보를 리스트 박스로 받아 보여주는 채팅 프로그램
-사용한 플랫폼 : net windows forms, visual studio, git hub 
-사용한 컨트롤 : label 2개, text box 1개, list box 1개, button 3개
-사용한 기술과 구현한 기능 : 
 -  컨트롤 배치와 기본적인 속성 제어 
 -  메서드와 조건문을 활용한 편의 기능 구현
 -  문자열 처리 및 속성 결합 활용
 -  컬렉션 제어 및 시스템 연동

   ## 실행 화면 (과제 1)
   -과제 1 코드의 실행 스크린샷
   
   <img width="502" height="304" alt="image" src="https://github.com/user-attachments/assets/f2c2ce00-5ad5-4ed5-b550-49a75089eefb" />

   #과제내용
   
     -Label(표시), TextBox(입력), Button(전송), ListBox(대화창)를 적절히 배치, 
   
     -전송 버튼 클릭 시 TextBox의 텍스트를 ListBox의 항목(Items)으로 추가,
   
     -추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비
   
   
   #구현 내용과 기능 설명
   
    -사용자 인터페이스의 가독성을 위해 상단에 Label과 TextBox를, 중앙에 ListBox(대화창)를 배치하고, 우측 및 하단에 제어용 Button들을 구성
    
    -전송 버튼 클릭 시 TextBox.Text 속성의 값을 ListBox.Items.Add() 메서드를 통해 대화창 목록으로 추가
    
    -메시지 전송 직후 TextBox.Clear()를 호출하여 다음 입력을 위한 빈 상태를 유지
    
   ## 실행 화면 (과제 2)
   -과제 2 코드의 실행 스크린샷
   
   <img width="511" height="302" alt="image" src="https://github.com/user-attachments/assets/549f9c8d-18a6-4d91-9c7f-1a81d8e14dc7" />

   #과제내용
   
    -전송이 끝나면 입력창에 남겨진 기존 메시지를 삭제
    
     -전송후에 마우스로 입력창을 다시 클릭하지 않아도 되도록 커서를 자동으로 입력창에 두기
   
     -마우스 클릭 대신 키보드의 Enter 키를 눌러도 메시지가 전송
   
     -내용이 없는 빈문자열이나 공백(Space)만 있을때는 메시지가 전송되지 않도록 방지
   

   #구현 내용과 기능 설명
   
    -전송 후 TextBox.Focus() 메서드를 실행하여, 사용자가 마우스를 다시 클릭하지 않아도 키보드로 연속해서 메시지를 입력할 수 있도록 구현
    
    -KeyDown 이벤트를 활용하여 Enter 키 입력 시 전송 버튼의 클릭 이벤트가 발생하도록 연결하여 조작성을 높임
    
    -string.IsNullOrWhiteSpace()를 사용하여 내용이 없는 빈 문자열이나 스페이스바만 있는 경우 전송 로직이 실행되지 않도록 방어 코드를 작성
    

   ## 실행 화면 (과제 3)
   -과제 3 코드의 실행 스크린샷
   
   <img width="500" height="298" alt="image" src="https://github.com/user-attachments/assets/880852a5-8e13-4a2b-8aaf-1b502836ed04" />

   #과제내용
   
     -메시지 앞에 현재시간 ([hh:mm:ss])을 자동으로 결합하여 리스트에 출력
   
     -현재 리스트에 쌓인 총 메시지 개수를 계산하여 하단Label에 실시간으로 업데이트
   
     -사용자가 입력한 메시지의 앞뒤 불필요한 공백을 Trim() 함수로 제거하여 저장
   
   
   #구현 내용과 기능 설명
   
     -DateTime.Now를 활용해 [hh:mm:ss] 형식의 현재 시간을 메시지 앞에 자동으로 접두어로 붙여 전송 시간을 기록
     
     -Trim() 함수를 적용하여 메시지 앞뒤의 불필요한 공백을 제거함으로써 데이터의 일관성을 유지
     
     -리스트에 항목이 추가/삭제될 때마다 ListBox.Items.Count 값을 하단 Label에 반영하여 현재 대화 개수를 실시간으로 노출
     
     

   ## 실행 화면 (과제 4)
   -과제 4 코드의 실행 스크린샷
   
   <img width="504" height="299" alt="image" src="https://github.com/user-attachments/assets/e14ae7bd-1e8a-47db-aee5-9bfb79fd6e31" />
    <img width="508" height="298" alt="image" src="https://github.com/user-attachments/assets/cc33dc82-c078-41ea-bc1a-4cfa824cd597" />

   #과제내용
   
     -ListBox에서 특정메시지를 마우스로 클릭하고'삭제' 버튼을 누르면 해당 항목만 목록에서 제거
   
      -대화 기록 삭제' 버튼을 클릭하면 리스트의 모든내용을 한번에 제거
   
     -입력창에 글자수를 50자로 제한하고, 초과 시 사용자에게 경고 메시지를 띄우거나 전송을 차단
   
   
   #구현 내용과 기능 설명
   
     -ListBox.SelectedIndex를 확인하여 사용자가 선택한 특정 메시지만 Items.RemoveAt()으로 개별 삭제하는 기능을 구현
     
     -'대화 기록 전체 삭제' 버튼 클릭 시 Items.Clear()를 통해 모든 대화 내용을 일괄 제거하고 카운트를 초기화
     
     -전송 시 Length를 체크하여 50자가 넘을 경우 MessageBox를 통해 사용자에게 경고를 알리고 전송을 차단


     
