/*
Navicat MySQL Data Transfer

Source Server         : J2EE
Source Server Version : 80019
Source Host           : localhost:3306
Source Database       : parkingsystem

Target Server Type    : MYSQL
Target Server Version : 80019
File Encoding         : 65001

Date: 2020-05-31 22:42:01
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for now
-- ----------------------------
DROP TABLE IF EXISTS `now`;
CREATE TABLE `now` (
  `cardnumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `intime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of now
-- ----------------------------
INSERT INTO `now` VALUES ('8886001', '2020-05-31 10:17:14');
INSERT INTO `now` VALUES ('8886002', '2020-05-31 10:18:31');

-- ----------------------------
-- Table structure for someinformation
-- ----------------------------
DROP TABLE IF EXISTS `someinformation`;
CREATE TABLE `someinformation` (
  `flag` varchar(255) DEFAULT NULL,
  `fees` float DEFAULT NULL,
  `discount` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of someinformation
-- ----------------------------
INSERT INTO `someinformation` VALUES ('here', '12', '0.9');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('admin', 'admin');

-- ----------------------------
-- Table structure for vip
-- ----------------------------
DROP TABLE IF EXISTS `vip`;
CREATE TABLE `vip` (
  `cardnumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `carnumber` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `phone` varchar(255) DEFAULT NULL,
  `money` float(255,0) DEFAULT NULL,
  `time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of vip
-- ----------------------------
INSERT INTO `vip` VALUES ('8886001', '赣A88888', '朱克磊', '19916089409', '100', '2020-05-30 08:42:51');
INSERT INTO `vip` VALUES ('8886002', '123', '123', '123', '123', '2020-05-31 10:19:54');
INSERT INTO `vip` VALUES ('8886003', '123', '123', '123', '123', '2020-05-31 10:20:10');
