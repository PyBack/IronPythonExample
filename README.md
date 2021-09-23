# IronPythonExample

IronPython은 마이크로소프트에서 개발하는 파이썬의 구현 중 하나로, 처음에는 Jim Hugunin이 닷넷 프레임워크와 모노를 위하여 개발하였다.   
버전 1.0은 2006년 9월 5일에 발표되었다. IronPython은 전체가 C#로 작성되어 있다.  
  
.NET 에서 python 코드를 작동시키거나 반대로 python 에서 .NET 코드를 작동시킬 수 있다.

## Example

본 예제는 파이썬 모듈 import, 파이썬 출력함수, 입력함수를 테스트 해보고자 한다. 

### 1. 환경설정
설치프로그램: visual studio 2019, anaconda3

### 2. 테스트
visual studio를 실행해 샘플 콘솔응용프로그램 하나를 준비  
visual studio의 nuget 패키지 관리자를 활용하여  
도구 -> nuget패키지 관리자 -> 패키지 관리자 콘솔을 클릭  
ironPython 다운로드를 위해선 콘솔창에 아래 명령어를 입력  
Install-Package IronPython -Version 2.7.9  
(miniconda2 가 포합되어 있어서 별도 anaconda3 은 설치 할필요 없이 테스트 가능..)
(anacond3 를 활용하기 위해서는 Path 에 경로추가 필요)

### 3.결과
일단 작동은 되나 anaconda3 와 연동을 위해서는 경로추가가 필요  
python3 를 사용하기 위해서는 ironpython3.1이 필요한데 nuget 에서는 제공하지 않아서 별도 설치(.msi)가 필요  
.msi 버전은 프로젝트 라이브러리 참조 방법을 사용해야 한다.  
  
pandas, numpy 모듈 import 는 잘안되는데
ironpython 이 .pyd 와 같은 cpython c-api 는 지원이 되지 않는다.. ([참조](https://stackoverflow.com/questions/30299837/ironpython-unable-to-run-script-that-imports-numpy))  
대안으로 [다른 패키지](https://github.com/pythonnet/pythonnet) 를 활용하는 방법도 있을 수 있을거 같다.



