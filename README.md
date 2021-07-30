# 개요

MVVM 패턴의 이해도, WPF 구현 내용, 코딩 스타일을 파악 할 수 있을 것이라 판단되어 해당 솔루션을 제작.

# 내용

## 개발 환경

* 도구 - VisualStudio 2019
* 언어 - C# .Net Framework 4.6.1

## UI

* 기본 사항 입력을 선택했을때 내용 출력

  ![image](https://user-images.githubusercontent.com/23272977/127709344-05e29c00-4dea-4d68-8e27-3bf9e0ff8e5b.png) ![image](https://user-images.githubusercontent.com/23272977/127709422-2c10dcbd-7bce-4e3b-aa62-fe57c385cf6c.png)

## 구조

  ![Flow](https://user-images.githubusercontent.com/23272977/127708940-7418300e-fd81-4503-a8d6-ea8c396649c3.png)

## 적용 내용

* 솔루션 관리
  * View, ViewModel, Model로 3개의 프로젝트로 구분지어 처리
* MVVM 패턴 적용
  * View는 ViewModel을 알지만 ViewModel은 View를 알지 못하는 단방향 구조로 구성
