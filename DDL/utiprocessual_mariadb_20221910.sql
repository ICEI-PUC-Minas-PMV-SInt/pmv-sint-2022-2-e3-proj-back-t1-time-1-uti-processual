CREATE DATABASE IF NOT EXISTS `utiprocessual` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

-- utiprocessual.cadastroprocessos definition

CREATE TABLE `cadastroprocessos` (
  `Id` char(36) CHARACTER SET ascii NOT NULL,
  `NumeroProcessoPenal` int(11) NOT NULL,
  `TipoPenal` longtext NOT NULL,
  `LocalDoCrime` longtext NOT NULL,
  `DataDoCrime` datetime(6) NOT NULL,
  `NumeroPCNET` int(11) NOT NULL,
  `NumeroREDS` int(11) NOT NULL,
  `NumInqueritoPolicial` int(11) NOT NULL,
  `NomeReu` longtext NOT NULL,
  `FiliacaoReu` longtext NOT NULL,
  `DataNascReu` datetime(6) NOT NULL,
  `NaturalidadeReu` longtext NOT NULL,
  `EnderecoReu` longtext NOT NULL,
  `TelefoneReu` int(11) NOT NULL,
  `Advogado` longtext NOT NULL,
  `OABAdvogado` longtext NOT NULL,
  `DefensoriaPublica` longtext NOT NULL,
  `Status` int(1),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- utiprocessual.user definition

CREATE TABLE `user` (
  `UserId` char(36) CHARACTER SET ascii NOT NULL,
  `Nome` longtext NOT NULL,
  `Sobrenome` longtext NOT NULL,
  `Email` longtext NOT NULL,
  `Senha` varchar(50) NOT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
