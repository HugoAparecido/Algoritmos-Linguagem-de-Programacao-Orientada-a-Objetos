-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 22-Out-2023 às 17:05
-- Versão do servidor: 8.0.31
-- versão do PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro_escolar`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aluno`
--

DROP TABLE IF EXISTS `aluno`;
CREATE TABLE IF NOT EXISTS `aluno` (
  `Ra` char(14) NOT NULL,
  `nome` varchar(65) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `endereco` varchar(160) NOT NULL,
  `telefone` varchar(14) NOT NULL,
  `email` varchar(60) NOT NULL,
  `curso` varchar(60) NOT NULL,
  `nota_Bim1` double NOT NULL,
  `nota_Bim2` double NOT NULL,
  `nota_Bim3` double NOT NULL,
  `nota_Bim4` double NOT NULL,
  `media` double NOT NULL,
  PRIMARY KEY (`Ra`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `aluno`
--

INSERT INTO `aluno` (`Ra`, `nome`, `cpf`, `endereco`, `telefone`, `email`, `curso`, `nota_Bim1`, `nota_Bim2`, `nota_Bim3`, `nota_Bim4`, `media`) VALUES
('16543789080-98', 'Andrus Neves Romam', '904.786.908-90', 'andrus.neves@gmail.com', 'Informática', '(19)78964-9024', 'Rua Praça Nova 98', 10, 9, 8, 2, 7),
('78965431989-13', 'Júlia Eduarda Carvalho', '876.345.908-12', 'Administração', 'juju.dudu@gmai', 'Rua Alexandre Fleming 747', '(18)09456-3420', 7, 9, 10, 5, 7),
('56723987156-90', 'Hugo Aparecido Gregorio de Almeida', '245.908.564-34', 'Rua Alexandre Fleming 747', '(18)90876-2387', 'hugoapga626@gmail.com', 'Informática', 10, 10, 10, 8, 9);

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso`
--

DROP TABLE IF EXISTS `curso`;
CREATE TABLE IF NOT EXISTS `curso` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(65) NOT NULL,
  `cargaHoraria` int NOT NULL,
  `periodo` varchar(25) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `curso`
--

INSERT INTO `curso` (`codigo`, `nome`, `cargaHoraria`, `periodo`) VALUES
(1, 'Administração', 100, 'Diurno'),
(2, 'Informática', 200, 'Integral'),
(3, 'Engenharia da Computação', 140, 'Integral'),
(4, 'Licenciatura em Matemática', 140, 'Integral');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
