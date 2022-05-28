# DBproject

### 프로젝트 주제
  + 헬스장 회원관리 프로그램

### 프로젝트 설명
  + 회원등록 및 관리를 해주는 프로그램
    + 회원 개인정보 저장
    + 트레이너 정보 저장
    + 회원권 구매
    + PT 이용권 구매
    + 회원 운동 일지 작성
  + 트레이너 정보가 있어 회원들이 트레이너를 선택할 때 도움이 된다.
  + 운동 일지를 작성하여 신체 변화를 파악할 수 있게한다.

-----------------------------------------------------------------
![image](https://user-images.githubusercontent.com/48307813/169842317-84b8546e-eb39-419f-a594-1054e8c7f290.png)
-----------------------------------------------------------------
### 요구 사항 명세서
 1. 헬스장에 __회원__ 등록을 하려면 __회원 아이디__, __회원 명__, __생년월일__, __전화번호__, __주소__ 를 입력해야 한다.
 2. 회원은 회원 아이디로 식별한다.
 3. __트레이너__ 에 대한 __트레이너명, 입상 횟수, 관리중인 회원 내역__ 정보를 유지해야 한다.
 4. 트레이너는 트레이너 닉네임으로 식별한다.
 5. 회원은 여러 트레이너를 선택할 수 있고, 한 명의 트레이너가 여러 명의 회원을 레슨 할 수 있다.
 6. 회원이 트레이너를 선택하면 트레이너의 __입상 횟수__ 를 유지해야 한다.
 7. 각 트레이너는 __센터__ 에서 공급하고, 센터 하나에서 여러 트레이너들을 공급할 수다.
 8. 센터에 대한 __센터명, 위치, 전화번호__ 정보를 유지해야 한다.
 9. 센터는 센터명으로 식별한다.
 10. 하나의 센터는 한 명의 __관장__ 이 관리한다.
 11. 관장에 대한 __관장 명, 입상 횟수, 전화번호__ 정보를 유지해야 한다.
 12. PT 이용권에 대한 __PT 시작일자 및 종료일자, PT 이용회원 현황, 가격, 할인율__ 을 유지해야 한다.
-----------------------------------------------------------------
|개체|속성|
|:---:|:---:|
|회원     |회원 아이디, 회원명, 나이, 주소, 전화번호|
|트레이너 |트레이너명, 입상 횟수, 관리 중인 회원 내역|
|센터     |센터명, 위치, 전화번호|
|PT 이용권|PT 시작일자 및 종료일자, 가격, 할인율, PT 이용회원 현황|
|관장     |관장명, 입상 횟수, 전화번호|

|관계|관계에 참여하는 개체|관계 유형|속성|
|:---:|:---:|:---:|:---:|
|PT 이용권 구매|회원(선택), 트레이너(선택)|다대다|PT 시작일자 및 종료일자, PT 이용회원 현황, 가격, 할인율|
|공급 |트레이너(필수),      센터(선택)|일대다|
|관리 |센터(필수), 관장(필수)|일대일|

-----------------------------------------------------------------
### 릴레이션 스키마

![image](https://user-images.githubusercontent.com/48307813/170816741-fd65e58a-a102-46c0-a0af-469eb395e101.png)
-----------------------------------------------------------------
### 테이블 스크립트

![image](https://user-images.githubusercontent.com/48307813/170723029-1f011e7d-8396-4c2f-b667-3ae00dd964e1.png)

## 정규화 과정

  + 제1정규형
  
    + 삽입 이상 : 회원이 PT를 등록하려면 트레이너 닉네임, 센터명, 스케줄을 무조건 알아야함
    + 삭제 이상 : 회원이 등록을 취소하면 트레이너 정보 등 모든 정보 삭제
    + 갱신 이상 : 트레이너가 그만 두는 경우 해당 트레이너가 포함된 행을 모두 변경해야함
    
  + 제2정규형
    
    + 삽입 이상 : 트레이너가 센터에 소속되려면 회원이 반드시 필요
    + 삭제 이상 : 회원이 탈퇴하는 경우 담당 트레이너의 근무지 정보 삭제
    + 갱신 이상 : 트레이너의 근무지가 변경되는 경우 모두 찾아 변경해야 함 (트레이너가 동일한 회원이 여럿 있는 경우)
   
    ![image](https://user-images.githubusercontent.com/48307813/170816537-1f88cc2d-0504-40e3-a18d-09d17495a24b.png)
   
   + 제3정규형
     
     + 삽입 이상 : 새로운 트레이너의 스케줄을 추가하려면 적어도 한명의 회원이 필요
     + 삭제 이상 : 회원이 탈퇴하거나 PT 등록을 취소하면 트레이너가 해당 시간대 담당하는 정보도 같이 삭제
     + 갱신 이상 : 트레이너의 스케줄이 변경되면 일일이 찾아서 수정해야함
     
     ![image](https://user-images.githubusercontent.com/48307813/170816434-9c189d38-a256-438e-be54-594e13e6e440.png)

     
   + 보이스/코드 정규형
      
      ![image](https://user-images.githubusercontent.com/48307813/170816012-be408a1d-6085-4a64-a74e-65d1490da84e.png)

    

    
