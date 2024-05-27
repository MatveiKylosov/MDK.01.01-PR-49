-- Создание схемы ISP_21_2_10
CREATE SCHEMA IF NOT EXISTS ISP_21_2_10;

-- Используем созданную схему
USE ISP_21_2_10;

-- Создание таблицы Users
CREATE TABLE `Users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(255) DEFAULT NULL,
  `Login` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Добавление 10 записей в таблицу Users
INSERT INTO Users (Email, Login, Password) VALUES
    ('user1@example.com', 'user1', 'password1'),
    ('user2@example.com', 'user2', 'password2'),
    ('user3@example.com', 'user3', 'password3'),
    ('user4@example.com', 'user4', 'password4'),
    ('user5@example.com', 'user5', 'password5'),
    ('user6@example.com', 'user6', 'password6'),
    ('user7@example.com', 'user7', 'password7'),
    ('user8@example.com', 'user8', 'password8'),
    ('user9@example.com', 'user9', 'password9'),
    ('user10@example.com', 'user10', 'password10');

-- Создание таблицы Versions
CREATE TABLE `Versions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `VersionString` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Добавление 10 записей в таблицу Versions
INSERT INTO Versions (VersionString) VALUES
    ('1.0'),
    ('1.1'),
    ('2.0'),
    ('2.1'),
    ('3.0'),
    ('3.1'),
    ('4.0'),
    ('4.1'),
    ('5.0'),
    ('5.1');

-- Создание таблицы Dishes
CREATE TABLE `Dishes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Category` varchar(255) DEFAULT NULL,
  `NameDish` varchar(255) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Icon` varchar(255) DEFAULT NULL,
  `VersionId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `VersionId` (`VersionId`),
  CONSTRAINT `dishes_ibfk_1` FOREIGN KEY (`VersionId`) REFERENCES `Versions` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Добавление 10 записей в таблицу Dishes
INSERT INTO Dishes (Category, NameDish, Price, Icon, VersionId) VALUES
    ('Category A', 'Dish 1', 12.50, 'icon1.png', 1),
    ('Category B', 'Dish 2', 15.00, 'icon2.png', 2),
    ('Category A', 'Dish 3', 18.75, 'icon3.png', 3),
    ('Category C', 'Dish 4', 20.00, 'icon4.png', 4),
    ('Category B', 'Dish 5', 14.50, 'icon5.png', 5),
    ('Category A', 'Dish 6', 16.80, 'icon6.png', 6),
    ('Category C', 'Dish 7', 22.30, 'icon7.png', 7),
    ('Category B', 'Dish 8', 19.90, 'icon8.png', 8),
    ('Category A', 'Dish 9', 21.40, 'icon9.png', 9),
    ('Category C', 'Dish 10', 24.60, 'icon10.png', 9);

-- Создание таблицы Orders
CREATE TABLE `Orders` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Address` varchar(255) DEFAULT NULL,
  `Date` datetime DEFAULT NULL,
  `DishId` int DEFAULT NULL,
  `Count` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `DishId` (`DishId`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`DishId`) REFERENCES `Dishes` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Добавление 10 записей в таблицу Orders
INSERT INTO Orders (Address, Date, DishId, Count) VALUES
    ('123 Main St', '2024-05-27 14:30:00', 1, 2),
    ('456 Elm St', '2024-05-27 15:15:00', 3, 3),
    ('789 Oak St', '2024-05-27 16:00:00', 5, 1),
    ('101 Maple Ave', '2024-05-27 17:45:00', 7, 4),
    ('222 Pine Rd', '2024-05-27 18:30:00', 9, 2),
    ('333 Cedar Ln', '2024-05-27 19:15:00', 2, 1),
    ('444 Birch Blvd', '2024-05-27 20:00:00', 4, 3),
    ('555 Willow Dr', '2024-05-27 20:45:00', 6, 2),
    ('666 Spruce Ct', '2024-05-27 21:30:00', 8, 1),
    ('777 Fir Ave', '2024-05-27 22:15:00', 10, 3);
