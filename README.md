# OxyPlayer - 一个简易的音乐播放器

---

## 1.项目简介

​	OxyPlayer是一个简易的音乐播放器，功能简单直接。

### 1.1允许的功能

- ✅界面简洁，功能简单，主程序仅32KB大小
- ✅支持多种格式，包括.mp3,.wma等
- ✅支持歌曲信息，歌词，封面等标签的读取

- ✅支持歌曲搜索（基于LiteDB）

- ✅内置MusicTag工具


### 1.2缺点

- ❎主流格式中暂不支持.m4a格式


## 2.项目结构

```bash
├─.vs 
├─aip #Advenced Installer生成的文件
├─OxyPlayer #项目主目录
│  ├─bin
│  │  ├─Debug #使用Debug配置生成的输出
│  │  └─Release	#使用Release配置生成的输出
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

