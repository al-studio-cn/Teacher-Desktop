# Teacher-Desktop

<center>
<img src="./Resources/TDesktop.png" width="100" height="100" />
</center>

<center><a href="https://al-studio.cn/">AL-Studio</a> | <a href="https://alwolf.cn/">一只屑阿狼</a></center>

### 介绍

教师桌面，为电子白板制作的小程序

### 制作原因

起因是因为有位好友，他在学校里是管设备的，原话：

“我们班的有的小捣蛋总是自己打开娱乐 被老师逮了总是我背锅”



一开始他找到我，来问我

“你知不知道有啥软件是那种模块化桌面的”

“就是最顶上一个时间搁那走”

“下面那些软件都是一个小方格”

他说这些，让我以为是Mac的Dock栏，然后他给我看了他做的Demo

我才明白是类似“Windows的磁贴”的东西



所以本程序可以做到：

**用途1:供老师能更简便的使用**  

**用途2:防止我们班的小捣蛋自行打开娱乐**  


### 软件介绍

软件使用C#制作的一个小程序，本人也不是什么大佬，并不会做磁贴化与代码优化，有问题就请见谅了

UI方面使用SunnyUI

背景可切换成[本地模式]与[网络模式]

网络模式使用Bing图片，这里感谢大佬 [杨尚臻](https://www.yangshangzhen.com/)开源的[必应壁纸API](https://github.com/shangzhenyang/bing-wallpaper)


### 兼容性
只要是支持[NET.472]的系统，都可以兼容


### 使用说明

首次启动，会弹出安装界面和管理员密码设置的界面，点击完成后

再次启动，就会进入程序的主页面了

### 如何卸载

删除注册表：
`计算机\HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\TeacherDesktop`

然后直接把软件所在的文件夹 连同文件夹一起扔垃圾桶，清空即可！

### 开源引用

[SunnyUI](https://gitee.com/yhuse/SunnyUI)：https://gitee.com/yhuse/SunnyUI  

[必应壁纸API](https://github.com/shangzhenyang/bing-wallpaper)：https://github.com/shangzhenyang/bing-wallpaper  

### 图标来源

[即时设计](https://js.design/)：https://js.design/

[IconFont](https://iconfont.cn/)

### 仓库
[Gitee](https://gitee.com/al-studio/Teacher-Desktop)  

[Github](https://github.com/al-studio-cn/Teacher-Desktop)
