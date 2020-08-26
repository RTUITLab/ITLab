To Do
# Зарплаты сотрудников

Источники зарплат:
* События
* Проекты
* Отчеты
* Поощрения

Оплата состоит из суммы и комментария к ней.

Администратор - как правило единственное лицо, директор ИТ.

## События

Предполагаемая стоимость участия за:
* Событие
* Смену
* Место

Конечная зп каждого сотрудника утверждается администратором

## Проекты

Сущности:

* Проект
    * Кодовое название
    * Описание
* Версия проекта
    * Требования
    * Бюджет
* Требование к версии проекта
    * Описание требования
    * Направление требования (технологическая сфера-tag)
    * Исполнитель

Роли
* Исполнитель
* Тимлид
* Эксперт в технической сфере
* Администратор

**Исполнитель** - любой сотрудник лаборатории,как правило, является членом команды проекта.

Выполняет требование.

**Тимлид** прикрепляется на время к проекту, следит за разработкой. 

Формирует требования и подтверждает факт их выполнения.

Рекомендует для каждого выполненного требования оплату. Данная рекомендация видна ему и администратору.

**Эксперт в технической сфере** может рекомендовать оплату зя любое требование в любое проекте, при наличии соответствующего его направлению тега на требовании. Данная рекомендация видна ему и администратору.

**Администратор** на основании предложений от тимлидов и экспертов назначает финальную выплату сотруднику, которая видна тимлиду, и экспертам.

![](docs/img/Projects.png)

## Панель администратора

## Панель пользователя