# AwesomeNet.Unit35

-master первая версия  ( рабочая, без разделений на субпроекты)
 
-   # сделано   на 2023-11-06 16:15 dtnrf -dev-DLL
  - ++Rearanged for spliting to 4 Project -
   + AwesomeNet.Repository  = as MODEL in MVC pattern = Data & Buissnes Rules
   + AwesomeNet.CNTR = as CONTROLLERS in MVC pattern = maneging flow data<>view
   + AwesomeNet.ViewModels =  this are used as layer link for data validation by AutoMapper pack
   + AwesomeNet.Main = as VIEW in  MVC pattern = Main Application then Provide(generate) HTML pages which are Views of our data
   + БЕЗ ТЕСТОВ
     
  # сделано   на 2023-09-06 16:15
 - Глобальные задачи
  - - Регистрация
  - - Авторизация
  - - Страница пользователя с отображением фото, имени
    -  при отображением фото показывается "затычка"
  - - Изменение данных пользователя (форма)
    -   нет инициализауии из данных из SQL BD 
  - - Добавление друзей (из пользователей)
  - - Отправка сообщений друзьям
  - - Синхронизация SQL BD по EF

- - Пакеты доставлены
     +  AutoMapper 12.0.1
     +  AspNetCore.Identity 2.2.0
     +  AspNetCore.Identity.Entity Framework Core 5.0.17
     +  Entity Framework Core 5.0.17
     +  Entity Framework CoreSqlServer  5.0.17
     +  Entity Framework Core Tools  5.0.17
       
# надо делать
 - Автодобавление тестовых пользователей в SQL BD  
  - Общая красота
   - - Страница пользователя с отображением фото, имени
    -  при отображением фото показывается "затычка"
  - - Изменение данных пользователя 
    -   нет инициализауии из данных из SQL BD
