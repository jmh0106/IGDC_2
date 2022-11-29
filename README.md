<a id="readme-top"></a>

# ✨IGDC_2✨
 <p align="center">인하대학교 게임 개발 동아리 IGDC 3팀이 개발하는 게임 프로젝트입니다.</p>

 ## 목차
 1. [프로젝트 소개](#프로젝트-소개)
     + [스테이지 구성](#스테이지-구성)
     + [타워 구성](#타워-구성)
     + [적 구성](#적-구성)
 2. [개발 과정](#개발-과정)
 3. [멤버 구성](#멤버-구성)
 4. [사용 프로그램](#사용-프로그램)
     + [Unity](#unity-ver)
     + [Rider](#rider-ver)
 5. [To-Do List](#to-do-list)
 6. [Commit 규칙](#commit-규칙)
     + [Commit message 구조](#commit-message-구조)
     + [Type](#type)
     + [Subject](#subject)
     + [Body](#body) 

# 프로젝트 소개
인하 디펜스는 과제를 너무 많이 내는 교수님...

## 스테이지 구성
인하대학교의 모습을 스테이지로 만들어서 제작 (스테이지 이미지 첨부)

## 타워 구성
다양한 인하대학교를 과들을 타워로 만들었다. (타워 이미지 첨부)

## 적 구성
교수님과 과제, 시험 등을 적으로 만들었다. (적 이미지 첨부)

<p align="right">(<a href="#readme-top">맨 위로</a>)</p>

# 개발 과정
 **2022.11.23** : 첫 기획 회의

 <p align="right">(<a href="#readme-top">맨 위로</a>)</p>

# 멤버 구성
 |정민호 이미지|박유진 이미지|이종인 이미지|
 |:---:|:---:|:---:|
 |[<img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=GitHub&logoColor=white">](https://github.com/jmh0106)|소개링크|소개링크|
 |개발|개발, 디자인|개발, 기획|

 <p align="right">(<a href="#readme-top">맨 위로</a>)</p>

# 사용 프로그램
 <img src="https://img.shields.io/badge/Unity-2021.3.14f1-Green?style=for-the-badge&logo=unity" id="unity-ver">

 <img src="https://img.shields.io/badge/JetBrains Rider-2021.3.3-Green?style=for-the-badge&logo=rider" id="rider-ver">

 <p align="right">(<a href="#readme-top">맨 위로</a>)</p>

# To-Do List
 - [ ] 게임 외부
   - [ ] 기획서 제작
   - [ ] README 제작
   - [ ] 프로젝트 소개 PPT 제작
   - [ ] 프로젝트 발표하기! 
 - [ ] 게임 씬 제작
   - [ ] 시작 씬
   - [ ] 스테이지 선택 씬
   - [ ] 1 스테이지
   - [ ] 2 스테이지
   - [ ] 3 스테이지
   - [ ] 4 스테이지
   - [ ] 5 스테이지
 - [ ] 게임 시스템 제작
   - [ ] 게임 저장 기능
 - [ ] 게임 UI 개발 
   - [ ] 게임 옵션 화면
 - [ ] 적 개발
 - [ ] 터렛 개발
 - [ ] ✨🎉**프로젝트 빌드하기**✨🎉

 <p align="right">(<a href="#readme-top">맨 위로</a>)</p>

# Commit 규칙
 ## Commit message 구조
 기본적으로 commit message는 제목, 본문, 꼬리말로 구성합니다.
 제못만 필수사항이며, 본문과 꼬리말은 선택사항입니다.
 ```
 <Type>: <Subject>
 
 <Body>
 ```

 ## Type
 >`FEAT` : 새로운 기능 추가, 기존의 기능을 요구 사항에 맞추어 수정   
 >`FIX` : 버그 수정   
 >`BUILD` : 빌드 관련 수정   
 >`DOCS` : 문서 수정   
 >`STYLE` : 스타일 관련 기능(코드 포맷팅, 세미콜론 누락, 코드 자체의 
 >변경이 없는 경우)   
 >`REFACTOR` : 기능의 변화가 아닌 코드 리팩터링 (ex : 변수 이름 변경)   
 >`TEST` : 테스트 코트, 리펙토링 테스트 코드 추가   
 >`CHORE` : 빌드 업무 수정, 패키지 매니저 수정(ex .gitignore 수정 같은 경우)   
 >`RELEASE` : 버전 릴리즈   

 ## Subject
 Type과 함께 제목을 구성합니다. 예를 들어 스테이지를 추가했다면 다음과 같이 적습니다.
 ```
 FEAT: 스테이지 2 추가
 ```
 ```
 FEAT: Add Stage 2
 ```

 ## Body
 헤더로 표현이 가능하다면 생략이 가능합니다. 아닌 경우에는 자세한 내용을 함께 적어 본문을 구성하여 수정사항을 알 수 있게 합니다.
 ```
 FIX: 플레이어 이동

 플레이어가 가끔 더 빠른 속도로 이동하던 버그를 고쳤습니다.
 ```
 ```
 FIX: Player move

 Fixed a bug that sometimes the player moved at a faster speed. 
 ```

 <p align="right">(<a href="#readme-top">맨 위로</a>)</p>