-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: locadora_veiculo
-- ------------------------------------------------------
-- Server version	5.7.16-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `COD_CATEGORIA` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) NOT NULL,
  `VALOR` decimal(5,2) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_CATEGORIA`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (14,'Econômico',60.00,1);
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `checklist`
--

DROP TABLE IF EXISTS `checklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checklist` (
  `COD_CHECKLIST` int(11) NOT NULL AUTO_INCREMENT,
  `OBSERVACAO` longtext NOT NULL,
  `STATUS_CHECKLIST` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_CHECKLIST`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checklist`
--

LOCK TABLES `checklist` WRITE;
/*!40000 ALTER TABLE `checklist` DISABLE KEYS */;
INSERT INTO `checklist` VALUES (5,'Ok',0,1);
/*!40000 ALTER TABLE `checklist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `COD_CLIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `EMAIL` varchar(50) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  `ENDERECO_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`COD_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (16,'matheus.quintaes@gmail.com',1,20),(17,'ipiranga@ipiranga.com.br',1,21);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documento`
--

DROP TABLE IF EXISTS `documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `documento` (
  `COD_DOCUMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `RENAVAM` varchar(20) NOT NULL,
  `CHASSI` varchar(20) NOT NULL,
  `PLACA` varchar(10) NOT NULL,
  `MES_DATA_LICENCIAMENTO` varchar(25) NOT NULL,
  `COD_VEICULO` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  `ANO_DATA_LICENCIAMENTO` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`COD_DOCUMENTO`),
  KEY `COD_VEICULO` (`COD_VEICULO`),
  CONSTRAINT `documento_ibfk_1` FOREIGN KEY (`COD_VEICULO`) REFERENCES `veiculo` (`COD_VEICULO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documento`
--

LOCK TABLES `documento` WRITE;
/*!40000 ALTER TABLE `documento` DISABLE KEYS */;
INSERT INTO `documento` VALUES (5,'639884962','9BW ZZZ377 VT 004','EKJ-1545','Fevereiro',7,1,'2016');
/*!40000 ALTER TABLE `documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `endereco` (
  `ENDERECO_ID` int(11) NOT NULL AUTO_INCREMENT,
  `CEP` varchar(20) NOT NULL,
  `BAIRRO` varchar(50) NOT NULL,
  `LOGRADOURO` varchar(70) NOT NULL,
  `NUMERO` int(11) NOT NULL,
  `CIDADE` varchar(50) NOT NULL,
  `ESTADO` varchar(5) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`ENDERECO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (19,'70710-500','Rural','St Comercial Norte (Scn)',2,'Brasilia','DF',1),(20,'14090-550','Jd Castelo branco novo','Rua São Francisco de Assis',325,'Ribeirão Preto','SP',1),(21,'14090-550','Jd Castelo branco Novo','Rua Sao Francisco de Assis',325,'Ribeirão Preto','SP',1);
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedor` (
  `COD_FORNECEDOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_FANTASIA` varchar(50) NOT NULL,
  `RAZAO_SOCIAL` varchar(50) NOT NULL,
  `CNPJ` varchar(20) NOT NULL,
  `INSCRICAO_ESTADUAL` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `ENDERECO_ID` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_FORNECEDOR`),
  KEY `ENDERECO_ID` (`ENDERECO_ID`),
  CONSTRAINT `fornecedor_ibfk_1` FOREIGN KEY (`ENDERECO_ID`) REFERENCES `endereco` (`ENDERECO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (5,'Fiat','Fiat Automóveis Ltda',' 16.701.716/0001-56','111.111.111.111','fiat@fiat.com.br',19,1);
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_conformidade`
--

DROP TABLE IF EXISTS `item_conformidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_conformidade` (
  `COD_ITEM` int(11) NOT NULL AUTO_INCREMENT,
  `ITEM` varchar(50) NOT NULL,
  `COD_CHECKLIST` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_ITEM`),
  KEY `COD_CHECKLIST` (`COD_CHECKLIST`),
  CONSTRAINT `item_conformidade_ibfk_1` FOREIGN KEY (`COD_CHECKLIST`) REFERENCES `checklist` (`COD_CHECKLIST`)
) ENGINE=InnoDB AUTO_INCREMENT=154 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_conformidade`
--

LOCK TABLES `item_conformidade` WRITE;
/*!40000 ALTER TABLE `item_conformidade` DISABLE KEYS */;
INSERT INTO `item_conformidade` VALUES (150,'radioButton_CBuzina',5,1),(151,'radioButton_CFarol',5,1),(152,'radioButton_CParabrisa',5,1),(153,'radioButton_CSetas',5,1);
/*!40000 ALTER TABLE `item_conformidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manutencao`
--

DROP TABLE IF EXISTS `manutencao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `manutencao` (
  `COD_MANUTENCAO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO_MANUTENCAO` int(11) NOT NULL,
  `OBSERVACAO` longtext NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_MANUTENCAO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manutencao`
--

LOCK TABLES `manutencao` WRITE;
/*!40000 ALTER TABLE `manutencao` DISABLE KEYS */;
/*!40000 ALTER TABLE `manutencao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nivel_permissao_usuario`
--

DROP TABLE IF EXISTS `nivel_permissao_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nivel_permissao_usuario` (
  `COD_NIVEL_PERMISSAO_USUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `NIVEL_PERMISSAO` varchar(20) NOT NULL,
  `COD_USUARIO` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_NIVEL_PERMISSAO_USUARIO`),
  KEY `COD_USUARIO` (`COD_USUARIO`),
  CONSTRAINT `nivel_permissao_usuario_ibfk_1` FOREIGN KEY (`COD_USUARIO`) REFERENCES `usuario` (`COD_USUARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nivel_permissao_usuario`
--

LOCK TABLES `nivel_permissao_usuario` WRITE;
/*!40000 ALTER TABLE `nivel_permissao_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `nivel_permissao_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissao`
--

DROP TABLE IF EXISTS `permissao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permissao` (
  `COD_PERMISSAO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO` int(11) NOT NULL,
  `DESCRICAO` longtext NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_PERMISSAO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissao`
--

LOCK TABLES `permissao` WRITE;
/*!40000 ALTER TABLE `permissao` DISABLE KEYS */;
INSERT INTO `permissao` VALUES (1,1,'Administrador',1),(2,1,'Comum',1);
/*!40000 ALTER TABLE `permissao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa_fisica`
--

DROP TABLE IF EXISTS `pessoa_fisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa_fisica` (
  `COD_PESSOA_FISICA` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `CPF` varchar(15) NOT NULL,
  `DATA_NASCIMENTO` varchar(50) NOT NULL,
  `CNH` varchar(20) NOT NULL,
  `PASSAPORTE` varchar(20) NOT NULL,
  `NATURALIDADE` varchar(20) NOT NULL,
  `COD_CLIENTE` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_PESSOA_FISICA`),
  KEY `COD_CLIENTE` (`COD_CLIENTE`),
  CONSTRAINT `pessoa_fisica_ibfk_1` FOREIGN KEY (`COD_CLIENTE`) REFERENCES `cliente` (`COD_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa_fisica`
--

LOCK TABLES `pessoa_fisica` WRITE;
/*!40000 ALTER TABLE `pessoa_fisica` DISABLE KEYS */;
INSERT INTO `pessoa_fisica` VALUES (7,'Matheus Quintães de Castro','48.311.552-6','366.098.738-79','15/02/1991','48311111111','465454646545646564','brasileiro',16,1);
/*!40000 ALTER TABLE `pessoa_fisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa_juridica`
--

DROP TABLE IF EXISTS `pessoa_juridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa_juridica` (
  `COD_PESSOA_JURIDICA` int(11) NOT NULL AUTO_INCREMENT,
  `NOME_FANTASIA` varchar(50) NOT NULL,
  `RAZAO_SOCIAL` varchar(50) NOT NULL,
  `CNPJ` varchar(20) NOT NULL,
  `INSCRICAO_ESTADUAL` varchar(50) NOT NULL,
  `COD_CLIENTE` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_PESSOA_JURIDICA`),
  KEY `COD_CLIENTE` (`COD_CLIENTE`),
  CONSTRAINT `pessoa_juridica_ibfk_1` FOREIGN KEY (`COD_CLIENTE`) REFERENCES `cliente` (`COD_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa_juridica`
--

LOCK TABLES `pessoa_juridica` WRITE;
/*!40000 ALTER TABLE `pessoa_juridica` DISABLE KEYS */;
INSERT INTO `pessoa_juridica` VALUES (6,'Usina Ipiranga','Usina Ipiranga De Acucar E Alcool Ltda','47.544.176/0002-59','4754444176000259',17,1);
/*!40000 ALTER TABLE `pessoa_juridica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reserva`
--

DROP TABLE IF EXISTS `reserva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reserva` (
  `NUMERO_RESERVA` int(11) NOT NULL AUTO_INCREMENT,
  `DATA_RESERVA` varchar(50) NOT NULL,
  `FORMA_PAGAMENTO` varchar(50) NOT NULL,
  `TIPO_RETIRADA` varchar(50) NOT NULL,
  `DATA_ENTREGA` varchar(50) NOT NULL,
  `DATA_RETIRADA` varchar(50) NOT NULL,
  `SITUACAO` varchar(50) NOT NULL,
  `COD_CLIENTE` int(11) NOT NULL,
  `COD_USUARIO` int(11) NOT NULL,
  `COD_VEICULO` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  `VALOR_LOCACAO` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`NUMERO_RESERVA`),
  KEY `COD_CLIENTE` (`COD_CLIENTE`),
  KEY `COD_USUARIO` (`COD_USUARIO`),
  KEY `COD_VEICULO` (`COD_VEICULO`),
  CONSTRAINT `reserva_ibfk_1` FOREIGN KEY (`COD_CLIENTE`) REFERENCES `cliente` (`COD_CLIENTE`),
  CONSTRAINT `reserva_ibfk_2` FOREIGN KEY (`COD_USUARIO`) REFERENCES `usuario` (`COD_USUARIO`),
  CONSTRAINT `reserva_ibfk_3` FOREIGN KEY (`COD_VEICULO`) REFERENCES `veiculo` (`COD_VEICULO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reserva`
--

LOCK TABLES `reserva` WRITE;
/*!40000 ALTER TABLE `reserva` DISABLE KEYS */;
INSERT INTO `reserva` VALUES (4,'01/12/2016 11:20:25','Dinheiro','No Local','01/12/2016 11:26:14','01/12/2016 11:19:59','Reserva',16,2,7,1,300.00);
/*!40000 ALTER TABLE `reserva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefone_cliente`
--

DROP TABLE IF EXISTS `telefone_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefone_cliente` (
  `COD_TELEFONE_CLIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `TELEFONE` varchar(50) NOT NULL,
  `COD_CLIENTE` int(11) DEFAULT NULL,
  `COD_FORNECEDOR` int(11) DEFAULT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_TELEFONE_CLIENTE`),
  KEY `COD_CLIENTE` (`COD_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefone_cliente`
--

LOCK TABLES `telefone_cliente` WRITE;
/*!40000 ALTER TABLE `telefone_cliente` DISABLE KEYS */;
INSERT INTO `telefone_cliente` VALUES (10,'16997056221',16,NULL,1),(11,'16997056221',NULL,17,1);
/*!40000 ALTER TABLE `telefone_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefone_fornecedor`
--

DROP TABLE IF EXISTS `telefone_fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefone_fornecedor` (
  `COD_TELEFONE_FORNECEDOR` int(11) NOT NULL AUTO_INCREMENT,
  `TELEFONE` varchar(50) NOT NULL,
  `COD_FORNECEDOR` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_TELEFONE_FORNECEDOR`),
  KEY `COD_FORNECEDOR` (`COD_FORNECEDOR`),
  CONSTRAINT `telefone_fornecedor_ibfk_1` FOREIGN KEY (`COD_FORNECEDOR`) REFERENCES `fornecedor` (`COD_FORNECEDOR`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefone_fornecedor`
--

LOCK TABLES `telefone_fornecedor` WRITE;
/*!40000 ALTER TABLE `telefone_fornecedor` DISABLE KEYS */;
INSERT INTO `telefone_fornecedor` VALUES (4,'(16) 9999-9999:(16) 99999-9999',5,1);
/*!40000 ALTER TABLE `telefone_fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `COD_USUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `CPF` varchar(15) NOT NULL,
  `LOGIN` varchar(20) NOT NULL,
  `SENHA` varchar(20) NOT NULL,
  `COD_PERMISSAO` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_USUARIO`),
  KEY `COD_PERMISSAO` (`COD_PERMISSAO`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`COD_PERMISSAO`) REFERENCES `permissao` (`COD_PERMISSAO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Ramon','5555','5555','ramon','ramon',1,1),(2,'admin','418909271','42962723810','admin','admin',1,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo`
--

DROP TABLE IF EXISTS `veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo` (
  `COD_VEICULO` int(11) NOT NULL AUTO_INCREMENT,
  `TANQUE` varchar(45) NOT NULL,
  `MARCA` varchar(50) NOT NULL,
  `MODELO` varchar(50) NOT NULL,
  `ANO_FABRICACAO` varchar(45) NOT NULL,
  `KM` varchar(45) NOT NULL,
  `VIDRO_ELETRICO` tinyint(1) NOT NULL,
  `TRAVA_ELETRICA` tinyint(1) NOT NULL,
  `AUTOMATICO` tinyint(1) NOT NULL,
  `QUANTIDADE_PORTAS` int(11) NOT NULL,
  `DIRECAO_HIDRAULICA` tinyint(1) NOT NULL,
  `COR` varchar(20) NOT NULL,
  `AR_CONDICIONADO` tinyint(1) NOT NULL,
  `COD_CATEGORIA` int(11) NOT NULL,
  `COMBUSTIVEL` varchar(45) NOT NULL,
  `STATUS` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`COD_VEICULO`),
  KEY `COD_CATEGORIA` (`COD_CATEGORIA`),
  CONSTRAINT `veiculo_ibfk_1` FOREIGN KEY (`COD_CATEGORIA`) REFERENCES `categoria` (`COD_CATEGORIA`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo`
--

LOCK TABLES `veiculo` WRITE;
/*!40000 ALTER TABLE `veiculo` DISABLE KEYS */;
INSERT INTO `veiculo` VALUES (7,'1/4','Fiat Uno','Fire','2016','11111',0,1,0,4,1,'Branco',1,14,'Flex',2);
/*!40000 ALTER TABLE `veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo_tem_checklist`
--

DROP TABLE IF EXISTS `veiculo_tem_checklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo_tem_checklist` (
  `COD_VEICULO_TEM_CHECKLIST` int(11) NOT NULL AUTO_INCREMENT,
  `DATA_CHECAGEM` varchar(20) NOT NULL,
  `COD_VEICULO` int(11) NOT NULL,
  `COD_CHECKLIST` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_VEICULO_TEM_CHECKLIST`),
  KEY `COD_VEICULO` (`COD_VEICULO`),
  KEY `COD_CHECKLIST` (`COD_CHECKLIST`),
  CONSTRAINT `veiculo_tem_checklist_ibfk_1` FOREIGN KEY (`COD_VEICULO`) REFERENCES `veiculo` (`COD_VEICULO`),
  CONSTRAINT `veiculo_tem_checklist_ibfk_2` FOREIGN KEY (`COD_CHECKLIST`) REFERENCES `checklist` (`COD_CHECKLIST`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo_tem_checklist`
--

LOCK TABLES `veiculo_tem_checklist` WRITE;
/*!40000 ALTER TABLE `veiculo_tem_checklist` DISABLE KEYS */;
INSERT INTO `veiculo_tem_checklist` VALUES (4,'01/12/2016',7,5,1);
/*!40000 ALTER TABLE `veiculo_tem_checklist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo_tem_fornecedor`
--

DROP TABLE IF EXISTS `veiculo_tem_fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo_tem_fornecedor` (
  `COD_VEICULO_TEM_FORNECEDOR` int(11) NOT NULL AUTO_INCREMENT,
  `COD_VEICULO` int(11) NOT NULL,
  `COD_FORNECEDOR` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_VEICULO_TEM_FORNECEDOR`),
  KEY `COD_VEICULO` (`COD_VEICULO`),
  KEY `COD_FORNECEDOR` (`COD_FORNECEDOR`),
  CONSTRAINT `veiculo_tem_fornecedor_ibfk_1` FOREIGN KEY (`COD_VEICULO`) REFERENCES `veiculo` (`COD_VEICULO`),
  CONSTRAINT `veiculo_tem_fornecedor_ibfk_2` FOREIGN KEY (`COD_FORNECEDOR`) REFERENCES `fornecedor` (`COD_FORNECEDOR`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo_tem_fornecedor`
--

LOCK TABLES `veiculo_tem_fornecedor` WRITE;
/*!40000 ALTER TABLE `veiculo_tem_fornecedor` DISABLE KEYS */;
INSERT INTO `veiculo_tem_fornecedor` VALUES (5,7,5,1);
/*!40000 ALTER TABLE `veiculo_tem_fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo_tem_manutencao`
--

DROP TABLE IF EXISTS `veiculo_tem_manutencao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo_tem_manutencao` (
  `COD_VEICULO_TEM_MANUTENCAO` int(11) NOT NULL AUTO_INCREMENT,
  `DATA_PREVISTA` date NOT NULL,
  `DATA_ENTREGA` date NOT NULL,
  `DATA_SAIDA` date NOT NULL,
  `COD_VEICULO` int(11) NOT NULL,
  `COD_MANUTENCAO` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`COD_VEICULO_TEM_MANUTENCAO`),
  KEY `COD_VEICULO` (`COD_VEICULO`),
  KEY `COD_MANUTENCAO` (`COD_MANUTENCAO`),
  CONSTRAINT `veiculo_tem_manutencao_ibfk_1` FOREIGN KEY (`COD_VEICULO`) REFERENCES `veiculo` (`COD_VEICULO`),
  CONSTRAINT `veiculo_tem_manutencao_ibfk_2` FOREIGN KEY (`COD_MANUTENCAO`) REFERENCES `manutencao` (`COD_MANUTENCAO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo_tem_manutencao`
--

LOCK TABLES `veiculo_tem_manutencao` WRITE;
/*!40000 ALTER TABLE `veiculo_tem_manutencao` DISABLE KEYS */;
/*!40000 ALTER TABLE `veiculo_tem_manutencao` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-01 11:27:02


--
-- Table structure for table `empregado`
--

DROP TABLE IF EXISTS `empregado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empregado` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `ENDERECO_ID` int(11) NOT NULL,
  `STATUS` int(11) DEFAULT '1',
  `DATA_NASCIMENTO` date NOT NULL,
  `DATA_ADMISSAO` date NOT NULL,
  `DATA_DEMISSAO` date NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `ENDERECO_ID` (`ENDERECO_ID`),
  CONSTRAINT `empregado_ibfk_1` FOREIGN KEY (`ENDERECO_ID`) REFERENCES `endereco` (`ENDERECO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
