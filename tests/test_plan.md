### Содержание
  1. [Введение](#1)
  2. [Объект тестирования](#2)
  3. [Риски](#3)
  4. [Аспекты тестирования](#4)<br>
  5. [Подходы к тестированию](#5)
  6. [Представление результатов](#6)
  7. [Выводы](#7)

<a name="1"></a>
### 1. Введение
  Данный файл содержит тест-план приложения **TheWayOut!** Основной целью тестирования является
  проверка приложения на соответствие требованиям.

<a name="2"></a>
### 2. Объект тестирования
Объект тестирования -  приложение **TheWayOut!**
Функция, которую выполняет данное приложение - развитие памяти, логики, решая задания.

1. Функциональность:
+ функциональная полнота: приложение обязано выполнять все заявленные функции;
+ функциональная корректность: приложение должно выполнять все заявленные функции;
+ функциональная целесообразность: отсутствуют незаявленные функции, которые бы мешали приложению выполнять первоначально поставленные задачи.

2. Надёжность:  
+ отсутствие ошибок;   
+ защищённость.  

3. Сопровождаемость:  
+ стабильность;
+ изменяемость.

4. Практичность:  
+ понятность;
+ простота использования;
+ привлекательность;
+ доступность;

<a name="3"></a>
### 3. Риски
К рискам можно отнести следующие пункты:
* Вероятность сбоев в драйвере видеокарты.

<a name="4"></a>
### 4. Аспекты тестирования
К аспектам тестирования относится реализация основных функций приложения:
* Выбор уровня;
* Начать игру;
* Закончить игру;
* Выбор фона;
* Покупка внутриигровой валюты;
* Покупка дополнительного контента;

#### Функциональные требования:

##### Выбор уровня
Этот вариант использования небходимо протестировать на:
1. Кликабельность кнопок
2. Корректность выбора уровня

##### Начать игру
Этот вариант использования небходимо протестировать на:
1. Кликабельность кнопок
2. Возможность начать игру

##### Закончить игру
Этот вариант использования небходимо протестировать на:
1. Кликабельность кнопок
2. Возможность закончить игру

##### Выбор фона
Этот вариант использования небходимо протестировать на:
1. Кликабельность кнопок
2. Корректность выбора фона
3. Корректность установки фона

#### Нефункциональные требования:
1. Понятность. Интуитивный интерфейс и управление.
2. Производительность. Игра не требовательна к ресурсам.
3. Безопасность. Внутриигровые покупки должны осуществляться с помощью безопасных платформ.



<a name="5"></a>
### 5. Подходы к тестированию
Каждый аспект тестирования был произведен с помощью системного тестирования.
Системное тестирование - это тестирование программы в целом.
Каждый тест производится вручную.
Такой метод подходит для небольших проектов.

<a name="6"></a>
### 6. Представление результатов
Результаты тестирования представлены в таблице

Case ID | Case Description | Scenario/Steps | Expected Result | Actual Result | Pass/Fail
:-----: | :--------------: | :------------- | :-------------: | :-----------: | :------:
1|Выбор уровня|1) Нажатие кнопки уровня <br/>|Уровень загрузился|Уровень загрузился|Pass
2|Начать игру|1) Нажатие управляющей кнопки <br/>|Движение объекта|Движение объекта|Pass
3|Закончить игру|1) Нажатие кнопки "Выход" <br/>|Выход в меню|Выход в меню|Pass
4|Выбор фона|1) Нажатие кнопки выбора фона <br/>2) Выбор фона<br/>|Изменение фона на выбранный|Изменение фона на выбранный|Pass

<a name="7"></a>
### 7. Выводы
Данный тестовый план позволяет протестировать основной функционал приложения.
Успешное прохождение всех тестов может свидетельствовать тому, что приложение
соответствует всем заявленным требованиям и стабильно работает.