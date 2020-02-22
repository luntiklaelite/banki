-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Фев 23 2020 г., 02:04
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `banki`
--

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `fio` varchar(45) NOT NULL,
  `login` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `datebirth` date NOT NULL,
  `role` tinyint(45) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=14 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id_user`, `fio`, `login`, `pass`, `datebirth`, `role`) VALUES
(1, 'КАЛИНИН АЛЕКСАНДР ВЛАДИМИРОВИЧ', 'admin', 'admin', '2003-08-06', 0),
(2, 'КУТУЗОВ ПАВЕЛ ДЕНИСОВИЧ', 'pavelKutuz', 'pashOchka123', '2003-02-03', 1),
(3, 'ИЛЬИН АЛЕКСЕЙ ВАЛЕРЬЕВИЧ', 'fl00fy', 'alexey1488', '2003-03-25', 1),
(4, 'БОРОВ ВАЛЕРИЙ САНЫЧ', 'manager', 'manager', '2003-08-06', 2),
(6, 'Горыныч Иван Палыч', 'gorynych', 'simsim', '2005-01-01', 0),
(7, 'Тётка Аднуб Валерьевич', 'adnub', '123123', '2001-01-22', 0),
(8, 'Дикарев Александр Сергеевич', 'dikarev123', 'pass123', '1999-02-18', 0),
(9, 'Сухарев Александр Васильевич', 'sashasuhar', 'pass123', '2000-01-23', 1),
(10, 'Бабариха Луиза Степановна', 'luiza', '123123', '2002-04-18', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `vkladi`
--

CREATE TABLE IF NOT EXISTS `vkladi` (
  `vklad_id` int(11) NOT NULL AUTO_INCREMENT,
  `depId` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `vklad_sum` double NOT NULL,
  `date_vlozh` date NOT NULL,
  PRIMARY KEY (`vklad_id`),
  KEY `depId` (`depId`),
  KEY `userId` (`userId`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=14 ;

--
-- Дамп данных таблицы `vkladi`
--

INSERT INTO `vkladi` (`vklad_id`, `depId`, `userId`, `vklad_sum`, `date_vlozh`) VALUES
(1, 1, 2, 100000, '2003-11-02'),
(2, 2, 2, 59234, '2003-11-02'),
(3, 1, 3, 500, '2003-11-02'),
(5, 1, 3, 30000, '2003-11-02'),
(6, 2, 3, 10000, '2003-11-02'),
(11, 4, 4, 123, '2020-02-22'),
(12, 2, 1, 123, '2020-02-22'),
(13, 1, 10, 1541242, '2020-02-23');

-- --------------------------------------------------------

--
-- Структура таблицы `vkladi_have`
--

CREATE TABLE IF NOT EXISTS `vkladi_have` (
  `depositid` int(11) NOT NULL AUTO_INCREMENT,
  `depName` varchar(64) NOT NULL,
  `depProc` double NOT NULL,
  `depTime` int(11) NOT NULL,
  `depDescr` varchar(255) NOT NULL,
  `depActive` tinyint(1) NOT NULL,
  PRIMARY KEY (`depositid`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `vkladi_have`
--

INSERT INTO `vkladi_have` (`depositid`, `depName`, `depProc`, `depTime`, `depDescr`, `depActive`) VALUES
(1, 'Лучший', 12.42, 365, 'Наилучший вклад для вас, что только можно придумать.', 1),
(2, 'Быстрый', 4, 90, 'Есть нечего? Потерпи 3 месяца и получи свои копейки.', 1),
(3, 'БОЖЕСТВЕННЫЙ', 200, 365, 'Пасхалочка', 0),
(4, 'Нужный', 2.44, 365, 'Не важно', 1);

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `vkladi`
--
ALTER TABLE `vkladi`
  ADD CONSTRAINT `vkladi_ibfk_1` FOREIGN KEY (`depId`) REFERENCES `vkladi_have` (`depositid`),
  ADD CONSTRAINT `vkladi_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `users` (`id_user`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
