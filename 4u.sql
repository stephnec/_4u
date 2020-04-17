-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 06-Nov-2018 às 01:07
-- Versão do servidor: 10.1.36-MariaDB
-- versão do PHP: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `4u`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `data_nascimento` date NOT NULL,
  `telefone` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `tipo_cliente` tinyint(1) NOT NULL,
  `cpf` varchar(255) DEFAULT NULL,
  `cnpj` varchar(255) DEFAULT NULL,
  `cep` varchar(255) NOT NULL,
  `estado` varchar(255) NOT NULL,
  `cidade` varchar(255) NOT NULL,
  `rua` varchar(255) NOT NULL,
  `numero_residencia` int(11) NOT NULL,
  `complemento` varchar(255) DEFAULT NULL,
  `servico` varchar(255) NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT '1',
  `criado` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modificado` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id`, `nome`, `data_nascimento`, `telefone`, `email`, `tipo_cliente`, `cpf`, `cnpj`, `cep`, `estado`, `cidade`, `rua`, `numero_residencia`, `complemento`, `servico`, `ativo`, `criado`, `modificado`) VALUES
(1, 'jão', '1990-07-12', '(11) 1111-1111', 'jao@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 23, '', 'Games', 1, '2018-10-21 12:29:45', '2018-11-02 19:04:32'),
(2, 'Maria', '1997-05-03', '(11) 2222-2222', 'tresmarias@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 345, '63', 'Edição de Vídeo', 1, '2018-10-21 12:35:43', '2018-11-02 19:09:08'),
(3, 'Carlos', '1986-07-23', '(11) 1234-4123', 'carlos@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 7897, '24', 'Desenvolvimento Mobile', 1, '2018-11-02 19:20:44', '2018-11-02 19:20:44'),
(4, 'Enzo', '1999-10-10', '(11) 6666-6666', 'enzo@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 234, '', 'Games', 1, '2018-11-02 19:22:09', '2018-11-02 19:22:09'),
(5, 'Valentina', '1999-02-23', '(11) 4444-4444', 'val_entina@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 4309, '89', 'Edição de Vídeo', 1, '2018-11-02 19:24:08', '2018-11-02 19:24:08'),
(6, 'Pedro', '1982-09-28', '(11) 92345-6789', 'pedro@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 1234, '', 'Banco de Dados', 1, '2018-11-02 19:34:08', '2018-11-02 19:34:08'),
(7, 'Laura', '1994-11-29', '(11) 97382-7383', 'laura@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 2131, '', 'Design Gráfico', 1, '2018-11-02 19:35:23', '2018-11-02 19:35:23'),
(8, 'Camila', '1997-03-03', '(11) 91230-1023', 'camila@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538000', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 3456, '12', 'WebDesign', 1, '2018-11-02 19:36:24', '2018-11-02 19:36:24'),
(9, 'Jeremias', '1983-05-12', '(11) 98293-8293', 'jeremias@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 6532, '659', 'WebDesign', 1, '2018-11-02 19:38:33', '2018-11-02 19:38:33'),
(10, 'Eduardo', '1998-12-08', '(11) 98393-3938', 'edu@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 153, '748-C', 'Desenvolvimento Mobile', 1, '2018-11-02 19:40:50', '2018-11-02 19:40:50'),
(11, 'FIAP', '2018-01-01', '(11) 97289-2828', 'fiap@email.com', 1, '   .   .   -', '12.312.312/3123-12', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 2222, '', 'WebDesign', 1, '2018-11-02 19:43:06', '2018-11-02 19:43:06');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `data_nascimento` date NOT NULL,
  `telefone` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `tipo_funcionario` tinyint(1) NOT NULL,
  `cpf` varchar(255) DEFAULT NULL,
  `cnpj` varchar(255) DEFAULT NULL,
  `cep` varchar(255) NOT NULL,
  `estado` varchar(255) NOT NULL,
  `cidade` varchar(255) NOT NULL,
  `rua` varchar(255) NOT NULL,
  `numero_residencia` int(11) NOT NULL,
  `complemento` varchar(255) DEFAULT NULL,
  `cargo` varchar(255) NOT NULL,
  `setor` varchar(255) NOT NULL,
  `data_admissao` date NOT NULL,
  `data_demissao` date DEFAULT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT '1',
  `criado` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modificado` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id`, `nome`, `data_nascimento`, `telefone`, `email`, `tipo_funcionario`, `cpf`, `cnpj`, `cep`, `estado`, `cidade`, `rua`, `numero_residencia`, `complemento`, `cargo`, `setor`, `data_admissao`, `data_demissao`, `ativo`, `criado`, `modificado`) VALUES
(1, 'Stephane', '2001-11-28', '(11) 91111-1111', 'stephane@email.com', 0, '123.456.789-12', '', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 1234, '12A', 'Desenvolvedor de Softwares', 'Desenvolvimento', '2018-10-12', NULL, 1, '2018-10-21 13:29:48', '2018-10-21 15:20:49'),
(2, 'abc', '2016-02-10', '1234-1234', 'asb@asb.com', 0, '123.123.123-12', NULL, '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 12, '123A', 'Estágiario', 'Operacional', '2018-10-10', NULL, 1, '2018-10-21 16:23:05', '2018-10-21 16:23:05'),
(3, 'Ana', '2001-01-11', '(11) 91111-1111', 'ana@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 484, '15', 'Designer Gráfico', 'Desenvolvimento', '2018-10-21', NULL, 1, '2018-11-02 19:56:27', '2018-11-02 19:56:27'),
(4, 'karlos', '2000-11-02', '(11) 91111-1111', 'karlos@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 563, '', 'Programador', 'Desenvolvimento', '2018-10-10', NULL, 1, '2018-11-02 20:38:05', '2018-11-02 20:38:05'),
(5, 'Carol', '2002-05-28', '(11) 91111-1111', 'carol@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 5279, '', 'WebDesigner', 'Desenvolvimento', '2018-10-10', NULL, 1, '2018-11-02 20:41:50', '2018-11-02 20:41:50'),
(6, 'Nalita', '2002-10-08', '(11) 91111-1111', 'nalita@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 683, '', 'Desenvolvedor de Softwares', 'Desenvolvimento', '2018-10-10', NULL, 1, '2018-11-02 20:51:16', '2018-11-02 20:51:16'),
(7, 'Joana', '1999-04-12', '(11) 98391-2088', 'joana@email.com', 0, '123.123.123-12', '  .   .   /    -', '01538001', 'SP', 'São Paulo', 'Avenida Lins de Vasconcelos', 7129, '93', 'Estagiário', 'Operacional', '2018-11-01', NULL, 1, '2018-11-02 20:57:02', '2018-11-02 20:57:02');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `funcionario_id` int(11) NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT '1',
  `criado` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `modificado` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `senha`, `funcionario_id`, `ativo`, `criado`, `modificado`) VALUES
(1, 'abc', 'asdb@adff.com', '123', 2, 1, '2018-10-21 16:24:37', '2018-10-21 16:24:37');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `funcionario_id` (`funcionario_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`funcionario_id`) REFERENCES `funcionarios` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
