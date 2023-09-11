# AwesomeNet.Unit35

- первая версия  (похоже рабочая версия)
   # сделано   на 2023-09-12 02:15 ветка: dev-DLL-4 ( ветка сделана дополнительно, после сообщеня о невозможности получить рабочий вариант ветки:dev-DLL)
- - вариант от 2023-09-08 18:00 ментора не устроил, новый выгружен в отдельную ветку = dev-DLL-4
- - БЕЗ ТЕСТОВ, ибо на мой взгляд тестирование существенно зависит от разбиения по субпроектам
- - В силу возможности иного(?) разбиения частей проекта DLL слияние в ветку -master не делалось 
  - ++Rearanged for spliting to 4 Project -
   + AwesomeNet.Repository  = as MODEL in MVC pattern = Data & Buissnes Rules
     +  - Models      -  - SQL - Repository -
     +  - Migrations (собственно сюда перенесен её конфигурация, сама миграция не тестировалась)
   + AwesomeNet.CNTR = as CONTROLLERS in MVC pattern = maneging flow data<>view
   + AwesomeNet.ViewModels =  this are used as layer link for data validation by AutoMapper pack
   + AwesomeNet.Main = as VIEW in  MVC pattern = Main Application then Provide(generate) HTML pages which are Views of our data
   
  # сделано   на 2023-09-08 18:00
  ## модификация проекта =  ветка: dev-DLL
- По дополнительному требованию ментора - проект разбит на 3 части, результат выгружен в отдельную ветку = dev-DLL
- -  (в изначальном задании такого требования не было, хотя оно вполне разумно) 
- В силу возможности иного(?) разбиения частей проекта DLL слияние в ветку -master не делалось
- ++ Split to 3 Project -
   + AwesomeNet.Unit35 = Main
   + AwesomeNet.Front = FrontEnd DLL
   + - ViewModels+Mapping  
   + AwesomeNet.Repository = BackEnd DLL
   +  - Models      -  - SQL - Repository -
   +  - Migrations (собственно сюда перенесен её конфигурация, сама миграция не тестировалась)
  ## модификация проекта =  ветка: devevelop
 -  в  ветку - devevelop обработано доплнительное слияние от соразработчика -
 - - косметичекие правки 
  # сделано   на 2023-09-07 16:15
 - Глобальные задачи
  - - Регистрация
  - - Авторизация
  - - Страница пользователя с отображением фото, имени
    -  при отображением фото показывается "затычка" или ссылка из Инета
  - - Изменение данных пользователя  
  - - Добавление друзей (из пользователей)
  - - Отправка сообщений друзьям
  -  - Автодобавление тестовых пользователей  
  - - Синхронизация SQL BD по EF (в ветке dev-migrate слияние с master не делалось специально)
    + + Add - Message -public DateTime TimeStamp { get; set; } 
    + + New SQL DB (Name = AwesomeNet)
    + + TimeStamp отбражается в Chat

- - Пакеты доставлены
     +  AutoMapper 12.0.1
     +  AspNetCore.Identity 2.2.0
     +  AspNetCore.Identity.Entity Framework Core 5.0.17
     +  Entity Framework Core 5.0.17
     +  Entity Framework CoreSqlServer  5.0.17
     +  Entity Framework Core Tools  5.0.17
       
# возможно надо делать
  - Общая красота
   - - Страница пользователя с отображением фото
    -  при отображением фото показывается картинка из БД
  - - Изменение данных пользователя 
    -   кривизна с датой- изначальная(но работает)

  
