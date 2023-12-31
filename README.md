Проект "CRUD на тему пользователей" представляет собой ASP.NET Core Web API для управления списком пользователей с использованием языка C# и .NET Core. В этом проекте реализованы операции CRUD (Create, Read, Update, Delete) для управления пользователями и их ролями. Ниже представлено подробное описание проекта:

Модель данных:

User (Пользователь):
Id (Уникальный идентификатор пользователя)
Name (Имя пользователя)
Age (Возраст пользователя)
Email (Электронная почта пользователя)
UserRoleModels (Связанная сущность "Роль" - множественная связь, один пользователь может иметь несколько ролей).
Контроллеры и операции:

UserController:
Получение списка всех пользователей с поддержкой пагинации, сортировки и фильтрации по различным атрибутам пользователя и роли.
Получение пользователя по Id и всех его ролей.
Добавление новой роли пользователю.
Создание нового пользователя.
Обновление информации о пользователе по Id.
Удаление пользователя по Id.

UserController:
Выдача токена

Бизнес-логика:

Проводится валидация данных в контроллерах, включая проверку наличия обязательных полей (Имя, Возраст, Email), уникальности Email и положительности возраста.
Обработка ошибок и возврат соответствующих статусных кодов HTTP (например, 404 при отсутствии пользователя).
Используемые технологии:

Entity Framework Core  для доступа к данным и сохранения пользователей и ролей в базе данных.
Создание миграций для создания необходимых таблиц в базе данных.
Документирование API с использованием инструментов Swagger.

Этот проект предоставляет полноценное решение для управления пользователями и их ролями, включая систему аутентификации и авторизации с использованием JWT-токенов и разных привилегий на основе ролей.
