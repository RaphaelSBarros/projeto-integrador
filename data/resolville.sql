-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25/07/2023 às 21:06
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `resolville`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `atendimento_prefeitura`
--

CREATE TABLE `atendimento_prefeitura` (
  `Code_Atendimento` int(11) NOT NULL,
  `ID_Status` int(11) NOT NULL,
  `Setor_Responsavel` varchar(100) NOT NULL,
  `Resposta` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `bairro`
--

CREATE TABLE `bairro` (
  `ID_Bairro` int(11) NOT NULL,
  `Bairro` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `postagem`
--

CREATE TABLE `postagem` (
  `Code_Postagem` int(11) NOT NULL,
  `ID_Status` int(11) NOT NULL,
  `ID_Usuario` int(11) NOT NULL,
  `ID_Bairro` int(11) NOT NULL,
  `Logradouro` varchar(100) NOT NULL,
  `Code_Problema` int(100) NOT NULL,
  `Outros_Problemas` varchar(100) NOT NULL,
  `Foto` blob NULL,
  `Observacao` varchar(100) NOT NULL,
  `Data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `problema`
--

CREATE TABLE `problema` (
  `Code_Problema` int(11) NOT NULL,
  `Problema` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `status_atendimento`
--

CREATE TABLE `status_atendimento` (
  `ID_Status` int(11) NOT NULL,
  `Descricao_Status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `ID_Usuario` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Nome_Usuario` varchar(100) NOT NULL,
  `Senha` varchar(100) NOT NULL,
  `Telefone` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `atendimento_prefeitura`
--
ALTER TABLE `atendimento_prefeitura`
  ADD PRIMARY KEY (`Code_Atendimento`),
  ADD KEY `ID_Status` (`ID_Status`),
  CHANGE `Code_Atendimento` `Code_Atendimento` INT(11) NOT NULL AUTO_INCREMENT;

--
-- Índices de tabela `bairro`
--
ALTER TABLE `bairro`
  ADD PRIMARY KEY (`ID_Bairro`),
  CHANGE `ID_Bairro` `ID_Bairro` INT(11) NOT NULL AUTO_INCREMENT;

--
-- Índices de tabela `postagem`
--
ALTER TABLE `postagem`
  ADD PRIMARY KEY (`Code_Postagem`),
  ADD KEY `ID_Usuario` (`ID_Usuario`),
  ADD KEY `ID_Bairro` (`ID_Bairro`),
  ADD KEY `ID_Status` (`ID_Status`),
  ADD KEY `Code_Problema` (`Code_Problema`),
  CHANGE `Code_Postagem` `Code_Postagem` INT(11) NOT NULL AUTO_INCREMENT;

--
-- Índices de tabela `problema`
--
ALTER TABLE `problema`
  ADD PRIMARY KEY (`Code_Problema`),
  CHANGE `Code_Problema` `Code_Problema` INT(11) NOT NULL AUTO_INCREMENT;
  
--
-- Índices de tabela `status_atendimento`
--
ALTER TABLE `status_atendimento`
  ADD PRIMARY KEY (`ID_Status`),
  CHANGE `ID_Status` `ID_Status` INT(11) NOT NULL AUTO_INCREMENT;

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`ID_Usuario`),
  CHANGE `ID_Usuario` `ID_Usuario` INT(11) NOT NULL AUTO_INCREMENT; 

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `atendimento_prefeitura`
--
ALTER TABLE `atendimento_prefeitura`
  ADD CONSTRAINT `atendimento_prefeitura_ibfk_1` FOREIGN KEY (`ID_Status`) REFERENCES `status_atendimento` (`ID_Status`);

--
-- Restrições para tabelas `postagem`
--
ALTER TABLE `postagem`
  ADD CONSTRAINT `postagem_ibfk_1` FOREIGN KEY (`ID_Usuario`) REFERENCES `usuario` (`id_usuario`),
  ADD CONSTRAINT `postagem_ibfk_2` FOREIGN KEY (`ID_Bairro`) REFERENCES `bairro` (`ID_Bairro`),
  ADD CONSTRAINT `postagem_ibfk_3` FOREIGN KEY (`ID_Status`) REFERENCES `status_atendimento` (`ID_Status`),
  ADD CONSTRAINT `postagem_ibfk_4` FOREIGN KEY (`Code_Problema`) REFERENCES `problema` (`Code_Problema`);
COMMIT;

--
-- ADICIONAR VALORES PARA BAIRROS DE JOINVILLE
--
INSERT INTO `bairro` (`Bairro`) VALUES
  ('Adhemar Garcia'),
  ('América'),
  ('Anita Garibaldi'),
  ('Atiradores'),
  ('Aventureiro'),
  ('Boa Vista'),
  ('Boehmerwald'),
  ('Bom Retiro'),
  ('Bucarein'),
  ('Centro'),
  ('Comasa'),
  ('Costa e Silva'),
  ('Espinheiros'),
  ('Fátima'),
  ('Floresta'),
  ('Glória'),
  ('Guanabara'),
  ('Iririú'),
  ('Itaum'),
  ('Itinga'),
  ('Jardim Iririú'),
  ('Jardim Paraíso'),
  ('Jardim Sophia'),
  ('Jarivatuba'),
  ('Jativoca'),
  ('João Costa'),
  ('Morro do Meio'),
  ('Nova Brasília'),
  ('Parque Guarani'),
  ('Paranaguamirim'),
  ('Petrópolis'),
  ('Pirabeiraba'),
  ('Profipo'),
  ('Saguaçu'),
  ('Santa Catarina'),
  ('Santo Antônio'),
  ('São Marcos'),
  ('Ulysses Guimarães'),
  ('Vila Cubatão'),
  ('Vila Nova'),
  ('Zona Industrial Norte'),
  ('Zona Industrial Tupy');

--
-- ADICIONAR VALORES PARA O STATUS DE ATENDIMENTO
--
INSERT INTO `status_atendimento` (`Descricao_Status`) VALUES 
  ('Em Aguardo'),
  ('Em Andamento'),
  ('Resolvido');

--
-- ADICIONAR VALORES PARA PROBLEMAS DE JOINVILLE
--
INSERT INTO `problema` (`Problema`) VALUES 
  ('Buracos na via'),
  ('Ponto de ônibus danificado'),
  ('Ponto de ônibus sem iluminação'),
  ('Má sinalização na via'),
  ('Valos, córregos e valetas sujos'),
  ('Faixa de pedestre apagada'),
  ('Sugestão de faixa de pedestre na via'),
  ('Semáforo com problema'),
  ('Casa e terrenos abandonados'),
  ('Buraco na ciclovia'),
  ('Repintar faixa da ciclovia'),
  ('Bueiro entupido'),
  ('Bueiro quebrado'),
  ('Buraco na calçada');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
