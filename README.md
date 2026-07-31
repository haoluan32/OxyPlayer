

# OxyPlayer - 一个简易的音乐播放器

---


[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
## 1.项目简介

​	OxyPlayer是一个简易的音乐播放器，功能简单直接。

### 1.1 允许的功能

- ✅界面简洁，功能简单
- ✅支持多种格式，包括.mp3,.wma等
- ✅支持歌曲信息，歌词，封面等标签的读取
- ✅支持歌曲搜索


### 1.2 暂不支持的功能

- ❎不支持SMTC


## 2.快速上手

- 你可以直接从 [Release](https://github.com/haoluan32/OxyPlayer/releases) 中下载最新的安装包
  （如果Github无法访问你可以在[Gitee](https://gitee.com/haoluan_bilibili/oxy-player/releases)中下载）

-你也可以从源码编译
```bash
git clone https://github.com/haoluan32/OxyPlayer.git
cd /path/to/OxyPlayer
dotnet restore
msbuild
```

## 3.版本命名规则

本程序采用 **主版本号.次版本号** 的格式作为版本号基础，并结合发布阶段后缀进行标识：

| 发布阶段 | 代号 | 版本号格式 | 示例 |
| :--- | :--- | :--- | :--- |
| **正式版** | Oxygen（氧） | `主版本号.次版本号` | `1.20` |
| **测试版** | Carbon（碳） | `主版本号.次版本号.构建日期` | `1.20.26.07.22` |
| **开发版** | Hydrogen（氢） | `主版本号.次版本号.构建日期` | `1.21.26.07.22` |

> 📌 **说明**：
> - 构建日期格式为 `YY.MM.DD`（年.月.日）
> - 正式版发布时，去除日期后缀，仅保留 `主版本号.次版本号`
> - 测试版每次发布时，更新日期后缀以区分不同构建

> ⚠️ **关于开发版（Hydrogen）**：
> 作者**不提供** Hydrogen 版本的预编译安装包或二进制文件。
> 如果您需要体验或测试最新开发特性，请自行从源码编译构建。
> 编译方式请参考上文 **快速上手** 章节。

## 4.环境依赖
- 开发工具：Visual Studio 2026
- .NET 版本：.NET Framework 4.8
- UI 框架：WinForms + SunnyUI / AntdUI
- 音频引擎：System.Windows.Media.MediaPlayer
- 元数据读取：TagLibSharp
- 数据库：LiteDB

## 5.开源协议

本程序是自由软件，遵循 **GNU General Public License v3.0**（GPLv3）发布。

## 6.本程序使用的第三方库/版本/协议：
详见“[NOTICE](./NOTICE.txt)”
