# AwesomeNet.Unit35

- первая версия  (похоже рабочая версия)
  # сделано   на 2023-09-08 16:15 
- По дополнительному требованию ментора - проект разбит на 3 части результат выгружен в отдельную ветка = dev-DLL
- ++ Split to 3 Project -
   + AwesomeNet.Unit35 = Main
   + AwesomeNet.Front  - ViewModels+Mapping  = FrontEnd DLL
   + AwesomeNet.Repository = BackEnd DLL
   +   - - Models - SQL - Repository -
         -         -- Migrations
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

  
