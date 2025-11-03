# Rating Rush

## Описанеие
Rating Rush – казуальная аркада, в которой игроку необходимо оценивать фильмы на скорость, основываясь на косвенных параметрах, следуя заданному алгоритму. Все фильмы генерируются кодом игры!

## Запуск
- Через файлы репозитория: Rating Rush/bin/Release/Rating Rush.exe
- Через билд лежащий в релизах: build/Rating Rush.exe
  
Очень рекомендуется вручную установить шрифты из папки Fonts

## Скриншоты
Главное меню
![RA main menu](https://github.com/user-attachments/assets/96b234cf-b470-457a-b96d-ee470f7eaf2f)
Геймплей
![RA Movie4](https://github.com/user-attachments/assets/9ea7a0cd-ccff-4989-a049-3992d0d56d13)
![Ra gameplay](https://github.com/user-attachments/assets/5845f8c3-3e1f-4233-912c-f2f89e6b0cdc)
Статистика
![RA staticstics](https://github.com/user-attachments/assets/6848d373-f643-44a1-b330-d294c1a35cef)
![Day RA](https://github.com/user-attachments/assets/aa4c8811-0ab7-4fd7-8dfb-e11afcea3bdd)

## Технические детали:
- Используемые технологии:
	- Язык программирования: C#.
  	- Фреймворки: WinForms, .NET
	- Среда разработки: Visual Studio 2022.

- Структура проекта:
	- Был соблюдён паттерн MVC
	- Model - классы, enum'ы, и интерфейсы в папке Domain
	- View - контроллы в папке Views
	- Controller - метод ChangeStage() в MainForm. Контроллер небольшой, потому что всё управление в игре реализуется с помощью мыши.

- Модульное тестирование:
  	- Все конструкторы и методы классов протестированны с помощью NUnit тестов. С их помощью так же были отточены вероятности при генерации фильмов.

## Презентация
[Rating Rush.pptx](https://github.com/user-attachments/files/23302826/Rating.Rush.pptx)
