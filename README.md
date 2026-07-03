# OxyPlayer - 一个简易的音乐播放器

---

## 1.项目简介

​	OxyPlayer是一个简易的音乐播放器，功能简单直接。

### 1.1允许的功能

- ✅界面简洁，功能简单
- ✅支持多种格式，包括.mp3,.wma等
- ✅支持歌曲信息，歌词，封面等标签的读取
- ✅支持歌曲搜索


### 1.2缺点

- ❎不支持SMTC


## 2.项目结构

```bash
├─.vs 
├─aip #Advenced Installer生成的文件(Advenced Installer不再使用)
├─iss #Inno Setup Script
├─OxyPlayer #项目主目录
│  ├─bin
│  │  ├─Debug #使用Debug配置生成的输出
│  │  └─Release	#使用Release配置生成的输出(安装程序打包的文件夹)
└─packages #NuGet生成的文件
    ├─LiteDB.5.0.21
    ├─System.Buffers.4.5.1
    └─TagLibSharp.2.3.0
```

## 3.环境依赖
开发工具 :Visual Studio 2015
.NET版本 :.NET Framework 4.7.2 

## 4.开源协议

本程序基于Apache License v2开源

## 5.本程序使用的第三方库/版本/协议：
```bash
LiteDB 5.0.21 MIT
System.Numerics.Vectors 4.5.0 MIT 
Ookii.Dialogs.WinForms 4.0.0 BSD 3-Clause 
System.Resources.Extensions 6.0.0 MIT 
System.Buffers 4.5.1 MIT 
System.Runtime.CompilerServices.Unsafe 4.5.3 MIT 
System.Memory 4.5.4 MIT 
TagLibSharp 2.3.0 LGPL v2.1-Only
```
