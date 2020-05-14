## Cloud Native 
1. 在本地快速构建一个 cloud native 的开发环境, 全部自动化
2. 面向业务开发，而不面向框架开发
3. 组合优先

```
当我们有一点新的想法时，想到就可以立马去做。而不用纠结于要怎样和一个大而全的业务框架整合。
尽管这些大型框架都很成熟，搭建起来也很方便。但里面包含的太多和你当前的想实现的想法无关的东西，  
往往就是，我把这些框架搭建好，bulid，run 一个 hello world 后，脑袋里又蹦出个声音：算了吧，好累。

比如这个项目，我就突然想尝试实现以 CQRS，Event Source 为基础的服务，看看这样后面会遇到什么大坑，  
这样我就可以专注于解决一这个业务背景下可能会出现的问题。
-- 立马开始 dotnet new webapi , 
-- 打开 `vs code` ，
-- 按 bob 大叔 的架构思想 快速构建好项目结构，
-- 快速集成 MediatR， 
-- 写几行代码，自动 build，publish，test，感觉真爽。

微服务，把和业务无关的一些东西，比如，日志，熔断......这些交给Cloud平台去做吧。  
我们专注处理业务问题吧。业务价值是公司的生命线啊。
```

### 开发工具
- ubuntu 20.04
- minikube
- vs code 
- kubectl
- skaffold

### 后端
- .net core
- MediatR
- nats   

### 前端
- typescript
- react
- mobx
- nextjs
- semantic ui


#### 未完待续
![avatar](./going-on.png)





