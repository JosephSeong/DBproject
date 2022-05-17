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
![image](https://user-images.githubusercontent.com/48307813/168596752-e3ba225a-c123-4375-aed8-ed2f5034824c.png)
-----------------------------------------------------------------
### 요구 사항 명세서
 1. 헬스장에 __회원__ 등록을 하려면 __회원 아이디__, __회원 명__, __생년월일__, __전화번호__, __주소__ 를 입력해야 한다.
 2. 회원은 회원 아이디로 식별한다.
 3. __트레이너__ 에 대한 __트레이너명, 입상 정보, 관리중인 회원 내역__ 정보를 유지해야 한다.
 4. 트레이너는 트레이너명으로 식별한다.
 5. 회원은 여러 트레이너를 선택할 수 있고, 한 명의 트레이너가 여러 명의 회원을 레슨 할 수 있다.
 6. 회원이 트레이너를 선택하면 트레이너의 __입상 정보__ 를 유지해야 한다.
 7. 각 트레이너는 __센터__ 에서 공급하고, 센터 하나에서 여러 트레이너들을 공급할 수다.
 8. 센터에 대한 __센터명, 위치, 전화번호__ 정보를 유지해야 한다.
 9. 센터는 센터명으로 식별한다.
 10. 하나의 센터는 한 명의 __관장__ 이 관리한다.
 11. 관장에 대한 __관장 명, 입상 정보, 전화번호__ 정보를 유지해야 한다.
 12. PT 이용권에 대한 __PT 시작일자 및 종료일자, PT 이용회원 현황, 가격, 할인율__ 을 유지해야 한다.
-----------------------------------------------------------------
|개체|속성|
|:---:|:---:|
|회원     |회원 아이디, 회원명, 나이, 주소, 전화번호|
|트레이너 |트레이너명, 입상 정보, 관리 중인 회원 내역|
|센터     |센터명, 위치, 전화번호|
|PT 이용권|PT 시작일자 및 종료일자, 가격, 할인율, PT 이용회원 현황|
|관장     |관장명, 입상 정보, 전화번호|
