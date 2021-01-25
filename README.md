BTS 멤버를 사진으로 예측하는 프로그램
----------
#### (뷔, 정국, 지민만 가능합니다)
#### (예측은 CNN 으로 설계된 모델로 하고, 프로그램은 C# window form 으로 제작했습니다.)
#### BTS-CNN 에 관한 내용은 ![여기](https://github.com/simplepro/bts-cnn) 에서 참고할 수 있습니다.

설치 방법
----------
#### 아래 링크에서 zip 파일을 다운 받은 후, 압축을 풀고, Release 폴더 안에 PRED-BTS.exe 파일을 실행하면 됩니다.
#### https://drive.google.com/file/d/1vBzW0SD81_ER0yWpIYafeP0DElPDQz2P/view?usp=sharing

실행방법
-------
#### 1. 실행화면은 아래와 같습니다.  
![실행화면](https://user-images.githubusercontent.com/66504341/105654697-e5cdae00-5f01-11eb-8c0d-72c54d703855.JPG)

#### 2. 설치되어있는 파이썬 경로를 입력합니다. 예) C:\Users\USER\AppData\Local\Programs\Python\Python38  
#### 필요 패키지 : cv2, keras, numpy (파이썬 권장 버전 : 3.8)  
![파이썬 경로 입력](https://user-images.githubusercontent.com/66504341/105654715-ed8d5280-5f01-11eb-9f35-797dca11f99a.JPG)

#### 3. 이미지 불러오기 버튼을 클릭한 후, 이미지를 선택하면 예측을 하게 됩니다.  
#### (초기실행시 시간이 7 ~ 8초 내외 정도 걸리므로 기다려주세요)  
![결과화면](https://user-images.githubusercontent.com/66504341/105654727-f2520680-5f01-11eb-88bb-458e80cc9fca.JPG)
