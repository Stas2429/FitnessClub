## 🏋️ Fitness Club Database

### 👥 Client

**ID** – Уникальный идентификатор клиента\
**Name** – Имя клиента\
**Surname** – Фамилия клиента\
**Patronymic** – Отчество клиента\
**Date of birth** – Дата рождения\
**Gender** – Пол клиента

### 🏋️‍♂️ Trainer

**ID** – Уникальный идентификатор тренера\
**Name** – Имя тренера\
**Surname** – Фамилия тренера\
**Patronymic** – Отчество тренера\
**Date of birth** – Дата рождения\
**Gender** – Пол тренера

### 📅 Class

**ID** – Уникальный идентификатор класса\
**Name** – Название класса\
**Time** – Длительность занятия\
**Cost** – Стоимость\
**Max number** – Максимальное количество участников

### ⏳ Schedule

**ID** – Уникальный идентификатор расписания\
**Date** – Дата проведения\
**Date begin** – Время начала\
**Date end** – Время окончания

### 🎫 Subscription

**ID** – Уникальный идентификатор абонемента\
**Name** – Название абонемента

### 📌 Reserv

**ID\_Reserv** – Уникальный идентификатор бронирования\
**ID\_Class** – Связь с классом\
**ID\_Trainer** – Связь с тренером\
**Type** – Тип бронирования\
**Number** – Количество участников

### 🔄 Client/Reserv

**ID\_Client** – Связь с клиентом\
**ID\_Reserv** – Связь с бронированием

### 🔄 Trainer/Reserv

**ID\_Reserv** – Связь с бронированием\
**ID\_Trainer** – Связь с тренером

### 🔄 Schedule/Reserv

**ID\_Reserv** – Связь с бронированием\
**ID\_Schedule** – Связь с расписанием

### 🔄 Subscription/Reserv

**ID\_Subscription** – Связь с абонементом\
**ID\_Reserv** – Связь с бронированием

### 🔗 Связи между сущностями:

- Client/1 > Client/Reserv/M
- Trainer/1 > Trainer/Reserv/M
- Class/1 > Reserv/M
- Schedule/1 > Schedule/Reserv/M
- Subscription/1 > Subscription/Reserv/M
- Reserv/1 > Client/Reserv/M
- Reserv/1 > Trainer/Reserv/M
- Reserv/1 > Schedule/Reserv/M
- Reserv/1 > Subscription/Reserv/M

